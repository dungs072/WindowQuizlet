namespace QuizletWindows.Forms.Class
{
    partial class FrmRegisterJoiningClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegisterJoiningClass));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchJoinningClass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.registerJoiningClassGridView = new System.Windows.Forms.DataGridView();
            this.LearningModuleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LearningModuleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OwnerFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberTerms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnBarReadFirst = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnBarRegister = new DevExpress.XtraBars.BarButtonItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registerJoiningClassGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtSearchJoinningClass);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1152, 82);
            this.panel1.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Silver;
            this.btnSearch.Location = new System.Drawing.Point(539, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(109, 46);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchJoinningClass
            // 
            this.txtSearchJoinningClass.Location = new System.Drawing.Point(144, 27);
            this.txtSearchJoinningClass.Name = "txtSearchJoinningClass";
            this.txtSearchJoinningClass.Size = new System.Drawing.Size(375, 27);
            this.txtSearchJoinningClass.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Finding module:";
            // 
            // registerJoiningClassGridView
            // 
            this.registerJoiningClassGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.registerJoiningClassGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.registerJoiningClassGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LearningModuleId,
            this.ClassId,
            this.LearningModuleName,
            this.ClassName,
            this.OwnerFullName,
            this.NumberTerms});
            this.registerJoiningClassGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registerJoiningClassGridView.Location = new System.Drawing.Point(0, 116);
            this.registerJoiningClassGridView.MultiSelect = false;
            this.registerJoiningClassGridView.Name = "registerJoiningClassGridView";
            this.registerJoiningClassGridView.RowHeadersWidth = 62;
            this.registerJoiningClassGridView.RowTemplate.Height = 28;
            this.registerJoiningClassGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.registerJoiningClassGridView.Size = new System.Drawing.Size(1152, 345);
            this.registerJoiningClassGridView.TabIndex = 1;
            // 
            // LearningModuleId
            // 
            this.LearningModuleId.HeaderText = "LearningModuleId";
            this.LearningModuleId.MinimumWidth = 8;
            this.LearningModuleId.Name = "LearningModuleId";
            this.LearningModuleId.ReadOnly = true;
            this.LearningModuleId.Visible = false;
            // 
            // ClassId
            // 
            this.ClassId.HeaderText = "ClassId";
            this.ClassId.MinimumWidth = 8;
            this.ClassId.Name = "ClassId";
            this.ClassId.ReadOnly = true;
            this.ClassId.Visible = false;
            // 
            // LearningModuleName
            // 
            this.LearningModuleName.HeaderText = "Learning Module Name";
            this.LearningModuleName.MinimumWidth = 8;
            this.LearningModuleName.Name = "LearningModuleName";
            this.LearningModuleName.ReadOnly = true;
            // 
            // ClassName
            // 
            this.ClassName.HeaderText = "Class Name";
            this.ClassName.MinimumWidth = 8;
            this.ClassName.Name = "ClassName";
            this.ClassName.ReadOnly = true;
            // 
            // OwnerFullName
            // 
            this.OwnerFullName.HeaderText = "Owner Full Name";
            this.OwnerFullName.MinimumWidth = 8;
            this.OwnerFullName.Name = "OwnerFullName";
            this.OwnerFullName.ReadOnly = true;
            // 
            // NumberTerms
            // 
            this.NumberTerms.HeaderText = "Terms";
            this.NumberTerms.MinimumWidth = 8;
            this.NumberTerms.Name = "NumberTerms";
            this.NumberTerms.ReadOnly = true;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnBarReadFirst,
            this.btnBarRegister});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 2;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnBarRegister, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnBarReadFirst, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnBarReadFirst
            // 
            this.btnBarReadFirst.Caption = "Read First";
            this.btnBarReadFirst.Id = 0;
            this.btnBarReadFirst.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBarReadFirst.ImageOptions.SvgImage")));
            this.btnBarReadFirst.Name = "btnBarReadFirst";
            this.btnBarReadFirst.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBarReadFirst_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1152, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 461);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1152, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 427);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1152, 34);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 427);
            // 
            // btnBarRegister
            // 
            this.btnBarRegister.Caption = "Register";
            this.btnBarRegister.Id = 1;
            this.btnBarRegister.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.btnBarRegister.Name = "btnBarRegister";
            this.btnBarRegister.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBarRegister_ItemClick);
            // 
            // FrmRegisterJoiningClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 481);
            this.Controls.Add(this.registerJoiningClassGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmRegisterJoiningClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register JoinClass";
            this.Load += new System.EventHandler(this.FrmRegisterJoiningClass_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registerJoiningClassGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView registerJoiningClassGridView;
        private System.Windows.Forms.TextBox txtSearchJoinningClass;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnBarReadFirst;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn LearningModuleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassId;
        private System.Windows.Forms.DataGridViewTextBoxColumn LearningModuleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OwnerFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberTerms;
        private DevExpress.XtraBars.BarButtonItem btnBarRegister;
    }
}