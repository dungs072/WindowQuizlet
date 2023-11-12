using DevExpress.XtraEditors;
using QuizletWindows.API;
using QuizletWindows.ViewModels.Terminologies;
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

namespace QuizletWindows.Forms.Library.Objective
{
    public partial class FrmResultTest : DevExpress.XtraEditors.XtraForm
    {
        private  List<ResultTest> results;
        private FrmObjectivePractice objectivePractice;
        public void SetResults(List<ResultTest> results)
        {
            this.results = results;
        }
        public void SetPractice(FrmObjectivePractice practice)
        {
            this.objectivePractice = practice;
        }
        public void SetResultText(string text)
        {
            txtResult.Text = text;
        }
        public FrmResultTest()
        {
            InitializeComponent();
        }
        private void FrmResultTest_Load(object sender, EventArgs e)
        {
            FetchDataTable();
            InitialSetUp();
        }
        private void FetchDataTable()
        {
            resultGridView.AutoGenerateColumns = false;
            resultGridView.DataSource = results;


        }
        private void InitialSetUp()
        {
            DataGridViewColumn termName = resultGridView.Columns["TermName"];
            DataGridViewColumn termExplanation = resultGridView.Columns["Explanation"];
            termName.DataPropertyName = "TermName";
            termExplanation.DataPropertyName = "Explanation";
            termName.Width = 500;
            resultGridView.ColumnHeadersDefaultCellStyle.Font = new Font(resultGridView.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            resultGridView.Refresh();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            objectivePractice.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

      
    }
}