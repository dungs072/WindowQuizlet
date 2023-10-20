using DevExpress.XtraEditors;
using QuizletWindows.API;
using QuizletWindows.ViewModels.Terminologies;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace QuizletWindows.Forms.Library
{
    
    public partial class FrmEditLearningModule : DevExpress.XtraEditors.XtraForm
    {
        public static event Action OnUpdated;
        public static int ModuleId { get; set; }
        
        public FrmEditLearningModule()
        {
            InitializeComponent();
        }
        public void SetTextModuleNameInput(string text)
        {
            inputModuleName.Text = text;
        }
        public void SetTextDescribeInput(string text)
        {
            inputDescribe.Text = text;
        }


        private void FrmAddTitle_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnCreate_Click(object sender, EventArgs e)
        {
            if(inputModuleName.Text.Trim().Length==0)
            {
                Notification.ShowError("Please enter your module name!!!");
                return;
            }
            LearningModuleViewModel2 viewModel = new LearningModuleViewModel2();
            viewModel.TitleId = FrmYourModules.TitleId;
            viewModel.LearningModuleId = ModuleId;
            viewModel.LearningModuleName = inputModuleName.Text.Trim();
            viewModel.Describe = inputDescribe.Text.Trim();
            var canUpdate = await TerminologyApi.Instance.UpdateLearningModule(viewModel);
            if (!canUpdate)
            {
                Notification.ShowError("Your module name is duplicated with another one.\nPlease fix it");
                return;
            }
            Notification.ShowNotification("Update module succesfully");
            
            this.Close();
            OnUpdated?.Invoke();
        }
    }
}