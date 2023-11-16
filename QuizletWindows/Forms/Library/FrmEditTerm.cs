using DevExpress.XtraEditors;
using QuizletWindows.API;
using QuizletWindows.ViewModels.Terminologies;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizletWindows.Forms.Library
{
    public partial class FrmEditTerm : DevExpress.XtraEditors.XtraForm
    {
        public FireBaseGoogle fireBaseGoogle;
        public static event Action OnUpdated;
        public static int LearningModuleId { get; set; }
        public static int TermId { get; set; }
        private OpenFileDialog openFileDialog1;
        private string imageUrl;

        public FrmEditTerm()
        {
            InitializeComponent();
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All files|*.*";
            fireBaseGoogle = new FireBaseGoogle();
        }
        private void FrmEditTerm_Load(object sender, EventArgs e)
        {
            
        }
        public void SetTextTermNameInput(string text)
        {
            inputTermName.Text = text;
        }
        public void SetTextExplanationInput(string text)
        {
            inputExplanation.Text = text;
        }
        public void SetImage(string url)
        {
            txtImage.Image = System.Drawing.Image.FromStream(new System.Net.WebClient().OpenRead(url));
            imageUrl = url;
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (inputTermName.Text.Trim().Length == 0)
            {
                Notification.ShowError("Please enter your term name!!!");
                return;
            }
            TermViewModel viewModel = new TermViewModel();
            viewModel.LearningModuleId = LearningModuleId;
            viewModel.TermId = TermId;
            viewModel.TermName = inputTermName.Text.Trim();
            viewModel.Explaination = inputExplanation.Text.Trim();
            if(imageUrl!=null)
            {
                fireBaseGoogle.DeleteTheOldImage(imageUrl);
            }
            
            //byte[] imageBytes = fireBaseGoogle.ImageToByteArray(txtImage.Image);
            //var task = fireBaseGoogle.FirebaseStorage
            //    .Child("images")
            //    .Child($"image_{DateTime.Now.Ticks}.png")
            //    .PutAsync(new MemoryStream(imageBytes));

            //var downloadUrl = await task;
            viewModel.Image = await fireBaseGoogle.StoreImage("images",txtImage.Image);
            var canUpdate = await TerminologyApi.Instance.UpdateTerm(viewModel);
            if (!canUpdate)
            {
                Notification.ShowError("Your terminology name is duplicated with another one.\nPlease fix it");
                return;
            }
            Notification.ShowNotification("Update terminology succesfully");

            this.Close();
            OnUpdated?.Invoke();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtImage.Image = Image.FromFile(openFileDialog1.FileName);

            }
        }

      
    }
}