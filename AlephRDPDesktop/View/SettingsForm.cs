using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlephRDPDesktop.Controller;
using AlephRDPDesktop.Model;
using ComponentFactory.Krypton.Toolkit;
using Microsoft.Win32;

namespace AlephRDPDesktop.View
{
    public partial class SettingsForm : KryptonForm
    {
        private AppSettingsModel settings;
        private bool loaded = false;
        private bool closed = false;
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            MinimumSize = Size;
            MaximumSize = Size;
            
            settings = MainForm.Instance.AppSettings;
            launchOnStartupBox.Checked = settings.launchOnStartup;
            hideDefaultBox.Checked = settings.hideDefault;
            hideOnCloseBox.Checked = settings.hideOnClose;
            serverOnLaunchBox.Checked = settings.serverOnLaunch;
            notifyBox.Checked = settings.notify;
            periodicCheckBox.Checked = settings.periodicCheck;
            checkIntervalBox.Text = settings.checkInterval.ToString();
            portBox.Text = settings.serverPort.ToString();
            port2Box.Text = settings.serverPort2.ToString();
            passwordBox.Text = settings.password;
            ToggleIntervalText();
            loaded = true;
            MainForm.Instance.ServerController.OnUpdateStatus += ServerController_OnUpdateStatus;
            UpdateServerStarted();
        }

        private void SaveSettings()
        {
            if (!loaded) return;
            settings.launchOnStartup = launchOnStartupBox.Checked;
            settings.hideDefault = hideDefaultBox.Checked;
            settings.hideOnClose = hideOnCloseBox.Checked;
            settings.serverOnLaunch = serverOnLaunchBox.Checked;
            settings.notify = notifyBox.Checked;
            settings.periodicCheck = periodicCheckBox.Checked;
            settings.password = passwordBox.Text;
            try { settings.checkInterval = Int32.Parse(checkIntervalBox.Text); } catch { }
            try { settings.serverPort = Int32.Parse(portBox.Text); } catch { }
            try { settings.serverPort2 = Int32.Parse(portBox.Text) + 1; } catch { }
            if (settings.serverPort < 1 || settings.serverPort > 65534) settings.serverPort = 727;
            if (settings.serverPort2 < 1 || settings.serverPort2 > 65535) settings.serverPort = 728;
            if (settings.checkInterval < 1) settings.checkInterval = 1;
            AppSettingsController.SaveSettings(settings);
            MainForm.Instance.AppSettings = settings;
        }

        private void ToggleIntervalText()
        {
            intervalLabel.Visible = settings.periodicCheck;
            intervalCLabel.Visible = settings.periodicCheck;
            checkIntervalBox.Visible = settings.periodicCheck;
        }
        private void ToggleHideDefault()
        {
            hideDefaultBox.Visible = settings.launchOnStartup;
        }
        private void launchOnStartupBox_CheckedChanged(object sender, EventArgs e)
        {
            SaveSettings();
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\RunOnce", true))
            {
                if (key == null)
                {
                    Console.WriteLine("Error accessing the registry key. Make sure you have the necessary permissions.");
                    return;
                }
                if (settings.launchOnStartup)
                {
                    key.SetValue("AlephRDP", Path.Combine(AppContext.BaseDirectory, "AlephRDPStartup.exe"));
                    Console.WriteLine("Application added to RunOnce.");
                } else
                {
                    try
                    {
                        key.DeleteValue("AlephRDP");
                        Console.WriteLine("Application removed from RunOnce.");
                    }
                    catch { }
                }
            }
            ToggleHideDefault();
        }
        private void hideDefaultBox_CheckedChanged(object sender, EventArgs e)
        {
            SaveSettings();
        }
        private void hideOnCloseBox_CheckedChanged(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void serverOnLaunchBox_CheckedChanged(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void notifyBox_CheckedChanged(object sender, EventArgs e)
        {
            SaveSettings();
            MainForm.Instance.ServerController.UpdateNotify(settings.notify);
        }

        private void periodicCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SaveSettings();
            ToggleIntervalText();
        }

        private void checkIntervalBox_TextChanged(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void portBox_TextChanged(object sender, EventArgs e)
        {
            SaveSettings();
            port2Box.Text = settings.serverPort2.ToString();
        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void serverButton_Click(object sender, EventArgs e)
        {
            if (!MainForm.Instance.ServerController.IsStarted())
            {
                MainForm.Instance.ServerController.Start();
                (new MessageForm("Сервер запущен")).ShowDialog();
            }
            else
            {
                MainForm.Instance.ServerController.Stop();
                (new MessageForm("Сервер остановлен")).ShowDialog();
            }
        }
        private void ServerController_OnUpdateStatus(object sender, EventArgs e)
        {
            UpdateServerStarted();
        }

        private void UpdateServerStarted()
        {
            if (closed) return;
            bool started = MainForm.Instance.ServerController.IsStarted();
            serverButton.Text = started ? "Остановить сервер" : "Запустить сервер";
            serverButton.ButtonStyle = started ? ButtonStyle.Custom2 : ButtonStyle.Custom1;
        }

        private void SettingsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            closed = true;
        }
    }
}
