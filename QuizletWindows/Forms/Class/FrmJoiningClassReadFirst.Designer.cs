namespace QuizletWindows.Forms.Class
{
    partial class FrmJoiningClassReadFirst
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.termGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TermName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Explanation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.termGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1147, 67);
            this.panel1.TabIndex = 0;
            // 
            // termGridView
            // 
            this.termGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.termGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.termGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TermName,
            this.Explanation});
            this.termGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.termGridView.Location = new System.Drawing.Point(0, 67);
            this.termGridView.MultiSelect = false;
            this.termGridView.Name = "termGridView";
            this.termGridView.RowHeadersWidth = 62;
            this.termGridView.RowTemplate.Height = 28;
            this.termGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.termGridView.Size = new System.Drawing.Size(1147, 414);
            this.termGridView.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(500, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Try to read it first";
            // 
            // TermName
            // 
            this.TermName.HeaderText = "Term Name";
            this.TermName.MinimumWidth = 8;
            this.TermName.Name = "TermName";
            this.TermName.ReadOnly = true;
            // 
            // Explanation
            // 
            this.Explanation.HeaderText = "Explanation";
            this.Explanation.MinimumWidth = 8;
            this.Explanation.Name = "Explanation";
            this.Explanation.ReadOnly = true;
            // 
            // FrmJoiningClassReadFirst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 481);
            this.Controls.Add(this.termGridView);
            this.Controls.Add(this.panel1);
            this.Name = "FrmJoiningClassReadFirst";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YourModuleNameHere";
            this.Load += new System.EventHandler(this.FrmJoiningClassReadFirst_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.termGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView termGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TermName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Explanation;
    }
}