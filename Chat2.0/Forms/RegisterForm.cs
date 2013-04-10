using Chat2._0.ServiceReference1;
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
            tbLoginReg.Enabled = tbNameReg.Enabled = tbPasswordReg.Enabled = btnOkReg.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;

            Register(tbLoginReg.Text.Trim(), tbNameReg.Text.Trim(), tbPasswordReg.Text.Trim())
                .ContinueWith(task =>
                {
                    if (task.Result)
                    {
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid data or user exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    tbLoginReg.Enabled = tbNameReg.Enabled = tbPasswordReg.Enabled = btnOkReg.Enabled = true;
                    Cursor.Current = Cursors.Default;

                }, TaskContinuationOptions.ExecuteSynchronously);
        }

        private Task<bool> Register(string login, string name, string pass)
        {
             TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();

             tcs.SetResult(ServerConnection.Connect
                 .CreateUser(new UserDTO
                                {
                                    Login = login,
                                    Name = name,
                                    Password = pass
                                }));
             return tcs.Task;
        }
    }
}
