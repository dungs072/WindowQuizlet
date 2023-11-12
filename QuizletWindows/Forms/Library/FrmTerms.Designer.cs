namespace QuizletWindows.Forms.Library
{
    partial class FrmTerms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTerms));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnBarAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnBarEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnBarDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnBarPractice = new DevExpress.XtraBars.BarButtonItem();
            this.btnBarBack = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ModuleName = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtDisplayTerm = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnPrevious = new DevExpress.XtraEditors.SimpleButton();
            this.btnNext = new DevExpress.XtraEditors.SimpleButton();
            this.imageDisplay = new DevExpress.XtraEditors.PictureEdit();
            this.termGridView = new System.Windows.Forms.DataGridView();
            this.TermId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TermName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TermExplanation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageDisplay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.termGridView)).BeginInit();
            this.SuspendLayout();
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
            this.btnBarAdd,
            this.btnBarEdit,
            this.btnBarDelete,
            this.btnBarPractice,
            this.btnBarBack});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 6;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnBarAdd, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnBarEdit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnBarDelete, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnBarPractice, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnBarBack, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnBarAdd
            // 
            this.btnBarAdd.Caption = "Add";
            this.btnBarAdd.Id = 0;
            this.btnBarAdd.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBarAdd.ImageOptions.SvgImage")));
            this.btnBarAdd.Name = "btnBarAdd";
            this.btnBarAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBarAdd_ItemClick);
            // 
            // btnBarEdit
            // 
            this.btnBarEdit.Caption = "Edit";
            this.btnBarEdit.Id = 1;
            this.btnBarEdit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBarEdit.ImageOptions.SvgImage")));
            this.btnBarEdit.Name = "btnBarEdit";
            this.btnBarEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBarEdit_ItemClick);
            // 
            // btnBarDelete
            // 
            this.btnBarDelete.Caption = "Delete";
            this.btnBarDelete.Id = 2;
            this.btnBarDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBarDelete.ImageOptions.SvgImage")));
            this.btnBarDelete.Name = "btnBarDelete";
            this.btnBarDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBarDelete_ItemClick);
            // 
            // btnBarPractice
            // 
            this.btnBarPractice.Caption = "Test";
            this.btnBarPractice.Id = 3;
            this.btnBarPractice.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBarPractice.ImageOptions.SvgImage")));
            this.btnBarPractice.Name = "btnBarPractice";
            this.btnBarPractice.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBarPractice_ItemClick);
            // 
            // btnBarBack
            // 
            this.btnBarBack.Caption = "Back";
            this.btnBarBack.Id = 5;
            this.btnBarBack.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBarBack.ImageOptions.SvgImage")));
            this.btnBarBack.Name = "btnBarBack";
            this.btnBarBack.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBarBack_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1096, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 440);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1096, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 406);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1096, 34);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 406);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1096, 319);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ModuleName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1096, 47);
            this.panel2.TabIndex = 5;
            // 
            // ModuleName
            // 
            this.ModuleName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ModuleName.AutoSize = true;
            this.ModuleName.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModuleName.Location = new System.Drawing.Point(503, 12);
            this.ModuleName.Name = "ModuleName";
            this.ModuleName.Size = new System.Drawing.Size(142, 24);
            this.ModuleName.TabIndex = 0;
            this.ModuleName.Text = "ModuleName";
            this.ModuleName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.Controls.Add(this.txtDisplayTerm);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Location = new System.Drawing.Point(216, 53);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(739, 260);
            this.panel4.TabIndex = 4;
            // 
            // txtDisplayTerm
            // 
            this.txtDisplayTerm.Location = new System.Drawing.Point(140, 0);
            this.txtDisplayTerm.Name = "txtDisplayTerm";
            this.txtDisplayTerm.ReadOnly = true;
            this.txtDisplayTerm.Size = new System.Drawing.Size(472, 27);
            this.txtDisplayTerm.TabIndex = 3;
            this.txtDisplayTerm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.Controls.Add(this.btnPrevious);
            this.panel3.Controls.Add(this.btnNext);
            this.panel3.Controls.Add(this.imageDisplay);
            this.panel3.Location = new System.Drawing.Point(92, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(562, 228);
            this.panel3.TabIndex = 2;
            // 
            // btnPrevious
            // 
            this.btnPrevious.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPrevious.ImageOptions.SvgImage")));
            this.btnPrevious.Location = new System.Drawing.Point(0, 0);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(49, 228);
            this.btnPrevious.TabIndex = 4;
            this.btnPrevious.Text = "simpleButton2";
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNext.ImageOptions.SvgImage")));
            this.btnNext.Location = new System.Drawing.Point(513, 0);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(49, 228);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "simpleButton1";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // imageDisplay
            // 
            this.imageDisplay.Location = new System.Drawing.Point(45, 0);
            this.imageDisplay.MenuManager = this.barManager1;
            this.imageDisplay.Name = "imageDisplay";
            this.imageDisplay.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.imageDisplay.Size = new System.Drawing.Size(472, 228);
            this.imageDisplay.TabIndex = 0;
            this.imageDisplay.Click += new System.EventHandler(this.imageDisplay_Click);
            // 
            // termGridView
            // 
            this.termGridView.AllowUserToAddRows = false;
            this.termGridView.AllowUserToDeleteRows = false;
            this.termGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.termGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.termGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TermId,
            this.TermName,
            this.TermExplanation,
            this.Image});
            this.termGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.termGridView.Location = new System.Drawing.Point(0, 353);
            this.termGridView.MultiSelect = false;
            this.termGridView.Name = "termGridView";
            this.termGridView.RowHeadersWidth = 62;
            this.termGridView.RowTemplate.Height = 50;
            this.termGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.termGridView.Size = new System.Drawing.Size(1096, 87);
            this.termGridView.TabIndex = 5;
            this.termGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.termGridView_DataBindingComplete);
            // 
            // TermId
            // 
            this.TermId.HeaderText = "TermId";
            this.TermId.MinimumWidth = 8;
            this.TermId.Name = "TermId";
            this.TermId.ReadOnly = true;
            this.TermId.Visible = false;
            // 
            // TermName
            // 
            this.TermName.HeaderText = "Terminology name";
            this.TermName.MinimumWidth = 8;
            this.TermName.Name = "TermName";
            this.TermName.ReadOnly = true;
            // 
            // TermExplanation
            // 
            this.TermExplanation.HeaderText = "Explanation";
            this.TermExplanation.MinimumWidth = 8;
            this.TermExplanation.Name = "TermExplanation";
            this.TermExplanation.ReadOnly = true;
            // 
            // Image
            // 
            this.Image.HeaderText = "Image";
            this.Image.MinimumWidth = 8;
            this.Image.Name = "Image";
            this.Image.ReadOnly = true;
            this.Image.Visible = false;
            // 
            // FrmTerms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 440);
            this.Controls.Add(this.termGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmTerms";
            this.Text = "Terminology";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmTerms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageDisplay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.termGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.DataGridView termGridView;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraBars.BarButtonItem btnBarAdd;
        private DevExpress.XtraBars.BarButtonItem btnBarEdit;
        private DevExpress.XtraBars.BarButtonItem btnBarDelete;
        private DevExpress.XtraBars.BarButtonItem btnBarPractice;
        private DevExpress.XtraBars.BarButtonItem btnBarBack;
        private System.Windows.Forms.Label ModuleName;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.PictureEdit imageDisplay;
        private System.Windows.Forms.TextBox txtDisplayTerm;
        private DevExpress.XtraEditors.SimpleButton btnPrevious;
        private DevExpress.XtraEditors.SimpleButton btnNext;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TermId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TermName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TermExplanation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Image;
    }
}