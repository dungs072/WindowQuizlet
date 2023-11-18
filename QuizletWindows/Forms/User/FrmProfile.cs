using DevExpress.Drawing;
using DevExpress.XtraEditors;
using QuizletWindows.API;
using QuizletWindows.ViewModels.User;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace QuizletWindows.Forms.User
{
    public partial class FrmProfile : DevExpress.XtraEditors.XtraForm
    {
        private List<string> types = new List<string>() { "Student","Teacher"};
        private UserViewModel viewModel;
        private FireBaseGoogle fireBaseGoogle;
        private OpenFileDialog openFileDialog1;
        public FrmProfile()
        {
            InitializeComponent();
            fireBaseGoogle = new FireBaseGoogle();
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All files|*.*";
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
            if (avartarPicture.Image != null)
            {
                if (viewModel.Image != null)
                {
                    fireBaseGoogle.DeleteTheOldImage(viewModel.Image,"users");
                }
                var imageUrl = await fireBaseGoogle.StoreImage("users", avartarPicture.Image);
                viewModel.Image = imageUrl;
            }
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

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                avartarPicture.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private async void btnDeleteImage_Click(object sender, EventArgs e)
        {
            if (avartarPicture.Image != null)
            {
                if (viewModel.Image != null)
                {
                    fireBaseGoogle.DeleteTheOldImage(viewModel.Image,"users");
                    viewModel.Image = null;
                    var state = await UserApi.Instance.UpdateProfile(viewModel);
                    if(state)
                    {
                        Notification.ShowNotification("Delete your avatar successfully");
                        avartarPicture.Image = null;
                    }
                    else
                    {
                        Notification.ShowNotification("Delete your avatar failed");
                    }
                }
            }
        }
    }
}