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
        private UserUI currentUser;
        private Thread messageLoader;
        private Thread userLoader;

        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(UserUI currentUser)
            :this()
        {
            this.currentUser = currentUser;

            messageLoader = new Thread(LoadMessages);
            messageLoader.Start();

            userLoader = new Thread(LoadUsers);
            userLoader.Start();
        }

        private void LoadMessages()
        {
            while (true)
            {
                List<MessageDTO> lastMessages = ServerConnection.Connect.GetAllMessagesForUser(ServerConnection.Connect.GetCurrentUser()).ToList();

                this.Invoke(new Action(() =>
                {
                    tbMonitor.SuspendLayout();
                    tbMonitor.Text = string.Empty;
                    lastMessages.ForEach(m => tbMonitor.Text += m.Text + Environment.NewLine);
                    tbMonitor.Select(tbMonitor.Text.Length == 0 ? 0 : tbMonitor.Text.Length - 1, 0);
                    tbMonitor.ScrollToCaret();
                    tbMonitor.ResumeLayout();
                }));

                Thread.Sleep(1000);
            }
        }

        private void LoadUsers()
        {
            while (true)
            {
                List<UserUI> users = ServerConnection.Connect.GetAllUsers().Select(u => new UserUI(u)).ToList();

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
                Thread.Sleep(3000);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            ServerConnection.Connect.SendMessage(new MessageDTO
               {
                   Date = DateTime.Now,
                   Text = tbText.Text.Trim(),
                   UserFrom=ServerConnection.Connect.GetCurrentUser()

               });
            tbText.Text = string.Empty;
            Cursor.Current = Cursors.Default;
        }

        private void bWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                //Thread.Sleep(1000);
                //while (a = true)
                //{
                //if (isLoggedOn && bwMessageLoader.CancellationPending == false)
                //{
                //    List<MessageDTO> lastMessages = new List<MessageDTO>();

                //    lastMessages = ServerConnection.Connect.GetAllMessagesForUser(ServerConnection.Connect.GetCurrentUser()).ToList();

                //    this.Invoke(new Action(() =>
                //    {
                //        tbMonitor.SuspendLayout();
                //        tbMonitor.Text = string.Empty;
                //        lastMessages.ForEach(m => tbMonitor.Text += m.Text + Environment.NewLine);
                //        tbMonitor.Select(tbMonitor.Text.Length == 0 ? 0 : tbMonitor.Text.Length - 1, 0);
                //        tbMonitor.ScrollToCaret();
                //        tbMonitor.ResumeLayout();
                //    }));

                //    Thread.Sleep(1000);
                //}
                //else
                //{
                //    e.Cancel = true;
                //    break;
                //}
                //}
            }
        }

        private void bwUsersLoader_DoWork(object sender, DoWorkEventArgs e)
        {
            //while (true)
            //{
            //    if (isLoggedOn && bwUsersLoader.CancellationPending == false)
            //    {
            //        List<UserUI> users = ServerConnection.Connect.GetAllUsers().Select(u => new UserUI(u)).ToList();

            //        this.Invoke(new Action(() =>
            //       {
            //           var selection = lbFriendList.SelectedItem;
            //           lbFriendList.Items.Clear();
            //           lbFriendList.Items.AddRange(users.ToArray());
            //           if (selection != null)
            //           {
            //               lbFriendList.SelectedItem = selection;
            //           }
            //       }));
            //        Thread.Sleep(10000);
            //    }
            //    else
            //    {
            //        e.Cancel = true;
            //        break;
            //    }
            //}
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                if (messageLoader != null)
                {
                    messageLoader.Abort();
                    messageLoader = null;
                }
                if (userLoader != null)
                {
                    userLoader.Abort();
                    userLoader = null;
                }
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
