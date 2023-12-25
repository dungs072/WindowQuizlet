namespace QuizletWindows.Forms.Class
{
    partial class FrmClassDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClassDetail));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LearningModuleGridView = new System.Windows.Forms.DataGridView();
            this.LearningModuleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LearningModuleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Describe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberTerms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.participantGridView = new System.Windows.Forms.DataGridView();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegisterDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnBarBack = new DevExpress.XtraBars.BarButtonItem();
            this.btnBarAddModule = new DevExpress.XtraBars.BarButtonItem();
            this.btnBarRemoveModule = new DevExpress.XtraBars.BarButtonItem();
            this.btnBarAddParticipant = new DevExpress.XtraBars.BarButtonItem();
            this.btnBarRemoveParticipant = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnBarPending = new DevExpress.XtraBars.BarButtonItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LearningModuleGridView)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.participantGridView)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LearningModuleGridView);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1091, 439);
            this.panel1.TabIndex = 0;
            // 
            // LearningModuleGridView
            // 
            this.LearningModuleGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LearningModuleGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LearningModuleGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LearningModuleId,
            this.LearningModuleName,
            this.Describe,
            this.AddedDate,
            this.NumberTerms});
            this.LearningModuleGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LearningModuleGridView.Location = new System.Drawing.Point(0, 77);
            this.LearningModuleGridView.MultiSelect = false;
            this.LearningModuleGridView.Name = "LearningModuleGridView";
            this.LearningModuleGridView.RowHeadersWidth = 62;
            this.LearningModuleGridView.RowTemplate.Height = 28;
            this.LearningModuleGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LearningModuleGridView.Size = new System.Drawing.Size(1091, 362);
            this.LearningModuleGridView.TabIndex = 1;
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
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1091, 77);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(432, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Learning Modules";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.participantGridView);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(1091, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(755, 439);
            this.panel2.TabIndex = 1;
            // 
            // participantGridView
            // 
            this.participantGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.participantGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.participantGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LastName,
            this.UserId,
            this.FirstName,
            this.Gmail,
            this.RegisterDate});
            this.participantGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.participantGridView.Location = new System.Drawing.Point(0, 77);
            this.participantGridView.MultiSelect = false;
            this.participantGridView.Name = "participantGridView";
            this.participantGridView.RowHeadersWidth = 62;
            this.participantGridView.RowTemplate.Height = 28;
            this.participantGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.participantGridView.Size = new System.Drawing.Size(755, 362);
            this.participantGridView.TabIndex = 1;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last Name";
            this.LastName.MinimumWidth = 8;
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // UserId
            // 
            this.UserId.HeaderText = "UserId";
            this.UserId.MinimumWidth = 8;
            this.UserId.Name = "UserId";
            this.UserId.ReadOnly = true;
            this.UserId.Visible = false;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First Name";
            this.FirstName.MinimumWidth = 8;
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // Gmail
            // 
            this.Gmail.HeaderText = "Gmail";
            this.Gmail.MinimumWidth = 8;
            this.Gmail.Name = "Gmail";
            this.Gmail.ReadOnly = true;
            // 
            // RegisterDate
            // 
            this.RegisterDate.HeaderText = "Register Date";
            this.RegisterDate.MinimumWidth = 8;
            this.RegisterDate.Name = "RegisterDate";
            this.RegisterDate.ReadOnly = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(755, 77);
            this.panel4.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(287, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Participants";
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
            this.btnBarAddModule,
            this.btnBarRemoveModule,
            this.btnBarAddParticipant,
            this.btnBarRemoveParticipant,
            this.btnBarPending});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 6;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(275, 201);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnBarBack, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnBarAddModule, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnBarRemoveModule, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnBarAddParticipant, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnBarRemoveParticipant, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnBarPending, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
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
            // btnBarAddModule
            // 
            this.btnBarAddModule.Caption = "Add Module";
            this.btnBarAddModule.Id = 1;
            this.btnBarAddModule.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBarAddModule.ImageOptions.SvgImage")));
            this.btnBarAddModule.Name = "btnBarAddModule";
            this.btnBarAddModule.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBarAddModule_ItemClick);
            // 
            // btnBarRemoveModule
            // 
            this.btnBarRemoveModule.Caption = "Remove Module";
            this.btnBarRemoveModule.Id = 2;
            this.btnBarRemoveModule.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBarRemoveModule.ImageOptions.SvgImage")));
            this.btnBarRemoveModule.Name = "btnBarRemoveModule";
            this.btnBarRemoveModule.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBarRemoveModule_ItemClick);
            // 
            // btnBarAddParticipant
            // 
            this.btnBarAddParticipant.Caption = "Add Participant";
            this.btnBarAddParticipant.Id = 3;
            this.btnBarAddParticipant.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBarAddParticipant.ImageOptions.SvgImage")));
            this.btnBarAddParticipant.Name = "btnBarAddParticipant";
            this.btnBarAddParticipant.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBarAddParticipant_ItemClick);
            // 
            // btnBarRemoveParticipant
            // 
            this.btnBarRemoveParticipant.Caption = "Remove Participant";
            this.btnBarRemoveParticipant.Id = 4;
            this.btnBarRemoveParticipant.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBarRemoveParticipant.ImageOptions.SvgImage")));
            this.btnBarRemoveParticipant.Name = "btnBarRemoveParticipant";
            this.btnBarRemoveParticipant.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBarRemoveParticipant_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1846, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 473);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1846, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 439);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1846, 34);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 439);
            // 
            // btnBarPending
            // 
            this.btnBarPending.Caption = "Pending Participant";
            this.btnBarPending.Id = 5;
            this.btnBarPending.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.btnBarPending.Name = "btnBarPending";
            this.btnBarPending.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBarPending_ItemClick);
            // 
            // FrmClassDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1846, 473);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmClassDetail";
            this.Text = "Class Detail";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmClassDetail_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LearningModuleGridView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.participantGridView)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.DataGridView LearningModuleGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView participantGridView;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn LearningModuleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn LearningModuleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Describe;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberTerms;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegisterDate;
        private DevExpress.XtraBars.BarButtonItem btnBarBack;
        private DevExpress.XtraBars.BarButtonItem btnBarAddModule;
        private DevExpress.XtraBars.BarButtonItem btnBarRemoveModule;
        private DevExpress.XtraBars.BarButtonItem btnBarAddParticipant;
        private DevExpress.XtraBars.BarButtonItem btnBarRemoveParticipant;
        private DevExpress.XtraBars.BarButtonItem btnBarPending;
    }
}