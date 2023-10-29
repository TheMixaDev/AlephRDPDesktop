using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlephRDPDesktop.Model
{
    public class ConnectionSettingsModel
    {
        public string name { get; set; }
        public string ip { get; set; }
        public int port { get; set; }
        public string password { get; set; }
    }
}
