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

namespace MLDA_Application.Preparation
{
    public partial class UC_PC_missing : UserControl
    {
        private prepareModel model;
        private string x;
        public Timer timer1;

        public UC_PC_missing()
        {
            InitializeComponent();
            txtCleanView.Padding = new Padding(15, 5, 5, 5);
            model = new prepareModel();
            string x = get();
            Console.WriteLine("water:"+x);
            dsetInfo(1, 0, 0, 0);
            
        }
        public void SetFilePath(string filePath)
        {
            model.path = filePath;
        }
        public string get()
        {
            return model.path;
        }

        public string dsetInfo(int flag1, int flag2,int flag3, int flag4)
        {
            
            string python_Interpreter_Path = @"C:\Users\Sandaru\AppData\Local\Programs\Python\Python310\python.exe";
            string python_Script_Path = @"C:\Users\Sandaru\Desktop\FDAML\Project\ML_DataAnalyzer\MLDA_scripts\pc_missing.py";
            string csv_path = @"C:\Users\Sandaru\Desktop\Sophia\Datasets\UnListed\MelBon Housing\melb_data.csv";
            //string csv_path = @filePath;
            Console.WriteLine("path in csvupLoad: " + csv_path);

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
    }
}
