namespace MLDA_Application.Preparation.PreProcess
{
    partial class UC_Normalize
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMinMax = new Guna.UI2.WinForms.Guna2TileButton();
            this.BtnZcore = new Guna.UI2.WinForms.Guna2TileButton();
            this.label3 = new System.Windows.Forms.Label();
            this.NuupdMax = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.NuupdMin = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStd = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnNrmlzPrcd = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.NuupdMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NuupdMin)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select the columns to normalize";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select the Method";
            // 
            // btnMinMax
            // 
            this.btnMinMax.BorderRadius = 3;
            this.btnMinMax.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMinMax.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMinMax.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMinMax.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMinMax.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMinMax.ForeColor = System.Drawing.Color.White;
            this.btnMinMax.Location = new System.Drawing.Point(36, 121);
            this.btnMinMax.Name = "btnMinMax";
            this.btnMinMax.Size = new System.Drawing.Size(76, 35);
            this.btnMinMax.TabIndex = 3;
            this.btnMinMax.Text = "MinMax";
            this.btnMinMax.Click += new System.EventHandler(this.btnMinMax_Click);
            // 
            // BtnZcore
            // 
            this.BtnZcore.BorderRadius = 3;
            this.BtnZcore.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnZcore.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnZcore.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnZcore.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnZcore.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnZcore.ForeColor = System.Drawing.Color.White;
            this.BtnZcore.Location = new System.Drawing.Point(118, 121);
            this.BtnZcore.Name = "BtnZcore";
            this.BtnZcore.Size = new System.Drawing.Size(76, 35);
            this.BtnZcore.TabIndex = 4;
            this.BtnZcore.Text = "Zscore";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Input Max and Min ranges";
            // 
            // NuupdMax
            // 
            this.NuupdMax.BackColor = System.Drawing.Color.Transparent;
            this.NuupdMax.BorderRadius = 2;
            this.NuupdMax.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NuupdMax.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NuupdMax.Location = new System.Drawing.Point(74, 195);
            this.NuupdMax.Name = "NuupdMax";
            this.NuupdMax.Size = new System.Drawing.Size(64, 28);
            this.NuupdMax.TabIndex = 6;
            // 
            // NuupdMin
            // 
            this.NuupdMin.BackColor = System.Drawing.Color.Transparent;
            this.NuupdMin.BorderRadius = 2;
            this.NuupdMin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NuupdMin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NuupdMin.Location = new System.Drawing.Point(185, 195);
            this.NuupdMin.Name = "NuupdMin";
            this.NuupdMin.Size = new System.Drawing.Size(68, 28);
            this.NuupdMin.TabIndex = 7;
            this.NuupdMin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Max";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(145, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Min";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Enter Standard Deviation";
            // 
            // txtStd
            // 
            this.txtStd.BorderRadius = 2;
            this.txtStd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStd.DefaultText = "";
            this.txtStd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtStd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtStd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtStd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStd.Location = new System.Drawing.Point(214, 232);
            this.txtStd.Name = "txtStd";
            this.txtStd.PasswordChar = '\0';
            this.txtStd.PlaceholderText = "default 1";
            this.txtStd.SelectedText = "";
            this.txtStd.Size = new System.Drawing.Size(76, 30);
            this.txtStd.TabIndex = 11;
            // 
            // btnNrmlzPrcd
            // 
            this.btnNrmlzPrcd.BorderRadius = 3;
            this.btnNrmlzPrcd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNrmlzPrcd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNrmlzPrcd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNrmlzPrcd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNrmlzPrcd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNrmlzPrcd.ForeColor = System.Drawing.Color.White;
            this.btnNrmlzPrcd.Location = new System.Drawing.Point(37, 288);
            this.btnNrmlzPrcd.Name = "btnNrmlzPrcd";
            this.btnNrmlzPrcd.Size = new System.Drawing.Size(94, 39);
            this.btnNrmlzPrcd.TabIndex = 12;
            this.btnNrmlzPrcd.Text = "Proceed";
            // 
            // guna2Button2
            // 
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(149, 288);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(98, 39);
            this.guna2Button2.TabIndex = 13;
            this.guna2Button2.Text = "guna2Button2";
            // 
            // guna2Button3
            // 
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Location = new System.Drawing.Point(173, 238);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(8, 8);
            this.guna2Button3.TabIndex = 14;
            this.guna2Button3.Text = "guna2Button3";
            // 
            // UC_Normalize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.btnNrmlzPrcd);
            this.Controls.Add(this.txtStd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NuupdMin);
            this.Controls.Add(this.NuupdMax);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnZcore);
            this.Controls.Add(this.btnMinMax);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UC_Normalize";
            this.Size = new System.Drawing.Size(321, 450);
            ((System.ComponentModel.ISupportInitialize)(this.NuupdMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NuupdMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TileButton btnMinMax;
        private Guna.UI2.WinForms.Guna2TileButton BtnZcore;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2NumericUpDown NuupdMax;
        private Guna.UI2.WinForms.Guna2NumericUpDown NuupdMin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtStd;
        private Guna.UI2.WinForms.Guna2Button btnNrmlzPrcd;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
    }
}
