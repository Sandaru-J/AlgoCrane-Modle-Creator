using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MLDA_Application.Shared
{
    public partial class DfUpload : Form
    {
        public DfUpload()
        {
            InitializeComponent();
            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV files (*.csv)|*.csv";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtUpFileLoc.Text = openFileDialog.FileName;
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            bool isConnected = false;
            try
            {
                using (var client = new WebClient())
                using (var stream = client.OpenRead("https://www.google.com"))
                {
                    isConnected = true;
                }
            }
            catch
            {
                isConnected = false;
                MessageBox.Show("No Network Connection Found", "Network Error");
                return;
            }
            string name = txtUpFileName.Text;
            string path = txtUpFileLoc.Text;
            Console.WriteLine("Name of the uploading file: " + name);
            Console.WriteLine("Path of the uploading file: " + path);
            if ((string.IsNullOrEmpty(txtUpFileLoc.Text) || txtUpFileLoc.Text == txtUpFileLoc.PlaceholderText)
                || (string.IsNullOrEmpty(txtUpFileName.Text) || txtUpFileName.Text == txtUpFileName.PlaceholderText))
            {
                MessageBox.Show("Enter a name and a location", "Missed");
            }
            else
            {
                MongoCon mongoCon = new MongoCon();
                bool upload = mongoCon.insertCsv(name, path);
                if (upload)
                {
                    MessageBox.Show("File Sucessfully to Database", "Sucess");
                    Dispose();
                }
                else
                {
                    MessageBox.Show("File Uploading Failed", "Error");
                }
            }
        }

        private void btnCancl_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
