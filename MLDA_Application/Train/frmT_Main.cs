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

namespace MLDA_Application.Train
{
    public partial class frmT_Main : Form
    {
        public frmT_Main()
        {
            InitializeComponent();
        }

        public void preTrainScript(int flag1)
        {
            int button = flag1;
            string python_Interpreter_Path = @"C:\Users\Sandaru\AppData\Local\Programs\Python\Python310\python.exe";
            string python_Script_Path = @"C:\Users\Sandaru\Desktop\FDAML\Testing\pyScripts\preInfo.py";
            string csv_path = @"C:\Users\Sandaru\Desktop\Sophia\Datasets\UnListed\Trunfo AirPlanes\airplanes.csv";
            //string csv_path = @filePath;
            Console.WriteLine("path in csvupLoad: " + csv_path);

            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = python_Interpreter_Path;
            start.Arguments = $"\"{python_Script_Path}\"" +
                                $" \"{csv_path}\""+
                                $" \"{button}\"";
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            start.CreateNoWindow = true;

            //Console.WriteLine("set:" + csv_path);
            // Start the process and get the output
            using (Process process = Process.Start(start))
            {
                // Read the output from the Python script
                string output = process.StandardOutput.ReadToEnd();

                txtBxCmd.Text=txtBxCmd.Text + output;
                txtBxCmd.SelectionStart = txtBxCmd.TextLength;
                txtBxCmd.ScrollToCaret();
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            preTrainScript(9);
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            preTrainScript(0);
        }

        private void btnNumeric_Click(object sender, EventArgs e)
        {
            preTrainScript(1);
        }

        private void btnNon_Click(object sender, EventArgs e)
        {
            preTrainScript(2);
        }

        private void btnLinerity_Click(object sender, EventArgs e)
        {
            preTrainScript(5);
        }
        private void btnDuplct_Click(object sender, EventArgs e)
        {
            preTrainScript(4);
        }
        private void btnMissing_Click(object sender, EventArgs e)
        {
            preTrainScript(3);
        }

        private void btnNormality_Click(object sender, EventArgs e)
        {
            preTrainScript(6);
        }

        private void btnHead_Click(object sender, EventArgs e)
        {
            preTrainScript(7);
        }

        private void btnTail_Click(object sender, EventArgs e)
        {
            preTrainScript(8);
        }
    }
}
