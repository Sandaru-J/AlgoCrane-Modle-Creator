using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MLDA_Application.Template
{
    public partial class Frm_Predictor : Form
    {
        string modelFile;
        double[] txtBxArray;
        double[] listArray;
        string[] colList;
        string path;
        List<List<double>> list = new List<List<double>>();
        public Frm_Predictor(string tempPath)
        {
            InitializeComponent();
            path = tempPath;
            readMethods();
        }

        public bool readMethods()
        {
            //string path = "C:\\Users\\Sandaru\\Desktop\\testTemplate1.txt"; // replace with the path to your file
            //string path = TemplatePath;

            if (File.Exists(path))
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length >= 2)
                        {
                            string l = "Template";
                            string method = parts[0];
                            string output = " ";
                            //int y = int.Parse(parts[1]);
                            //l=parts[2];
                            if (method == "Template")
                            {
                                lblTemplateName.Text = parts[1];
                            }
                            else if (method == "Model")
                            {
                                modelFile = parts[1];
                                //Console.WriteLine($"Method: {method}, Path: {modelFile}");
                            }
                            else if (method == "Layout")
                            {
                                int y = int.Parse(parts[1]);
                                addLayout(y);
                                //Console.WriteLine($"Method: {method}, Rows: {y}");
                            }
                            else if (method == "Label")
                            {
                                int y = int.Parse((parts[1]));
                                l = parts[2];
                                addLbl(y, l);
                                //Console.WriteLine($"Method: {method}, Row: {y}, Text:{l}");
                            }
                            else if (method == "Input")
                            {
                                int y = int.Parse(parts[1]);
                                addtxtBx(y);
                                //Console.WriteLine($"Method: {method}, Row: {y}");
                            }
                            else
                            {
                                MessageBox.Show("Invalid file or Template", "Invalid Type");
                                return false;
                            }
                            txtOutptPnl.Text = output;
                            // Do something with the name and age variables
                            //Console.WriteLine($"Name: {method}, Age: {y}");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine($"File '{path}' not found.");
                return false;
            }

            return true;
        }

        public bool addLayout(int rowcount)
        {
            rowcount = rowcount + 2;
            TableLayoutPanel tableLayoutPanel1 = new TableLayoutPanel();

            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.BackColor = Color.DimGray;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.RowCount = rowcount;

            for (int i = 0; i < rowcount; i++)
            {
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F / rowcount)); // add rows with equal percentage height
            }
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));

            // Add the TableLayoutPanel to the Panel
            tableLayoutPanel1.Parent = pnlTemplate;

            return true;
        }
        public bool addLbl(int y, string text)
        {
            int X = 0;
            string z = "New label";
            Label label2 = new Label();
            label2.Text = text;
            label2.AutoSize = true;
            label2.Anchor = AnchorStyles.None;

            label2.Font = new Font("Arial", 11, FontStyle.Regular);
            label2.ForeColor = Color.WhiteSmoke;
            //label2.BackColor = Color.Yellow;
            label2.TextAlign = ContentAlignment.MiddleCenter;

            TableLayoutPanel tableLayoutPanel1 = pnlTemplate.Controls.OfType<TableLayoutPanel>().FirstOrDefault();
            tableLayoutPanel1.Controls.Add(label2, X, y);

            return true;
        }
        public bool addtxtBx(int y)
        {
            int X = 1;

            TextBox textBox1 = new TextBox();
            //textBox1.Text = "still nothing";
            //textBox1.Dock = DockStyle.Fill;
            textBox1.Anchor = AnchorStyles.None;

            TableLayoutPanel tableLayoutPanel1 = pnlTemplate.Controls.OfType<TableLayoutPanel>().FirstOrDefault();
            tableLayoutPanel1.Controls.Add(textBox1, X, y);
            return true;
        }

        public bool extractVals()
        {
            List<string> textboxValues = new List<string>();
            List<string> lableVals = new List<string>();
            // Loop through each control in the panel
            foreach (Control control in pnlTemplate.Controls)
            {
                // Check if the control is a TableLayoutPanel
                if (control is TableLayoutPanel tableLayoutPanel)
                {
                    // Loop through each row in the table
                    for (int row = 0; row < tableLayoutPanel.RowCount; row++)
                    {
                        // Loop through each column in the row
                        for (int col = 0; col < tableLayoutPanel.ColumnCount; col++)
                        {
                            Control innerControl = tableLayoutPanel.GetControlFromPosition(col, row);

                            if (innerControl is Label label)
                            {
                                string labelText = label.Text;
                                lableVals.Add(labelText);
                                //Console.WriteLine(labelText);
                            }
                            else if (innerControl is TextBox textBox)
                            {
                                string textBoxText = textBox.Text;
                                //..............................................................class1
                                //Console.WriteLine("class 1: " + textBoxText);

                                //index = index++; 

                                // Store the textbox value in the array
                                textboxValues.Add(textBoxText);
                                //Console.WriteLine($"Textbox to {index}: {textboxValues[index]}");
                                //Console.WriteLine(textBox.Text);
                            }
                            else if (innerControl is TableLayoutPanel innerTableLayoutPanel)
                            {
                                // If the control is a nested TableLayoutPanel, recursively iterate over its controls
                                for (int innerRow = 0; innerRow < innerTableLayoutPanel.RowCount; innerRow++)
                                {
                                    for (int innerCol = 0; innerCol < innerTableLayoutPanel.ColumnCount; innerCol++)
                                    {
                                        Control innerInnerControl = innerTableLayoutPanel.GetControlFromPosition(innerCol, innerRow);
                                        Console.WriteLine("In Nested");
                                        if (innerInnerControl is Label innerLabel)
                                        {
                                            string innerLabelText = innerLabel.Text;
                                        }
                                        else if (innerInnerControl is TextBox innerTextBox)
                                        {
                                            string innerTextBoxText = innerTextBox.Text;
                                            Console.WriteLine("class 2" + innerTextBox);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                else if (control is Label label)
                {
                    string labelText = label.Text;
                    Console.WriteLine("Here 1");
                }
                else if (control is TextBox textBox)
                {
                    string textBoxText = textBox.Text;
                    Console.WriteLine("class 3" + textBoxText);
                }
            }
            string[] txtValArray = textboxValues.ToArray();
            colList = lableVals.ToArray();

            double[] valArray = new double[txtValArray.Length];
            try
            {
                for (int i = 0; i < txtValArray.Length; i++)
                {
                    valArray[i] = double.Parse(txtValArray[i]);
                }

                txtBxArray = valArray;
                listArray = valArray;
                if (txtBxArray.Length > 0)
                {
                    //list.Add(txtBxArray.ToList());
                    return true;
                }
                else
                {
                    MessageBox.Show("No Texts.", "Type Error");
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("Invalid Data Type or Empty Fields. Check data type required to fill.", "Type Error");
                return false;
            }
        }
        public void runModel()
        {
            //txtExtract();
            string python_Interpreter_Path = @"C:\Users\Sandaru\AppData\Local\Programs\Python\Python310\python.exe";
            string python_Script_Path = @"C:\Users\Sandaru\Desktop\FDAML\Project\ML_DataAnalyzer\MLDA_scripts\runModel.py";
            string modelPath = modelFile;
            ;
            //double[] inputArray= { 10, 15 };
            double[] inputArray = txtBxArray;
            string inputSet = string.Join(",", inputArray.Select(v => v.ToString()));

            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = python_Interpreter_Path;
            start.Arguments = $"\"{python_Script_Path}\"" +
                                $" \"{modelPath}\" " +
                                $"\"{inputSet}\"";

            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            start.CreateNoWindow = true;

            // Start the process and get the output
            using (Process process = Process.Start(start))
            {
                // Read the output from the Python script
                string output = process.StandardOutput.ReadToEnd();

                if(output.Contains("size Error"))
                {
                    MessageBox.Show("Template not matched with the model", "Mismatched Error");
                }
                else
                {
                    txtOutptPnl.Text = "Predicted value: " + output;

                    foreach (Control c in tableLayoutPanel1.Controls)
                    {
                        if (c is Guna.UI2.WinForms.Guna2TextBox)
                        {
                            ((Guna.UI2.WinForms.Guna2TextBox)c).Text = "";
                        }
                    }
                }
                
                //double doubleOut = double.Parse(output);

                //Array.Resize(ref listArray, listArray.Length + 1);
                //listArray[listArray.Length - 1] = doubleOut;
                //list.Add(listArray.ToList());
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {

            if (extractVals())
            {
                if (txtBxArray == null)
                {
                    MessageBox.Show("Text Fields are empty to proceed", "No inputs");
                }
                else if (modelFile == null)
                {
                    MessageBox.Show("No model add to templae", "No Model");
                }
                //else if (extractVals())
                //{
                    //runModel();
                //}
                else
                {
                    runModel();
                    //MessageBox.Show("Invalid Attempt", "Error");
                }
            }
            else
            {
                //MessageBox.Show("Invalid Attempt", "Error");
                return;
            }

            /*
            if(txtBxArray != null || modelFile !=null)
            {
                if(extractVals())
                {
                    runModel();
                }
                else if( txtBxArray == null )
                {
                    MessageBox.Show("Text Fields are empty to proceed", "No inputs");
                }
            }
            else
            {
                MessageBox.Show("Invalid Attempt","Error");
            }
            */
        }

        private void btnCncl_Click(object sender, EventArgs e)
        {
            foreach (Control cntrl in pnlTemplate.Controls)
            {
                if (cntrl is TableLayoutPanel tbl)
                {
                    for (int row = 0; row < tbl.RowCount; row++)
                    {
                        // Loop through each column in the row
                        for (int col = 0; col < tbl.ColumnCount; col++)
                        {
                            Control innerControl = tbl.GetControlFromPosition(col, row);

                            if (innerControl is TextBox textBox)
                            {
                                textBox.Text = " ";
                            }
                        }
                    }
                }
            }
            txtOutptPnl.Clear();
        }
    }
}
