namespace MLDA_Application.Preparation
{
    partial class frmP_clean
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnMissingval = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.uC_PC_missing1 = new MLDA_Application.Preparation.UC_PC_missing();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(23)))), ((int)(((byte)(74)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.btnMissingval);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(250, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 243);
            this.panel1.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(34, 98);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(212, 106);
            this.listBox1.TabIndex = 2;
            // 
            // btnMissingval
            // 
            this.btnMissingval.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMissingval.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMissingval.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMissingval.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMissingval.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMissingval.ForeColor = System.Drawing.Color.White;
            this.btnMissingval.Location = new System.Drawing.Point(87, 54);
            this.btnMissingval.Name = "btnMissingval";
            this.btnMissingval.Size = new System.Drawing.Size(146, 37);
            this.btnMissingval.TabIndex = 1;
            this.btnMissingval.Text = "Missing Values";
            this.btnMissingval.Click += new System.EventHandler(this.btnMissingval_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(110, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Check For";
            // 
            // uC_PC_missing1
            // 
            this.uC_PC_missing1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(70)))));
            this.uC_PC_missing1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_PC_missing1.Location = new System.Drawing.Point(0, 0);
            this.uC_PC_missing1.Name = "uC_PC_missing1";
            this.uC_PC_missing1.Size = new System.Drawing.Size(951, 430);
            this.uC_PC_missing1.TabIndex = 1;
            // 
            // frmP_clean
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(23)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(951, 430);
            this.Controls.Add(this.uC_PC_missing1);
            this.Controls.Add(this.panel1);
            this.Name = "frmP_clean";
            this.Text = "frmP_clean";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnMissingval;
        private System.Windows.Forms.Label label1;
        private UC_PC_missing uC_PC_missing1;
        private System.Windows.Forms.ListBox listBox1;
    }
}