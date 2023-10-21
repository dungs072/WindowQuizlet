namespace QuizletWindows.Forms.Library.Objective
{
    partial class FrmObjectivePractice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmObjectivePractice));
            this.panel3 = new System.Windows.Forms.Panel();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnBarExit = new DevExpress.XtraBars.BarButtonItem();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ObjectiveNamePractice = new System.Windows.Forms.Label();
            this.QuestionName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.radioA = new System.Windows.Forms.RadioButton();
            this.radioB = new System.Windows.Forms.RadioButton();
            this.radioC = new System.Windows.Forms.RadioButton();
            this.radioD = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sampleRadio = new System.Windows.Forms.RadioButton();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnCheck);
            this.panel3.Controls.Add(this.btnNext);
            this.panel3.Controls.Add(this.btnBack);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 252);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(909, 89);
            this.panel3.TabIndex = 2;
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
            this.btnBarExit});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 1;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1056, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 438);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1056, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 404);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1056, 34);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 404);
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnBarExit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnBarExit
            // 
            this.btnBarExit.Caption = "exit";
            this.btnBarExit.Id = 0;
            this.btnBarExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.btnBarExit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.btnBarExit.Name = "btnBarExit";
            this.btnBarExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBarExit_ItemClick);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBack.Location = new System.Drawing.Point(3, 21);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(242, 44);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnNext.Location = new System.Drawing.Point(664, 21);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(242, 44);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCheck.Location = new System.Drawing.Point(331, 21);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(242, 44);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.sampleRadio);
            this.panel1.Controls.Add(this.QuestionName);
            this.panel1.Controls.Add(this.ObjectiveNamePractice);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(909, 70);
            this.panel1.TabIndex = 0;
            // 
            // ObjectiveNamePractice
            // 
            this.ObjectiveNamePractice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ObjectiveNamePractice.AutoSize = true;
            this.ObjectiveNamePractice.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ObjectiveNamePractice.Location = new System.Drawing.Point(-168, 24);
            this.ObjectiveNamePractice.Name = "ObjectiveNamePractice";
            this.ObjectiveNamePractice.Size = new System.Drawing.Size(72, 24);
            this.ObjectiveNamePractice.TabIndex = 0;
            this.ObjectiveNamePractice.Text = "label1";
            this.ObjectiveNamePractice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // QuestionName
            // 
            this.QuestionName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.QuestionName.AutoSize = true;
            this.QuestionName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionName.Location = new System.Drawing.Point(433, 24);
            this.QuestionName.Name = "QuestionName";
            this.QuestionName.Size = new System.Drawing.Size(58, 29);
            this.QuestionName.TabIndex = 1;
            this.QuestionName.Text = "123";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.radioD, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.radioC, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.radioB, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.radioA, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 70);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(909, 182);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // radioA
            // 
            this.radioA.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radioA.AutoSize = true;
            this.radioA.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioA.Location = new System.Drawing.Point(30, 8);
            this.radioA.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.radioA.Name = "radioA";
            this.radioA.Size = new System.Drawing.Size(168, 28);
            this.radioA.TabIndex = 0;
            this.radioA.Text = "radioButton1";
            this.radioA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioA.UseVisualStyleBackColor = true;
            // 
            // radioB
            // 
            this.radioB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radioB.AutoSize = true;
            this.radioB.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioB.Location = new System.Drawing.Point(30, 53);
            this.radioB.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.radioB.Name = "radioB";
            this.radioB.Size = new System.Drawing.Size(168, 28);
            this.radioB.TabIndex = 1;
            this.radioB.Text = "radioButton2";
            this.radioB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioB.UseVisualStyleBackColor = true;
            // 
            // radioC
            // 
            this.radioC.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radioC.AutoSize = true;
            this.radioC.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioC.Location = new System.Drawing.Point(30, 98);
            this.radioC.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.radioC.Name = "radioC";
            this.radioC.Size = new System.Drawing.Size(168, 28);
            this.radioC.TabIndex = 2;
            this.radioC.Text = "radioButton3";
            this.radioC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioC.UseVisualStyleBackColor = true;
            // 
            // radioD
            // 
            this.radioD.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radioD.AutoSize = true;
            this.radioD.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioD.Location = new System.Drawing.Point(30, 144);
            this.radioD.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.radioD.Name = "radioD";
            this.radioD.Size = new System.Drawing.Size(168, 28);
            this.radioD.TabIndex = 3;
            this.radioD.Text = "radioButton4";
            this.radioD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioD.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(51, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(911, 343);
            this.panel2.TabIndex = 1;
            // 
            // sampleRadio
            // 
            this.sampleRadio.AutoSize = true;
            this.sampleRadio.Location = new System.Drawing.Point(88, 30);
            this.sampleRadio.Name = "sampleRadio";
            this.sampleRadio.Size = new System.Drawing.Size(125, 23);
            this.sampleRadio.TabIndex = 2;
            this.sampleRadio.TabStop = true;
            this.sampleRadio.Text = "radioButton1";
            this.sampleRadio.UseVisualStyleBackColor = true;
            this.sampleRadio.Visible = false;
            // 
            // FrmObjectivePractice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 438);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmObjectivePractice";
            this.Text = "ObjectivePractice";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmObjectivePractice_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnBarExit;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton radioD;
        private System.Windows.Forms.RadioButton radioC;
        private System.Windows.Forms.RadioButton radioB;
        private System.Windows.Forms.RadioButton radioA;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label QuestionName;
        private System.Windows.Forms.Label ObjectiveNamePractice;
        private System.Windows.Forms.RadioButton sampleRadio;
    }
}