namespace QuizletWindows.Forms.User
{
    partial class FrmChangePass
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
            this.showNewPassword = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.showOldPassword = new DevExpress.XtraEditors.CheckEdit();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.showConfirm = new DevExpress.XtraEditors.CheckEdit();
            this.showNewPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showOldPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showConfirm.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // showNewPassword
            // 
            this.showNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.showNewPassword.Controls.Add(this.showConfirm);
            this.showNewPassword.Controls.Add(this.checkEdit1);
            this.showNewPassword.Controls.Add(this.showOldPassword);
            this.showNewPassword.Controls.Add(this.btnUpdate);
            this.showNewPassword.Controls.Add(this.label4);
            this.showNewPassword.Controls.Add(this.label3);
            this.showNewPassword.Controls.Add(this.txtConfirm);
            this.showNewPassword.Controls.Add(this.txtNewPassword);
            this.showNewPassword.Controls.Add(this.label2);
            this.showNewPassword.Controls.Add(this.txtOldPassword);
            this.showNewPassword.Controls.Add(this.label1);
            this.showNewPassword.Location = new System.Drawing.Point(212, 12);
            this.showNewPassword.Name = "showNewPassword";
            this.showNewPassword.Size = new System.Drawing.Size(745, 389);
            this.showNewPassword.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnUpdate.Location = new System.Drawing.Point(241, 288);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(281, 44);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Change password";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(182, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 19);
            this.label4.TabIndex = 18;
            this.label4.Text = "Confirm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(128, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "New password:";
            // 
            // txtConfirm
            // 
            this.txtConfirm.Location = new System.Drawing.Point(276, 213);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Size = new System.Drawing.Size(315, 27);
            this.txtConfirm.TabIndex = 16;
            this.txtConfirm.UseSystemPasswordChar = true;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(276, 151);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(315, 27);
            this.txtNewPassword.TabIndex = 15;
            this.txtNewPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(249, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "CHANGE PASSWORD";
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Location = new System.Drawing.Point(276, 88);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.Size = new System.Drawing.Size(315, 27);
            this.txtOldPassword.TabIndex = 13;
            this.txtOldPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Old password:";
            // 
            // showOldPassword
            // 
            this.showOldPassword.Location = new System.Drawing.Point(597, 88);
            this.showOldPassword.Name = "showOldPassword";
            this.showOldPassword.Properties.Caption = "Show";
            this.showOldPassword.Size = new System.Drawing.Size(112, 27);
            this.showOldPassword.TabIndex = 20;
            this.showOldPassword.CheckedChanged += new System.EventHandler(this.showOldPassword_CheckedChanged);
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(597, 151);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Show";
            this.checkEdit1.Size = new System.Drawing.Size(112, 27);
            this.checkEdit1.TabIndex = 21;
            this.checkEdit1.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // showConfirm
            // 
            this.showConfirm.Location = new System.Drawing.Point(597, 209);
            this.showConfirm.Name = "showConfirm";
            this.showConfirm.Properties.Caption = "Show";
            this.showConfirm.Size = new System.Drawing.Size(112, 27);
            this.showConfirm.TabIndex = 22;
            this.showConfirm.CheckedChanged += new System.EventHandler(this.showConfirm_CheckedChanged);
            // 
            // FrmChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 440);
            this.Controls.Add(this.showNewPassword);
            this.Name = "FrmChangePass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change password";
            this.showNewPassword.ResumeLayout(false);
            this.showNewPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showOldPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showConfirm.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel showNewPassword;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOldPassword;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.CheckEdit showOldPassword;
        private DevExpress.XtraEditors.CheckEdit showConfirm;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
    }
}