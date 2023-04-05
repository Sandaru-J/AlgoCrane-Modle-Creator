using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MLDA_Application.Shared;

namespace MLDA_Application.Preparation.PreProcess
{
    public partial class UC_Encoding : UserControl
    {
        int technique = 1;
        int encdType = 1;
        int outputType = 1;
        int unData = 1;
        int scale = 1;

        private bool btnTechnique=false;
        public string filePath;
        public string fileName;
        public UC_Encoding()
        {
            InitializeComponent();
            filePath = PathModel.Path;
            fileName = PathModel.Name;
        }

        public bool DfChekc()
        {
            if (filePath == null)
            {
                DialogResult result = MessageBox.Show("You Have not selected any DataSets." +
                    "Click Refresh to if already Selected.",
                    "Warning", MessageBoxButtons.RetryCancel);
                if (result == DialogResult.Retry)
                {
                    filePath = PathModel.Path;
                    fileName = PathModel.Name;
                    //if (filePath != null)
                    //{
                    //txtCleanView.Text += txtCleanView.Text + "File " + fileName + " Selected."+"\r";
                    //}
                    if (filePath == null)
                    {
                        MessageBox.Show("You Have not Selected");
                        return false;
                    }
                    return true;
                }
                return false;
            }
            return true;
        }
        private void encode()
        {
            bool check = DfChekc();
            if (!check)
            {
                return;
            }
            string python_Interpreter_Path = @"C:\Users\Sandaru\AppData\Local\Programs\Python\Python310\python.exe";
            string python_Script_Path = @"C:\Users\Sandaru\Desktop\FDAML\Project\ML_DataAnalyzer\MLDA_scripts\pp_encoding.py";
            //string csv_path = @"C:\Users\Sandaru\Desktop\Sophia\Datasets\UnListed\Medical\insurance.csv";
            string csv_path = @filePath;

            int init;
            int task;
            //string std  = txtStd.Text;
            double std = 0.1;

            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = python_Interpreter_Path;
            start.Arguments = $"\"{python_Script_Path}\"" +
                                $" \"{csv_path}\"" +
                                //$" \"{init}\"" +
                                $" \"{technique}\"" +
                                $" \"{outputType}\"" +
                                $" \"{unData}\"" +
                                $" \"{scale}\"";
                               
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            start.CreateNoWindow = true;

            prepareModel ps = new prepareModel();
            ps.path = csv_path;

            // Start the process and get the output
            using (Process process = Process.Start(start))
            {
                while (!process.StandardOutput.EndOfStream)
                {
                    string line = process.StandardOutput.ReadLine();
                    frmP_pp pp = (frmP_pp)this.ParentForm;
                    pp.updatetext(line);
                    Thread.Sleep(200);
                }
                // Read the output from the Python script
                //string output = process.StandardOutput.ReadToEnd();

                //frmP_pp pp = (frmP_pp)this.ParentForm;
                //pp.updatetext(output);
            }
            //btnPrcd.Text = "Proceed";
        }

        private void btnLabel_Click(object sender, EventArgs e)
        {
            btnTechnique = true;
            btnNeClm.Enabled = false;
            btnMstCmn.Enabled = false;
            btnSpecial.Enabled = true;
            btnRolace.Enabled = true;
            btnIgnre.Enabled = true;
            btnOneHot.Checked = false;
            btnOrdinal.Checked = false;

            technique = 1;

            frmP_pp pp = (frmP_pp)this.ParentForm;
            pp.updatetext("Label Encoding Selected");
        }

        private void btnOneHot_Click(object sender, EventArgs e)
        {
            btnTechnique = true;
            btnscYes.Enabled = false;
            btnNeClm.Enabled = false;
            btnSpecial.Enabled = false;
            btnRolace.Enabled = true;
            btnIgnre.Enabled = true;
            btnMstCmn.Enabled = true;
            btnLabel.Checked = false;
            btnOrdinal.Checked = false;

            technique = 2;

            frmP_pp pp = (frmP_pp)this.ParentForm;
            pp.updatetext("One-Hot Encoding Selected");
        }

        private void btnOrdinal_Click(object sender, EventArgs e)
        {
            btnTechnique = true;
            btnMstCmn.Enabled = false;
            btnSpecial.Enabled = false;
            btnRolace.Enabled = true;
            btnIgnre.Enabled = true;
            btnNeClm.Enabled=true;
            btnscYes.Enabled=true;
            btnLabel.Checked=false;
            btnOneHot.Checked = false;

            technique = 3;

            frmP_pp pp = (frmP_pp)this.ParentForm;
            pp.updatetext("Ordinal Encoding Selected.");
        }
        private void btnRolace_Click(object sender, EventArgs e)
        {
            outputType = 1;
            btnNeClm.Checked = false;
        }

        private void btnNeClm_Click(object sender, EventArgs e)
        {
            outputType=2;
            btnRolace.Checked = false;
        }

        private void btnIgnre_Click(object sender, EventArgs e)
        {
            unData = 1;
            btnMstCmn.Checked = false;
            btnSpecial.Checked = false;
        }

        private void btnMstCmn_Click(object sender, EventArgs e)
        {
            unData=2;
            btnIgnre.Checked = false;
            btnSpecial.Checked = false;
        }

        private void btnSpecial_Click(object sender, EventArgs e)
        {
            unData=3;
            btnMstCmn.Checked = false;
            btnIgnre.Checked = false;
        }

        private void btnscYes_Click(object sender, EventArgs e)
        {
            scale = 2;
            btnSclNo.Checked = false;
        }

        private void btnSclNo_Click(object sender, EventArgs e)
        {
            scale=1;
            btnscYes.Checked = false;
        }
        private void btnPrcd_Click(object sender, EventArgs e)
        {
            btnPrcd.Text = "Proceeding";
            
            this.btnPrcd.Text = "dsafd";
            if (btnTechnique)
            {
                frmP_pp pp = (frmP_pp)this.ParentForm;
                pp.updatetext("Proceeding...");
                encode();
            }else
            {
                DialogResult result=MessageBox.Show("You Have not selected any techniqes. " +
                    "Encoding will perform with defalut settings",
                    "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if(result==DialogResult.OK)
                {
                    frmP_pp pp = (frmP_pp)this.ParentForm;
                    pp.updatetext("Proceeding....");
                    encode();
                }
                else
                {
                    return;
                }
            }
            btnReset();
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnReset();            
        }
        public void btnReset()
        {
            /* not working this
            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    Button button = (Button)control;
                    button.Enabled = true;
                    button.Text = "changed";
                    button.FlatStyle = FlatStyle.Standard;
                    button.BackColor = SystemColors.Control;
                    button.ForeColor = SystemColors.ControlText;
                    btnCancel.Text = "Canceled";
                }
            }
            */
            btnOneHot.Checked = false;
            btnLabel.Checked = false;
            btnOrdinal.Checked = false;

            btnIgnre.Enabled = true;
            btnNeClm.Enabled = true;
            btnRolace.Enabled = true;
            btnSclNo.Enabled = true;
            btnscYes.Enabled = true;
            btnSpecial.Enabled = true;
            btnMstCmn.Enabled = true;

            btnIgnre.Checked= false;
            btnNeClm.Checked= false;
            btnRolace.Checked= false;
            btnSclNo.Checked= false;
            btnscYes.Checked= false;
            btnSpecial.Checked= false;
            btnMstCmn.Checked= false;

            btnPrcd.Text = "Proceed";
        }
    }
}
