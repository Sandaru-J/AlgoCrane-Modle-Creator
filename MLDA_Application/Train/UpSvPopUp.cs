using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MLDA_Application.Train
{
    public partial class UpSvPopUp : Form
    {
        bool type;
        public UpSvPopUp()
        {
            InitializeComponent();
            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.RootFolder = Environment.SpecialFolder.Desktop;
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtBxLoc.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnCncl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            type = false;
            txtBxLoc.Text = "none";
            txtFileName.Text = "none";
            DataSent?.Invoke(this, new DataSentEventArgs(txtBxLoc.Text, txtFileName.Text, type));
            this.Close();
        }
        private void btnSavNew_Click(object sender, EventArgs e)
        {
            
            if((string.IsNullOrEmpty(txtBxLoc.Text)) || (string.IsNullOrEmpty(txtFileName.Text)))
            {
                MessageBox.Show("Text Fields are empty to Proceed", "Missing");
            }
            else
            {
                var invalidChars = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());
                var regex = new Regex($"[{Regex.Escape(invalidChars)}]");
                if (regex.IsMatch(txtFileName.Text))
                {
                    MessageBox.Show("Invalid Naming Convention", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFileName.Text = " ";
                }
                else if (txtFileName.Text.Length > 260)
                {
                    MessageBox.Show("Charachter Counts Exceeded", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFileName.Text = " ";
                }
                else
                {
                    type = true;
                    DataSent?.Invoke(this, new DataSentEventArgs(txtBxLoc.Text, txtFileName.Text,type));
                    this.Close();
                    //Console.WriteLine(txtBxLoc.Text);
                }
            }
        }
        public event EventHandler<DataSentEventArgs> DataSent;
    }
    public class DataSentEventArgs : EventArgs
    {
        public string Input1 { get; }
        public string Input2 { get; }
        public bool Type { get; }

        public DataSentEventArgs(string input1, string input2,bool type)
        {
            Input1 = input1;
            Input2 = input2;
            Type=type;
        }
    }
}
