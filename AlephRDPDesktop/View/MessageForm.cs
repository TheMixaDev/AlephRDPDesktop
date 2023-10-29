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

namespace AlephRDPDesktop.View
{
    public partial class MessageForm : KryptonForm
    {
        string message;
        public MessageForm(string message)
        {
            this.message = message;
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MessageForm_Load(object sender, EventArgs e)
        {
            MinimumSize = Size;
            MaximumSize = Size;
            notifyLabel.Text = message;
        }
    }
}
