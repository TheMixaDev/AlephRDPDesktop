using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace AlephRDPUnpacker
{
    public partial class UnpackerForm : Form
    {
        string appFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "AlephRDP");
        int maxValue = 4;
        public UnpackerForm()
        {
            InitializeComponent();
        }

        private void UnpackerForm_Load(object sender, EventArgs e)
        {
            MinimumSize = Size;
            MaximumSize = Size;
            progressBar.Maximum = maxValue;
            progressBar.Value = 0;

            CheckFolder();
        }

        private void CheckFolder()
        {
            try
            {
                statusLabel.Text = "Проверка наличия папки";
                if (Directory.Exists(appFolder))
                {
                    DirectoryExists();
                }
                else
                {
                    DirectoryNotExists();
                }
            }
            catch { ErrorAbort(); }
        }

        private void DirectoryExists()
        {
            try
            {
                progressBar.Value++;
                progressBar.Maximum = 3;
                statusLabel.Text = "Проверка наличия файла";
                if (File.Exists(Path.Combine(appFolder, "AlephRDPDesktop.exe")) && File.Exists(Path.Combine(appFolder, "AlephRDPStartup.exe")))
                {
                    Finish();
                }
                else
                {
                    CopyFiles();
                }
            }
            catch { ErrorAbort(); }
        }
        private void DirectoryNotExists()
        {
            try
            {
                progressBar.Value++;
                statusLabel.Text = "Создание папки";
                Directory.CreateDirectory(appFolder);
                CopyFiles();
            } catch { ErrorAbort(); }
        }
        private void CopyFiles()
        {
            try
            {
                progressBar.Value++;
                progressBar.Maximum = maxValue;
                statusLabel.Text = "Копирование файлов (1/2)";
                File.WriteAllBytes(Path.Combine(appFolder, "AlephRDPDesktop.exe"), global::AlephRDPUnpacker.Properties.Resources.AlephRDPDesktop);
                progressBar.Value++;
                statusLabel.Text = "Копирование файлов (2/2)";
                File.WriteAllBytes(Path.Combine(appFolder, "AlephRDPStartup.exe"), global::AlephRDPUnpacker.Properties.Resources.AlephRDPStartup);
                Finish();
            } catch { ErrorAbort(); }
        }
        private void ErrorAbort()
        {
            MessageBox.Show("Во время распаковки произошла ошибка!");
            Close();
        }
        private void Finish()
        {
            progressBar.Value++;
            statusLabel.Text = "Запуск приложения";
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = Path.Combine(appFolder, "AlephRDPDesktop.exe"),
                WorkingDirectory = appFolder,
                Domain = appFolder
            };
            Process.Start(startInfo);
            Close();
        }
    }
}
