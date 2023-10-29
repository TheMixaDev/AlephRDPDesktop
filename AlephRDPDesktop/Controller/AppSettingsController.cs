using AlephRDPDesktop.Model;
using Newtonsoft.Json;
using System;
using System.IO;

namespace AlephRDPDesktop.Controller
{
    public class AppSettingsController
    {
        public const string defaultPath = "settings.json";
        public static AppSettingsModel ReadSettings(string path)
        {
            if (File.Exists(path))
            {
                try
                {
                    string jsonFilePath = path;
                    string jsonContent = File.ReadAllText(jsonFilePath);
                    AppSettingsModel jsonObject = JsonConvert.DeserializeObject<AppSettingsModel>(jsonContent);
                    SaveSettings(jsonObject);
                    return jsonObject;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            } else
            {
                AppSettingsModel newSettings = new AppSettingsModel();
                SaveSettings(newSettings);
                return newSettings;
            }
            return null;
        }
        public static AppSettingsModel ReadSettings()
        {
            return ReadSettings(defaultPath);
        }
        public static void SaveSettings(AppSettingsModel settings)
        {
            File.WriteAllText(defaultPath, JsonConvert.SerializeObject(settings));
        }
    }
}
