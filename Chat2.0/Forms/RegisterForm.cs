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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnOkReg_Click(object sender, EventArgs e)
        {
            UserUI newUser = new UserUI()
            {
                Login = tbLoginReg.Text,
                Name = tbNameReg.Text,
                Password = tbPasswordReg.Text
            };
            if (ServerConnection.Connect.CreateUser(newUser.UserToDTO())==true)
            {
                MessageBox.Show("Sucsses!");
                RegisterForm.ActiveForm.Close();
            }
            else MessageBox.Show("invalid!");

        }
    }
}
