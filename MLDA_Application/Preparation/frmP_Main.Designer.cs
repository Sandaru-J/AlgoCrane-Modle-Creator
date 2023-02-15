namespace MLDA_Application.Preparation
{
    partial class frmP_Main
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
            this.btnCatImport = new FontAwesome.Sharp.IconButton();
            this.pnlPfrmHolder = new System.Windows.Forms.Panel();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.guna2TextBox1);
            this.panel1.Controls.Add(this.btnCatImport);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(767, 47);
            this.panel1.TabIndex = 0;
            // 
            // btnCatImport
            // 
            this.btnCatImport.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCatImport.IconColor = System.Drawing.Color.Black;
            this.btnCatImport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCatImport.Location = new System.Drawing.Point(0, 0);
            this.btnCatImport.Margin = new System.Windows.Forms.Padding(2);
            this.btnCatImport.Name = "btnCatImport";
            this.btnCatImport.Size = new System.Drawing.Size(130, 48);
            this.btnCatImport.TabIndex = 0;
            this.btnCatImport.Text = "Import";
            this.btnCatImport.UseVisualStyleBackColor = true;
            this.btnCatImport.Click += new System.EventHandler(this.btnCatImport_Click);
            // 
            // pnlPfrmHolder
            // 
            this.pnlPfrmHolder.Location = new System.Drawing.Point(0, 48);
            this.pnlPfrmHolder.Margin = new System.Windows.Forms.Padding(2);
            this.pnlPfrmHolder.Name = "pnlPfrmHolder";
            this.pnlPfrmHolder.Size = new System.Drawing.Size(767, 437);
            this.pnlPfrmHolder.TabIndex = 1;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(561, 15);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(181, 24);
            this.guna2TextBox1.TabIndex = 1;
            // 
            // frmP_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 439);
            this.Controls.Add(this.pnlPfrmHolder);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmP_Main";
            this.Text = "FrmPrepare";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnCatImport;
        private System.Windows.Forms.Panel pnlPfrmHolder;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
    }
}