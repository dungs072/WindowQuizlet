using DevExpress.XtraEditors;
using QuizletWindows.API;
using QuizletWindows.ViewModels.Terminologies;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizletWindows.Forms.Library
{
    public partial class FrmAddTerm : DevExpress.XtraEditors.XtraForm
    {
        public static event Action OnCreated;
        public static int LearningModuleId { get;set; }
        public FrmAddTerm()
        {
            InitializeComponent();
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
    }
}