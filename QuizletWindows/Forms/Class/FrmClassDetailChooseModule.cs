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
    public partial class FrmClassDetailChooseModule : DevExpress.XtraEditors.XtraForm
    {
        private List<LearningModuleViewModel> modules;
        public static int TitleId;
        public static string TitleName;
        public FrmClassDetailChooseModule()
        {
            InitializeComponent();
        }
        private void FrmClassDetailChooseModule_Load(object sender, EventArgs e)
        {
            this.Text = TitleName;
            FetchDataTable();
            InitialSetUp();
        }
        private void FetchDataTable()
        {
            modules = ClassApi.Instance.GetModuleDatas(FrmClassDetail.classId,TitleId).Where(a=>!a.IsChoose).ToList();
            ModuleGridView.AutoGenerateColumns = false;
            ModuleGridView.DataSource = modules;
        }
        private void InitialSetUp()
        {
            DataGridViewColumn moduleNameColumn = ModuleGridView.Columns["ModuleName"];
            DataGridViewColumn describeColumn = ModuleGridView.Columns["Describe"];
            DataGridViewColumn moduleIdColumn = ModuleGridView.Columns["LearningModuleId"];
            moduleNameColumn.DataPropertyName = "LearningModuleName";
            describeColumn.DataPropertyName = "Describe";
            moduleIdColumn.DataPropertyName = "LearningModuleId";
            moduleNameColumn.Width = 500;
            ModuleGridView.ColumnHeadersDefaultCellStyle.Font = new Font(ModuleGridView.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            ModuleGridView.Refresh();
        }
        private int GetModuleId()
        {
            if (ModuleGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = ModuleGridView.SelectedRows[0];
                string cellValue = selectedRow.Cells["LearningModuleId"].Value.ToString();
                return int.Parse(cellValue);
            }
            return -1;
        }
        private void btnBarBack_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
            
        }

        private async void btnBarChoose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ModuleGridView.Rows.Count == 0) { return; }
            LearningModuleDetail detail = new LearningModuleDetail();
            detail.ClassId = FrmClassDetail.classId;
            detail.LearningModuleId = GetModuleId();

            var check = await ClassApi.Instance.AddModuleToClass(detail);
            if (!check)
            {
                Notification.ShowError("Cannot add module to class. Server error");
            }
            else
            {
                Notification.ShowNotification("Add module to class successfully");
            }
            FetchDataTable();
        }

       
    }
}