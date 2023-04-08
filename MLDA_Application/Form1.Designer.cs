namespace MLDA_Application
{
    partial class FormMain
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.MBtn_Train = new FontAwesome.Sharp.IconButton();
            this.MpBtn_Prepare = new FontAwesome.Sharp.IconButton();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.btnMenu = new FontAwesome.Sharp.IconButton();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnLoadDf = new Guna.UI2.WinForms.Guna2Button();
            this.pnlChildHolder = new System.Windows.Forms.Panel();
            this.btnUpld = new Guna.UI2.WinForms.Guna2Button();
            this.pnlMenu.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.pnlMenu.Controls.Add(this.MBtn_Train);
            this.pnlMenu.Controls.Add(this.MpBtn_Prepare);
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(137, 552);
            this.pnlMenu.TabIndex = 0;
            this.pnlMenu.MouseEnter += new System.EventHandler(this.pnlMenu_MouseEnter);
            // 
            // MBtn_Train
            // 
            this.MBtn_Train.Dock = System.Windows.Forms.DockStyle.Top;
            this.MBtn_Train.FlatAppearance.BorderSize = 0;
            this.MBtn_Train.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MBtn_Train.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MBtn_Train.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.MBtn_Train.IconChar = FontAwesome.Sharp.IconChar.Beer;
            this.MBtn_Train.IconColor = System.Drawing.Color.SandyBrown;
            this.MBtn_Train.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MBtn_Train.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MBtn_Train.Location = new System.Drawing.Point(0, 154);
            this.MBtn_Train.Name = "MBtn_Train";
            this.MBtn_Train.Size = new System.Drawing.Size(137, 55);
            this.MBtn_Train.TabIndex = 2;
            this.MBtn_Train.Tag = "Train";
            this.MBtn_Train.Text = "Train";
            this.MBtn_Train.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MBtn_Train.UseVisualStyleBackColor = true;
            this.MBtn_Train.Click += new System.EventHandler(this.MBtn_Train_Click);
            this.MBtn_Train.MouseEnter += new System.EventHandler(this.pnlMenu_MouseEnter);
            // 
            // MpBtn_Prepare
            // 
            this.MpBtn_Prepare.Dock = System.Windows.Forms.DockStyle.Top;
            this.MpBtn_Prepare.FlatAppearance.BorderSize = 0;
            this.MpBtn_Prepare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MpBtn_Prepare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MpBtn_Prepare.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.MpBtn_Prepare.IconChar = FontAwesome.Sharp.IconChar.Beer;
            this.MpBtn_Prepare.IconColor = System.Drawing.Color.SandyBrown;
            this.MpBtn_Prepare.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MpBtn_Prepare.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MpBtn_Prepare.Location = new System.Drawing.Point(0, 99);
            this.MpBtn_Prepare.Name = "MpBtn_Prepare";
            this.MpBtn_Prepare.Size = new System.Drawing.Size(137, 55);
            this.MpBtn_Prepare.TabIndex = 1;
            this.MpBtn_Prepare.Tag = "Prepare";
            this.MpBtn_Prepare.Text = "Prepare";
            this.MpBtn_Prepare.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MpBtn_Prepare.UseVisualStyleBackColor = true;
            this.MpBtn_Prepare.Click += new System.EventHandler(this.MpBtn_Prepare_Click);
            this.MpBtn_Prepare.MouseEnter += new System.EventHandler(this.pnlMenu_MouseEnter);
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.btnMenu);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(137, 99);
            this.pnlLogo.TabIndex = 0;
            this.pnlLogo.MouseEnter += new System.EventHandler(this.pnlMenu_MouseEnter);
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.IconChar = FontAwesome.Sharp.IconChar.Opera;
            this.btnMenu.IconColor = System.Drawing.Color.Black;
            this.btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenu.Location = new System.Drawing.Point(89, 12);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(42, 35);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.pnlTop.Controls.Add(this.btnUpld);
            this.pnlTop.Controls.Add(this.btnLoadDf);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(137, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(784, 75);
            this.pnlTop.TabIndex = 1;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            // 
            // btnLoadDf
            // 
            this.btnLoadDf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadDf.BorderRadius = 1;
            this.btnLoadDf.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLoadDf.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLoadDf.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLoadDf.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLoadDf.FillColor = System.Drawing.Color.Orange;
            this.btnLoadDf.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLoadDf.ForeColor = System.Drawing.Color.White;
            this.btnLoadDf.Location = new System.Drawing.Point(561, 27);
            this.btnLoadDf.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.btnLoadDf.Name = "btnLoadDf";
            this.btnLoadDf.Size = new System.Drawing.Size(96, 30);
            this.btnLoadDf.TabIndex = 0;
            this.btnLoadDf.Text = "Load DF";
            this.btnLoadDf.Click += new System.EventHandler(this.btnLoadDf_Click);
            // 
            // pnlChildHolder
            // 
            this.pnlChildHolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.pnlChildHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChildHolder.Location = new System.Drawing.Point(137, 75);
            this.pnlChildHolder.Margin = new System.Windows.Forms.Padding(2);
            this.pnlChildHolder.Name = "pnlChildHolder";
            this.pnlChildHolder.Size = new System.Drawing.Size(784, 477);
            this.pnlChildHolder.TabIndex = 2;
            // 
            // btnUpld
            // 
            this.btnUpld.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpld.BorderRadius = 1;
            this.btnUpld.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpld.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpld.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpld.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpld.FillColor = System.Drawing.Color.Orange;
            this.btnUpld.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpld.ForeColor = System.Drawing.Color.White;
            this.btnUpld.Location = new System.Drawing.Point(664, 27);
            this.btnUpld.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.btnUpld.Name = "btnUpld";
            this.btnUpld.Size = new System.Drawing.Size(96, 30);
            this.btnUpld.TabIndex = 1;
            this.btnUpld.Text = "Upload";
            this.btnUpld.Click += new System.EventHandler(this.btnUpld_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(921, 552);
            this.Controls.Add(this.pnlChildHolder);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlMenu);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            this.pnlMenu.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlLogo;
        private FontAwesome.Sharp.IconButton MpBtn_Prepare;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlChildHolder;
        private FontAwesome.Sharp.IconButton btnMenu;
        private FontAwesome.Sharp.IconButton MBtn_Train;
        private Guna.UI2.WinForms.Guna2Button btnLoadDf;
        private Guna.UI2.WinForms.Guna2Button btnUpld;
    }
}

