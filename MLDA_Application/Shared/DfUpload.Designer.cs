namespace MLDA_Application.Shared
{
    partial class DfUpload
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
            this.btnUpload = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancl = new Guna.UI2.WinForms.Guna2Button();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.txtUpFileLoc = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUpFileName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel1.Controls.Add(this.btnUpload);
            this.panel1.Controls.Add(this.btnCancl);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.txtUpFileLoc);
            this.panel1.Controls.Add(this.txtUpFileName);
            this.panel1.Controls.Add(this.guna2Panel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 247);
            this.panel1.TabIndex = 0;
            // 
            // btnUpload
            // 
            this.btnUpload.Animated = true;
            this.btnUpload.BorderRadius = 3;
            this.btnUpload.BorderThickness = 2;
            this.btnUpload.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpload.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpload.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpload.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpload.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnUpload.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpload.ForeColor = System.Drawing.Color.White;
            this.btnUpload.Location = new System.Drawing.Point(185, 159);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(140, 42);
            this.btnUpload.TabIndex = 7;
            this.btnUpload.Text = "Upload";
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnCancl
            // 
            this.btnCancl.Animated = true;
            this.btnCancl.BorderRadius = 3;
            this.btnCancl.BorderThickness = 2;
            this.btnCancl.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancl.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancl.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancl.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancl.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCancl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancl.ForeColor = System.Drawing.Color.White;
            this.btnCancl.Location = new System.Drawing.Point(331, 159);
            this.btnCancl.Name = "btnCancl";
            this.btnCancl.Size = new System.Drawing.Size(139, 42);
            this.btnCancl.TabIndex = 6;
            this.btnCancl.Text = "Cancel";
            this.btnCancl.Click += new System.EventHandler(this.btnCancl_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Transparent;
            this.iconButton1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.SearchLocation;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 22;
            this.iconButton1.Location = new System.Drawing.Point(433, 67);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(32, 25);
            this.iconButton1.TabIndex = 5;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // txtUpFileLoc
            // 
            this.txtUpFileLoc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUpFileLoc.BorderRadius = 4;
            this.txtUpFileLoc.BorderThickness = 2;
            this.txtUpFileLoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUpFileLoc.DefaultText = "";
            this.txtUpFileLoc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUpFileLoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUpFileLoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUpFileLoc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUpFileLoc.FillColor = System.Drawing.Color.Silver;
            this.txtUpFileLoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUpFileLoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUpFileLoc.ForeColor = System.Drawing.Color.Gray;
            this.txtUpFileLoc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUpFileLoc.Location = new System.Drawing.Point(38, 61);
            this.txtUpFileLoc.Name = "txtUpFileLoc";
            this.txtUpFileLoc.PasswordChar = '\0';
            this.txtUpFileLoc.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUpFileLoc.PlaceholderText = "Select File";
            this.txtUpFileLoc.SelectedText = "";
            this.txtUpFileLoc.Size = new System.Drawing.Size(434, 36);
            this.txtUpFileLoc.TabIndex = 3;
            // 
            // txtUpFileName
            // 
            this.txtUpFileName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUpFileName.BorderRadius = 4;
            this.txtUpFileName.BorderThickness = 2;
            this.txtUpFileName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUpFileName.DefaultText = "";
            this.txtUpFileName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUpFileName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUpFileName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUpFileName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUpFileName.FillColor = System.Drawing.Color.Silver;
            this.txtUpFileName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUpFileName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUpFileName.ForeColor = System.Drawing.Color.Gray;
            this.txtUpFileName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUpFileName.Location = new System.Drawing.Point(38, 109);
            this.txtUpFileName.Name = "txtUpFileName";
            this.txtUpFileName.PasswordChar = '\0';
            this.txtUpFileName.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUpFileName.PlaceholderText = "Give a Name";
            this.txtUpFileName.SelectedText = "";
            this.txtUpFileName.Size = new System.Drawing.Size(434, 36);
            this.txtUpFileName.TabIndex = 2;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(506, 42);
            this.guna2Panel1.TabIndex = 0;
            // 
            // DfUpload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 247);
            this.Controls.Add(this.panel1);
            this.Name = "DfUpload";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DfUpload";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtUpFileLoc;
        private Guna.UI2.WinForms.Guna2TextBox txtUpFileName;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Guna.UI2.WinForms.Guna2Button btnUpload;
        private Guna.UI2.WinForms.Guna2Button btnCancl;
    }
}