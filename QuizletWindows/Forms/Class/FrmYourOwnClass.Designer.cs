namespace QuizletWindows.Forms.Class
{
    partial class FrmYourOwnClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYourOwnClass));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnBarAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnBarEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnBarDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnBarGoto = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.classGridView = new System.Windows.Forms.DataGridView();
            this.ClassId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Describe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberParticipant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberModules = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1079, 69);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(470, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Class";
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
            this.btnBarGoto});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 4;
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnBarGoto, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnBarAdd
            // 
            this.btnBarAdd.Caption = "Add";
            this.btnBarAdd.Id = 0;
            this.btnBarAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBarAdd.ImageOptions.Image")));
            this.btnBarAdd.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBarAdd.ImageOptions.LargeImage")));
            this.btnBarAdd.Name = "btnBarAdd";
            this.btnBarAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBarAdd_ItemClick);
            // 
            // btnBarEdit
            // 
            this.btnBarEdit.Caption = "Edit";
            this.btnBarEdit.Id = 1;
            this.btnBarEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBarEdit.ImageOptions.Image")));
            this.btnBarEdit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBarEdit.ImageOptions.LargeImage")));
            this.btnBarEdit.Name = "btnBarEdit";
            this.btnBarEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBarEdit_ItemClick);
            // 
            // btnBarDelete
            // 
            this.btnBarDelete.Caption = "Delete";
            this.btnBarDelete.Id = 2;
            this.btnBarDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBarDelete.ImageOptions.Image")));
            this.btnBarDelete.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBarDelete.ImageOptions.LargeImage")));
            this.btnBarDelete.Name = "btnBarDelete";
            this.btnBarDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBarDelete_ItemClick);
            // 
            // btnBarGoto
            // 
            this.btnBarGoto.Caption = "Go to";
            this.btnBarGoto.Id = 3;
            this.btnBarGoto.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBarGoto.ImageOptions.Image")));
            this.btnBarGoto.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBarGoto.ImageOptions.LargeImage")));
            this.btnBarGoto.Name = "btnBarGoto";
            this.btnBarGoto.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBarGoto_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1079, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 437);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1079, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 403);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1079, 34);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 403);
            // 
            // classGridView
            // 
            this.classGridView.AllowUserToAddRows = false;
            this.classGridView.AllowUserToDeleteRows = false;
            this.classGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.classGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.classGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClassId,
            this.ClassName,
            this.Describe,
            this.CreatedDate,
            this.NumberParticipant,
            this.NumberModules});
            this.classGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.classGridView.Location = new System.Drawing.Point(0, 103);
            this.classGridView.MultiSelect = false;
            this.classGridView.Name = "classGridView";
            this.classGridView.RowHeadersWidth = 62;
            this.classGridView.RowTemplate.Height = 28;
            this.classGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.classGridView.Size = new System.Drawing.Size(1079, 334);
            this.classGridView.TabIndex = 5;
            this.classGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.classGridView_DataBindingComplete);
            // 
            // ClassId
            // 
            this.ClassId.HeaderText = "ClassId";
            this.ClassId.MinimumWidth = 8;
            this.ClassId.Name = "ClassId";
            this.ClassId.Visible = false;
            // 
            // ClassName
            // 
            this.ClassName.HeaderText = "Class name";
            this.ClassName.MinimumWidth = 8;
            this.ClassName.Name = "ClassName";
            this.ClassName.ReadOnly = true;
            // 
            // Describe
            // 
            this.Describe.HeaderText = "Descirbe";
            this.Describe.MinimumWidth = 8;
            this.Describe.Name = "Describe";
            this.Describe.ReadOnly = true;
            // 
            // CreatedDate
            // 
            this.CreatedDate.HeaderText = "Created date";
            this.CreatedDate.MinimumWidth = 8;
            this.CreatedDate.Name = "CreatedDate";
            this.CreatedDate.ReadOnly = true;
            // 
            // NumberParticipant
            // 
            this.NumberParticipant.HeaderText = "Number participant";
            this.NumberParticipant.MinimumWidth = 8;
            this.NumberParticipant.Name = "NumberParticipant";
            this.NumberParticipant.ReadOnly = true;
            // 
            // NumberModules
            // 
            this.NumberModules.HeaderText = "Number modules";
            this.NumberModules.MinimumWidth = 8;
            this.NumberModules.Name = "NumberModules";
            this.NumberModules.ReadOnly = true;
            // 
            // FrmYourOwnClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 437);
            this.Controls.Add(this.classGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmYourOwnClass";
            this.Text = "Your own class";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmYourOwnClass_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraBars.BarButtonItem btnBarAdd;
        private DevExpress.XtraBars.BarButtonItem btnBarEdit;
        private DevExpress.XtraBars.BarButtonItem btnBarDelete;
        private DevExpress.XtraBars.BarButtonItem btnBarGoto;
        private System.Windows.Forms.DataGridView classGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Describe;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberParticipant;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberModules;
    }
}