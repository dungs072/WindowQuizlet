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
using System.Windows.Forms;

namespace QuizletWindows.Forms.User
{
    public partial class FrmChangePass : DevExpress.XtraEditors.XtraForm
    {
        public FrmChangePass()
        {
            InitializeComponent();
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if(txtOldPassword.Text.Trim()=="")
            {
                Notification.ShowError("Please enter your old password");
                return;
            }
            if(txtNewPassword.Text.Trim()=="")
            {
                Notification.ShowError("Please enter your new password");
                return;
            }
            if(txtConfirm.Text.Trim()=="")
            {
                Notification.ShowError("Please enter your confirm");
                return;
            }
            if(txtNewPassword.Text!=txtConfirm.Text)
            {
                Notification.ShowError("New password and confirm do not match");
                return;
            }
            ChangePasswordViewModel viewModel = new ChangePasswordViewModel();
            viewModel.OldPassword = txtOldPassword.Text.Trim();
            viewModel.NewPassword = txtNewPassword.Text.Trim();
            viewModel.ConfirmPassword = txtConfirm.Text.Trim();
            viewModel.UserId = Program.UserId;
            var state = await UserApi.Instance.ChangePassword(viewModel);
            if(state)
            {
                Notification.ShowNotification("Change password successfully");
                this.Close();
            }
            else
            {
                Notification.ShowError("Your old password is wrong");
            }

        }

        private void showOldPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtOldPassword.UseSystemPasswordChar = !showOldPassword.Checked;
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            txtNewPassword.UseSystemPasswordChar = !checkEdit1.Checked;
        }

        private void showConfirm_CheckedChanged(object sender, EventArgs e)
        {
            txtConfirm.UseSystemPasswordChar = !showConfirm.Checked;
        }
    }
}