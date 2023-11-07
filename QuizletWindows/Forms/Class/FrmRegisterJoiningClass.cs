using DevExpress.XtraEditors;
using QuizletWindows.API;
using QuizletWindows.ViewModels.Classes;
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
    public partial class FrmRegisterJoiningClass : DevExpress.XtraEditors.XtraForm
    {
        private List<RegisterClass> registerClasses; 
        public FrmRegisterJoiningClass()
        {
            InitializeComponent();
        }
        private void FrmRegisterJoiningClass_Load(object sender, EventArgs e)
        {
            InitialSetUp();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FetchDataTable();
            
        }
        private void FetchDataTable()
        {
            if (txtSearchJoinningClass.Text.Trim() == "") { return; }
            registerClasses = ClassApi.Instance.GetRegisterClass(Program.UserId,txtSearchJoinningClass.Text);
            registerJoiningClassGridView.AutoGenerateColumns = false;
            registerJoiningClassGridView.DataSource = registerClasses;
        }
        private void InitialSetUp()
        {
            DataGridViewColumn classId = registerJoiningClassGridView.Columns["ClassId"];
            DataGridViewColumn learningModuleName = registerJoiningClassGridView.Columns["LearningModuleName"];
            DataGridViewColumn className = registerJoiningClassGridView.Columns["ClassName"];
            DataGridViewColumn ownerFullName = registerJoiningClassGridView.Columns["OwnerFullName"];
            DataGridViewColumn terms = registerJoiningClassGridView.Columns["NumberTerms"];
            DataGridViewColumn learningModuleId = registerJoiningClassGridView.Columns["LearningModuleId"];
            classId.DataPropertyName = "ClassId";
            learningModuleName.DataPropertyName = "LearningModuleName";
            className.DataPropertyName = "ClassName";
            ownerFullName.DataPropertyName = "OwnerFullName";
            terms.DataPropertyName = "NumberTerms";
            learningModuleId.DataPropertyName = "LearningModuleId";
            registerJoiningClassGridView.ColumnHeadersDefaultCellStyle.Font = new Font(registerJoiningClassGridView.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            registerJoiningClassGridView.Refresh();
        }
        private int GetModuleId()
        {
            if (registerJoiningClassGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = registerJoiningClassGridView.SelectedRows[0];
                string cellValue = selectedRow.Cells["LearningModuleId"].Value.ToString();
                return int.Parse(cellValue);
            }
            return -1;
        }
        private string GetModuleName()
        {
            if (registerJoiningClassGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = registerJoiningClassGridView.SelectedRows[0];
                string cellValue = selectedRow.Cells["LearningModuleName"].Value.ToString();
                return cellValue;
            }
            return "";
        }
        private int GetClassId()
        {
            if (registerJoiningClassGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = registerJoiningClassGridView.SelectedRows[0];
                string cellValue = selectedRow.Cells["ClassId"].Value.ToString();
                return int.Parse(cellValue);
            }
            return -1;
        }
        private void btnBarReadFirst_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int moduleId = GetModuleId();
            if (moduleId == -1) { return; }
            FrmJoiningClassReadFirst readFirst = new FrmJoiningClassReadFirst();
            FrmJoiningClassReadFirst.LearningModuleId = moduleId;
            readFirst.Text = GetModuleName();
            readFirst.ShowDialog();
        }

        private async void btnBarRegister_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int classId = GetClassId();
            if (classId == -1) { return; }
            RegisterDetailClass registerDetailClass = new RegisterDetailClass();
            registerDetailClass.ClassId = classId;
            registerDetailClass.UserId = Program.UserId;
            registerDetailClass.IsAccepted = false;
            bool canRegister = await ClassApi.Instance.AddParticipantToClass(registerDetailClass);
            if (!canRegister)
            {
                Notification.ShowError("Cannot handle your request. Server error");
            }
            else
            {
                Notification.ShowNotification("Register this class sucessfully");
                FetchDataTable();
            }
      
        }
    }
}