﻿using System;
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
        
        int saveCheck =0;

        string TrgtCol;

        string path;
        public UC_PC_missing()
        {
            InitializeComponent();
            guna2Panel1.Visible = false;
            txtCleanView.Padding = new Padding(15, 5, 5, 5);
            model = new prepareModel();
            //string x = get();
            filePath = PathModel.Path;
            fileName = PathModel.Name;
        }
        public void rerfreshDF()
        {
            filePath = PathModel.Path;
            fileName = PathModel.Name;
            string dfText = fileName + "New Dataset Loaded.";
            txtCleanView.Text = txtCleanView.Text + dfText;
            txtCleanView.SelectionStart = txtCleanView.TextLength;
            txtCleanView.ScrollToCaret();
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
        public string dsetInfo(int flag1)
        {
            filePath=PathModel.Path;
            //Console.WriteLine("call from script " + filePath);
            if (chckBxClean.Checked)
            {
                saveCheck = 1;
            }
            bool check = DfChekc();
            if (!check)
            {
                return null;
            }
            string python_Interpreter_Path = @"C:\Users\Sandaru\AppData\Local\Programs\Python\Python310\python.exe";
            string python_Script_Path = @"C:\Users\Sandaru\Desktop\FDAML\Project\ML_DataAnalyzer\MLDA_scripts\pc_missing.py";
            //string csv_path = @"C:\Users\Sandaru\Desktop\Sophia\Datasets\UnListed\Trunfo AirPlanes\airplanes.csv";
            string csv_path = @filePath;

            int btn=flag1;

            int check_string = flag1;
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = python_Interpreter_Path;
            start.Arguments = $"\"{python_Script_Path}\"" +
                                $" \"{csv_path}\"" +
                                $" \"{btn}\"" +
                                $" \"{saveCheck}\"";
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
                chckBxClean.Checked = false;
                return output;
            }
        }
        private string dupplicate(int flag1)
        {
            filePath = PathModel.Path;
            if (chckBxClean.Checked)
            {
                saveCheck = 1;
            }
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
                                $" \"{init}\""+
                                $" \"{saveCheck}\""; 
                                //$" \"{mean}\"" +
                                //$" \"{mode}\"" +
                                //$" \"{median}\"";

            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            start.CreateNoWindow = true;

            prepareModel ps = new prepareModel();
            ps.path = csv_path;

            // Start the process and get the output
            using (Process process = Process.Start(start))
            {
                // Read the output from the Python script
                string output = process.StandardOutput.ReadToEnd();

                txtCleanView.Text = txtCleanView.Text + output;
                txtCleanView.SelectionStart = txtCleanView.TextLength;
                txtCleanView.ScrollToCaret();
                chckBxClean.Checked = false;
                return output;
            }
        }
        private void btnMeanFill_Click(object sender, EventArgs e)
        {
            dsetInfo(3);
        }

        private void guna2GradientTileButton2_Click(object sender, EventArgs e)
        {
            dsetInfo(4);
        }

        private void guna2GradientTileButton3_Click(object sender, EventArgs e)
        {
            dsetInfo(5);
        }

        private void btnMCheck_Click(object sender, EventArgs e)
        {
            dsetInfo(1);
            btnDropDup.Enabled = false;
            btnDropOUt.Enabled = false;
            btnRepOUt.Enabled = false;
            btnModeFill.Enabled = true;
            btnMedianFIll.Enabled = true;
            btnMeanFill.Enabled = true;
            btnDropMissing.Enabled=true;
            guna2GradientTileButton1.Checked = false;
        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {
            dupplicate(1);
            btnDropDup.Enabled = true;
            btnMeanFill.Enabled = false;
            btnMedianFIll.Enabled = false;
            btnModeFill.Enabled = false;
            btnDropMissing.Enabled = false;
            btnMCheck.Checked = false;
            btnRepOUt.Enabled=false;
            btnDropOUt.Enabled = false;
        }

        private void btnDropMissing_Click(object sender, EventArgs e)
        {
            dsetInfo(2);
        }

        private void btnDropDup_Click(object sender, EventArgs e)
        {
            dupplicate(2);
        }

        private void chckBxClean_CheckStateChanged(object sender, EventArgs e)
        {
            if(chckBxClean.Checked)
            {
                txtCleanView.Text = txtCleanView.Text + "\nSaving checked";
                txtCleanView.SelectionStart = txtCleanView.TextLength;
                txtCleanView.ScrollToCaret();
            }
            else
            {
                txtCleanView.Text = txtCleanView.Text + "\nSaving Unchecked";
                txtCleanView.SelectionStart = txtCleanView.TextLength;
                txtCleanView.ScrollToCaret();
            }
        }

        private void btnOutlierCheck_Click(object sender, EventArgs e)
        {
            guna2Panel1.Visible = true;
            btnDropDup.Enabled = false;
            btnMeanFill.Enabled = false;
            btnMedianFIll.Enabled = false;
            btnModeFill.Enabled = false;
            btnDropMissing.Enabled = false;
            btnMCheck.Checked = false;
            btnRepOUt.Enabled = true;
            btnDropOUt.Enabled = true;
        }

        private void btnOutlierDne_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBxTargtCol.Text))
            {
                MessageBox.Show("Enter Target Column", "Missing");
            }
            else
            {
                TrgtCol = txtBxTargtCol.Text;
                outlliers(1);
                Console.WriteLine(TrgtCol);
            }
            guna2Panel1.Visible = false;
        }
        public void outlliers(int btn)
        {
            filePath = PathModel.Path;
            if (chckBxClean.Checked)
            {
                saveCheck = 1;
            }
            bool check = DfChekc();
            if (!check)
            {
                return;
            }
            string python_Interpreter_Path = @"C:\Users\Sandaru\AppData\Local\Programs\Python\Python310\python.exe";
            string python_Script_Path = @"C:\Users\Sandaru\Desktop\FDAML\Project\ML_DataAnalyzer\MLDA_scripts\outliers.py";
            //string csv_path = @"C:\Users\Sandaru\Desktop\Sophia\Datasets\UnListed\Trunfo AirPlanes\airplanes.csv";
            string csv_path = @filePath;

            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = python_Interpreter_Path;
            start.Arguments = $"\"{python_Script_Path}\"" +
                                $" \"{csv_path}\"" +
                                $" \"{TrgtCol}\"" +
                                $" \"{btn}\"" +
                                $" \"{saveCheck}\"";
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            start.CreateNoWindow = true;

            // Start the process and get the output
            using (Process process = Process.Start(start))
            {
                // Read the output from the Python script
                string output = process.StandardOutput.ReadToEnd();

                txtCleanView.Text = txtCleanView.Text + output;
                txtCleanView.SelectionStart = txtCleanView.TextLength;
                txtCleanView.ScrollToCaret();
                chckBxClean.Checked = false;
            }
            //guna2Panel1.Visible = false;
        }

        private void btnDropOUt_Click(object sender, EventArgs e)
        {
            outlliers(3);
        }

        private void btnRepOUt_Click(object sender, EventArgs e)
        {
            outlliers(2);
        }

        private void txtCleanView_KeyPress(object sender, KeyPressEventArgs e)
        {
            filePath = PathModel.Path;
            path = filePath;
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; 

                //string command = textBox1.Text.Trim(); // Get the input from the TextBox and trim any leading/trailing whitespace

                string output = string.Empty; // Variable to store the output of the command

                string[] lines = txtCleanView.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
                string command = lines[lines.Length - 1];
                if (command == "help")
                {
                    string helpList = "head: show the head of the data set." +
                        "tail: show the tail of the data set." +
                        "clear: Clear the interface." +
                        "cols: Show columns of the dataset." +
                        "col_d: Show the data types of the data set." +
                        "shape: Length of the columns into rows.";

                    // Append each item in the helpList to the textBoxOutput on a separate line
                    string[] helpItems = helpList.Split('.'); // Split the items by '.' character
                    foreach (string helpItem in helpItems)
                    {
                        // Append the helpItem followed by a new line to the textBoxOutput
                        txtCleanView.AppendText(helpItem.Trim() + Environment.NewLine);
                    }
                    command = string.Empty;
                }
                if (command == "clear")
                {
                    txtCleanView.Clear();
                    command = string.Empty;
                }
                if (command != string.Empty)
                {
                    CliSwitch cs = new CliSwitch();
                    output = cs.Switch(command, path);
                }

                // Append the output to the TextBox
                txtCleanView.AppendText(output + Environment.NewLine);

                //textBox1.Clear(); // Clear the input TextBox
            }
        }
    }
}
