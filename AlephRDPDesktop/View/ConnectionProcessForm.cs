using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using AlephRDP.ClientSide;
using AlephRDPDesktop.Model;
using ComponentFactory.Krypton.Toolkit;

namespace AlephRDPDesktop.View
{
    public partial class ConnectionProcessForm : KryptonForm
    {
        ConnectionProcessForm instance;
        ConnectionSettingsModel settings;
        bool active = true;
        bool connectingPhase = false;
        public ConnectionProcessForm(ConnectionSettingsModel settings)
        {
            instance = this;
            this.settings = settings;
            InitializeComponent();
        }

        private void ConnectionProcessForm_Load(object sender, EventArgs e)
        {
            MinimumSize = Size;
            MaximumSize = Size;

            MainForm.Instance.Client = new Client(settings.ip, settings.port, settings.password);
            MainForm.Instance.Client.PropertyChanged += Client_PropertyChanged;
            new Thread(() =>
            {
                MainForm.Instance.Client.Connect();
            }).Start();
        }

        private void Client_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (!active) return;
            if (e.PropertyName == "Status") HandleStatusChange();
            if (e.PropertyName == "Authorized") HandleAuthorizedChange();
        }
        private void HandleStatusChange()
        {
            if(MainForm.Instance.Client.Status == ClientStatus.Disconnected)
            {
                ExitWithError(connectingPhase ? "Неверный пароль доступа" : "Сервер не отвечает");
            } else if(MainForm.Instance.Client.Status == ClientStatus.Labeled)
            {
                ExitWithSuccess();
            } else if(MainForm.Instance.Client.Status == ClientStatus.Connecting)
            {
                connectingPhase = true;
                statusLabel.Text = "Подключение к сокету...";
            }
        }
        private void HandleAuthorizedChange()
        {
            if(!MainForm.Instance.Client.Authorized)
            {
                ExitWithError("Не удалось авторизоваться");
            }
        }
        private void ExitWithError(string error)
        {
            active = false;
            instance.Invoke(new Action(() => Close()));
            MainForm.Instance.Invoke(new Action(() => MainForm.Instance.ShowError(error)));
        }
        private void ExitWithSuccess()
        {
            active = false;
            instance.Invoke(new Action(() => Close()));
            MainForm.Instance.Invoke(new Action(() => MainForm.Instance.ProcessConnection()));
        }
    }
}
