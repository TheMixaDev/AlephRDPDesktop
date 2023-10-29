using AlephRDPDesktop.Model;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;

namespace AlephRDPDesktop.Controller
{
    public class ConnectionSettingsController
    {
        public const string defaultPath = "connectionSettings.json";
        public static ConnectionSettingsModel PromptSettings()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON|*.json";
            openFileDialog.Title = "Выберите файл с настройками подключения";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                return ReadSettings(openFileDialog.FileName);
            return null;
        }
        public static ConnectionSettingsModel ReadSettings(string path)
        {
            if(File.Exists(path))
            {
                try
                {
                    string jsonFilePath = path;
                    string jsonContent = File.ReadAllText(jsonFilePath);
                    ConnectionSettingsModel jsonObject = JsonConvert.DeserializeObject<ConnectionSettingsModel>(jsonContent);
                    SaveSettings(jsonObject);
                    return jsonObject;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            return null;
        }
        public static ConnectionSettingsModel ReadSettings()
        {
            return ReadSettings(defaultPath);
        }
        public static void SaveSettings(ConnectionSettingsModel settings, string path)
        {
            if (path == null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "JSON|*.json";
                saveFileDialog.Title = "Выберите файл";

                if (saveFileDialog.ShowDialog() != DialogResult.OK) return;
                path = saveFileDialog.FileName;
            }
            File.WriteAllText(path, JsonConvert.SerializeObject(settings));
        }
        public static void SaveSettings(ConnectionSettingsModel settings)
        {
            SaveSettings(settings, defaultPath);
        }
    }
}
