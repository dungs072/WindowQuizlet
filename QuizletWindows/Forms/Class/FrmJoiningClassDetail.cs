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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizletWindows.Forms.Class
{
    public partial class FrmJoiningClassDetail : DevExpress.XtraEditors.XtraForm
    {
        public static int ClassId;
        private List<ClassLearningModuleViewModel> modules;
        public FrmJoiningClassDetail()
        {
            InitializeComponent();
        }

        private void FrmJoiningClassDetail_Load(object sender, EventArgs e)
        {
            FetchDataTable();
            InitialSetUp();
        }
        private void FetchDataTable()
        {
            modules = ClassApi.Instance.GetDetailLearningModuleClass(ClassId);
            detailGridView.AutoGenerateColumns = false;
            detailGridView.DataSource = modules;
        }
        private void InitialSetUp()
        {
            DataGridViewColumn learningModuleId = detailGridView.Columns["LearningModuleId"];
            DataGridViewColumn learningModuleName = detailGridView.Columns["LearningModuleName"];
            DataGridViewColumn describe = detailGridView.Columns["Describe"];
            DataGridViewColumn addedDate = detailGridView.Columns["AddedDate"];
            DataGridViewColumn numberTerms = detailGridView.Columns["NumberTerms"];
            learningModuleId.DataPropertyName = "LearningModuleId";
            learningModuleName.DataPropertyName = "LearningModuleName";
            describe.DataPropertyName = "Describe";
            addedDate.DataPropertyName = "AddedDate";
            numberTerms.DataPropertyName = "NumberTerms";
            detailGridView.ColumnHeadersDefaultCellStyle.Font = new Font(detailGridView.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            detailGridView.Refresh();
        }

        private void btnBarBack_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.mainMenu.CloseAllChildrenForm();
            Program.mainMenu.ShowForm(typeof(FrmJoiningClass));
        }
        private int GetModuleId()
        {
            if (detailGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = detailGridView.SelectedRows[0];
                string cellValue = selectedRow.Cells["LearningModuleId"].Value.ToString();
                return int.Parse(cellValue);
            }
            return -1;
        }

        private void btnBarTerminology_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int moduleId = GetModuleId();
            if (moduleId == -1) { return; }
            Program.mainMenu.CloseAllChildrenForm();
            FrmTerms.ModuleId = moduleId;
            Form f = Program.mainMenu.ShowForm(typeof(FrmTerms));
            if(f is FrmTerms)
            {
                ((FrmTerms)f).ToggleJoiningClassMode(false);
            }
        }
    }
}