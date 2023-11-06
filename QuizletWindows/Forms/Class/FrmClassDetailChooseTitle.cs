using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraEditors;
using QuizletWindows.API;
using QuizletWindows.Forms.Library;
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
    public partial class FrmClassDetailChooseTitle : DevExpress.XtraEditors.XtraForm
    {
        private List<TitleViewModel> titles;
        public FrmClassDetailChooseTitle()
        {
            InitializeComponent();
        }

        private void FrmClassDetailChooseTitle_Load(object sender, EventArgs e)
        {
            FetchDataTable();
            InitialSetUp();
        }
        private void FetchDataTable()
        {
            titles = TerminologyApi.Instance.GetTitlesBaseOnUserId(Program.UserId);
            titleGridView.AutoGenerateColumns = false;
            titleGridView.DataSource = titles;


        }
        private void InitialSetUp()
        {
            DataGridViewColumn titleColumn = titleGridView.Columns["TitleName"];
            DataGridViewColumn describeColumn = titleGridView.Columns["Describe"];
            DataGridViewColumn titleIdColumn = titleGridView.Columns["TitleId"];
            titleColumn.DataPropertyName = "TitleName";
            describeColumn.DataPropertyName = "Describe";
            titleIdColumn.DataPropertyName = "TitleId";
            titleColumn.Width = 500;
            titleGridView.ColumnHeadersDefaultCellStyle.Font = new Font(titleGridView.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            titleGridView.Refresh();
        }
        private int GetTitleId()
        {
            if (titleGridView.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = titleGridView.SelectedRows[0];
                string cellValue = selectedRow.Cells["TitleId"].Value.ToString();
                return int.Parse(cellValue);
            }
            return -1;
        }
        private string GetTitleName()
        {
            if (titleGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = titleGridView.SelectedRows[0];
                string cellValue = selectedRow.Cells["TitleName"].Value.ToString();
                return cellValue;
            }
            return "";
        }

        private void btnBarChoose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (titleGridView.SelectedRows.Count == 0) { return; }
            FrmClassDetailChooseModule.TitleId = GetTitleId();
            FrmClassDetailChooseModule.TitleName = GetTitleName();
            FrmClassDetailChooseModule module = new FrmClassDetailChooseModule();
            module.ShowDialog();
            
        }
    }
}