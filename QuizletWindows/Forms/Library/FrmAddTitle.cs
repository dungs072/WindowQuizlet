using DevExpress.XtraEditors;
using QuizletWindows.API;
using QuizletWindows.ViewModels.Terminologies;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace QuizletWindows.Forms.Library
{
    
    public partial class FrmAddTitle : DevExpress.XtraEditors.XtraForm
    {
        public static event Action OnCreated;
        public FrmAddTitle()
        {
            InitializeComponent();
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
            if(inputTitleName.Text.Trim().Length==0)
            {
                Notification.ShowError("Please enter your title name!!!");
                return;
            }
            TitleViewModel viewModel = new TitleViewModel();
            viewModel.TitleId = 0;
            viewModel.UserId = Program.UserId;
            viewModel.TitleName = inputTitleName.Text.Trim();
            viewModel.Describe = inputDescribe.Text.Trim();
            var canCreate = await TerminologyApi.Instance.CreateTitle(viewModel);
            if (!canCreate)
            {
                Notification.ShowError("Your title name is duplicated with another one.\nPlease fix it");
                return;
            }
            Notification.ShowNotification("Created new title succesfully");
            
            this.Close();
            OnCreated?.Invoke();
        }
    }
}