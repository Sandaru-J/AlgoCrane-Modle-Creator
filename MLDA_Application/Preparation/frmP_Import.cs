using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MLDA_Application.Preparation.Shared;

namespace MLDA_Application.Preparation
{

    public partial class frmP_Import : Form
    {
        public string filePath;
        private UC_PC_missing ucM;
        public string fileName;
        public frmP_Import()
        {
            InitializeComponent();
            ucM = new UC_PC_missing();
            txtDsInfo.Padding= new Padding(15,5,5,5);
            panel4.Visible = false;
            panel3.Visible = false;
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(guna2TextBox1.Text))
            {
                DialogResult result = MessageBox.Show("Please Select a file to Upload", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    return;
                }
            }
            else
            {
                ShowTable(guna2TextBox1.Text);
                lblDsFileName.Text = Path.GetFileName(openFileDialog1.FileName);
                panel2.Visible = false;
                panel3.Visible = true;
                panel4.Visible = true;
                dSetInfo();
            }                                            
        }

        public void guna2TextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    guna2TextBox1.Text = openFileDialog1.FileName;
                    Console.WriteLine("imported: " + guna2TextBox1.Text);
                    filePath = openFileDialog1.FileName;
                    ucM.SetFilePath(filePath);
                    fileName=Path.GetFileName(openFileDialog1.FileName);
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        private void ShowTable(string filepath)
        {
            DataTable dt = new DataTable();
            string[] lines = System.IO.File.ReadAllLines(filepath);
            if (lines.Length > 0)
            {
                string firstLine = lines[0];
                string[] headerLabels = firstLine.Split(',');

                foreach (string headerWord in headerLabels)
                {
                    dt.Columns.Add(new DataColumn(headerWord));
                }
                for (int r = 1; r < lines.Length; r++)
                {
                    string[] datawords = lines[r].Split(',');
                    DataRow dr = dt.NewRow();
                    int coloumIndex = 0;
                    foreach (string headerword in headerLabels)
                    {
                        if(coloumIndex<datawords.Length)
                        {
                            dr[headerword] = datawords[coloumIndex++];
                        }else
                        {
                            dr[headerword] = null;
                            label1.Text = "This file has already Extracted"; 
                                }
                        
                    }
                    dt.Rows.Add(dr);
                }
            }

            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }

            SetScrollBar();
        }

        private void SetScrollBar()
        {
            int numRows = dataGridView1.Rows.Count;
            int numVisibleRows = dataGridView1.DisplayedRowCount(true);

            guna2VScrollBar1.Maximum = dataGridView1.RowCount - 10;
            guna2HScrollBar1.Maximum = dataGridView1.ColumnCount - 1;
            
            Console.WriteLine(numRows + " " + numVisibleRows);
            /*
            if (numVisibleRows > numRows)
            {
                guna2VScrollBar1.Maximum = numRows - 1;
                int scrollBarSize = guna2VScrollBar1.Height * numVisibleRows / numRows;
                guna2VScrollBar1.LargeChange = numVisibleRows;
                guna2VScrollBar1.SmallChange = 1;
                guna2VScrollBar1.Width = SystemInformation.VerticalScrollBarWidth;
                guna2VScrollBar1.Height = scrollBarSize;
                guna2VScrollBar1.Visible = true;
            }
            else
            {
                guna2VScrollBar1.Visible = false;
            }
            */
        }

        private void guna2VScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            dataGridView1.FirstDisplayedScrollingRowIndex = guna2VScrollBar1.Value;
        }

        private void guna2HScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
                dataGridView1.FirstDisplayedScrollingColumnIndex = guna2HScrollBar1.Value;
        }
        public string dSetInfo()
        {
            // console.WriteLine("Hello World!");
            string python_Interpreter_Path = @"C:\Users\Sandaru\AppData\Local\Programs\Python\Python310\python.exe";
            string python_Script_Path = @"C:\Users\Sandaru\Desktop\FDAML\Project\ML_DataAnalyzer\MLDA_scripts\pi_import.py";
            //string csv_path = @"C:\Users\Sandaru\Desktop\Sophia\Datasets\UnListed\Medical\insurance.csv";
            string csv_path = @filePath;
            Console.WriteLine("path in csvupLoad: " + csv_path);

            string check_string = "testing 1";
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = python_Interpreter_Path;
            start.Arguments = $"\"{python_Script_Path}\" \"{csv_path}\" \"{check_string}\"";
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            start.CreateNoWindow = true;

            prepareModel ps = new prepareModel();
            ps.path = csv_path;
            
            Console.WriteLine("set:"+csv_path);
            // Start the process and get the output
            using (Process process = Process.Start(start))
            {
                // Read the output from the Python script
                string output = process.StandardOutput.ReadToEnd();

                //Console.WriteLine(output);
                txtDsInfo.Text = output;
                return filePath;
            }
        }

        private void btnExtract_Click(object sender, EventArgs e)
        {
           uplPopUp uplPopUp = new uplPopUp(fileName,filePath);
            DialogResult result= uplPopUp.ShowDialog();

        }
    }
}
