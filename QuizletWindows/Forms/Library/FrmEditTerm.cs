using DevExpress.XtraEditors;
using QuizletWindows.API;
using QuizletWindows.ViewModels.Terminologies;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizletWindows.Forms.Library
{
    public partial class FrmEditTerm : DevExpress.XtraEditors.XtraForm
    {
        public static event Action OnUpdated;
        public static int LearningModuleId { get; set; }
        public static int TermId { get; set; }

        public FrmEditTerm()
        {
            InitializeComponent();
        }
        public void SetTextTermNameInput(string text)
        {
            inputTermName.Text = text;
        }
        public void SetTextExplanationInput(string text)
        {
            inputExplanation.Text = text;
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
    }
}