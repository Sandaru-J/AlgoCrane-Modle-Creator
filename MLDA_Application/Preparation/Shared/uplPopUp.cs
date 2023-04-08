using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MLDA_Application.Shared;
using System.Net;

namespace MLDA_Application.Preparation.Shared
{
    public partial class uplPopUp : Form
    {
        public string filePath;
        public uplPopUp(string fileName,string path)
        {
            InitializeComponent();
            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;

            txtFileName.Text = fileName;
            filePath = path;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            //FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            //folderBrowserDialog.RootFolder=Environment.SpecialFolder.Desktop;
            //if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
            //{
            //txtFileLoc.Text = folderBrowserDialog.SelectedPath;
            //}
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV files (*.csv)|*.csv";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtFileLoc.Text = openFileDialog.FileName;
            }
        }

        private bool saveFile()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV file (*.csv)|*.csv|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;

            saveFileDialog.InitialDirectory = txtFileLoc.Text;
            saveFileDialog.FileName = txtFileName.Text;

            string csvContent = File.ReadAllText(filePath);

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                {
                    sw.WriteLine(csvContent);
                }
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(btnSave.Text=="Save")
                {
                bool save = saveFile();
                if (save)
                {
                    MessageBox.Show("File Sucessfully saved", "Sucess");
                }
                else
                {
                    MessageBox.Show("File saving failed", "Error");
                }
                btnSave.Text = "Finish";

            }else if(btnSave.Text=="Finish")
            {
                Dispose();
            }
           
        }

        private void btnCancl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            bool isConnected = false;
            try
            {
                using (var client = new WebClient())
                using(var stream = client.OpenRead("https://www.google.com"))
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
            string name = txtFileName.Text;
            string path=txtFileLoc.Text;
            if((string.IsNullOrEmpty(txtFileLoc.Text) || txtFileLoc.Text== txtFileLoc.PlaceholderText)
                || (string.IsNullOrEmpty(txtFileName.Text) || txtFileName.Text==txtFileName.PlaceholderText))
            {
                MessageBox.Show("Enter a name and a location","Missed");
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
    }
}
