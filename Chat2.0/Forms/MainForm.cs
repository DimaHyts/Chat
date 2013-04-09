using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm form = new RegisterForm();
            form.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ServerConnection.Connect.Login(tbLogin.Text, tbPassword.Text))
            {
                MonitorForm mform = new MonitorForm();
                mform.Show();
            }
            else MessageBox.Show("loh");
        }
    }
}
