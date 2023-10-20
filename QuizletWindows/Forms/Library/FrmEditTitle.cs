using DevExpress.XtraEditors;
using QuizletWindows.API;
using QuizletWindows.ViewModels.Terminologies;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace QuizletWindows.Forms.Library
{
    
    public partial class FrmEditTitle : DevExpress.XtraEditors.XtraForm
    {
        public static event Action OnUpdated;
        public static int TitleId { get; set; }
        
        public FrmEditTitle()
        {
            InitializeComponent();
        }
        public void SetTextTitleNameInput(string text)
        {
            inputTitleName.Text = text;
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
            if(inputTitleName.Text.Trim().Length==0)
            {
                Notification.ShowError("Please enter your title name!!!");
                return;
            }
            TitleViewModel viewModel = new TitleViewModel();
            viewModel.TitleId = TitleId;
            viewModel.UserId = Program.UserId;
            viewModel.TitleName = inputTitleName.Text.Trim();
            viewModel.Describe = inputDescribe.Text.Trim();
            var canUpdate = await TerminologyApi.Instance.UpdateTitle(viewModel);
            if (!canUpdate)
            {
                Notification.ShowError("Your title name is duplicated with another one.\nPlease fix it");
                return;
            }
            Notification.ShowNotification("Update title succesfully");
            
            this.Close();
            OnUpdated?.Invoke();
        }
    }
}