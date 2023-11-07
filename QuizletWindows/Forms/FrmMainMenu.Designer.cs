namespace QuizletWindows
{
    partial class FrmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainMenu));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnBarUserInfor = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.btnBarCreateNewTitle = new DevExpress.XtraBars.BarButtonItem();
            this.btnBarCreateNewClass = new DevExpress.XtraBars.BarButtonItem();
            this.btnBarLogOut = new DevExpress.XtraBars.BarButtonItem();
            this.btnBarStatistics = new DevExpress.XtraBars.BarButtonItem();
            this.btnBarLibrary = new DevExpress.XtraBars.BarButtonItem();
            this.btnBarYourOwnClass = new DevExpress.XtraBars.BarButtonItem();
            this.btnBarJoiningClass = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnBarAchievement = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsTypeUser = new System.Windows.Forms.ToolStripLabel();
            this.tsNameUser = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.CaptionBarItemLinks.Add(this.btnBarUserInfor);
            this.ribbonControl1.CaptionBarItemLinks.Add(this.barSubItem1);
            this.ribbonControl1.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(67, 66, 67, 66);
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnBarUserInfor,
            this.barSubItem1,
            this.ribbonControl1.ExpandCollapseItem,
            this.btnBarStatistics,
            this.btnBarLibrary,
            this.btnBarYourOwnClass,
            this.btnBarJoiningClass,
            this.barButtonItem1,
            this.btnBarCreateNewTitle,
            this.btnBarCreateNewClass,
            this.btnBarLogOut,
            this.btnBarAchievement});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(6);
            this.ribbonControl1.MaxItemId = 16;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 742;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1137, 231);
            // 
            // btnBarUserInfor
            // 
            this.btnBarUserInfor.Caption = "barButtonItem2";
            this.btnBarUserInfor.Id = 8;
            this.btnBarUserInfor.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBarUserInfor.ImageOptions.Image")));
            this.btnBarUserInfor.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBarUserInfor.ImageOptions.LargeImage")));
            this.btnBarUserInfor.Name = "btnBarUserInfor";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "barSubItem1";
            this.barSubItem1.Id = 9;
            this.barSubItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barSubItem1.ImageOptions.Image")));
            this.barSubItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barSubItem1.ImageOptions.LargeImage")));
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnBarCreateNewTitle, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnBarCreateNewClass, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnBarLogOut, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // btnBarCreateNewTitle
            // 
            this.btnBarCreateNewTitle.Caption = "Create new title";
            this.btnBarCreateNewTitle.Id = 10;
            this.btnBarCreateNewTitle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBarCreateNewTitle.ImageOptions.Image")));
            this.btnBarCreateNewTitle.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBarCreateNewTitle.ImageOptions.LargeImage")));
            this.btnBarCreateNewTitle.Name = "btnBarCreateNewTitle";
            this.btnBarCreateNewTitle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBarCreateNewTitle_ItemClick);
            // 
            // btnBarCreateNewClass
            // 
            this.btnBarCreateNewClass.Caption = "Create new class";
            this.btnBarCreateNewClass.Id = 11;
            this.btnBarCreateNewClass.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBarCreateNewClass.ImageOptions.SvgImage")));
            this.btnBarCreateNewClass.Name = "btnBarCreateNewClass";
            this.btnBarCreateNewClass.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBarCreateNewClass_ItemClick);
            // 
            // btnBarLogOut
            // 
            this.btnBarLogOut.Caption = "Log out";
            this.btnBarLogOut.Id = 14;
            this.btnBarLogOut.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBarLogOut.ImageOptions.SvgImage")));
            this.btnBarLogOut.Name = "btnBarLogOut";
            this.btnBarLogOut.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBarLogOut_ItemClick);
            // 
            // btnBarStatistics
            // 
            this.btnBarStatistics.Caption = "Statistics";
            this.btnBarStatistics.Id = 1;
            this.btnBarStatistics.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBarStatistics.ImageOptions.Image")));
            this.btnBarStatistics.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBarStatistics.ImageOptions.LargeImage")));
            this.btnBarStatistics.Name = "btnBarStatistics";
            this.btnBarStatistics.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBarStatistics_ItemClick);
            // 
            // btnBarLibrary
            // 
            this.btnBarLibrary.Caption = "Library";
            this.btnBarLibrary.Id = 2;
            this.btnBarLibrary.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBarLibrary.ImageOptions.Image")));
            this.btnBarLibrary.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBarLibrary.ImageOptions.LargeImage")));
            this.btnBarLibrary.Name = "btnBarLibrary";
            this.btnBarLibrary.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBarLibrary_ItemClick);
            // 
            // btnBarYourOwnClass
            // 
            this.btnBarYourOwnClass.Caption = "Your own class";
            this.btnBarYourOwnClass.Id = 4;
            this.btnBarYourOwnClass.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBarYourOwnClass.ImageOptions.Image")));
            this.btnBarYourOwnClass.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBarYourOwnClass.ImageOptions.LargeImage")));
            this.btnBarYourOwnClass.Name = "btnBarYourOwnClass";
            this.btnBarYourOwnClass.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBarYourOwnClass_ItemClick);
            // 
            // btnBarJoiningClass
            // 
            this.btnBarJoiningClass.Caption = "Joining class";
            this.btnBarJoiningClass.Id = 5;
            this.btnBarJoiningClass.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBarJoiningClass.ImageOptions.SvgImage")));
            this.btnBarJoiningClass.Name = "btnBarJoiningClass";
            this.btnBarJoiningClass.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBarJoiningClass_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 6;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnBarAchievement
            // 
            this.btnBarAchievement.Caption = "Achievement";
            this.btnBarAchievement.Id = 15;
            this.btnBarAchievement.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBarAchievement.ImageOptions.SvgImage")));
            this.btnBarAchievement.Name = "btnBarAchievement";
            this.btnBarAchievement.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBarAchievement_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Main";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnBarStatistics);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnBarAchievement);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnBarLibrary);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Your";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnBarYourOwnClass);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnBarJoiningClass);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Class";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsTypeUser,
            this.tsNameUser});
            this.toolStrip1.Location = new System.Drawing.Point(0, 496);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1137, 30);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsTypeUser
            // 
            this.tsTypeUser.Name = "tsTypeUser";
            this.tsTypeUser.Size = new System.Drawing.Size(73, 25);
            this.tsTypeUser.Text = "Student";
            // 
            // tsNameUser
            // 
            this.tsNameUser.Name = "tsNameUser";
            this.tsNameUser.Size = new System.Drawing.Size(162, 25);
            this.tsNameUser.Text = "Nguyễn Hữu Dũng";
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 526);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMainMenu";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnBarStatistics;
        private DevExpress.XtraBars.BarButtonItem btnBarLibrary;
        private DevExpress.XtraBars.BarButtonItem btnBarYourOwnClass;
        private DevExpress.XtraBars.BarButtonItem btnBarJoiningClass;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnBarUserInfor;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tsNameUser;
        private System.Windows.Forms.ToolStripLabel tsTypeUser;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem btnBarCreateNewTitle;
        private DevExpress.XtraBars.BarButtonItem btnBarCreateNewClass;
        private DevExpress.XtraBars.BarButtonItem btnBarLogOut;
        private DevExpress.XtraBars.BarButtonItem btnBarAchievement;
    }
}

