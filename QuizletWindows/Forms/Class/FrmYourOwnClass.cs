using DevExpress.XtraEditors;
using QuizletWindows.API;
using QuizletWindows.Forms.Library;
using QuizletWindows.ViewModels.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizletWindows.Forms.Class
{
    public partial class FrmYourOwnClass : DevExpress.XtraEditors.XtraForm
    {
        private List<ClassViewModel> classes;
        public FrmYourOwnClass()
        {
            InitializeComponent();
            FrmAddYourOwnClass.OnCreated += FetchDataTable;
        }

        private void FrmYourOwnClass_Load(object sender, EventArgs e)
        {
            FetchDataTable();
            InitialSetUp();

        }
        private void FetchDataTable()
        {
            classes = ClassApi.Instance.GetClassesByUser(Program.UserId);
            classGridView.AutoGenerateColumns = false;
            classGridView.DataSource = classes;


        }
        private void InitialSetUp()
        {
            DataGridViewColumn classId = classGridView.Columns["ClassId"];
            DataGridViewColumn className = classGridView.Columns["ClassName"];
            DataGridViewColumn describe = classGridView.Columns["Describe"];
            DataGridViewColumn createdDate = classGridView.Columns["CreatedDate"];
            DataGridViewColumn numberParticipant = classGridView.Columns["NumberParticipant"];
            DataGridViewColumn numberModules = classGridView.Columns["NumberModules"];
            classId.DataPropertyName = "ClassId";
            className.DataPropertyName = "ClassName";
            describe.DataPropertyName = "Describe";
            createdDate.DataPropertyName = "CastFormatCreatedDate";
            numberParticipant.DataPropertyName = "NumberParticipants";
            numberModules.DataPropertyName = "NumberLearningModules";
            classGridView.ColumnHeadersDefaultCellStyle.Font = new Font(classGridView.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            classGridView.Refresh();
        }
        private int GetClassId()
        {
            if (classGridView.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = classGridView.SelectedRows[0];
                string cellValue = selectedRow.Cells["ClassId"].Value.ToString();
                return int.Parse(cellValue);
            }
            return -1;
        }
        private string GetClassName()
        {
            if (classGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = classGridView.SelectedRows[0];
                string cellValue = selectedRow.Cells["ClassName"].Value.ToString();
                return cellValue;
            }
            return "";
        }
        private string GetDescribe()
        {
            if (classGridView.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = classGridView.SelectedRows[0];
                if (selectedRow.Cells["Describe"].Value != null)
                {
                    string cellValue = selectedRow.Cells["Describe"].Value.ToString();
                    return cellValue;
                }
            }
            return "";
        }
        private string GetCreatedDate()
        {
            if (classGridView.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = classGridView.SelectedRows[0];
                if (selectedRow.Cells["CreatedDate"].Value != null)
                {
                    string cellValue = selectedRow.Cells["CreatedDate"].Value.ToString();
                    return cellValue;
                }
            }
            return "";
        }

        private void btnBarAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmAddYourOwnClass ownClass = new FrmAddYourOwnClass();
            ownClass.ShowDialog();
        }

        private void btnBarEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (classGridView.SelectedRows.Count == 0) { return; }
            int classId = GetClassId();
            string className = GetClassName();
            string describe = GetDescribe();
            FrmEditYourOwnClass.ClassId = classId;
            FrmEditYourOwnClass frmEditClass = new FrmEditYourOwnClass();
            frmEditClass.SetTextDescribeInput(describe);
            frmEditClass.SetTextClassNameInput(className);
            frmEditClass.ShowDialog();
        }

        private async void btnBarDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (classGridView.SelectedRows.Count == 0) { return; }
            DialogResult result = Notification.ShowDeleteWarning("Are your sure about deleting this class permanently");
            if (result == DialogResult.OK)
            {
                int classId = GetClassId();
                await ClassApi.Instance.DeleteClass(classId);
                Notification.ShowNotification("Delete this class successfully");
                FetchDataTable();
            }
        }

        private void btnBarGoto_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmClassDetail.classId = GetClassId();
            Program.mainMenu.CloseAllChildrenForm();
            Program.mainMenu.ShowForm(typeof(FrmClassDetail));
        }

        private void classGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow dGVRow in this.classGridView.Rows)
            {
                dGVRow.HeaderCell.Value = String.Format("{0}", dGVRow.Index + 1);
            }
            this.classGridView.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }
    }
}