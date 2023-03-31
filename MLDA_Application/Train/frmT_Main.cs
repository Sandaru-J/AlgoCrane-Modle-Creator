using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MLDA_Application.Train
{
    public partial class frmT_Main : Form
    {
        int smplvalue=50;
        int splitRatio = 50;
        
        string colName;
        string colValue;
        
        string filename;
        string path;
        
        string con_cols;
        string targetCol;
        
        string trainCols;
        string trainTargt;

        string mdlName;
        string mdlLoc;

        int noOfCols;
        int btnSub = 0;
        int algobtn = 1;
        //string csv_path = @"C:\Users\Sandaru\Desktop\Sophia\Datasets\Iris set\iris_test.csv";
        //string csv_path = @"C:\Users\Sandaru\Desktop\Sophia\Datasets\UnListed\Medical\insurance.csv";
        string csv_path = @"C:\Users\Sandaru\Desktop\Sophia\Datasets\UnListed\Ca  Housing Prices\housing.csv";
        public frmT_Main()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        public void preTrainScript(int flag1)
        {
            int button = flag1;
            string python_Interpreter_Path = @"C:\Users\Sandaru\AppData\Local\Programs\Python\Python310\python.exe";
            string python_Script_Path = @"C:\Users\Sandaru\Desktop\FDAML\Testing\pyScripts\preInfo.py";
            //string csv_path = @"C:\Users\Sandaru\Desktop\Sophia\Datasets\UnListed\Medical\insurance.csv";
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

        private void guna2TrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
           
        }

        private void guna2TrackBar1_ValueChanged(object sender, EventArgs e)
        {
            smplvalue = guna2TrackBar1.Value;
            label6.Text = smplvalue.ToString() + "%";
        }
        private void btnFitter_Click(object sender, EventArgs e)
        {
            colName = txtSFcolName.Text.ToString();
            colValue=txtSfvalue.Text.ToString();
            if(colValue.Length < 0 && colName.Length <0)
            {
                txtBxCmd.Text = txtBxCmd.Text + "Enter values to Filtter";
            }else
            {
                fiterSmple(2);
            }
            
        }
        private void fiterSmple(int flag1)
        {
            int fBtn = flag1;
            string python_Interpreter_Path = @"C:\Users\Sandaru\AppData\Local\Programs\Python\Python310\python.exe";
            string python_Script_Path = @"C:\Users\Sandaru\Desktop\FDAML\Testing\pyScripts\sampling.py";
            //string csv_path = @"C:\Users\Sandaru\Desktop\Sophia\Datasets\UnListed\MelBon Housing\melb_data.csv";
            //string csv_path = @filePath;

            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = python_Interpreter_Path;
            start.Arguments = $"\"{python_Script_Path}\"" +
                                $" \"{csv_path}\"" +
                                $" \"{fBtn}\""+
                                $" \"{smplvalue}\""+
                                $" \"{colName}\""+
                                $" \"{colValue}\""+
                                $" \"{path}\"" +
                                $" \"{filename}\"" ;
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            start.CreateNoWindow = true;

            //Console.WriteLine("set:" + csv_path);
            // Start the process and get the output
            using (Process process = Process.Start(start))
            {
                // Read the output from the Python script
                string output = process.StandardOutput.ReadToEnd();

                txtBxCmd.Text = txtBxCmd.Text + output;
                txtBxCmd.SelectionStart = txtBxCmd.TextLength;
                txtBxCmd.ScrollToCaret();
            }
        }

        private void btnSmpl_Click(object sender, EventArgs e)
        {
            fiterSmple(4);
        }

        private void btnFiterSav_Click(object sender, EventArgs e)
        {
            //UpSvPopUp svPopUp = new UpSvPopUp(filename,path);
            //DialogResult result = svPopUp.ShowDialog();

            var popUpForm = new UpSvPopUp();
            popUpForm.DataSent += PopUpForm_DataSent;
            popUpForm.ShowDialog();
            //Console.WriteLine("fdsa:" + filename + " " + path);
        }
        private void PopUpForm_DataSent(object sender, DataSentEventArgs e)
        {
            //Transfer the data from the pop-up form to the main form
            //txtBxCmd.Text = e.Input1;
            
            //txtBxCmd.Text = e.Input2;

            Console.WriteLine(e.Input2 + e.Input1+e.Type);
            if (e.Type)
            {
                filename = e.Input1;
                path= e.Input2;
                fiterSmple(1);
            }
            if(!e.Type)
            {
                
                fiterSmple(5);
            }
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            txtBxCon_Cols.Text = "All Columns Selected";
            btnSub = 1;
        }
        public void featureSelect(int button)
        {
            int featureBtn = button;
            string python_Interpreter_Path = @"C:\Users\Sandaru\AppData\Local\Programs\Python\Python310\python.exe";
            string python_Script_Path = @"C:\Users\Sandaru\Desktop\FDAML\Project\ML_DataAnalyzer\MLDA_scripts\FeatureSelect.py";
            //string csv_path = @"C:\Users\Sandaru\Desktop\Sophia\Datasets\UnListed\Medical\insurance.csv";
            //string csv_path = @filePath;

            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = python_Interpreter_Path;
            start.Arguments = $"\"{python_Script_Path}\"" +
                                $" \"{csv_path}\"" +
                                $" \"{featureBtn}\""+
                                $" \"{con_cols}\"" +
                                $" \"{targetCol}\"" +
                                $" \"{noOfCols}\""+
                                $" \"{btnSub}\"";
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            start.CreateNoWindow = true;

            //Console.WriteLine("set:" + csv_path);
            // Start the process and get the output
            using (Process process = Process.Start(start))
            {
                // Read the output from the Python script
                string output = process.StandardOutput.ReadToEnd();

                txtBxCmd.Text = txtBxCmd.Text + output;
                txtBxCmd.SelectionStart = txtBxCmd.TextLength;
                txtBxCmd.ScrollToCaret();
            }
        }

        private void btnPrintCol_Click(object sender, EventArgs e)
        {
            featureSelect(1);
        }

        private void BtnCheckFeSe_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(txtBxCon_Cols.Text)) ||
                (string.IsNullOrEmpty(txtBx_targtCol.Text)) || 
                (string.IsNullOrEmpty(NuUpD_no_of_cols.Value.ToString())))
            {
                MessageBox.Show("Text Fields are empty to Proceed", "Missing");
            }
            else
            {
                con_cols= txtBxCon_Cols.Text;
                targetCol = txtBx_targtCol.Text;
                noOfCols = (int)NuUpD_no_of_cols.Value;
                featureSelect(2);
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            txtBx_targtCol.Text = " ";
            txtBxCon_Cols.Text = " ";
            NuUpD_no_of_cols.ResetText();
            //featureSelect(5);
        }

        private void BtnMse_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(txtBxCon_Cols.Text)) ||
               (string.IsNullOrEmpty(txtBx_targtCol.Text)) ||
               (string.IsNullOrEmpty(NuUpD_no_of_cols.Value.ToString())))
            {
                MessageBox.Show("Text Fields are empty to Proceed", "Missing");
            }
            else
            {
                con_cols = txtBxCon_Cols.Text;
                targetCol = txtBx_targtCol.Text;
                noOfCols = (int)NuUpD_no_of_cols.Value;
                featureSelect(3);
            }
        }

        private void BtnRSq_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(txtBxCon_Cols.Text)) ||
               (string.IsNullOrEmpty(txtBx_targtCol.Text)) ||
               (string.IsNullOrEmpty(NuUpD_no_of_cols.Value.ToString())))
            {
                MessageBox.Show("Text Fields are empty to Proceed", "Missing");
            }
            else
            {
                con_cols = txtBxCon_Cols.Text;
                targetCol = txtBx_targtCol.Text;
                noOfCols = (int)NuUpD_no_of_cols.Value;
                featureSelect(4);
            }
        }

        private void guna2TrackBar2_ValueChanged(object sender, EventArgs e)
        {
            splitRatio = guna2TrackBar2.Value;
            label15.Text = splitRatio.ToString()+"%";
        }

        public void TrainScript(int flag1)
        {
            int btn = flag1;
            string python_Interpreter_Path = @"C:\Users\Sandaru\AppData\Local\Programs\Python\Python310\python.exe";
            string python_Script_Path = @"C:\Users\Sandaru\Desktop\FDAML\Project\ML_DataAnalyzer\MLDA_scripts\Train&Model.py";
            //string csv_path = @"C:\Users\Sandaru\Desktop\Sophia\Datasets\UnListed\Medical\insurance.csv";
            //string csv_path = @filePath;

            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = python_Interpreter_Path;
            start.Arguments = $"\"{python_Script_Path}\"" +
                                $" \"{csv_path}\""+
                                $" \"{btn}\"" +
                                $" \"{trainCols}\""+
                                $" \"{trainTargt}\""+
                                $" \"{splitRatio}\""+
                                $" \"{algobtn}\""+
                                $" \"{mdlName}\"" +
                                $" \"{mdlLoc}\"" ;
                               
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            start.CreateNoWindow = true;

            // Start the process and get the output
            using (Process process = Process.Start(start))
            {
                // Read the output from the Python script
                string output = process.StandardOutput.ReadToEnd();

                txtBxCmd.Text = txtBxCmd.Text + output;
                txtBxCmd.SelectionStart = txtBxCmd.TextLength;
                txtBxCmd.ScrollToCaret();
            }
        }

        private void btnTrain_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(txtTrainCol.Text)) ||
               (string.IsNullOrEmpty(txtBxTrainTarget.Text)))
            {
                MessageBox.Show("Text Fields are empty to Proceed", "Missing");
            }
            else
            {
                trainCols = txtTrainCol.Text;
                trainTargt = txtBxTrainTarget.Text;
                TrainScript(1);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            algobtn = 1;
            guna2Button3.Checked = false;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            algobtn = 0;
            guna2Button2.Checked = false;
        }

        private void txtBxModLoc_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                /*
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    txtBxModLoc.Text= openFileDialog1.FileName;
                    //filePath = openFileDialog1.FileName;
                    //ucM.SetFilePath(filePath);
                    //fileName = Path.GetFileName(openFileDialog1.FileName);
                }
                else
                {

                }
                */
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                folderBrowserDialog.RootFolder = Environment.SpecialFolder.Desktop;
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    txtBxModLoc.Text = folderBrowserDialog.SelectedPath;
                    mdlLoc = folderBrowserDialog.SelectedPath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        private void btnMdlCreate_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(txtBxModLoc.Text)) || 
                (string.IsNullOrEmpty(txtBxModelNme.Text)) ||
                (string.IsNullOrEmpty(txtTrainCol.Text)) ||
                (string.IsNullOrEmpty(txtBxTrainTarget.Text)))
            {
                MessageBox.Show("Text Fields are empty to Proceed", "Missing");
            }
            else
            {
                var invalidChars = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());
                var regex = new Regex($"[{Regex.Escape(invalidChars)}]");
                if (regex.IsMatch(txtBxModelNme.Text))
                {
                    MessageBox.Show("Invalid Naming Convention", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBxModelNme.Text = " ";
                }
                else if (txtBxModelNme.Text.Length > 260)
                {
                    MessageBox.Show("Charachter Counts Exceeded", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBxModelNme.Text = " ";
                }
                else
                {
                    mdlName = txtBxModelNme.Text;
                    mdlLoc = txtBxModLoc.Text;
                    TrainScript(2);
                    //Console.WriteLine(txtBxLoc.Text);
                }
            }
        }
    }
}
