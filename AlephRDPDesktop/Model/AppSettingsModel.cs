using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlephRDPDesktop.Model
{
    public class AppSettingsModel
    {
        public bool launchOnStartup {  get; set; }
        public bool hideDefault { get; set; }
        public bool hideOnClose { get; set; }
        public bool serverOnLaunch { get; set; }
        public bool notify { get; set; }
        public bool periodicCheck { get; set; }
        public int checkInterval { get; set; }
        public int serverPort { get; set; }
        public int serverPort2 { get; set; }
        public string password { get; set; }

        public AppSettingsModel()
        {
            launchOnStartup = true;
            hideDefault = true;
            hideOnClose = true;
            serverOnLaunch = false;
            notify = true;
            periodicCheck = true;
            checkInterval = 120;
            serverPort = 7272;
            serverPort2 = 7273;
            password = "password";
        }
    }
}
