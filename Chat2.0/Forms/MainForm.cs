using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chat2._0.ServiceReference1;
using System.Threading;


namespace Client
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            tbText.Hide();
            btnSend.Hide();
            tbMonitor.Hide();
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
                //MonitorForm mform = new MonitorForm();
                //mform.Show();
                tbText.Show();
                btnSend.Show();
                tbMonitor.Show();

                btnLogin.Enabled = false;

                bwMessageLoader.RunWorkerAsync();
                bwUsersLoader.RunWorkerAsync();
            }
            else MessageBox.Show("loh");
            
           // new Thread(CheckOnLineUsers).Start();
            //AutoResetEvent reset = new AutoResetEvent(true);

           // TimerCallback timerClb = new TimerCallback(Query);
            //new Thread(() =>
            //{ System.Threading.Timer timer = new System.Threading.Timer(Query, null, 1000, 1000); }).Start();
  
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            ServerConnection.Connect.SendMessage(new MessageDTO
               {
                   Date = DateTime.Now,
                   Text = tbText.Text.Trim(),
                   UserFrom=ServerConnection.Connect.GetCurrentUser(),
                   UserTo = ServerConnection.Connect.GetCurrentUser()
               });
            tbText.Text = string.Empty;
            
        }

        public bool a = true;

        public void Query()
        {

          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                Thread.Sleep(1000);

                List<MessageDTO> lastMessages = new List<MessageDTO>();

                //Thread.Sleep(1000);
                //while (a = true)
                //{
                lastMessages = ServerConnection.Connect.GetAllMessagesForUser(ServerConnection.Connect.GetCurrentUser()).ToList();

                    this.Invoke(new Action(() =>
                    {

                        tbMonitor.SuspendLayout();
                        tbMonitor.Text = string.Empty;
                        lastMessages.ForEach(m => tbMonitor.Text += m.Text + Environment.NewLine);
                        tbMonitor.Select(tbMonitor.Text.Length == 0 ? 0 : tbMonitor.Text.Length - 1, 0);
                        tbMonitor.ScrollToCaret();
                        tbMonitor.ResumeLayout();
                    }));
                //}
            }
        }

        private void bwUsersLoader_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
               
                List<UserUI> users = ServerConnection.Connect.GetOnlineUser().Select(u => new UserUI(u)).ToList();

               
                this.Invoke(new Action(() =>
               {
                   var selection = lbFriendList.SelectedItem;
                   lbFriendList.Items.Clear();
                   lbFriendList.Items.AddRange(users.ToArray());
                   if (selection != null)
                   {
                       lbFriendList.SelectedItem = selection;
                   }
               }));

                Thread.Sleep(10000);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("bla", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true;
                bwMessageLoader.CancelAsync();
                bwUsersLoader.CancelAsync();
            }
        }

        private void lbFriendList_DoubleClick(object sender, EventArgs e)
        {
            if (lbFriendList.SelectedItem != null)
            {
               //(lbFriendList.SelectedItem as UserUI)
            }
        }

    }
}
