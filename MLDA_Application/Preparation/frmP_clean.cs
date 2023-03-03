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

namespace MLDA_Application.Preparation
{
    public partial class frmP_clean : Form
    {
        public frmP_clean()
        {
            InitializeComponent();
            listBox1.Padding= new Padding(15, 5, 5, 5);
            bindList();
            uC_PC_missing1.Visible = false;
        }

        private void btnMissingval_Click(object sender, EventArgs e)
        {
            uC_PC_missing1.Show();
        }

        private void bindList()
        {
            MongoCon mongoCon = new MongoCon();
            listBox1.DataSource = mongoCon.dataList();
        }
    }
}
