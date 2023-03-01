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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmP_Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCleaning = new Guna.UI2.WinForms.Guna2Button();
            this.btnCatImport = new FontAwesome.Sharp.IconButton();
            this.pnlPfrmHolder = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.pnlPfrmHolder.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.btnCleaning);
            this.panel1.Controls.Add(this.btnCatImport);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(767, 47);
            this.panel1.TabIndex = 0;
            // 
            // btnCleaning
            // 
            this.btnCleaning.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCleaning.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCleaning.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCleaning.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCleaning.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCleaning.ForeColor = System.Drawing.Color.White;
            this.btnCleaning.Location = new System.Drawing.Point(129, 0);
            this.btnCleaning.Name = "btnCleaning";
            this.btnCleaning.Size = new System.Drawing.Size(139, 46);
            this.btnCleaning.TabIndex = 1;
            this.btnCleaning.Text = "Clean";
            this.btnCleaning.Click += new System.EventHandler(this.btnCleaning_Click);
            this.btnCleaning.MouseHover += new System.EventHandler(this.btnCleaning_MouseHover);
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
            this.pnlPfrmHolder.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlPfrmHolder.Controls.Add(this.panel2);
            this.pnlPfrmHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPfrmHolder.Location = new System.Drawing.Point(0, 47);
            this.pnlPfrmHolder.Margin = new System.Windows.Forms.Padding(2);
            this.pnlPfrmHolder.Name = "pnlPfrmHolder";
            this.pnlPfrmHolder.Size = new System.Drawing.Size(767, 400);
            this.pnlPfrmHolder.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.guna2PictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(767, 400);
            this.panel2.TabIndex = 0;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(141, -31);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(454, 447);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            this.contextMenuStrip1.Text = "Missing Vlues";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "Missing values";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "Duplicates";
            // 
            // frmP_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 447);
            this.Controls.Add(this.pnlPfrmHolder);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmP_Main";
            this.Text = "FrmPrepare";
            this.panel1.ResumeLayout(false);
            this.pnlPfrmHolder.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnCatImport;
        private System.Windows.Forms.Panel pnlPfrmHolder;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnCleaning;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}