using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraEditors;
using QuizletWindows.API;
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

namespace QuizletWindows.Forms.Library
{
    public partial class FrmYourModules : DevExpress.XtraEditors.XtraForm
    {
        private List<LearningModuleViewModel2> modules;
        public static int TitleId { get; set; }
        public static string TitleName { get; set; }
        public static string DescribeTitle { get; set; }
        public FrmYourModules()
        {
            InitializeComponent();
            FrmAddLearningModule.OnCreated += FetchDataTable;
            FrmEditLearningModule.OnUpdated += FetchDataTable;
            
        }
        private void FrmYourModules_Load(object sender, EventArgs e)
        {
            FetchDataTable();
            InitialSetUp();
            TitleNameLabel.Text = TitleName + " - " + DescribeTitle;
        }
        private void FetchDataTable()
        {
            modules = TerminologyApi.Instance.GetLearningModuleByTitleId(TitleId);
            ModuleGridView.AutoGenerateColumns = false;
            ModuleGridView.DataSource = modules;


        }
        private void InitialSetUp()
        {
            DataGridViewColumn moduleNameColumn = ModuleGridView.Columns["ModuleName"];
            DataGridViewColumn describeColumn = ModuleGridView.Columns["Describe"];
            DataGridViewColumn moduleIdColumn = ModuleGridView.Columns["ModuleId"];
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
                string cellValue = selectedRow.Cells["ModuleId"].Value.ToString();
                return int.Parse(cellValue);
            }
            return -1;
        }
        private string GetModuleName()
        {
            if (ModuleGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = ModuleGridView.SelectedRows[0];
                string cellValue = selectedRow.Cells["ModuleName"].Value.ToString();
                return cellValue;
            }
            return "";
        }
        private string GetDescribe()
        {
            if (ModuleGridView.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = ModuleGridView.SelectedRows[0];
                if (selectedRow.Cells["Describe"].Value!=null)
                {
                    string cellValue = selectedRow.Cells["Describe"].Value.ToString();
                    return cellValue;
                }
               
            }
            return "";
        }
        private void btnBarBack_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
            Program.mainMenu.ShowForm(typeof(FrmYourLibrary));
        }

        private void btnBarAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            FrmAddLearningModule module = new FrmAddLearningModule();
            module.ShowDialog();
            
        }

        private void btnBarEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ModuleGridView.SelectedRows.Count == 0) { return; }
            int moduleId = GetModuleId();
            string moduleName = GetModuleName();
            string describe = GetDescribe();
            FrmEditLearningModule.ModuleId = moduleId;
            FrmEditLearningModule frmEditModule = new FrmEditLearningModule();
            frmEditModule.SetTextDescribeInput(describe);
            frmEditModule.SetTextModuleNameInput(moduleName);
            frmEditModule.ShowDialog();
        }

        private async void btnBarDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ModuleGridView.SelectedRows.Count == 0) { return; }
            DialogResult result = Notification.ShowDeleteWarning("Are your sure about deleting this module permanently");
            if (result == DialogResult.OK)
            {
                int moduleId = GetModuleId();
                bool canDelete = await TerminologyApi.Instance.DeleteLearningModule(moduleId);
                if(canDelete)
                {
                    Notification.ShowNotification("Delete this module successfully");
                    FetchDataTable();
                }
                else
                {
                    Notification.ShowError("Failed to delete. Server error");
                }
                
            }

        }

        private void btnBarTerm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmTerms.TitleId = TitleId;
            FrmTerms.ModuleId = GetModuleId();
            FrmTerms.ModuleNameDisplay = GetModuleName();
            FrmTerms.DescribeNameDisplay = GetDescribe();
            this.Close();
            Program.mainMenu.ShowForm(typeof(FrmTerms));
            
        }


      
    }
}