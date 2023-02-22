namespace MLDA_Application.Preparation
{
    partial class UC_PC_missing
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnMedianFIll = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btnModeFill = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btnMeanFill = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtCleanView = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 312);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 81);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(447, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(309, 312);
            this.panel2.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(309, 58);
            this.panel7.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(70)))));
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(309, 58);
            this.panel8.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel6.BackColor = System.Drawing.Color.DimGray;
            this.panel6.Controls.Add(this.btnMedianFIll);
            this.panel6.Controls.Add(this.btnModeFill);
            this.panel6.Controls.Add(this.btnMeanFill);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Location = new System.Drawing.Point(14, 64);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(281, 242);
            this.panel6.TabIndex = 0;
            // 
            // btnMedianFIll
            // 
            this.btnMedianFIll.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMedianFIll.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMedianFIll.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMedianFIll.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMedianFIll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMedianFIll.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(70)))));
            this.btnMedianFIll.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnMedianFIll.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnMedianFIll.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMedianFIll.ForeColor = System.Drawing.Color.White;
            this.btnMedianFIll.Location = new System.Drawing.Point(182, 55);
            this.btnMedianFIll.Name = "btnMedianFIll";
            this.btnMedianFIll.Size = new System.Drawing.Size(80, 40);
            this.btnMedianFIll.TabIndex = 3;
            this.btnMedianFIll.Text = "Median";
            this.btnMedianFIll.Click += new System.EventHandler(this.guna2GradientTileButton3_Click);
            // 
            // btnModeFill
            // 
            this.btnModeFill.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnModeFill.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnModeFill.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnModeFill.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnModeFill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnModeFill.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(70)))));
            this.btnModeFill.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnModeFill.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnModeFill.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnModeFill.ForeColor = System.Drawing.Color.White;
            this.btnModeFill.Location = new System.Drawing.Point(101, 55);
            this.btnModeFill.Name = "btnModeFill";
            this.btnModeFill.Size = new System.Drawing.Size(80, 40);
            this.btnModeFill.TabIndex = 2;
            this.btnModeFill.Text = "Mode";
            this.btnModeFill.Click += new System.EventHandler(this.guna2GradientTileButton2_Click);
            // 
            // btnMeanFill
            // 
            this.btnMeanFill.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMeanFill.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMeanFill.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMeanFill.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMeanFill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMeanFill.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(70)))));
            this.btnMeanFill.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnMeanFill.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnMeanFill.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMeanFill.ForeColor = System.Drawing.Color.White;
            this.btnMeanFill.Location = new System.Drawing.Point(20, 55);
            this.btnMeanFill.Name = "btnMeanFill";
            this.btnMeanFill.Size = new System.Drawing.Size(80, 40);
            this.btnMeanFill.TabIndex = 1;
            this.btnMeanFill.Text = "Mean";
            this.btnMeanFill.Click += new System.EventHandler(this.btnMeanFill_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fill Missing Values By";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtCleanView);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.flowLayoutPanel1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(447, 312);
            this.panel3.TabIndex = 2;
            // 
            // txtCleanView
            // 
            this.txtCleanView.Animated = true;
            this.txtCleanView.BorderColor = System.Drawing.Color.Gray;
            this.txtCleanView.BorderRadius = 1;
            this.txtCleanView.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCleanView.DefaultText = "";
            this.txtCleanView.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCleanView.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCleanView.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCleanView.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCleanView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCleanView.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txtCleanView.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCleanView.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtCleanView.ForeColor = System.Drawing.Color.Silver;
            this.txtCleanView.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCleanView.Location = new System.Drawing.Point(16, 58);
            this.txtCleanView.Multiline = true;
            this.txtCleanView.Name = "txtCleanView";
            this.txtCleanView.PasswordChar = '\0';
            this.txtCleanView.PlaceholderText = "";
            this.txtCleanView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCleanView.SelectedText = "";
            this.txtCleanView.Size = new System.Drawing.Size(413, 254);
            this.txtCleanView.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(429, 58);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(18, 254);
            this.panel5.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 58);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(16, 254);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(447, 58);
            this.panel4.TabIndex = 0;
            // 
            // UC_PC_missing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(70)))));
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UC_PC_missing";
            this.Size = new System.Drawing.Size(756, 393);
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2TextBox txtCleanView;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnMedianFIll;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnModeFill;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnMeanFill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel8;
    }
}
