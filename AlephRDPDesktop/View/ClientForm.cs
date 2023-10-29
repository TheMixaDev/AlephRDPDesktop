using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using Newtonsoft.Json;

namespace AlephRDPDesktop.View
{
    public partial class ClientForm : KryptonForm
    {
        private ClientForm instance;
        private TextBox ConsoleOutputTextBox;
        private TextBox UserInputTextBox;
        private PictureBox screenBox;
        private bool consoleView;
        private bool screenView;

        public ClientForm()
        {
            instance = this;
            InitializeComponent();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            MinimumSize = Size;
            MaximumSize = Size;

            MainForm.Instance.Client.ClientConsole.PropertyChanged += ClientConsole_PropertyChanged;
            MainForm.Instance.Client.ClientScreenshare.PropertyChanged += ClientScreenshare_PropertyChanged;
            InitializeConsole();
        }

        private void ClientConsole_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            AppendTextToConsole(MainForm.Instance.Client.ClientConsole.Output);
        }

        private void ClientScreenshare_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (screenView)
            {
                try
                {
                    screenBox.Image = MainForm.Instance.Client.ClientScreenshare.CurrentImage;
                    MainForm.Instance.Client.ClientScreenshare.RequestUpdate();
                }
                catch { }
            }
        }

        private void ClearPanel()
        {
            itemsPanel.Controls.Clear();
            if (screenView)
                MainForm.Instance.Client.ClientScreenshare.CloseScreenshare();
            consoleView = false;
            screenView = false;
            uploadFileButton.Visible = false;
        }

        // Console

        private void InitializeConsole()
        {
            ClearPanel();
            ConsoleOutputTextBox = new TextBox
            {
                Multiline = true,
                ReadOnly = true,
                BackColor = Color.Black,
                ForeColor = Color.White,
                Font = new Font("Consolas", 10f),
                Dock = DockStyle.Fill,
                ScrollBars = ScrollBars.Vertical
            };
            itemsPanel.Controls.Add(ConsoleOutputTextBox);
            UserInputTextBox = new TextBox
            {
                Font = new Font("Consolas", 10f),
                Dock = DockStyle.Bottom,
                ForeColor = Color.White,
                BackColor = Color.Black
            };
            UserInputTextBox.KeyPress += UserInputTextBox_KeyPress;
            itemsPanel.Controls.Add(UserInputTextBox);
            UserInputTextBox.Focus();
            consoleView = true;
            uploadFileButton.Visible = true;
            MainForm.Instance.Client.ClientConsole.OpenConsole();
        }
        private void UserInputTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                string input = UserInputTextBox.Text.Trim();
                UserInputTextBox.Text = "";
                AppendTextToConsole(input + Environment.NewLine);
                MainForm.Instance.Client.ClientConsole.ProcessInputCommand(input);
            }
        }
        public void AppendTextToConsole(string text)
        {
            instance.Invoke(new Action(() =>
            {
                ConsoleOutputTextBox.AppendText(text);
                ConsoleOutputTextBox.SelectionStart = ConsoleOutputTextBox.Text.Length;
                ConsoleOutputTextBox.ScrollToCaret();
            }));
        }

        // Screen

        private void InitializeScreen()
        {
            ClearPanel();
            screenBox = new PictureBox
            {
                Dock = DockStyle.Fill,
                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor = Color.Black,
            };
            itemsPanel.Controls.Add(screenBox);
            screenView = true;
            MainForm.Instance.Client.ClientScreenshare.OpenScreenshare();
        }

        private void screenButton_Click(object sender, EventArgs e)
        {
            InitializeScreen();
        }

        private void consoleButton_Click(object sender, EventArgs e)
        {
            InitializeConsole();
        }

        private void uploadFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Все файлы|*";
            openFileDialog.Title = "Выберите файл";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if(MainForm.Instance.Client.ClientConsole.UploadFile(openFileDialog.FileName))
                {
                    (new MessageForm("Файл успешно загружен")).ShowDialog();
                } else
                {
                    (new MessageForm("Файл для загрузки не был найден")).ShowDialog();
                }
            }
        }
    }
}
