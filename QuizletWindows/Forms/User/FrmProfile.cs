using DevExpress.XtraEditors;
using QuizletWindows.API;
using QuizletWindows.ViewModels.User;
using System;
using System.Collections.Generic;

namespace QuizletWindows.Forms.User
{
    public partial class FrmProfile : DevExpress.XtraEditors.XtraForm
    {
        private List<string> types = new List<string>() { "Student","Teacher"};
        private UserViewModel viewModel;
        private FireBaseGoogle fireBaseGoogle;
        public FrmProfile()
        {
            InitializeComponent();
            fireBaseGoogle = new FireBaseGoogle();
        }
        public void SetUserViewModel(UserViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        private void FrmProfile_Load(object sender, EventArgs e)
        {
            txtFirstName.Text = viewModel.FirstName;
            txtLastName.Text = viewModel.LastName;
            txtGmail.Text = viewModel.Gmail;
            if(viewModel.Image!=null)
            {
                avartarPicture.Image = System.Drawing.Image.FromStream(new System.Net.WebClient().OpenRead(viewModel.Image));
                btnDeleteImage.Enabled = true;
            }
            else
            {
                btnDeleteImage.Enabled = false;
            }
           
            if (viewModel.TypeAccount=="Admin")
            {
                cmbTypeUser.DataSource = viewModel.TypeAccount;
            }
            else
            {
                cmbTypeUser.DataSource = types;
                cmbTypeUser.SelectedItem = viewModel.TypeAccount;
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if(txtFirstName.Text.Trim()=="")
            {
                Notification.ShowError("Your first name is blank. Please enter it");
                return;
            }
            if (txtLastName.Text.Trim() == "")
            {
                Notification.ShowError("Your last name is blank. Please enter it");
                return;
            }
            if (txtGmail.Text.Trim() == "")
            {
                Notification.ShowError("Your gmail is blank. Please enter it");
                return;
            }
            viewModel.FirstName = txtFirstName.Text.Trim();
            viewModel.LastName = txtLastName.Text.Trim();
            viewModel.Gmail = txtGmail.Text.Trim();
            viewModel.TypeAccount = cmbTypeUser.SelectedValue.ToString();
            var state = await UserApi.Instance.UpdateProfile(viewModel);
            if(state)
            {
                Notification.ShowNotification("Update profile successfully");
                Program.mainMenu.SetNameAndTypeUser(viewModel.LastName + " " + viewModel.FirstName, viewModel.TypeAccount);
                this.Close();
            }
            else
            {
                Notification.ShowNotification("Update failed. Please fix it");
            }
        }

        private async void btnUploadImage_Click(object sender, EventArgs e)
        {
            if(avartarPicture.Image!=null)
            {
                if(viewModel.Image!=null)
                {
                    fireBaseGoogle.DeleteTheOldImage(viewModel.Image);
                }
                var imageUrl = await fireBaseGoogle.StoreImage("users", avartarPicture.Image);
                viewModel.Image = imageUrl;
                var state = await UserApi.Instance.UpdateProfile(viewModel);
                if(state)
                {
                    Notification.ShowNotification("Upload avatar successfully");
                    avartarPicture.Image = System.Drawing.Image.FromStream(new System.Net.WebClient().OpenRead(viewModel.Image));
                }
                else
                {
                    Notification.ShowNotification("Upload avatar failed");
                }
                

            }
        }

        private void btnDeleteImage_Click(object sender, EventArgs e)
        {
            if (avartarPicture.Image != null)
            {
                if (viewModel.Image != null)
                {
                    fireBaseGoogle.DeleteTheOldImage(viewModel.Image);
                }
            }
        }
    }
}