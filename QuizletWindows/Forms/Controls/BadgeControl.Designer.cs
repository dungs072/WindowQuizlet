namespace QuizletWindows.Forms.Controls
{
    partial class BadgeControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtImage = new DevExpress.XtraEditors.PictureEdit();
            this.txtDateAchievement = new System.Windows.Forms.TextBox();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.txtNameBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtImage.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtImage);
            this.panel1.Controls.Add(this.txtDateAchievement);
            this.panel1.Controls.Add(this.checkBox);
            this.panel1.Controls.Add(this.txtNameBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 233);
            this.panel1.TabIndex = 0;
            // 
            // txtImage
            // 
            this.txtImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtImage.Location = new System.Drawing.Point(103, 67);
            this.txtImage.Name = "txtImage";
            this.txtImage.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.txtImage.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.txtImage.Size = new System.Drawing.Size(100, 82);
            this.txtImage.TabIndex = 7;
            // 
            // txtDateAchievement
            // 
            this.txtDateAchievement.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDateAchievement.Location = new System.Drawing.Point(80, 155);
            this.txtDateAchievement.Name = "txtDateAchievement";
            this.txtDateAchievement.ReadOnly = true;
            this.txtDateAchievement.Size = new System.Drawing.Size(156, 27);
            this.txtDateAchievement.TabIndex = 6;
            this.txtDateAchievement.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBox
            // 
            this.checkBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox.AutoSize = true;
            this.checkBox.Enabled = false;
            this.checkBox.Location = new System.Drawing.Point(93, 188);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(112, 23);
            this.checkBox.TabIndex = 5;
            this.checkBox.Text = "is achieved";
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // txtNameBox
            // 
            this.txtNameBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNameBox.Location = new System.Drawing.Point(39, 33);
            this.txtNameBox.Name = "txtNameBox";
            this.txtNameBox.ReadOnly = true;
            this.txtNameBox.Size = new System.Drawing.Size(241, 27);
            this.txtNameBox.TabIndex = 4;
            this.txtNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BadgeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.panel1);
            this.Name = "BadgeControl";
            this.Size = new System.Drawing.Size(320, 233);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtImage.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.TextBox txtNameBox;
        private System.Windows.Forms.TextBox txtDateAchievement;
        private DevExpress.XtraEditors.PictureEdit txtImage;
    }
}
