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

namespace QuizletWindows.Forms.Class
{
    public partial class FrmJoiningClassReadFirst : DevExpress.XtraEditors.XtraForm
    {
        private List<TermViewModel> terms;
        public static int LearningModuleId;
        public FrmJoiningClassReadFirst()
        {
            InitializeComponent();
        }

        private void FrmJoiningClassReadFirst_Load(object sender, EventArgs e)
        {
            FetchDataTable();
            InitialSetUp();
        }
        private void FetchDataTable()
        {
            terms = TerminologyApi.Instance.GetTermByLearningModuleId(LearningModuleId);
            termGridView.AutoGenerateColumns = false;
            termGridView.DataSource = terms;


        }
        private void InitialSetUp()
        {
            DataGridViewColumn termName = termGridView.Columns["TermName"];
            DataGridViewColumn explanation = termGridView.Columns["Explanation"];

            termName.DataPropertyName = "TermName";
            explanation.DataPropertyName = "Explaination";
            termGridView.ColumnHeadersDefaultCellStyle.Font = new Font(termGridView.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            termGridView.Refresh();
        }

    }
}