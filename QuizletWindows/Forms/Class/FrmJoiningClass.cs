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
using static DevExpress.XtraEditors.Mask.MaskSettings;

namespace QuizletWindows.Forms.Class
{
    public partial class FrmJoiningClass : DevExpress.XtraEditors.XtraForm
    {
        private List<ClassViewModel> classes;
        public FrmJoiningClass()
        {
            InitializeComponent();
        }

        private void FrmJoiningClass_Load(object sender, EventArgs e)
        {
            FetchDataTable();
            InitialSetUp();
        }
        private void FetchDataTable()
        {
            classes = ClassApi.Instance.GetJoinClass(Program.UserId);
            joiningClassGridView.AutoGenerateColumns = false;
            joiningClassGridView.DataSource = classes;


        }
        private void InitialSetUp()
        {
            DataGridViewColumn classId = joiningClassGridView.Columns["ClassId"];
            DataGridViewColumn className = joiningClassGridView.Columns["ClassName"];
            DataGridViewColumn describe = joiningClassGridView.Columns["Describe"];
            DataGridViewColumn createdDate = joiningClassGridView.Columns["CreatedDate"];
            DataGridViewColumn numberParticipant = joiningClassGridView.Columns["NumberParticipants"];
            DataGridViewColumn numberModules = joiningClassGridView.Columns["NumberLearningModules"];
            classId.DataPropertyName = "ClassId";
            className.DataPropertyName = "ClassName";
            describe.DataPropertyName = "Describe";
            createdDate.DataPropertyName = "CastFormatCreatedDate";
            numberParticipant.DataPropertyName = "NumberParticipants";
            numberModules.DataPropertyName = "NumberLearningModules";
            joiningClassGridView.ColumnHeadersDefaultCellStyle.Font = new Font(joiningClassGridView.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            joiningClassGridView.Refresh();
        }

        private void btnBarRegisterNewClass_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmRegisterJoiningClass frmRegisterJoiningClass = new FrmRegisterJoiningClass();
            frmRegisterJoiningClass.ShowDialog();
            FetchDataTable();
        }
        private int GetClassId()
        {
            if (joiningClassGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = joiningClassGridView.SelectedRows[0];
                string cellValue = selectedRow.Cells["ClassId"].Value.ToString();
                return int.Parse(cellValue);
            }
            return -1;
        }

        private async void btnBarCancelRegistration_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int classId = GetClassId();
            if (classId == -1) { return; }
            DialogResult result = Notification.ShowDeleteWarning("Are you sure about quitting your class");
            if (result == DialogResult.Cancel) { return; }
            var check = await ClassApi.Instance.DeleteParticipantFromClass(classId, Program.UserId);
            if (!check)
            {
                Notification.ShowError("Cannot quit from class. Server error");

            }
            else
            {
                Notification.ShowNotification("Quit from class successfully");
                FetchDataTable();
            }
        }

        private void btnBarGoTo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int classId = GetClassId();
            if (classId == -1) { return; }
            Program.mainMenu.CloseAllChildrenForm();
            FrmJoiningClassDetail.ClassId = classId;
            Program.mainMenu.ShowForm(typeof(FrmJoiningClassDetail));
        }
    }
}