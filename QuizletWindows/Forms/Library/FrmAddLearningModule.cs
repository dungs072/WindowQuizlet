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
    public partial class FrmAddLearningModule : DevExpress.XtraEditors.XtraForm
    {
        public static event Action OnCreated;
        public FrmAddLearningModule()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnCreate_Click(object sender, EventArgs e)
        {
            if (inputModuleName.Text.Trim().Length == 0)
            {
                Notification.ShowError("Please enter your module name!!!");
                return;
            }
            LearningModuleViewModel2 module = new LearningModuleViewModel2();
            module.TitleId = FrmYourModules.TitleId;
            module.LearningModuleId = 0;
            module.LearningModuleName = inputModuleName.Text.Trim();
            module.Describe = inputDescribe.Text.Trim();
            var canCreate = await TerminologyApi.Instance.CreateLearningModule(module);
            if (!canCreate)
            {
                Notification.ShowError("Your module name is duplicated with another one.\nPlease fix it");
                return;
            }
            Notification.ShowNotification("Created new module succesfully");

            this.Close();
            OnCreated?.Invoke();
        }
    }
}