using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace AlephRDPStartup
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = Path.Combine(AppContext.BaseDirectory, "AlephRDPDesktop.exe"),
                Arguments = "startup",
                WorkingDirectory = AppContext.BaseDirectory,
                Domain = AppContext.BaseDirectory
            };
            Process.Start(startInfo);
        }
    }
}
