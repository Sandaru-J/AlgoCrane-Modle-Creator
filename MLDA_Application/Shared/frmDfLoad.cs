using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MLDA_Application.Preparation;

namespace MLDA_Application.Shared
{
    public partial class frmDfLoad : Form
    {
        string dfName;
        string dfPath;
        public frmDfLoad()
        {
            InitializeComponent();
            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            bindList();
        }

        private void btnCncl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindList()
        {
            MongoCon mongoCon = new MongoCon();
            guna2DataGridView1.DataSource = mongoCon.DgvData();
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0 && e.ColumnIndex>=0)
            {
                DataGridViewRow row= guna2DataGridView1.Rows[e.RowIndex];
                DataFile dataFile = (DataFile)row.DataBoundItem;

                dfName = dataFile.Name;
                dfPath = dataFile.Path;

                // Print the data for the clicked row
                //Console.WriteLine("Name: " + dataFile.Name);
                //Console.WriteLine("Path: " + dataFile.Path);
            }
        }
        UC_PC_missing ucObj = new UC_PC_missing();
        private void btnLoadDf_Click(object sender, EventArgs e)
        {
            //DataSent?.Invoke(this, new DataSentEventArgs(dfName,dfPath));
            //(this.Owner as FormMain).ReceiveDataFromPopup(dfName, dfPath);
            PathModel.Path = dfPath;
            PathModel.Name = dfName;
            //ucObj.kick();
            Console.WriteLine("Load Clicked");
            this.Close();
        }
       
        public event EventHandler<DataSentEventArgs> DataSent;
    }
    public class DataSentEventArgs : EventArgs
    {
        public string name { get; }
        public string path { get; }
        //public bool Type { get; }

        public DataSentEventArgs(string input1, string input2)
        {
            name = input1;
            path = input2;
        }
    }
}
