using AlephRDP.ServerSide;
using AlephRDPDesktop.Model;
using AlephRDPDesktop.Properties;
using AlephRDPDesktop.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlephRDPDesktop.Controller
{
    public class ServerController
    {
        public delegate void StatusUpdateHandler(object sender, EventArgs e);
        public event StatusUpdateHandler OnUpdateStatus;

        private Server server;
        private AppSettingsModel appSettings;

        public ServerController() { }

        public Server Server { get => server; set => server = value; }

        public void Start()
        {
            appSettings = MainForm.Instance.AppSettings;
            if (Server == null || !Server.Started)
            {
                if (Server == null)
                {
                    Server = new Server(appSettings.serverPort, appSettings.password);
                    Server.OnUpdateStatus += Server_OnUpdateStatus;
                    Server.Notify = appSettings.notify;
                }
                Server.Start();
            }
        }

        private void Server_OnUpdateStatus(object sender, EventArgs e)
        {
            OnUpdateStatus(sender, e);
        }
        public void UpdateNotify(bool notify)
        {
            if(Server != null)
            {
                Server.Notify = appSettings.notify;
            }
        }

        public bool IsStarted()
        {
            return Server != null && Server.Started;
        }
        public void Stop()
        {
            if (!IsStarted()) return;
            Server.Stop();
        }
    }
}
