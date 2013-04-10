using Client;
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
    public partial class LogOnForm : Form
    {
        public LogOnForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            tbLogin.Enabled = tbPass.Enabled = btnLogin.Enabled = btnRegister.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;

            Login().ContinueWith(task =>
                {
                    if (task.Result)
                    {
                        DialogResult = System.Windows.Forms.DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Login or Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    tbLogin.Enabled = tbPass.Enabled = btnLogin.Enabled = btnRegister.Enabled = true;
                    Cursor.Current = Cursors.Default;

                }, TaskContinuationOptions.ExecuteSynchronously);
        }

        private Task<bool> Login()
        {
            TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();

            tcs.SetResult(ServerConnection.Connect.Login(tbLogin.Text.Trim(), tbPass.Text.Trim()));

            return tcs.Task;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm regForm = new RegisterForm();
            regForm.Show();
        }

    }
}
