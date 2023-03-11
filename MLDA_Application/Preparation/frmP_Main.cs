using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MLDA_Application.Preparation.PreProcess;

namespace MLDA_Application.Preparation
{
    public partial class frmP_Main : Form
    {
        private frmP_Import frmP_Import1;
        private Form currentPchildForm;
        private Form currentUC;
        public frmP_Main()
        {
            InitializeComponent();
            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        public frmP_Import Import_data
        {
            get => default;
            set
            {
            }
        }

        public frmP_clean data_clean
        {
            get => default;
            set
            {
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
           frmP_Import frmP_Import = new frmP_Import();

            frmP_Import.Width = this.Width;
            frmP_Import.Height = this.Height;
        }


        private void OpenPChildForm(Form childForm)
        {
            /*if(currentPchildForm == null)
            {
                currentPchildForm.Close();  
            }
            */
            
            currentPchildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlPfrmHolder.Controls.Add(childForm);
            pnlPfrmHolder.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnCatImport_Click(object sender, EventArgs e)
        {
                OpenPChildForm(new frmP_Import());
        }
        private void FormMainMenu_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                FormBorderStyle = FormBorderStyle.None;
            else
                FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void btnCleaning_Click(object sender, EventArgs e)
        {
                OpenPChildForm(new frmP_clean());
        }

        private void btnCleaning_MouseHover(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(btnCleaning, new Point(0, btnCleaning.Height));
        }
        private void OpenUserControls(Form childForm)
        {
            currentUC = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlPfrmHolder.Controls.Add(childForm);
            pnlPfrmHolder.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
          
        }

        private void btnPreProcess_Click(object sender, EventArgs e)
        {
            OpenPChildForm(new frmP_pp());
        }
    }
}
