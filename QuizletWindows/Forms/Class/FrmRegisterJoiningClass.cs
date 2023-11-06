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
    public partial class FrmRegisterJoiningClass : DevExpress.XtraEditors.XtraForm
    {
        private List<RegisterClass> registerClasses; 
        public FrmRegisterJoiningClass()
        {
            InitializeComponent();
        }
        private void FrmRegisterJoiningClass_Load(object sender, EventArgs e)
        {
            InitialSetUp();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FetchDataTable();
            
        }
        private void FetchDataTable()
        {
            if (txtSearchJoinningClass.Text.Trim() == "") { return; }
            registerClasses = ClassApi.Instance.GetRegisterClass(Program.UserId,txtSearchJoinningClass.Text);
            registerJoiningClassGridView.AutoGenerateColumns = false;
            registerJoiningClassGridView.DataSource = registerClasses;
        }
        private void InitialSetUp()
        {
            DataGridViewColumn classId = registerJoiningClassGridView.Columns["ClassId"];
            DataGridViewColumn learningModuleName = registerJoiningClassGridView.Columns["LearningModuleName"];
            DataGridViewColumn className = registerJoiningClassGridView.Columns["ClassName"];
            DataGridViewColumn ownerFullName = registerJoiningClassGridView.Columns["OwnerFullName"];
            DataGridViewColumn terms = registerJoiningClassGridView.Columns["NumberTerms"];
            classId.DataPropertyName = "ClassId";
            learningModuleName.DataPropertyName = "LearningModuleName";
            className.DataPropertyName = "ClassName";
            ownerFullName.DataPropertyName = "OwnerFullName";
            terms.DataPropertyName = "NumberTerms";
            registerJoiningClassGridView.ColumnHeadersDefaultCellStyle.Font = new Font(registerJoiningClassGridView.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            registerJoiningClassGridView.Refresh();
        }

       
    }
}