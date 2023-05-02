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

namespace MLDA_Application.Template
{
    public partial class FrmTemp_Main : Form
    {
        int lblCnt = 0;
        int txtCnt = 0;
        int inputCnt;

        string modelPath;

        double[] txtBxArray;
        double[] listArray;
        string[] colList;

        List<List<double>> list = new List<List<double>>();
        List<string> MethodList = new List<string>();
        public FrmTemp_Main()
        {
            InitializeComponent();
            btnAddLbl.Enabled = false;
            btnAddTxtBx.Enabled = false;
        }

        public bool addLayout()
        {
            int rowcount = (int)NuUpDLayout.Value + 2;
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

            //string method = "Layout";
            string command = "Layout" + "," + rowcount;
            MethodList.Add(command);
            return true;
        }

        public bool addLbl()
        {
            int X = 0;
            int Y = (int)NuUpDLblRow.Value;
            string z = "New label";
            z = txtBxLblName.Text;
            Label label2 = new Label();
            label2.Text = z;
            label2.AutoSize = true;
            label2.Anchor = AnchorStyles.None;

            label2.Font = new Font("Arial", 11, FontStyle.Regular);
            label2.ForeColor = Color.WhiteSmoke;
            //label2.BackColor = Color.Yellow;
            label2.TextAlign = ContentAlignment.MiddleCenter;

            TableLayoutPanel tableLayoutPanel1 = pnlTemplate.Controls.OfType<TableLayoutPanel>().FirstOrDefault();
            tableLayoutPanel1.Controls.Add(label2, X, Y);

            txtBxLblName.Text = " ";

            string command = "Label" + "," + Y + "," + z;
            MethodList.Add(command);

            return true;
        }

        public bool addTextBox()
        {
            int X = 1;
            int Y = (int)NuUpDtxtRow.Value;

            TextBox textBox1 = new TextBox();
            //textBox1.Text = "still nothing";
            //textBox1.Dock = DockStyle.Fill;
            textBox1.Anchor = AnchorStyles.None;

            textBox1.Font = new Font("Arial", 10, FontStyle.Regular);
            textBox1.ForeColor = Color.Black;
            textBox1.BackColor = Color.White;
            textBox1.Multiline = true;
            textBox1.TextAlign = HorizontalAlignment.Left;
            textBox1.BorderStyle = BorderStyle.FixedSingle;

            TableLayoutPanel tableLayoutPanel1 = pnlTemplate.Controls.OfType<TableLayoutPanel>().FirstOrDefault();
            tableLayoutPanel1.Controls.Add(textBox1, X, Y);

            string command = "Input" + "," + Y;
            MethodList.Add(command);
            inputCnt++;
            return true;
        }

        private void btnTempName_Click(object sender, EventArgs e)
        {
            lblTemplateName.Text = txtBxTempName.Text;
            string command = "Template" + "," + txtBxTempName.Text;
            MethodList.Add(command);
        }

        private void btnAddLayout_Click(object sender, EventArgs e)
        {
            if (NuUpDLayout.Value == 0)
            {
                MessageBox.Show("Select Layout Count accordint to the no of inputs", "Invaliid attempt");
            }
            else
            {
                if (addLayout())
                {
                    btnAddLbl.Enabled = true;
                    btnAddTxtBx.Enabled = true;
                }
            }
            btnAddLayout.Enabled = false;
        }

        private void btnAddLbl_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(txtBxLblName.Text)))
            {
                MessageBox.Show("Enter a Name for Label", "Missing Field");
            }
            else if (lblCnt == NuUpDLblRow.Value)
            {
                MessageBox.Show("Change the Row count. Already, label in selected Row", "Invaliid attempt");
            }
            else
            {
                addLbl();
                lblCnt++;
            }
        }

        private void btnAddTxtBx_Click(object sender, EventArgs e)
        {
            if (txtCnt == NuUpDtxtRow.Value)
            {
                MessageBox.Show("Change the Row count. Already, textBox in selected Row", "Invaliid attempt");
            }
            else
            {
                addTextBox();
                txtCnt++;
            }
        }

        private bool txtExtract()
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
                                Console.WriteLine(labelText);
                            }
                            else if (innerControl is TextBox textBox)
                            {
                                string textBoxText = textBox.Text;
                                //..............................................................class1
                                Console.WriteLine("class 1: " + textBoxText);

                                //index = index++; 

                                // Store the textbox value in the array
                                textboxValues.Add(textBoxText);
                                //Console.WriteLine($"Textbox to {index}: {textboxValues[index]}");
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
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("Invalid Data Type.Check data type required to fill.", "Type Error");
                return false;
            }
            //Console.WriteLine(" afasd" + listArray.Length);
        }
        private void txtBxMdlChose_MouseClick(object sender, MouseEventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtBxMdlChose.Text = openFileDialog1.FileName;
                //modelfile = openFileDialog1.FileName;
                //modelPath = openFileDialog1.FileName;
            }
        }

        private void btnImprtMdl_Click(object sender, EventArgs e)
        {
            modelPath = openFileDialog1.FileName;
            string command = "Model" + "," + modelPath;
            MethodList.Add(command);

            btnImprtMdl.Enabled = false;
        }

        private void txtBxTmpLoc_MouseClick(object sender, MouseEventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.RootFolder = Environment.SpecialFolder.Desktop;
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtBxTmpLoc.Text = folderBrowserDialog.SelectedPath;
                //mdlLoc = folderBrowserDialog.SelectedPath;
            }
        }
        public bool savTmp()
        {
            string fileName = txtBxTmpSavName.Text;
            string fileLoc = txtBxTmpLoc.Text;

            var invalidChars = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());
            var regex = new System.Text.RegularExpressions.Regex($"[{Regex.Escape(invalidChars)}]");
            if (regex.IsMatch(fileName))
            {
                MessageBox.Show("Invalid Naming Convention", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                fileName = " ";
                return false;
            }
            else if (fileName.Length > 260)
            {
                MessageBox.Show("Charachter Counts Exceeded", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                fileName = " ";
                return false;
            }


            // Combine the file name and path into a single string
            string fullFilePath = Path.Combine(fileLoc, fileName);

            // Create the file (if it doesn't already exist)
            using (StreamWriter writer = new StreamWriter(fullFilePath))
            {
                foreach (string s in MethodList)
                {
                    writer.WriteLine(s);
                }
            }

            // Set the 'ReadOnly' attribute of the file to true
            File.SetAttributes(fullFilePath, FileAttributes.ReadOnly);
            return true;
        }

        private void btnSavTmp_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(txtBxTempName.Text)))
            {
                MessageBox.Show("You have not Given a Name for Template", "No Name");
            }
            else if (txtCnt == 0 || lblCnt == 0)
            {
                MessageBox.Show("No components Added to Template", "No Template");
            }
            else if ((string.IsNullOrEmpty(txtBxTmpSavName.Text)) ||
                (string.IsNullOrEmpty(txtBxTmpLoc.Text)))
            {
                MessageBox.Show("Fill the Required fields to Save", "Missing Fields");
            }
            else if ((string.IsNullOrEmpty(modelPath)))
            {
                MessageBox.Show("No Model File Selected. If selected Please click the import Button", "Model missing");
            }
            else if(!testTemplate())
            {
                MessageBox.Show("Input field count and required filed counts are different", "Failed");
                clearInputs();
            }
            else
            {
                if (savTmp())
                {
                    MessageBox.Show("Template File Saved Sucessfully", "Sucess");
                    clearInputs();
                }
                else
                {
                    MessageBox.Show("Template Saving failed", "Failed");
                    foreach (Control c in tableLayoutPanel7.Controls)
                    {
                        if (c is Guna.UI2.WinForms.Guna2TextBox)
                        {
                            ((Guna.UI2.WinForms.Guna2TextBox)c).Text = "";
                        }
                    }
                }
            }
        }

        private void clearInputs()
        {
            MethodList.Clear();
            modelPath = null;
            txtBxArray = null;
            txtOutptPnl.Text = " ";

            foreach (Control c in tableLayoutPanel3.Controls)
            {
                if (c is Guna.UI2.WinForms.Guna2TextBox)
                {
                    ((Guna.UI2.WinForms.Guna2TextBox)c).Text = "";
                }
            }
            NuUpDLayout.Value = NuUpDLayout.Minimum;
            NuUpDLblRow.Value = NuUpDLblRow.Minimum;
            NuUpDtxtRow.Value = NuUpDtxtRow.Minimum;

            foreach (Control c in tableLayoutPanel6.Controls)
            {
                if (c is Guna.UI2.WinForms.Guna2TextBox)
                {
                    ((Guna.UI2.WinForms.Guna2TextBox)c).Text = "";
                }
            }
            foreach (Control c in tableLayoutPanel7.Controls)
            {
                if (c is Guna.UI2.WinForms.Guna2TextBox)
                {
                    ((Guna.UI2.WinForms.Guna2TextBox)c).Text = "";
                }
            }

            lblCnt = 0;
            txtCnt = 0;
            inputCnt = 0;
        }
        private void BtnReset_Click(object sender, EventArgs e)
        {
            pnlTemplate.Controls.Clear();
            clearInputs();
            btnAddLayout.Enabled = true;
            lblTemplateName.Text = "Template";
            btnSavTmp.Enabled = true;
        }

        public void runModel()
        {
            //txtExtract();
            string python_Interpreter_Path = @"C:\Users\Sandaru\AppData\Local\Programs\Python\Python310\python.exe";
            string python_Script_Path = @"C:\Users\Sandaru\Desktop\FDAML\Project\ML_DataAnalyzer\MLDA_scripts\runModel.py";
            string modelpath = modelPath;
            //double[] inputArray= { 10, 15 };
            double[] inputArray = txtBxArray;
            string inputSet = string.Join(",", inputArray.Select(v => v.ToString()));

            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = python_Interpreter_Path;
            start.Arguments = $"\"{python_Script_Path}\"" +
                                $" \"{modelpath}\" " +
                                $"\"{inputSet}\"";

            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            start.CreateNoWindow = true;

            // Start the process and get the output
            using (Process process = Process.Start(start))
            {
                // Read the output from the Python script
                string output = process.StandardOutput.ReadToEnd();

                //Console.WriteLine(output);
                txtOutptPnl.Text = "Predicted value: " + output;
                double doubleOut = double.Parse(output);

                Array.Resize(ref listArray, listArray.Length + 1);
                listArray[listArray.Length - 1] = doubleOut;
                list.Add(listArray.ToList());
            }
        }

        private void btnPrcd_Click(object sender, EventArgs e)
        {
            if (txtExtract() || modelPath != null)
            {
                if (modelPath != null)
                {
                    runModel();
                }
                else
                {
                    MessageBox.Show("Model not imported correctly", "Error");
                }
            }
            else
            {
                MessageBox.Show("Text Fields are empty to Proceed", "Missing");
            }
        }
        private string mdlChck()
        {
            string python_Interpreter_Path = @"C:\Users\Sandaru\AppData\Local\Programs\Python\Python310\python.exe";
            string python_Script_Path = @"C:\Users\Sandaru\Desktop\FDAML\Project\ML_DataAnalyzer\MLDA_scripts\chckInputs.py";
            string modelpath = txtBxMdlChose.Text;

            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = python_Interpreter_Path;
            start.Arguments = $"\"{python_Script_Path}\"" +
                                $" \"{modelpath}\" ";
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            start.CreateNoWindow = true;

            // Start the process and get the output
            using (Process process = Process.Start(start))
            {
                // Read the output from the Python script
                string output = process.StandardOutput.ReadToEnd();

                //Console.WriteLine(output);
                //txtOutptPnl.Text = output;
                return output;
            }
        }

        private void btnChkMdl_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(txtBxMdlChose.Text)))
            {
                MessageBox.Show("No Model Seltected to Check", "No Model");
            }
            //else if ((string.IsNullOrEmpty(modelPath)))
            //{
              //  MessageBox.Show("If choosed a Model Please Click the Import Model Button", "Not Assigned");
            //}
            else
            {
                txtOutptPnl.Text = "The model requires "+ mdlChck() +" input(s).";
            }
        }

        private bool testTemplate()
        {
                //Console.WriteLine(mdlChck() + " " + inputCnt);
                string tempMdlCnt = mdlChck();
                int mdlCnt = Int32.Parse(tempMdlCnt);
                if(mdlCnt != inputCnt)
                {
                    return false;
                    //MessageBox.Show("Input field count and required filed counts are different", "Failed");
                }
                else
                {
                    return true;
                }
        }

        private void btnTestTemplate_Click(object sender, EventArgs e)
        {

            if (txtCnt == 0 || lblCnt == 0)
            {
                MessageBox.Show("No components Added to Template", "No template");
            }
            else if ((string.IsNullOrEmpty(txtBxMdlChose.Text)))
            {
                MessageBox.Show("No Model Imported to Check", "No Model");
            }else if (testTemplate())
            {
                MessageBox.Show("Input field count and required field counts are equal. Test passed.", "Sucess");
            }else
            {
                MessageBox.Show("Input field count and required field counts are different. Test Failed.", "Failed");
            }
        }
        private void btnMdlCncl_Click(object sender, EventArgs e)
        {
            string remove = "Model";
            MethodList.RemoveAll(method => method.Contains(remove));
            txtBxMdlChose.Text = " ";

            btnImprtMdl.Enabled = true;
        }

        private void btnOpnPrdctr_Click(object sender, EventArgs e)
        {
            if((string.IsNullOrEmpty(TxtBxChooseTemp.Text)))
            {
                MessageBox.Show("No Template Choosed. Click text box to choose", "No Template");
            }else
            {
                Frm_Predictor frmObj = new Frm_Predictor(TxtBxChooseTemp.Text);
                frmObj.Show();
                TxtBxChooseTemp.Text = " ";
            }
            
        }

        private void TxtBxChooseTemp_MouseClick(object sender, MouseEventArgs e)
        {
            //openFileDialog2.Filter = "Text files (*.txt)|*.txt";
            openFileDialog2.ReadOnlyChecked = true;
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                TxtBxChooseTemp.Text = openFileDialog2.FileName;
                //modelfile = openFileDialog1.FileName;
                //modelPath = openFileDialog1.FileName;
            }
        }

        private void btnTmpCncl_Click(object sender, EventArgs e)
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
