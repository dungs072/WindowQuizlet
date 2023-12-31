﻿using DevExpress.XtraEditors;
using QuizletWindows.API;
using QuizletWindows.ViewModels.Terminologies;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace QuizletWindows.Forms.Library
{
    public partial class FrmYourLibrary : DevExpress.XtraEditors.XtraForm
    {
        private List<TitleViewModel> titles;
        public FrmYourLibrary()
        {
            InitializeComponent();
            FrmAddTitle.OnCreated += FetchDataTable;
            FrmEditTitle.OnUpdated += FetchDataTable;
        }

        private  void FrmYourLibrary_Load(object sender, EventArgs e)
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

        private void titleGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            
        }

        private void titleGridView_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void titleGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow dGVRow in this.titleGridView.Rows)
            {
                dGVRow.HeaderCell.Value = String.Format("{0}", dGVRow.Index + 1);
            }
            this.titleGridView.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
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
        private string GetDescribe()
        {
            if (titleGridView.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = titleGridView.SelectedRows[0];
                if (selectedRow.Cells["Describe"].Value != null)
                {
                    string cellValue = selectedRow.Cells["Describe"].Value.ToString();
                    return cellValue;
                }
            }
            return "";
        }

        private void btnBarEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (titleGridView.SelectedRows.Count == 0) { return; }
            int titleId = GetTitleId();
            string titleName = GetTitleName();
            string describe = GetDescribe();
            FrmEditTitle.TitleId = titleId;
            FrmEditTitle frmEditTitle = new FrmEditTitle();
            frmEditTitle.SetTextDescribeInput(describe);
            frmEditTitle.SetTextTitleNameInput(titleName);
            frmEditTitle.ShowDialog();
        }

        private async void btnBarDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (titleGridView.SelectedRows.Count == 0) { return; }
            DialogResult result = Notification.ShowDeleteWarning("Are your sure about deleting this title permanently");
            if(result==DialogResult.OK)
            {
                int titleId = GetTitleId();
                var r  = await TerminologyApi.Instance.DeleteTitle(titleId);
                if(r)
                {
                    Notification.ShowNotification("Delete this title successfully");
                }else
                {
                    Notification.ShowError("Delete this title failed Because there are modules in it");
                }

                
                FetchDataTable();
            }
            
        }

        private void btnBarModules_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (titleGridView.SelectedRows.Count == 0) { return; }
            FrmYourModules.TitleId = GetTitleId();
            FrmYourModules.TitleName = GetTitleName();
            FrmYourModules.DescribeTitle = GetDescribe();
            Program.mainMenu.ShowForm(typeof(FrmYourModules));
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim().ToLower();
            titleGridView.ClearSelection();

            foreach (DataGridViewRow row in titleGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().ToLower().Contains(searchText))
                    {
                        row.Selected = true;
                        break; // Break to select the row once.
                    }
                }
            }
        }
    }
}