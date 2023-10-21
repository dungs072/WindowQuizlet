
using QuizletWindows.API;
using QuizletWindows.ViewModels.Classes;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace QuizletWindows.Forms.Class
{
    public partial class FrmEditYourOwnClass : DevExpress.XtraEditors.XtraForm
    {
        public static event Action OnUpdated;
        public static int ClassId { get; set; }
        public FrmEditYourOwnClass()
        {
            InitializeComponent();
        }
        public void SetTextClassNameInput(string text)
        {
            inputClassName.Text = text;
        }
        public void SetTextDescribeInput(string text)
        {
            inputDescribe.Text = text;
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (inputClassName.Text.Trim().Length == 0)
            {
                Notification.ShowError("Please enter your class name!!!");
                return;
            }
            ClassViewModel viewModel = new ClassViewModel();
            viewModel.ClassId = ClassId;
            viewModel.UserId = Program.UserId;
            viewModel.ClassName = inputClassName.Text.Trim();
            viewModel.Describe = inputDescribe.Text.Trim();
            var canUpdate = await ClassApi.Instance.UpdateClass(viewModel);
            if (!canUpdate)
            {
                Notification.ShowError("Your class name is duplicated with another one.\nPlease fix it");
                return;
            }
            Notification.ShowNotification("Update class succesfully");

            this.Close();
            OnUpdated?.Invoke();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}