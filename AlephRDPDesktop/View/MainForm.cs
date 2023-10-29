using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Xml.Serialization;
using AlephRDP.ClientSide;
using AlephRDP.ServerSide;
using AlephRDPDesktop.Controller;
using AlephRDPDesktop.Model;
using ComponentFactory.Krypton.Toolkit;
using Microsoft.Win32;
using static System.Windows.Forms.AxHost;

namespace AlephRDPDesktop.View
{
    public partial class MainForm : KryptonForm
    {
        private static MainForm instance;
        private string[] args;
        private Client client;
        private ServerController serverController;

        private ConnectionSettingsModel connectionSettings;
        private AppSettingsModel appSettings;

        private ClientForm clientForm;

        bool connected = false;
        bool wasAvailable = false;
        int counter = 0;
        System.Timers.Timer pingTimer;

        public Client Client { get => client; set => client = value; }
        public static MainForm Instance { get => instance; set => instance = value; }
        public AppSettingsModel AppSettings { get => appSettings; set => appSettings = value; }
        public ServerController ServerController { get => serverController; set => serverController = value; }

        public MainForm(string[] args)
        {
            this.args = args;
            instance = this;
            serverController = new ServerController();
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            appSettings = AppSettingsController.ReadSettings();
            connectionSettings = ConnectionSettingsController.ReadSettings();

            MinimumSize = Size;
            MaximumSize = Size;

            serverController.OnUpdateStatus += ServerController_OnUpdateStatus;

            ParseNotNullSettings();

            AutoRun();

            if (appSettings.hideDefault && args.Length > 0 && args[0] == "startup")
            {
                Hide();
                ShowInTaskbar = false;
            }
        }

        private void ServerController_OnUpdateStatus(object sender, EventArgs e)
        {
            if(serverController.IsStarted())
            {
                serverStatusLabel.Text = "Сервер запущен";
                serverStatusLabel.StateCommon.ShortText.Color1 = Color.Green;
            } else
            {
                serverStatusLabel.Text = "Сервер выключен";
                serverStatusLabel.StateCommon.ShortText.Color1 = Color.Red;
            }
        }

        private void AutoRun()
        {
            if (appSettings.launchOnStartup)
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\RunOnce", true))
                {
                    if (key == null)
                    {
                        Console.WriteLine("Error accessing the registry key. Make sure you have the necessary permissions.");
                        return;
                    }
                    key.SetValue("AlephRDP", Path.Combine(AppContext.BaseDirectory, "AlephRDPStartup.exe"));
                    Console.WriteLine("Application added to RunOnce.");
                }
            }
            if (appSettings.serverOnLaunch) { ServerController.Start(); }
            CheckPing();
            pingTimer = new System.Timers.Timer(1000);
            pingTimer.Elapsed += PingTimer_Elapsed;
            pingTimer.AutoReset = true;
            pingTimer.Start();
        }

        private void PingTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            counter++;
            if(appSettings.periodicCheck && counter >= appSettings.checkInterval)
            {
                counter = 0;
                CheckPing();
            }
            if (File.Exists(Program.awakePath))
            {
                try
                {
                    File.Delete(Program.awakePath);
                }
                catch { }
                notifyIcon_BalloonTipClicked(sender, null);
            }
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            if (!connected)
            {
                try
                {
                    connectionSettings = new ConnectionSettingsModel { name = nameBox.Text, ip = ipBox.Text, password = passwordBox.Text, port = Int32.Parse(portBox.Text) };
                    ConnectionSettingsController.SaveSettings(connectionSettings);
                    CheckPing();
                    (new ConnectionProcessForm(connectionSettings)).ShowDialog();
                } catch
                {
                    (new MessageForm("Введите корректный порт")).ShowDialog();
                }
            }
            else
            {
                client.Disconnect();
            }
        }

        private void profileActionButton_Click(object sender, EventArgs e)
        {
            if(!connected) {
                connectionSettings = ConnectionSettingsController.PromptSettings();
                ParseNotNullSettings();
                CheckPing();
            } else
            {
                ConnectionSettingsController.SaveSettings(connectionSettings, null);
            }
        }
        private void ParseNotNullSettings()
        {
            if(connectionSettings != null)
            {
                nameBox.Text = connectionSettings.name;
                ipBox.Text = connectionSettings.ip;
                portBox.Text = connectionSettings.port.ToString();
                passwordBox.Text = connectionSettings.password;
            }
        }
        public void ShowError(string message)
        {
            (new MessageForm(message)).ShowDialog();
        }
        public void ProcessConnection()
        {
            client.PropertyChanged += Client_PropertyChanged;
            connected = true;
            connectButton.Text = "Отключиться";
            connectButton.ButtonStyle = ButtonStyle.Custom2;
            profileActionButton.Text = "Экспорт профиля";
            nameBox.Enabled = false;
            ipBox.Enabled = false;
            passwordBox.Enabled = false;
            portBox.Enabled = false;
            clientForm = new ClientForm();
            clientForm.Show();
        }
        public void ProcessDisconnection()
        {
            instance.Invoke(new Action(() =>
            {
                connected = false;
                client = null;
                connectButton.Text = "Подключиться";
                connectButton.ButtonStyle = ButtonStyle.Custom1;
                profileActionButton.Text = "Импорт профиля";
                nameBox.Enabled = true;
                ipBox.Enabled = true;
                passwordBox.Enabled = true;
                portBox.Enabled = true;
                clientForm.Close();
                clientForm.Dispose();
                CheckPing();
                (new MessageForm("Соединение с ПК разорвано")).ShowDialog();
            }));
        }

        private void Client_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (!connected) return;
            if (e.PropertyName == "Status") HandleStatusChange();
            if (e.PropertyName == "Authorized") HandleAuthorizedChange();
        }
        private void HandleStatusChange()
        {
            if(client.Status == ClientStatus.Disconnected)
            {
                ProcessDisconnection();
            }
        }
        private void HandleAuthorizedChange()
        {
            if (!client.Authorized)
            {
                ProcessDisconnection();
            }
        }

        private void serverSettingsButton_Click(object sender, EventArgs e)
        {
            (new SettingsForm()).ShowDialog();
            AppSettings = AppSettingsController.ReadSettings();
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Normal;
            ShowInTaskbar = true;
            notifyIcon.Visible = true;
            Show();
        }
        private void notifyIcon_BalloonTipClicked(object sender, EventArgs e)
        {
            instance.Invoke(new Action(() => {
                if (ShowInTaskbar)
                {
                    WindowState = FormWindowState.Minimized;
                    Show();
                    WindowState = FormWindowState.Normal;
                }
                else notifyIcon_MouseDoubleClick(sender, null);
            }));
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }

        private void notifyIcon_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && (appSettings.hideOnClose || serverController.IsStarted()))
            {
                e.Cancel = true;
                WindowState = FormWindowState.Minimized;
                ShowInTaskbar = false;
                Hide();
                if(!appSettings.hideOnClose)
                {
                    notifyIcon.BalloonTipText = "Приложение продолжает работать, поскольку запущен сервер";
                    notifyIcon.BalloonTipTitle = "AlephRDPDesktop";
                    notifyIcon.ShowBalloonTip(500);
                }
            }
        }

        private void CheckPing()
        {
            try
            {
                connectionSettings = new ConnectionSettingsModel { name = nameBox.Text, ip = ipBox.Text, password = passwordBox.Text, port = Int32.Parse(portBox.Text) };
                instance.Invoke(new Action(() => {
                    pingLabel.Text = "Попытка подключения...";
                    pictureBox2.Image = global::AlephRDPDesktop.Properties.Resources.yellow_circle;
                }));
                new Thread(() =>
                {
                    Client.Ping(connectionSettings.ip, connectionSettings.port, new Action(() =>
                    {
                        instance.Invoke(new Action(() =>
                        {
                            pingLabel.Text = "Компьютер доступен";
                            pictureBox2.Image = global::AlephRDPDesktop.Properties.Resources.green_circle;
                            if(!wasAvailable)
                            {
                                notifyIcon.BalloonTipText = "Доступен ПК для подключения";
                                notifyIcon.BalloonTipTitle = "AlephRDPDesktop";
                                notifyIcon.ShowBalloonTip(500);
                            }
                            wasAvailable = true;
                        }));
                    }),
                    new Action(() =>
                    {
                        instance.Invoke(new Action(() =>
                        {
                            pingLabel.Text = "Нет связи с ПК";
                            pictureBox2.Image = global::AlephRDPDesktop.Properties.Resources.red_circle;
                            if (wasAvailable)
                            {
                                notifyIcon.BalloonTipText = "Доступный ПК был отключен";
                                notifyIcon.BalloonTipTitle = "AlephRDPDesktop";
                                notifyIcon.ShowBalloonTip(500);
                            }
                            wasAvailable = false;
                        }));
                    }));
                }).Start();
            }
            catch { }
        }
    }
}
