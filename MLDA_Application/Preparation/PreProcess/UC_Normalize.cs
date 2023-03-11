using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MLDA_Application.Preparation.PreProcess
{
    public partial class UC_Normalize : UserControl
    {
        private frmP_pp FrmP_pp;
        public UC_Normalize()
        {
            InitializeComponent();
        }

        private void btnMinMax_Click(object sender, EventArgs e)
        {
            txtStd.Enabled = false;
            normalize();
        }
        
        public void normalize()
        {
            /*
            string python_Interpreter_Path = @"C:\Users\Sandaru\AppData\Local\Programs\Python\Python310\python.exe";
            string python_Script_Path = @"C:\Users\Sandaru\Desktop\FDAML\Project\ML_DataAnalyzer\MLDA_scripts\pc_missing.py";
            string csv_path = @"C:\Users\Sandaru\Desktop\Sophia\Datasets\UnListed\MelBon Housing\melb_data.csv";
            //string csv_path = @filePath;
     

            int init = flag1;
            string method = flag2;
            int min = flag3;
            int max = flag3;
            float std  = flag4;

            int check_string = flag1;
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = python_Interpreter_Path;
            start.Arguments = $"\"{python_Script_Path}\"" +
                                $" \"{csv_path}\"" +
                                $" \"{init}\"" +
                                $" \"{method}\"" +
                                $" \"{min}\"" +
                                $" \"{max}\""+
                                $" \"{std}\"";
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            start.CreateNoWindow = true;

            prepareModel ps = new prepareModel();
            ps.path = csv_path;

            Console.WriteLine("set:" + csv_path);
            // Start the process and get the output
            using (Process process = Process.Start(start))
            {
                // Read the output from the Python script
                //string output = process.StandardOutput.ReadToEnd();

                frmP_pp pp = (frmP_pp)this.ParentForm;
                pp.updatetext(output);
                //txtCleanView.Text = txtCleanView.Text + output;
                //txtCleanView.SelectionStart = txtCleanView.TextLength;
                //txtCleanView.ScrollToCaret();
            }*/
            string output = "System is Acessing data from user control";
            frmP_pp pp = (frmP_pp)this.ParentForm;
            pp.updatetext(output);
        }
    }
}
