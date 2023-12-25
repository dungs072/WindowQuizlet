using DevExpress.XtraEditors;
using QuizletWindows.API;
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

namespace QuizletWindows.Forms.Class
{
    public partial class FrmPendingParticipant : DevExpress.XtraEditors.XtraForm
    {
        public static int classId = -1;
        private List<Participant> pendings;
        public FrmPendingParticipant()
        {
            InitializeComponent();
        }
        private void FrmPendingParticipant_Load(object sender, EventArgs e)
        {
            FetchDataParticipantTable();
            InitialSetUpParticipant();
        }

        private void FetchDataParticipantTable()
        {
            if (classId == -1) { return; }
            pendings =  ClassApi.Instance.GetDetailPendingParticipantClass(classId);
          
            pendingParticipant.AutoGenerateColumns = false;
            pendingParticipant.DataSource = pendings;


        }
        private void InitialSetUpParticipant()
        {
            DataGridViewColumn userId = pendingParticipant.Columns["UserId"];
            DataGridViewColumn firstName = pendingParticipant.Columns["FirstName"];
            DataGridViewColumn lastName = pendingParticipant.Columns["LastName"];
            DataGridViewColumn gmail = pendingParticipant.Columns["Gmail"];
            DataGridViewColumn registerDate = pendingParticipant.Columns["RegisterDate"];
            userId.DataPropertyName = "UserId";
            firstName.DataPropertyName = "FirstName";
            lastName.DataPropertyName = "LastName";
            gmail.DataPropertyName = "Gmail";
            registerDate.DataPropertyName = "CastFormatCreatedDate";
            pendingParticipant.ColumnHeadersDefaultCellStyle.Font = new Font(pendingParticipant.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            pendingParticipant.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private int GetUserId()
        {
            if (pendingParticipant.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = pendingParticipant.SelectedRows[0];
                string cellValue = selectedRow.Cells["UserId"].Value.ToString();
                return int.Parse(cellValue);
            }
            return -1;
        }

        private void btnBarAccept_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //int userId = GetUserId(); 
            //var registerDetail =  ClassApi.Instance.GetDetailPendingParticipant(classId, userId);
            //registerDetail.Is = true;
            //var canUpdate = await classService.UpdateRegisterDetail(registerDetail);
        }

        private void btnBarReject_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}