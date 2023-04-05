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
using MLDA_Application.Shared;

namespace MLDA_Application.Preparation
{
    public partial class UC_PC_missing : UserControl
    {
        private prepareModel model;
        public Timer timer1;

        public string filePath;
        public string fileName;

        public UC_PC_missing()
        {
            InitializeComponent();
            txtCleanView.Padding = new Padding(15, 5, 5, 5);
            model = new prepareModel();
            //string x = get();
            filePath = PathModel.Path;
            fileName = PathModel.Name;

        }
        public bool DfChekc()
        {
            if (filePath == null)
            {
                DialogResult result = MessageBox.Show("You Have not selected any DataSets." +
                    "Click Refresh to if already Selected.",
                    "Warning",MessageBoxButtons.RetryCancel);
                if (result == DialogResult.Retry)
                {
                    filePath = PathModel.Path;
                    fileName= PathModel.Name;
                    //if (filePath != null)
                    //{
                        //txtCleanView.Text += txtCleanView.Text + "File " + fileName + " Selected."+"\r";
                    //}
                    if(filePath == null)
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
        public void kick()
        {
            /*
            filePath = PathModel.Path;
            Console.WriteLine("Kicked: " + filePath);
            if (this.IsHandleCreated)
            {
                // Update the label and text box on the UI thread
                this.Invoke((MethodInvoker)delegate {
                    label3.Text = filePath;
                    txtCleanView.Text = txtCleanView.Text + "File path just changed to: " + filePath;
                });
            }*/
        }
        public string dsetInfo(int flag1, int flag2,int flag3, int flag4)
        {
            bool check = DfChekc();
            if (!check)
            {
                return null;
            }
            string python_Interpreter_Path = @"C:\Users\Sandaru\AppData\Local\Programs\Python\Python310\python.exe";
            string python_Script_Path = @"C:\Users\Sandaru\Desktop\FDAML\Project\ML_DataAnalyzer\MLDA_scripts\pc_missing.py";
            //string csv_path = @"C:\Users\Sandaru\Desktop\Sophia\Datasets\UnListed\Trunfo AirPlanes\airplanes.csv";
            string csv_path = @filePath;

            int init=flag1;
            int mean=flag2;
            int mode=flag3;
            int median=flag4;

            int check_string = flag1;
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = python_Interpreter_Path;
            start.Arguments = $"\"{python_Script_Path}\"" +
                                $" \"{csv_path}\"" +
                                $" \"{init}\"" +
                                $" \"{mean}\"" +
                                $" \"{mode}\"" +
                                $" \"{median}\"";
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
                string output = process.StandardOutput.ReadToEnd();

                txtCleanView.Text =txtCleanView.Text+ output;
                txtCleanView.SelectionStart = txtCleanView.TextLength;
                txtCleanView.ScrollToCaret();
                return output;
            }
        }

        private string dupplicate(int flag1)
        {
            bool check = DfChekc();
            if (!check)
            {
                return null;
            }
            string python_Interpreter_Path = @"C:\Users\Sandaru\AppData\Local\Programs\Python\Python310\python.exe";
            string python_Script_Path = @"C:\Users\Sandaru\Desktop\FDAML\Project\ML_DataAnalyzer\MLDA_scripts\pc_duplicate.py";
            //string csv_path = @"C:\Users\Sandaru\Desktop\Sophia\Datasets\UnListed\Medical\insurance.csv";
            string csv_path = filePath;

            int init = flag1;
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = python_Interpreter_Path;
            start.Arguments = $"\"{python_Script_Path}\"" +
                                $" \"{csv_path}\"" +
                                $" \"{init}\""; 
                                //$" \"{mean}\"" +
                                //$" \"{mode}\"" +
                                //$" \"{median}\"";

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
                string output = process.StandardOutput.ReadToEnd();

                txtCleanView.Text = txtCleanView.Text + output;
                txtCleanView.SelectionStart = txtCleanView.TextLength;
                txtCleanView.ScrollToCaret();
                return output;
            }
        }
        private void btnMeanFill_Click(object sender, EventArgs e)
        {
            dsetInfo(0, 2, 0, 0);
        }

        private void guna2GradientTileButton2_Click(object sender, EventArgs e)
        {
            dsetInfo(0, 0, 3, 0);
        }

        private void guna2GradientTileButton3_Click(object sender, EventArgs e)
        {
            dsetInfo(0, 0, 0, 4);
        }

        private void btnMCheck_Click(object sender, EventArgs e)
        {
            dsetInfo(1, 0, 0, 0);
        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {
            dupplicate(1);
        }
    }
}
