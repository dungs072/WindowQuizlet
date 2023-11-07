using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraEditors;
using QuizletWindows.API;
using QuizletWindows.Forms.Class;
using QuizletWindows.Forms.Library.Objective;
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
    public partial class FrmTerms : DevExpress.XtraEditors.XtraForm
    {
        public static bool isJoiningClassMode = false;
        private List<TermViewModel> terms;
        public static int ModuleId { get; set; }
        public static int TitleId { get;set; }
        public static string ModuleNameDisplay { get; set; }
        public static string DescribeNameDisplay { get; set; }
        public FrmTerms()
        {
            InitializeComponent();
            FrmAddTerm.OnCreated += FetchDataTable;
            isJoiningClassMode = false;
            FrmEditTerm.OnUpdated += FetchDataTable;
        }
        private void FrmTerms_Load(object sender, EventArgs e)
        {
            FetchDataTable();
            InitialSetUp();
            ModuleName.Text = ModuleNameDisplay+" - "+ DescribeNameDisplay;
            
        }
        private void FetchDataTable()
        {
            terms = TerminologyApi.Instance.GetTermByLearningModuleId(ModuleId);
            termGridView.AutoGenerateColumns = false;
            termGridView.DataSource = terms;


        }
        private void InitialSetUp()
        {
            DataGridViewColumn termName = termGridView.Columns["TermName"];
            DataGridViewColumn termExplanation = termGridView.Columns["TermExplanation"];
            DataGridViewColumn termId = termGridView.Columns["TermId"];
            termName.DataPropertyName = "TermName";
            termExplanation.DataPropertyName = "Explaination";
            termId.DataPropertyName = "TermId";
            termName.Width = 500;
            termGridView.ColumnHeadersDefaultCellStyle.Font = new Font(termGridView.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            termGridView.Refresh();
        }
        private int GetTermId()
        {
            if (termGridView.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = termGridView.SelectedRows[0];
                string cellValue = selectedRow.Cells["TermId"].Value.ToString();
                return int.Parse(cellValue);
            }
            return -1;
        }
        private string GetTermName()
        {
            if (termGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = termGridView.SelectedRows[0];
                string cellValue = selectedRow.Cells["TermName"].Value.ToString();
                return cellValue;
            }
            return "";
        }
        private string GetExplanation()
        {
            if (termGridView.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = termGridView.SelectedRows[0];
                if (selectedRow.Cells["TermExplanation"].Value != null)
                {
                    string cellValue = selectedRow.Cells["TermExplanation"].Value.ToString();
                    return cellValue;
                }
            }
            return "";
        }

        private void btnBarAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmAddTerm term = new FrmAddTerm();
            FrmAddTerm.LearningModuleId = ModuleId;
            term.ShowDialog();
        }

        private void btnBarEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (termGridView.SelectedRows.Count == 0) { return; }
            int termId = GetTermId();
            string termName = GetTermName();
            string explanation = GetExplanation();
            FrmEditTerm.LearningModuleId = ModuleId;
            FrmEditTerm.TermId = termId;
            FrmEditTerm frmEditTerm = new FrmEditTerm();
            frmEditTerm.SetTextExplanationInput(explanation);
            frmEditTerm.SetTextTermNameInput(termName);
            frmEditTerm.ShowDialog();
        }

        private async void btnBarDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (termGridView.SelectedRows.Count == 0) { return; }
            DialogResult result = Notification.ShowDeleteWarning("Are your sure about deleting this terminology permanently");
            if (result == DialogResult.OK)
            {
                int termId = GetTermId();
                bool canDelete = await TerminologyApi.Instance.DeleteTerm(termId);
                if (canDelete)
                {
                    Notification.ShowNotification("Delete this term successfully");
                    FetchDataTable();
                }
                else
                {
                    Notification.ShowError("Failed to delete. Server error");
                }

            }
        }

        private void btnBarPractice_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (terms.Count <=4) { return; }
            FrmObjectivePractice.LearningModuleId = ModuleId;
            Program.mainMenu.ShowForm(typeof(FrmObjectivePractice));
        }

        private void btnBarTest_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnBarBack_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
            Program.mainMenu.CloseAllChildrenForm();
            if (isJoiningClassMode)
            {
                
                Program.mainMenu.ShowForm(typeof(FrmJoiningClassDetail));
            }
            else
            {
                FrmYourModules.TitleId = TitleId;
                Program.mainMenu.ShowForm(typeof(FrmYourModules));
            }
            
        }

        private void termGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow dGVRow in this.termGridView.Rows)
            {
                dGVRow.HeaderCell.Value = String.Format("{0}", dGVRow.Index + 1);
            }
            this.termGridView.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }
        public void ToggleJoiningClassMode(bool state)
        {
            btnBarAdd.Enabled = btnBarDelete.Enabled = btnBarEdit.Enabled = state;
            isJoiningClassMode = !state;
        }
    }
}