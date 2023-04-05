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

        private frmP_clean instClean;
        private frmP_pp instPreProcess;
        private frmP_Import instImport;
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
            // Check if the child form instance already exists
            foreach (Control control in pnlPfrmHolder.Controls)
            {
                if (control.GetType() == childForm.GetType())
                {
                    // Child form instance already exists, bring it to front
                    control.BringToFront();
                    return;
                }
            }
            currentPchildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlPfrmHolder.Controls.Add(childForm);
            pnlPfrmHolder.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

            currentPchildForm = childForm;
        }

        private void instClean_FormClosed(object sender, FormClosedEventArgs e)
        {
            instClean.FormClosed -= instClean_FormClosed;
            instClean = null;
        }

        private void instPreProcess_FormClosed(object sender, FormClosedEventArgs e)
        {
            instPreProcess.FormClosed -= instPreProcess_FormClosed;
            instPreProcess = null;
        }

        private void instImport_FormClosed(object sender, FormClosedEventArgs e)
        {
            instImport.FormClosed -= instImport_FormClosed;
            instImport = null;
        }

        private void btnCatImport_Click(object sender, EventArgs e)
        {
            if (instImport == null)
            {
                instImport = new frmP_Import();
                instImport.FormClosed += instImport_FormClosed;
            }
            OpenPChildForm(instImport);
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
            btnPreProcess.Checked = false;
            if(instClean == null)
            {
                instClean = new frmP_clean();
                instClean.FormClosed += instClean_FormClosed;
            }
                OpenPChildForm(instClean);
        }

        private void btnCleaning_MouseHover(object sender, EventArgs e)
        {
            //contextMenuStrip1.Show(btnCleaning, new Point(0, btnCleaning.Height));
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
            btnCleaning.Checked = false;
            if (instPreProcess== null)
            {
                instPreProcess = new frmP_pp();
                instPreProcess.FormClosed += instPreProcess_FormClosed;
            }
            OpenPChildForm(instPreProcess);
        }
    }
}
