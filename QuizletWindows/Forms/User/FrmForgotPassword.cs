using DevExpress.XtraEditors;
using QuizletWindows.API;
using QuizletWindows.ViewModels.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.ModelBinding;
using System.Windows.Forms;

namespace QuizletWindows.Forms.User
{
    public partial class FrmForgotPassword : DevExpress.XtraEditors.XtraForm
    {
        public FrmForgotPassword()
        {
            InitializeComponent();
        }

        private async void btnForgetPassword_Click(object sender, EventArgs e)
        {
            if(txtGmail.Text.Trim()=="")
            {
                Notification.ShowError("Please enter your registered gmail");
            }
            ForgetPasswordViewModel model = new ForgetPasswordViewModel();
            model.Email = txtGmail.Text.Trim();
            bool state = await UserApi.Instance.HandleForgetPassword(model);
            if (state)
            {
                Notification.ShowNotification("System has send a new password to your email: "+ model.Email);
                this.Close();
            }
            else
            {
                Notification.ShowError("Your email you entered is not registered. Please check again !!!");
            }
        }
    }
}