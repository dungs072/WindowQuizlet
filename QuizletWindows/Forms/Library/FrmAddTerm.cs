using DevExpress.XtraEditors;
using Firebase.Storage;
using QuizletWindows.API;
using QuizletWindows.ViewModels.Terminologies;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizletWindows.Forms.Library
{
    public partial class FrmAddTerm : DevExpress.XtraEditors.XtraForm
    {
        public FireBaseGoogle fireBaseGoogle;
        public static event Action OnCreated;
        public static int LearningModuleId { get;set; }
        private OpenFileDialog openFileDialog1;
        public FrmAddTerm()
        {
            InitializeComponent();
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All files|*.*";
            fireBaseGoogle = new FireBaseGoogle();
        }

        private async void btnCreate_Click(object sender, EventArgs e)
        {
            if (inputTermName.Text.Trim().Length == 0)
            {
                Notification.ShowError("Please enter your terminology name!!!");
                return;
            }
            TermViewModel term = new TermViewModel();
            term.LearningModuleId = LearningModuleId;
            term.TermId = 0;
            term.TermName = inputTermName.Text.Trim();
            term.Explaination = inputTermExplanation.Text.Trim();
            byte[] imageBytes = fireBaseGoogle.ImageToByteArray(txtImage.Image);
            var task = fireBaseGoogle.FirebaseStorage
                .Child("images")
                .Child($"image_{DateTime.Now.Ticks}.png")
                .PutAsync(new MemoryStream(imageBytes));

            var downloadUrl = await task;
            term.Image = downloadUrl;
            var canCreate = await TerminologyApi.Instance.CreateTerm(term);
            if (!canCreate)
            {
                Notification.ShowError("Your terminology name is duplicated with another one.\nPlease fix it");
                return;
            }
            Notification.ShowNotification("Created new terminology succesfully");

            this.Close();
            OnCreated?.Invoke();
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