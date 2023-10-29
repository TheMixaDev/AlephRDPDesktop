using AlephRDPDesktop.View;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace AlephRDPDesktop
{
    internal static class Program
    {
        public static string awakePath = Path.Combine(AppContext.BaseDirectory, "awake");
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length > 1)
            {
                try
                {
                    if (!File.Exists(awakePath))
                        File.Create(awakePath);
                } catch { }
            } else Application.Run(new MainForm(args));
        }
    }
}
