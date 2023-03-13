﻿using System;
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

namespace MLDA_Application.Preparation.PreProcess
{
    public partial class UC_Normalize : UserControl
    {
        private frmP_pp FrmP_pp;
        int Max=1;
        int Min=0;
        int Std = 1;
        int Method = 1;
        public UC_Normalize()
        {
            InitializeComponent();
        }

        private void btnMinMax_Click(object sender, EventArgs e)
        {
            //btnMinMax.FillColor = Color.White;
            txtStd.Enabled = false;
            NuupdMin.Enabled = true;
            NuupdMax.Enabled = true;
            Method = 1;
            frmP_pp pp = (frmP_pp)this.ParentForm;
            pp.updatetext("MinMax Scaler Selected");
            //normalize();
        }
        
        public void normalize(int flag1)
        {
            string python_Interpreter_Path = @"C:\Users\Sandaru\AppData\Local\Programs\Python\Python310\python.exe";
            string python_Script_Path = @"C:\Users\Sandaru\Desktop\FDAML\Testing\pyScripts\cusNomlz.py";
            string csv_path = @"C:\Users\Sandaru\Desktop\Sophia\Datasets\UnListed\Medical\insurance.csv";
            //string csv_path = @filePath;
            
            int init;
            int method = Method;
            int min = (int)NuupdMin.Value;
            int max = (int)NuupdMax.Value;
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
                                $" \"{task}\"";
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
        }

        private void BtnZcore_Click(object sender, EventArgs e)
        {
            //BtnZcore.FillColor = Color.Red;
            txtStd.Enabled = true;
            NuupdMax.Enabled = false;
            NuupdMin.Enabled = false;
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
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            normalize(2);
        }
    }
}
