using Chat2._0.ServiceReference1;
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

namespace Client
{
    public partial class MonitorForm : Form
    {
        public MonitorForm()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbMessage.Text.Trim()))
            {
                ServerConnection.Connect.SendMessage(new MessageDTO
                {
                    Date = DateTime.Now,
                    Text = tbMessage.Text.Trim(),
                    //UserFrom = ServerConnection.Connect.GetCurrentUser(),
                    //UserTo = ServerConnection.Connect.GetCurrentUser()
                });
                tbMessage.Text = string.Empty;
            }
        }

        private void MonitorForm_Shown(object sender, EventArgs e)
        {
            System.Threading.Timer updater = new System.Threading.Timer(o =>
                {
                    //var messages = ServerConnection.Connect.Get
                }, null, 1000, 1000);
        }


    }
}
