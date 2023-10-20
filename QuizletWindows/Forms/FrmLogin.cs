using DevExpress.XtraEditors;
using QuizletWindows.API;
using QuizletWindows.ViewModels.User;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuizletWindows.Forms
{
    public partial class FrmLogin : DevExpress.XtraEditors.XtraForm
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            // Calculate the center position for the panel.
            int panelX = (this.Width - panel1.Width) / 2;
            int panelY = (this.Height - panel1.Height) / 2;

            // Set the panel's location to the calculated center position.
            panel1.Location = new Point(panelX, panelY);
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            
            if (txtGmail.Text.Trim().Length==0)
            {
                Notification.ShowNotification("Please enter your gmail");
                return;
            }
            if(txtPassword.Text.Trim().Length==0)
            {
                Notification.ShowNotification("Please enter your password");
                return;
            }
            UserViewModel user =  UserApi.Instance.FindAccount(txtGmail.Text.Trim(), txtPassword.Text.Trim());
            if (user!=null&&user.UserId!=0)
            {
                Program.UserId = user.UserId;
                Program.UserName = user.LastName + " " + user.FirstName;
                Program.TypeUser = user.TypeAccount;
                this.Close();
                DialogResult = DialogResult.OK;
            }
            else
            {
                Notification.ShowError("wrong gmail or password");
            }
        }

    }
}