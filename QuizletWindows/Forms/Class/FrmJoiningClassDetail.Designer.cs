namespace QuizletWindows.Forms.Class
{
    partial class FrmJoiningClassDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmJoiningClassDetail));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.detailGridView = new System.Windows.Forms.DataGridView();
            this.LearningModuleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LearningModuleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Describe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberTerms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnBarBack = new DevExpress.XtraBars.BarButtonItem();
            this.btnBarTerminology = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detailGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1245, 64);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(529, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Joining Class";
            // 
            // detailGridView
            // 
            this.detailGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.detailGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detailGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LearningModuleId,
            this.LearningModuleName,
            this.Describe,
            this.AddedDate,
            this.NumberTerms});
            this.detailGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailGridView.Location = new System.Drawing.Point(0, 98);
            this.detailGridView.MultiSelect = false;
            this.detailGridView.Name = "detailGridView";
            this.detailGridView.RowHeadersWidth = 62;
            this.detailGridView.RowTemplate.Height = 28;
            this.detailGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.detailGridView.Size = new System.Drawing.Size(1245, 385);
            this.detailGridView.TabIndex = 1;
            // 
            // LearningModuleId
            // 
            this.LearningModuleId.HeaderText = "LearningModuleId";
            this.LearningModuleId.MinimumWidth = 8;
            this.LearningModuleId.Name = "LearningModuleId";
            this.LearningModuleId.ReadOnly = true;
            this.LearningModuleId.Visible = false;
            // 
            // LearningModuleName
            // 
            this.LearningModuleName.HeaderText = "Learning Module Name";
            this.LearningModuleName.MinimumWidth = 8;
            this.LearningModuleName.Name = "LearningModuleName";
            this.LearningModuleName.ReadOnly = true;
            // 
            // Describe
            // 
            this.Describe.HeaderText = "Describe";
            this.Describe.MinimumWidth = 8;
            this.Describe.Name = "Describe";
            this.Describe.ReadOnly = true;
            // 
            // AddedDate
            // 
            this.AddedDate.HeaderText = "Added Date";
            this.AddedDate.MinimumWidth = 8;
            this.AddedDate.Name = "AddedDate";
            this.AddedDate.ReadOnly = true;
            // 
            // NumberTerms
            // 
            this.NumberTerms.HeaderText = "Number Terms";
            this.NumberTerms.MinimumWidth = 8;
            this.NumberTerms.Name = "NumberTerms";
            this.NumberTerms.ReadOnly = true;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnBarBack,
            this.btnBarTerminology});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 2;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnBarBack, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnBarTerminology, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnBarBack
            // 
            this.btnBarBack.Caption = "Back";
            this.btnBarBack.Id = 0;
            this.btnBarBack.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBarBack.ImageOptions.SvgImage")));
            this.btnBarBack.Name = "btnBarBack";
            this.btnBarBack.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBarBack_ItemClick);
            // 
            // btnBarTerminology
            // 
            this.btnBarTerminology.Caption = "Terminology";
            this.btnBarTerminology.Id = 1;
            this.btnBarTerminology.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBarTerminology.ImageOptions.SvgImage")));
            this.btnBarTerminology.Name = "btnBarTerminology";
            this.btnBarTerminology.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBarTerminology_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1245, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 483);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1245, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 449);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1245, 34);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 449);
            // 
            // FrmJoiningClassDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 483);
            this.Controls.Add(this.detailGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmJoiningClassDetail";
            this.Text = "Joining Class Here";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmJoiningClassDetail_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detailGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView detailGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn LearningModuleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn LearningModuleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Describe;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberTerms;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnBarBack;
        private DevExpress.XtraBars.BarButtonItem btnBarTerminology;
    }
}