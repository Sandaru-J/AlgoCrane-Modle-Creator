namespace MLDA_Application.Preparation.PreProcess
{
    partial class UC_Encoding
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
            this.btnOrdinal = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnOneHot = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnLabel = new Guna.UI2.WinForms.Guna2TileButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRolace = new Guna.UI2.WinForms.Guna2Button();
            this.btnNeClm = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnIgnre = new Guna.UI2.WinForms.Guna2Button();
            this.btnMstCmn = new Guna.UI2.WinForms.Guna2Button();
            this.btnSpecial = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnscYes = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnSclNo = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnPrcd = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select the columns to encode";
            // 
            // btnOrdinal
            // 
            this.btnOrdinal.BorderRadius = 3;
            this.btnOrdinal.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOrdinal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOrdinal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOrdinal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOrdinal.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdinal.ForeColor = System.Drawing.Color.White;
            this.btnOrdinal.Location = new System.Drawing.Point(212, 86);
            this.btnOrdinal.Name = "btnOrdinal";
            this.btnOrdinal.Size = new System.Drawing.Size(75, 35);
            this.btnOrdinal.TabIndex = 22;
            this.btnOrdinal.Text = "Ordinal";
            this.btnOrdinal.Click += new System.EventHandler(this.btnOrdinal_Click);
            // 
            // btnOneHot
            // 
            this.btnOneHot.BorderRadius = 3;
            this.btnOneHot.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnOneHot.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOneHot.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOneHot.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOneHot.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOneHot.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnOneHot.ForeColor = System.Drawing.Color.White;
            this.btnOneHot.Location = new System.Drawing.Point(115, 86);
            this.btnOneHot.Name = "btnOneHot";
            this.btnOneHot.Size = new System.Drawing.Size(89, 35);
            this.btnOneHot.TabIndex = 21;
            this.btnOneHot.Text = "One-Hot";
            this.btnOneHot.Click += new System.EventHandler(this.btnOneHot_Click);
            // 
            // btnLabel
            // 
            this.btnLabel.BorderRadius = 3;
            this.btnLabel.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnLabel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLabel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLabel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLabel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnLabel.ForeColor = System.Drawing.Color.White;
            this.btnLabel.Location = new System.Drawing.Point(33, 86);
            this.btnLabel.Name = "btnLabel";
            this.btnLabel.Size = new System.Drawing.Size(76, 35);
            this.btnLabel.TabIndex = 20;
            this.btnLabel.Text = "Label";
            this.btnLabel.Click += new System.EventHandler(this.btnLabel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Select the Technique";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Encoding Output";
            // 
            // btnRolace
            // 
            this.btnRolace.BorderRadius = 2;
            this.btnRolace.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnRolace.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRolace.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRolace.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRolace.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRolace.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRolace.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnRolace.ForeColor = System.Drawing.Color.White;
            this.btnRolace.Location = new System.Drawing.Point(34, 154);
            this.btnRolace.Name = "btnRolace";
            this.btnRolace.Size = new System.Drawing.Size(117, 37);
            this.btnRolace.TabIndex = 24;
            this.btnRolace.Text = "Replace";
            this.btnRolace.Click += new System.EventHandler(this.btnRolace_Click);
            // 
            // btnNeClm
            // 
            this.btnNeClm.BorderRadius = 2;
            this.btnNeClm.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnNeClm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNeClm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNeClm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNeClm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNeClm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNeClm.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnNeClm.ForeColor = System.Drawing.Color.White;
            this.btnNeClm.Location = new System.Drawing.Point(170, 154);
            this.btnNeClm.Name = "btnNeClm";
            this.btnNeClm.Size = new System.Drawing.Size(117, 37);
            this.btnNeClm.TabIndex = 25;
            this.btnNeClm.Text = "New Column";
            this.btnNeClm.Click += new System.EventHandler(this.btnNeClm_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Unknown Categories";
            // 
            // btnIgnre
            // 
            this.btnIgnre.BorderRadius = 2;
            this.btnIgnre.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnIgnre.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnIgnre.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnIgnre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnIgnre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnIgnre.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnIgnre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnIgnre.ForeColor = System.Drawing.Color.White;
            this.btnIgnre.Location = new System.Drawing.Point(35, 225);
            this.btnIgnre.Name = "btnIgnre";
            this.btnIgnre.Size = new System.Drawing.Size(84, 37);
            this.btnIgnre.TabIndex = 27;
            this.btnIgnre.Text = "Ignore";
            this.btnIgnre.Click += new System.EventHandler(this.btnIgnre_Click);
            // 
            // btnMstCmn
            // 
            this.btnMstCmn.BorderRadius = 2;
            this.btnMstCmn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnMstCmn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMstCmn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMstCmn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMstCmn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMstCmn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMstCmn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnMstCmn.ForeColor = System.Drawing.Color.White;
            this.btnMstCmn.Location = new System.Drawing.Point(125, 225);
            this.btnMstCmn.Name = "btnMstCmn";
            this.btnMstCmn.Size = new System.Drawing.Size(79, 37);
            this.btnMstCmn.TabIndex = 28;
            this.btnMstCmn.Text = "Most Common";
            this.btnMstCmn.Click += new System.EventHandler(this.btnMstCmn_Click);
            // 
            // btnSpecial
            // 
            this.btnSpecial.BorderRadius = 2;
            this.btnSpecial.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnSpecial.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSpecial.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSpecial.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSpecial.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSpecial.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSpecial.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSpecial.ForeColor = System.Drawing.Color.White;
            this.btnSpecial.Location = new System.Drawing.Point(209, 225);
            this.btnSpecial.Name = "btnSpecial";
            this.btnSpecial.Size = new System.Drawing.Size(77, 37);
            this.btnSpecial.TabIndex = 29;
            this.btnSpecial.Text = "Special";
            this.btnSpecial.Click += new System.EventHandler(this.btnSpecial_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Scale Encoded Data";
            // 
            // btnscYes
            // 
            this.btnscYes.BorderRadius = 3;
            this.btnscYes.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnscYes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnscYes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnscYes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnscYes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnscYes.FillColor = System.Drawing.Color.SaddleBrown;
            this.btnscYes.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnscYes.ForeColor = System.Drawing.Color.White;
            this.btnscYes.Location = new System.Drawing.Point(180, 268);
            this.btnscYes.Name = "btnscYes";
            this.btnscYes.Size = new System.Drawing.Size(54, 35);
            this.btnscYes.TabIndex = 31;
            this.btnscYes.Text = "Yes";
            this.btnscYes.Click += new System.EventHandler(this.btnscYes_Click);
            // 
            // btnSclNo
            // 
            this.btnSclNo.BorderRadius = 3;
            this.btnSclNo.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnSclNo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSclNo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSclNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSclNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSclNo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSclNo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSclNo.ForeColor = System.Drawing.Color.White;
            this.btnSclNo.Location = new System.Drawing.Point(230, 268);
            this.btnSclNo.Name = "btnSclNo";
            this.btnSclNo.Size = new System.Drawing.Size(56, 35);
            this.btnSclNo.TabIndex = 32;
            this.btnSclNo.Text = "No";
            this.btnSclNo.Click += new System.EventHandler(this.btnSclNo_Click);
            // 
            // btnPrcd
            // 
            this.btnPrcd.BorderRadius = 3;
            this.btnPrcd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrcd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrcd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrcd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrcd.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnPrcd.ForeColor = System.Drawing.Color.White;
            this.btnPrcd.Location = new System.Drawing.Point(36, 326);
            this.btnPrcd.Name = "btnPrcd";
            this.btnPrcd.Size = new System.Drawing.Size(122, 39);
            this.btnPrcd.TabIndex = 33;
            this.btnPrcd.Text = "Proceed";
            this.btnPrcd.Click += new System.EventHandler(this.btnPrcd_Click);
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
            this.btnCancel.Location = new System.Drawing.Point(170, 326);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 39);
            this.btnCancel.TabIndex = 34;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // UC_Encoding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPrcd);
            this.Controls.Add(this.btnSclNo);
            this.Controls.Add(this.btnscYes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSpecial);
            this.Controls.Add(this.btnMstCmn);
            this.Controls.Add(this.btnIgnre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnNeClm);
            this.Controls.Add(this.btnRolace);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnOrdinal);
            this.Controls.Add(this.btnOneHot);
            this.Controls.Add(this.btnLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UC_Encoding";
            this.Size = new System.Drawing.Size(321, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TileButton btnOrdinal;
        private Guna.UI2.WinForms.Guna2TileButton btnOneHot;
        private Guna.UI2.WinForms.Guna2TileButton btnLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnRolace;
        private Guna.UI2.WinForms.Guna2Button btnNeClm;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button btnIgnre;
        private Guna.UI2.WinForms.Guna2Button btnMstCmn;
        private Guna.UI2.WinForms.Guna2Button btnSpecial;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TileButton btnscYes;
        private Guna.UI2.WinForms.Guna2TileButton btnSclNo;
        private Guna.UI2.WinForms.Guna2TileButton btnPrcd;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
    }
}
