using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MLDA_Application.Shared;

namespace MLDA_Application.Preparation.PreProcess
{
    public partial class frmP_pp : Form
    {
        string path;
        string filePath;
        public frmP_pp()
        {
            InitializeComponent();
            txtbxPP.Padding = new Padding(15, 5, 5, 5);

            filePath = PathModel.Path;
        }

        public void updatetext(string text)
        {
            txtbxPP.Text +=Environment.NewLine + text;
            txtbxPP.SelectionStart = txtbxPP.TextLength;
            txtbxPP.ScrollToCaret();
        }

        private void btnNormalize_Click(object sender, EventArgs e)
        {
            uC_Normalize1.BringToFront();
        }
        private void btnscaling_Click(object sender, EventArgs e)
        {
            uC_Encoding1.BringToFront();
        }
        private void txtbxPP_KeyPress(object sender, KeyPressEventArgs e)
        {
            filePath = PathModel.Path;
            path = filePath;

            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                //string command = textBox1.Text.Trim(); // Get the input from the TextBox and trim any leading/trailing whitespace

                string output = string.Empty; // Variable to store the output of the command

                string[] lines = txtbxPP.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
                string command = lines[lines.Length - 1];
                if (command == "help")
                {
                    string helpList = " " +
                        "head: show the head of the data set." +
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
                        txtbxPP.AppendText(helpItem.Trim() + Environment.NewLine);
                    }
                    command = string.Empty;
                }
                if (command == "clear")
                {
                    txtbxPP.Clear();
                    command = string.Empty;
                }
                if (command != string.Empty)
                {
                    CliSwitch cs = new CliSwitch();
                    output = cs.Switch(command, path);
                }

                // Append the output to the TextBox
                txtbxPP.AppendText(output + Environment.NewLine);

                //textBox1.Clear(); // Clear the input TextBox
            }
        }
    }
}
