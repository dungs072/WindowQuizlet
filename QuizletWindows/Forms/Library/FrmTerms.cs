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

        private int currentTermIndex = 0;
        private int previousTermIndex = -1;
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
            LoadCurrentTermName(currentTermIndex);
        }
        private void LoadCurrentTermName(int currentIndex)
        {
            if (currentIndex < 0 || currentIndex >= terms.Count) { return; }
            TermViewModel term = terms[currentIndex];
            imageDisplay.Image = System.Drawing.Image.FromStream(new System.Net.WebClient().OpenRead("https://firebasestorage.googleapis.com/v0/b/quizlet-c9cab.appspot.com/o/main%2FFlashCard.png?alt=media&token=9a3befe7-f2f5-4eb2-9f6d-69e5b831d52f"));
            imageDisplay.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            txtDisplayTerm.Text = term.TermName;
        }
        private void LoadCurrentImageTerm(int currentIndex)
        {
            if(currentIndex<0||currentIndex>=terms.Count) { return; }
            TermViewModel term = terms[currentIndex];
            txtDisplayTerm.Text = term.Explaination;
            if (term.Image == null)
            {
                imageDisplay.Image = System.Drawing.Image.FromStream(new System.Net.WebClient().OpenRead("https://firebasestorage.googleapis.com/v0/b/quizlet-c9cab.appspot.com/o/main%2FFlashCard.png?alt=media&token=9a3befe7-f2f5-4eb2-9f6d-69e5b831d52f"));
                imageDisplay.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            }
            else
            {
                if (previousTermIndex == currentIndex) { return; }
                string imageUrl = term.Image;
                imageDisplay.Image = System.Drawing.Image.FromStream(new System.Net.WebClient().OpenRead(imageUrl));
                imageDisplay.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            }
            previousTermIndex = currentIndex;
            
           
        }
        private void imageDisplay_Click(object sender, EventArgs e)
        {
            LoadCurrentImageTerm(currentTermIndex);
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
            DataGridViewColumn image = termGridView.Columns["Image"];
            termName.DataPropertyName = "TermName";
            termExplanation.DataPropertyName = "Explaination";
            termId.DataPropertyName = "TermId";
            image.DataPropertyName = "Image";
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
        private string GetImage()
        {
            if (termGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = termGridView.SelectedRows[0];
                string cellValue = selectedRow.Cells["Image"].Value.ToString();
                return cellValue;
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
            string image = GetImage();
            FrmEditTerm.LearningModuleId = ModuleId;
            FrmEditTerm.TermId = termId;
            FrmEditTerm frmEditTerm = new FrmEditTerm();
            frmEditTerm.SetTextExplanationInput(explanation);
            frmEditTerm.SetTextTermNameInput(termName);
            frmEditTerm.SetImage(image);
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

        private void btnNext_Click(object sender, EventArgs e)
        {
            currentTermIndex = Math.Min(currentTermIndex+1,terms.Count-1);
            
            LoadCurrentTermName(currentTermIndex);
            previousTermIndex = -1;

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            currentTermIndex = Math.Max(currentTermIndex - 1, 0);
            LoadCurrentTermName(currentTermIndex);
            previousTermIndex = -1;
        }
    }
}