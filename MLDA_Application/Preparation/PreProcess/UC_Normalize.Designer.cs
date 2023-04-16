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
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDcmlScl = new Guna.UI2.WinForms.Guna2TileButton();
            this.NupdDcml = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.chckBxSav = new Guna.UI2.WinForms.Guna2CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.NuupdMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NuupdMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NupdDcml)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select the columns to normalize";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 65);
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
            this.btnMinMax.Location = new System.Drawing.Point(32, 88);
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
            this.BtnZcore.Location = new System.Drawing.Point(118, 88);
            this.BtnZcore.Name = "BtnZcore";
            this.BtnZcore.Size = new System.Drawing.Size(89, 35);
            this.BtnZcore.TabIndex = 4;
            this.BtnZcore.Text = "Zscore";
            this.BtnZcore.Click += new System.EventHandler(this.BtnZcore_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 130);
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
            this.NuupdMax.Location = new System.Drawing.Point(70, 162);
            this.NuupdMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NuupdMax.Name = "NuupdMax";
            this.NuupdMax.Size = new System.Drawing.Size(64, 28);
            this.NuupdMax.TabIndex = 6;
            this.NuupdMax.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NuupdMin
            // 
            this.NuupdMin.BackColor = System.Drawing.Color.Transparent;
            this.NuupdMin.BorderRadius = 2;
            this.NuupdMin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NuupdMin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NuupdMin.Location = new System.Drawing.Point(217, 162);
            this.NuupdMin.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.NuupdMin.Name = "NuupdMin";
            this.NuupdMin.Size = new System.Drawing.Size(68, 28);
            this.NuupdMin.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Max";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(169, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Min";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 209);
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
            this.txtStd.Location = new System.Drawing.Point(214, 199);
            this.txtStd.Name = "txtStd";
            this.txtStd.PasswordChar = '\0';
            this.txtStd.PlaceholderText = "1";
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
            this.btnNrmlzPrcd.Location = new System.Drawing.Point(32, 316);
            this.btnNrmlzPrcd.Name = "btnNrmlzPrcd";
            this.btnNrmlzPrcd.Size = new System.Drawing.Size(102, 39);
            this.btnNrmlzPrcd.TabIndex = 12;
            this.btnNrmlzPrcd.Text = "Proceed";
            this.btnNrmlzPrcd.Click += new System.EventHandler(this.btnNrmlzPrcd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BorderRadius = 3;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(179, 316);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(107, 39);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Stackpath;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(132, 317);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(41, 38);
            this.iconButton1.TabIndex = 15;
            this.iconButton1.Text = "iconButton1";
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Number of Decimal places ";
            // 
            // btnDcmlScl
            // 
            this.btnDcmlScl.BorderRadius = 3;
            this.btnDcmlScl.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDcmlScl.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDcmlScl.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDcmlScl.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDcmlScl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDcmlScl.ForeColor = System.Drawing.Color.White;
            this.btnDcmlScl.Location = new System.Drawing.Point(214, 88);
            this.btnDcmlScl.Name = "btnDcmlScl";
            this.btnDcmlScl.Size = new System.Drawing.Size(75, 35);
            this.btnDcmlScl.TabIndex = 18;
            this.btnDcmlScl.Text = "Decimal";
            this.btnDcmlScl.Click += new System.EventHandler(this.btnDcmlScl_Click);
            // 
            // NupdDcml
            // 
            this.NupdDcml.BackColor = System.Drawing.Color.Transparent;
            this.NupdDcml.BorderRadius = 2;
            this.NupdDcml.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NupdDcml.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NupdDcml.Location = new System.Drawing.Point(221, 243);
            this.NupdDcml.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NupdDcml.Name = "NupdDcml";
            this.NupdDcml.Size = new System.Drawing.Size(64, 28);
            this.NupdDcml.TabIndex = 19;
            this.NupdDcml.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // chckBxSav
            // 
            this.chckBxSav.AutoSize = true;
            this.chckBxSav.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.chckBxSav.CheckedState.BorderRadius = 0;
            this.chckBxSav.CheckedState.BorderThickness = 0;
            this.chckBxSav.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chckBxSav.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.chckBxSav.Location = new System.Drawing.Point(38, 282);
            this.chckBxSav.Name = "chckBxSav";
            this.chckBxSav.Size = new System.Drawing.Size(143, 17);
            this.chckBxSav.TabIndex = 20;
            this.chckBxSav.Text = "Update the Excisting File";
            this.chckBxSav.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chckBxSav.UncheckedState.BorderRadius = 0;
            this.chckBxSav.UncheckedState.BorderThickness = 0;
            this.chckBxSav.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // UC_Normalize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.chckBxSav);
            this.Controls.Add(this.NupdDcml);
            this.Controls.Add(this.btnDcmlScl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.btnCancel);
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
            ((System.ComponentModel.ISupportInitialize)(this.NupdDcml)).EndInit();
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
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TileButton btnDcmlScl;
        private Guna.UI2.WinForms.Guna2NumericUpDown NupdDcml;
        private Guna.UI2.WinForms.Guna2CheckBox chckBxSav;
    }
}
