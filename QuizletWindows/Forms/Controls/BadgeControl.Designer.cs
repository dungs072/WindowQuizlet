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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BadgeControl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.txtNameBox = new System.Windows.Forms.TextBox();
            this.svgImageBox1 = new DevExpress.XtraEditors.SvgImageBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.checkBox);
            this.panel1.Controls.Add(this.txtNameBox);
            this.panel1.Controls.Add(this.svgImageBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 149);
            this.panel1.TabIndex = 0;
            // 
            // checkBox
            // 
            this.checkBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox.AutoSize = true;
            this.checkBox.Enabled = false;
            this.checkBox.Location = new System.Drawing.Point(31, 113);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(112, 23);
            this.checkBox.TabIndex = 5;
            this.checkBox.Text = "is achieved";
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // txtNameBox
            // 
            this.txtNameBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNameBox.Location = new System.Drawing.Point(13, 9);
            this.txtNameBox.Name = "txtNameBox";
            this.txtNameBox.ReadOnly = true;
            this.txtNameBox.Size = new System.Drawing.Size(156, 27);
            this.txtNameBox.TabIndex = 4;
            this.txtNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // svgImageBox1
            // 
            this.svgImageBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.svgImageBox1.Location = new System.Drawing.Point(57, 42);
            this.svgImageBox1.Name = "svgImageBox1";
            this.svgImageBox1.Size = new System.Drawing.Size(65, 65);
            this.svgImageBox1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageBox1.SvgImage")));
            this.svgImageBox1.TabIndex = 3;
            this.svgImageBox1.Text = "svgImageBox1";
            // 
            // BadgeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.panel1);
            this.Name = "BadgeControl";
            this.Size = new System.Drawing.Size(187, 149);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.TextBox txtNameBox;
        private DevExpress.XtraEditors.SvgImageBox svgImageBox1;
    }
}
