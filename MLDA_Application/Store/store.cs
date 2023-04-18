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

namespace MLDA_Application.Store
{
    public partial class store : Form
    {
        string df_ID;
        string df_link;
        public store()
        {
            InitializeComponent();
            MongoCon conObj = new MongoCon();
            //DgvModel.AutoGenerateColumns = false;
            refreshDgv();
        }

        public void refreshDgv()
        {
            MongoCon mongoCon = new MongoCon();
            DgvDFData.DataSource = mongoCon.DgvData();
            //DgvDFData.Columns[3].Visible = false;
            DgvDFData.Columns[4].Visible = false;
            DgvDFData.Columns[5].Visible = false;

            DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
            column1.HeaderText = "Project Name";
            column1.DataPropertyName = "Pname"; // Set the DataPropertyName to the corresponding field name in the data source

            // Define column 2 for "model_name"
            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
            column2.HeaderText = "Model Name";
            column2.DataPropertyName = "Mname"; // Set the DataPropertyName to the corresponding field name in the data source

            // Add columns to DataGridView
            DGVModelData.Columns.Add(column1);
            DGVModelData.Columns.Add(column2);


            DGVModelData.DataSource = mongoCon.DgvModel();

            DGVModelData.Columns[3].Visible = false;
            DGVModelData.Columns[4].Visible = false;
            DGVModelData.Columns[5].Visible = false;

            //DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
            ////column1.HeaderText = "Project Name";
            column1.DataPropertyName = "Pname"; // Set the DataPropertyName to the corresponding field name in the data source

            // Define column 2 for "model_name"
            //DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
            //column2.HeaderText = "Model Name";
            //column2.DataPropertyName = "Mname"; // Set the DataPropertyName to the corresponding field name in the data source

            // Add columns to DataGridView
            DGVModelData.Columns.Add(column1);
            DGVModelData.Columns.Add(column2);
        }

        private void DgvDFData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBxDfname.Text = DgvDFData.CurrentRow.Cells[0].Value.ToString();
            txtBxPath.Text= DgvDFData.CurrentRow.Cells[1].Value.ToString();
            txtBxPrjctNme.Text= DgvDFData.CurrentRow.Cells[2].Value.ToString();
            //Console.WriteLine("does it " + DgvDFData.CurrentRow.Cells[5].Value.ToString());
            //txtBxLink.Text= DgvDFData.CurrentRow.Cells[3].Value.ToString();
            df_ID = DgvDFData.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnUpld_Click(object sender, EventArgs e)
        {
            MongoCon mongoCon = new MongoCon();
            if(string.IsNullOrEmpty(txtBxDfname.Text)||(string.IsNullOrEmpty(txtBxPath.Text)))
                {
                MessageBox.Show("File path and name are required", "Missing");
            }else
            {
                mongoCon.UploadCsv(txtBxPrjctNme.Text, txtBxDfname.Text, txtBxPath.Text, txtBxLink.Text);
                cleartxts(1);
            }
        }

        private void btnPathselcect_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtBxPath.Text = openFileDialog1.FileName;
                //modelfile = openFileDialog1.FileName;
            }
        }

        private void tableLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnUpMod_Click(object sender, EventArgs e)
        {
            MongoCon mongoCon = new MongoCon();
            if (string.IsNullOrEmpty(txtBxModName.Text) || (string.IsNullOrEmpty(txtBxModelfile.Text)))
            {
                MessageBox.Show("Model File and name are required", "Missing");
            }
            else
            {
                mongoCon.UploadModelFile(txtBxPrjctNmMod.Text,txtBxModName.Text,txtBxModelfile.Text);
                refreshDgv();
                cleartxts(2);
            }
        }

        private void btnChoseModel_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                txtBxModelfile.Text = openFileDialog2.FileName;
                //modelfile = openFileDialog1.FileName;
            }
        }

        private void btnDwnldModel_Click(object sender, EventArgs e)
        {
            MongoCon mongoCon = new MongoCon();
            if (string.IsNullOrEmpty(txtBxModName.Text))
            {
                MessageBox.Show("Model name is required to download", "Missing");
            }
            else
            {
                mongoCon.DownloadModelFile(txtBxModName.Text);
                cleartxts(2);
            }
        }

        private void DGVModelData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Check if there is a selected row
                if (DGVModelData.CurrentRow != null && DGVModelData.CurrentRow.Cells.Count > 1)
                {
                    // Access the values of the selected row
                    txtBxPrjctNmMod.Text = DGVModelData.CurrentRow.Cells[0].Value?.ToString();
                    txtBxModName.Text = DGVModelData.CurrentRow.Cells[1].Value?.ToString();
                }
            }
        }

        private void btnDlte_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(df_ID))
            {
                MessageBox.Show("No row is selected to delete. Click on a row to Delete", "Not Selected");
            }else
            {
                //Console.WriteLine("ID from Store: " + df_ID);
                MongoCon con = new MongoCon();
                con.DltDF(df_ID);
                refreshDgv();
                cleartxts(1);
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(df_ID))
            {
                MessageBox.Show("No row is selected to Update. Click on a row to Delete", "Not Selected");
            }
            else
            {
                MongoCon con = new MongoCon();
                con.UpdDf(df_ID, txtBxPrjctNme.Text, txtBxDfname.Text, txtBxPath.Text, txtBxLink.Text);
                refreshDgv();
                cleartxts(1);
            }
               
        }

        private void btnDltMod_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBxModName.Text))
            {
                MessageBox.Show("Enter Model Name to Delete", "Not Selected");
            }
            else
            {
                MongoCon con = new MongoCon();
                con.DltModel(txtBxModName.Text);
                refreshDgv();
                cleartxts(2);
            }
               
        }

        private void btnCancl_Click(object sender, EventArgs e)
        {
            /*foreach (Control control in tableLayoutPanel4.Controls)
            {
                // Check if the control is a TextBox
                if (control is TextBox textBox)
                {
                    // Clear the text of the TextBox
                    textBox.Clear();
                }
            }*/
            cleartxts(1);
        }

        private void btnCnclMod_Click(object sender, EventArgs e)
        {
            cleartxts(2);
        }

        public void cleartxts(int x)
        {
            if(x==1)
            {
                txtBxPrjctNme.Text = " ";
                txtBxDfname.Text = " ";
                txtBxLink.Text = " ";
                txtBxPath.Text = " ";
            }
            else
            {
                txtBxPrjctNmMod.Text = " ";
                txtBxModName.Text = " ";
                txtBxModelfile.Text = " ";
            }
        }
    }
}
