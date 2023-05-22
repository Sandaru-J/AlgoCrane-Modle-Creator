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
    public partial class UC_Normalize : UserControl
    {
        private frmP_pp FrmP_pp;
        int Max=1;
        int Min=0;
        int Std = 1;
        int Method = 1;

        int savChck = 0;

        public string filePath;
        public string fileName;
        public UC_Normalize()
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
        private void btnMinMax_Click(object sender, EventArgs e)
        {
            //btnMinMax.FillColor = Color.White;
            //btnMinMax.BorderColor = Color.Black;
            txtStd.Enabled = false;
            NuupdMin.Enabled = true;
            NuupdMax.Enabled = true;
            NupdDcml.Enabled = false;
            Method = 1;
            frmP_pp pp = (frmP_pp)this.ParentForm;
            pp.updatetext("MinMax Scaler Selected");
            //normalize();
        }
        
        public void normalize(int flag1)
        {
            filePath = PathModel.Path;
            Console.WriteLine("DF chek" + filePath);
            if (chckBxSav.Checked)
            {
                savChck = 1;
            }
            bool check = DfChekc();
            if (!check)
            {
                return;
            }
            string python_Interpreter_Path = @"C:\Users\Sandaru\AppData\Local\Programs\Python\Python310\python.exe";
            string python_Script_Path = @"C:\Users\Sandaru\Desktop\FDAML\Project\ML_DataAnalyzer\MLDA_scripts\pp_normalize.py";
            //string csv_path = @"C:\Users\Sandaru\Desktop\Sophia\Datasets\UnListed\Medical\insurance.csv";
            string csv_path = @filePath;
            
            int init;
            int method = Method;
            int min = (int)NuupdMin.Value;
            int max = (int)NuupdMax.Value;
            int dcml=(int)NupdDcml.Value;
            int task = flag1;
            //string std  = txtStd.Text;
            double std = 0.1;
            
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = python_Interpreter_Path;
            start.Arguments = $"\"{python_Script_Path}\"" +
                                $" \"{csv_path}\""+
                                //$" \"{init}\"" +
                                $" \"{method}\"" +
                                $" \"{min}\"" +
                                $" \"{max}\""+
                                $" \"{std}\""+
                                $" \"{dcml}\"" +
                                $" \"{task}\""+
                                $" \"{savChck}\"";
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

            chckBxSav.Checked = false;
        }
        private void BtnZcore_Click(object sender, EventArgs e)
        {
            //BtnZcore.FillColor = Color.Red;
            txtStd.Enabled = true;
            NuupdMax.Enabled = false;
            NuupdMin.Enabled = false;
            NupdDcml.Enabled = false;
            Method = 2;
            frmP_pp pp = (frmP_pp)this.ParentForm;
            pp.updatetext("Zscore Standard Scaler Selected");
        }
        private void btnNrmlzPrcd_Click(object sender, EventArgs e)
        {
            if(NuupdMax.Value<NuupdMin.Value)
            {
                MessageBox.Show("Minimun Range is higher than Maximum Range", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                frmP_pp pp = (frmP_pp)this.ParentForm;
                pp.updatetext("Proceeding");
                normalize(1);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmP_pp pp = (frmP_pp)this.ParentForm;
            pp.updatetext("Process Cancled");

            NuupdMax.Value = 1;
            NuupdMin.Value = 0;
            txtStd.Text = "1";
            BtnZcore.Enabled = true;
            btnMinMax.Enabled = true;
            chckBxSav.Enabled = false;
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            normalize(2);
        }
        private void btnDcmlScl_Click(object sender, EventArgs e)
        {
            NuupdMax.Enabled = false;
            NuupdMin.Enabled = false;
            txtStd.Enabled = false;
            NupdDcml.Enabled = true;
            Method = 3;
            frmP_pp pp = (frmP_pp)this.ParentForm;
            pp.updatetext("Decimal Scalling Selected");
        }
    }
}
