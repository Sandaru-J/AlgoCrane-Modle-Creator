using MLDA_Application.Preparation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MLDA_Application.Train;



namespace MLDA_Application
{
    public partial class FormMain : Form
    {
        private Form currentChildForm;
        public FormMain()
        {
            InitializeComponent();
            //CollapseMenu();
            //this.Padding = new Padding(borderSize);
            //this.BackColor = Color.Teal;
            this.Text=String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered= true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, InheritanceLevel lParam);

        
        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
       
        private void OpenChildForm(Form childForm)
        {
            if(currentChildForm!=null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlChildHolder.Controls.Add(childForm);
            pnlChildHolder.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void MpBtn_Prepare_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Preparation.frmP_Main());
        }

        private void FormMain_Resize(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        private void CollapseMenu()
        {
            if(this.pnlMenu.Width > 100)
            {
                pnlMenu.Width = 65;
                foreach(Button btn in pnlMenu.Controls.OfType<Button>())
                {
                    btn.Text = "";
                    btn.ImageAlign=ContentAlignment.MiddleLeft;
                    btn.Padding = new Padding(0);
                }
            }else
            {
                pnlMenu.Width = 137;
                foreach(Button btn in pnlMenu.Controls.OfType<Button>())
                {
                    btn.Text=" "+btn.Tag.ToString();
                    btn.ImageAlign=ContentAlignment.MiddleLeft;
                    btn.Padding=new Padding(5,0,0,0);
                }
            }
        }

        private void pnlMenu_MouseEnter(object sender, EventArgs e)
        {
            if (this.pnlMenu.Width < 100)
            {
                pnlMenu.Width = 137;
                foreach (Button btn in pnlMenu.Controls.OfType<Button>())
                {
                    btn.Text = " " + btn.Tag.ToString();
                    btn.ImageAlign = ContentAlignment.MiddleLeft;
                    btn.Padding = new Padding(5, 0, 0, 0);
                }
            }
          
        }
        private void MBtn_Train_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Train.frmT_Main());
        }

        private void btnVisual_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Visualization.frmV_Main());
        }
    }
}
