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
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.MpBtn_Prepare = new FontAwesome.Sharp.IconButton();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.btnMenu = new FontAwesome.Sharp.IconButton();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlChildHolder = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.pnlMenu.Controls.Add(this.iconButton2);
            this.pnlMenu.Controls.Add(this.MpBtn_Prepare);
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(137, 552);
            this.pnlMenu.TabIndex = 0;
            this.pnlMenu.MouseEnter += new System.EventHandler(this.pnlMenu_MouseEnter);
            // 
            // iconButton2
            // 
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Beer;
            this.iconButton2.IconColor = System.Drawing.Color.SandyBrown;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(0, 154);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(137, 55);
            this.iconButton2.TabIndex = 2;
            this.iconButton2.Tag = "Train";
            this.iconButton2.Text = "Training";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.MouseEnter += new System.EventHandler(this.pnlMenu_MouseEnter);
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
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(137, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(784, 75);
            this.pnlTop.TabIndex = 1;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlLogo;
        private FontAwesome.Sharp.IconButton MpBtn_Prepare;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlChildHolder;
        private FontAwesome.Sharp.IconButton btnMenu;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}

