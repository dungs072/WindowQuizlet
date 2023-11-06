using DevExpress.XtraEditors;
using QuizletWindows.API;
using QuizletWindows.Forms.Library;
using QuizletWindows.ViewModels.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IdentityModel.Protocols.WSTrust;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.XtraEditors.Mask.MaskSettings;

namespace QuizletWindows.Forms.Class
{
    public partial class FrmClassDetail : DevExpress.XtraEditors.XtraForm
    {
        public static int classId;
        private List<UserParticipant> Participants;
        private List<ClassLearningModuleViewModel> Modules;
        public FrmClassDetail()
        {
            InitializeComponent();
        }

        private void FrmClassDetail_Load(object sender, EventArgs e)
        {
            FetchDataParticipantTable();
            FetchDataModuleTable();
            InitialSetUpModule();
            InitialSetUpParticipant();
        }
        private void FetchDataModuleTable()
        {
            Modules = ClassApi.Instance.GetDetailLearningModuleClass(classId);
            LearningModuleGridView.AutoGenerateColumns = false;
            LearningModuleGridView.DataSource = Modules;


        }
        private void InitialSetUpModule()
        {
            DataGridViewColumn moduleId = LearningModuleGridView.Columns["LearningModuleId"];
            DataGridViewColumn moduleName = LearningModuleGridView.Columns["LearningModuleName"];
            DataGridViewColumn describe = LearningModuleGridView.Columns["Describe"];
            DataGridViewColumn addedDate = LearningModuleGridView.Columns["AddedDate"];
            DataGridViewColumn numberTerms = LearningModuleGridView.Columns["NumberTerms"];
            moduleId.DataPropertyName = "LearningModuleId";
            moduleName.DataPropertyName = "LearningModuleName";
            describe.DataPropertyName = "Describe";
            addedDate.DataPropertyName = "CastFormatCreatedDate";
            numberTerms.DataPropertyName = "NumberTerms";
            LearningModuleGridView.ColumnHeadersDefaultCellStyle.Font = new Font(LearningModuleGridView.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            LearningModuleGridView.Refresh();
        }
        private void FetchDataParticipantTable()
        {
            Participants = ClassApi.Instance.GetDetailParticipantClass(classId);
            participantGridView.AutoGenerateColumns = false;
            participantGridView.DataSource = Participants;


        }
        private void InitialSetUpParticipant()
        {
            DataGridViewColumn userId = participantGridView.Columns["UserId"];
            DataGridViewColumn firstName = participantGridView.Columns["FirstName"];
            DataGridViewColumn lastName = participantGridView.Columns["LastName"];
            DataGridViewColumn gmail = participantGridView.Columns["Gmail"];
            DataGridViewColumn registerDate = participantGridView.Columns["RegisterDate"];
            userId.DataPropertyName = "UserId";
            firstName.DataPropertyName = "FirstName";
            lastName.DataPropertyName = "LastName";
            gmail.DataPropertyName = "Gmail";
            registerDate.DataPropertyName = "CastFormatCreatedDate";
            participantGridView.ColumnHeadersDefaultCellStyle.Font = new Font(participantGridView.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            participantGridView.Refresh();
        }

        private void btnBarBack_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.mainMenu.CloseAllChildrenForm();
            Program.mainMenu.ShowForm(typeof(FrmYourOwnClass));
        }

        private void btnBarAddModule_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmClassDetailChooseTitle titleChoose = new FrmClassDetailChooseTitle();
            titleChoose.ShowDialog();
            FetchDataModuleTable();
        }
        private int GetModuleId()
        {
            if (LearningModuleGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = LearningModuleGridView.SelectedRows[0];
                string cellValue = selectedRow.Cells["LearningModuleId"].Value.ToString();
                return int.Parse(cellValue);
            }
            return -1;
        }
        private async void btnBarRemoveModule_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            int moduleId = GetModuleId();
            if (moduleId == -1) { return; }
            DialogResult result = Notification.ShowDeleteWarning("Are you sure about removing it from your class");
            if(result==DialogResult.OK)
            {
                var check = await ClassApi.Instance.DeleteModuleDetail(classId, moduleId);
                if (!check)
                {
                    Notification.ShowError("Cannot delete module from class. Server error");

                }
                else
                {
                    Notification.ShowNotification("Delete module from class successfully");
                }
                FetchDataModuleTable();
            }
            
        }

        private void btnBarAddParticipant_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmClassDetailChooseParticipant participant = new FrmClassDetailChooseParticipant();
            participant.ShowDialog();
            FetchDataParticipantTable();
        }
        private int GetUserId()
        {
            if (participantGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = participantGridView.SelectedRows[0];
                string cellValue = selectedRow.Cells["UserId"].Value.ToString();
                return int.Parse(cellValue);
            }
            return -1;
        }
        private async void btnBarRemoveParticipant_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int userId = GetUserId();
            if (userId == -1) { return; }
            DialogResult result = Notification.ShowDeleteWarning("Are you sure about removing this person from your class");
            if (result == DialogResult.OK)
            {
                var check = await ClassApi.Instance.DeleteParticipantFromClass(FrmClassDetail.classId, userId);
                if (!check)
                {
                    Notification.ShowError("Cannot kick out paticipant from class. Server error");
                }
                else
                {
                    Notification.ShowNotification("Kick out participant from class successfully");
                }
                FetchDataParticipantTable();
            }
            
           
        }
    }
}