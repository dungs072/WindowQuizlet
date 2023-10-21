using DevExpress.XtraEditors;
using QuizletWindows.API;
using QuizletWindows.ViewModels.Classes;
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

namespace QuizletWindows.Forms.Class
{
    public partial class FrmAddYourOwnClass : DevExpress.XtraEditors.XtraForm
    {
        public static event Action OnCreated;
        public FrmAddYourOwnClass()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnCreate_Click(object sender, EventArgs e)
        {
            if (inputClassName.Text.Trim().Length == 0)
            {
                Notification.ShowError("Please enter your class name!!!");
                return;
            }
            ClassViewModel cla = new ClassViewModel();
            cla.ClassId = 0;
            cla.UserId = Program.UserId;
            cla.ClassName = inputClassName.Text.Trim();
            cla.Describe = inputDescribe.Text.Trim();
            var canCreate = await ClassApi.Instance.CreateClass(cla);
            if (!canCreate)
            {
                Notification.ShowError("Your class name is duplicated with another one.\nPlease fix it");
                return;
            }
            Notification.ShowNotification("Created new class succesfully");

            this.Close();
            OnCreated?.Invoke();
        }
    }
}