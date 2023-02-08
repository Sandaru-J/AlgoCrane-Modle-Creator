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
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCatImport);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1027, 59);
            this.panel1.TabIndex = 0;
            // 
            // btnCatImport
            // 
            this.btnCatImport.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCatImport.IconColor = System.Drawing.Color.Black;
            this.btnCatImport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCatImport.Location = new System.Drawing.Point(0, 0);
            this.btnCatImport.Name = "btnCatImport";
            this.btnCatImport.Size = new System.Drawing.Size(173, 59);
            this.btnCatImport.TabIndex = 0;
            this.btnCatImport.Text = "Import";
            this.btnCatImport.UseVisualStyleBackColor = true;
            this.btnCatImport.Click += new System.EventHandler(this.btnCatImport_Click);
            // 
            // pnlPfrmHolder
            // 
            this.pnlPfrmHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPfrmHolder.Location = new System.Drawing.Point(0, 59);
            this.pnlPfrmHolder.Name = "pnlPfrmHolder";
            this.pnlPfrmHolder.Size = new System.Drawing.Size(1027, 481);
            this.pnlPfrmHolder.TabIndex = 1;
            // 
            // frmP_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 540);
            this.Controls.Add(this.pnlPfrmHolder);
            this.Controls.Add(this.panel1);
            this.Name = "frmP_Main";
            this.Text = "FrmPrepare";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnCatImport;
        private System.Windows.Forms.Panel pnlPfrmHolder;
    }
}