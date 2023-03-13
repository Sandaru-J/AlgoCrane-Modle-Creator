using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MLDA_Application.Preparation.PreProcess
{
    public partial class frmP_pp : Form
    {
        public frmP_pp()
        {
            InitializeComponent();
            txtbxPP.Padding = new Padding(15, 5, 5, 5);
        }

        public void updatetext(string text)
        {
            txtbxPP.Text +=Environment.NewLine + text;
            txtbxPP.SelectionStart = txtbxPP.TextLength;
            txtbxPP.ScrollToCaret();
            
        }
    }
}
