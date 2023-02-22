using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MLDA_Application.Preparation
{
    public partial class frmP_clean : Form
    {
        public frmP_clean()
        {
            InitializeComponent();
            uC_PC_missing1.Visible = false;
        }

        private void btnMissingval_Click(object sender, EventArgs e)
        {
            uC_PC_missing1.Show();
        }
    }
}
