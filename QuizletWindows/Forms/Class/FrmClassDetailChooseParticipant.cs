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
    public partial class FrmClassDetailChooseParticipant : DevExpress.XtraEditors.XtraForm
    {
        List<UserParticipant> users;
        public FrmClassDetailChooseParticipant()
        {
            InitializeComponent();
        }

        private void FrmClassDetailChooseParticipant_Load(object sender, EventArgs e)
        {
            InitialSetUp();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FetchDataTable();
            
        }
        private void FetchDataTable()
        {
            if (txtSearch.Text.Trim() == "") { return; }
            users = ClassApi.Instance.GetUserParticipant(FrmClassDetail.classId, txtSearch.Text, Program.UserId);
            participantGridView.AutoGenerateColumns = false;
            participantGridView.DataSource = users;
        }
        private void InitialSetUp()
        {
            DataGridViewColumn userId = participantGridView.Columns["UserId"];
            DataGridViewColumn lastName = participantGridView.Columns["LastName"];
            DataGridViewColumn firstName = participantGridView.Columns["FirstName"];
            DataGridViewColumn gmail = participantGridView.Columns["Gmail"];
            userId.DataPropertyName = "UserId";
            lastName.DataPropertyName = "LastName";
            firstName.DataPropertyName = "FirstName";
            gmail.DataPropertyName = "Gmail";
            participantGridView.ColumnHeadersDefaultCellStyle.Font = new Font(participantGridView.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            participantGridView.Refresh();
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

        private async void btnBarChoose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int userId = GetUserId();
            if (userId == -1) { return; }
            RegisterDetailClass registerDetailClass = new RegisterDetailClass();
            registerDetailClass.UserId = userId;
            registerDetailClass.ClassId = FrmClassDetail.classId;
            registerDetailClass.IsAccepted = true;

            var check = await ClassApi.Instance.AddParticipantToClass(registerDetailClass);
            if (!check)
            {
                Notification.ShowError("Cannot add this user to class. Server error");
            }
            else
            {
                Notification.ShowNotification("Add user to class successfully");
            }
            FetchDataTable();

        }
    }
}