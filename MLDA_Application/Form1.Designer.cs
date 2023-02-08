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
            this.MpBtn_Prepare = new FontAwesome.Sharp.IconButton();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlChildHolder = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.pnlMenu.Controls.Add(this.MpBtn_Prepare);
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(183, 679);
            this.pnlMenu.TabIndex = 0;
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
            this.MpBtn_Prepare.Location = new System.Drawing.Point(0, 122);
            this.MpBtn_Prepare.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MpBtn_Prepare.Name = "MpBtn_Prepare";
            this.MpBtn_Prepare.Size = new System.Drawing.Size(183, 68);
            this.MpBtn_Prepare.TabIndex = 1;
            this.MpBtn_Prepare.Text = "Prepare";
            this.MpBtn_Prepare.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MpBtn_Prepare.UseVisualStyleBackColor = true;
            this.MpBtn_Prepare.Click += new System.EventHandler(this.MpBtn_Prepare_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(183, 122);
            this.pnlLogo.TabIndex = 0;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(183, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1045, 92);
            this.pnlTop.TabIndex = 1;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            // 
            // pnlChildHolder
            // 
            this.pnlChildHolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.pnlChildHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChildHolder.Location = new System.Drawing.Point(183, 92);
            this.pnlChildHolder.Name = "pnlChildHolder";
            this.pnlChildHolder.Size = new System.Drawing.Size(1045, 587);
            this.pnlChildHolder.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1228, 679);
            this.Controls.Add(this.pnlChildHolder);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMain";
            this.Text = "Main Form";
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlLogo;
        private FontAwesome.Sharp.IconButton MpBtn_Prepare;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlChildHolder;
    }
}

