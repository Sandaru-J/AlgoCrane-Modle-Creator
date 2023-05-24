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
using MLDA_Application.Shared;
using MLDA_Application.Preparation.Shared;
using MLDA_Application.Store;
using System.Net.NetworkInformation;

namespace MLDA_Application
{
    public partial class FormMain : Form
    {
        private Form currentChildForm;

        private frmP_Main instaPrepare;
        private frmT_Main instaTrain;

        string dfName;
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
            foreach (Control control in pnlChildHolder.Controls)
            {
                if (control.GetType() == childForm.GetType())
                {
                    // Child form instance already exists, bring it to front
                    control.BringToFront();
                    return;
                }
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
        private void instaPrepare_FormClosed(object sender, FormClosedEventArgs e)
        {
            instaPrepare.FormClosed -= instaPrepare_FormClosed;
            instaPrepare = null;
        }
        private void instaTrain_FormClosed(object sender, FormClosedEventArgs e)
        {
            instaTrain.FormClosed -= instaTrain_FormClosed;
            instaTrain = null;
        }
        private void MpBtn_Prepare_Click(object sender, EventArgs e)
        {
            if (instaPrepare== null)
            {
                instaPrepare = new frmP_Main();
                instaPrepare.FormClosed += instaPrepare_FormClosed;
            }
            OpenChildForm(instaPrepare);
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
                label1.Visible = false;
                foreach(Button btn in pnlMenu.Controls.OfType<Button>())
                {
                    btn.Text = "";
                    btn.ImageAlign=ContentAlignment.MiddleLeft;
                    btn.Padding = new Padding(0);
                }
            }else
            {
                pnlMenu.Width = 140;
                label1.Visible = true;
                foreach (Button btn in pnlMenu.Controls.OfType<Button>())
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
                pnlMenu.Width = 140;
                foreach (Button btn in pnlMenu.Controls.OfType<Button>())
                {
                    btn.Text = " " + btn.Tag.ToString();
                    btn.ImageAlign = ContentAlignment.MiddleLeft;
                    btn.Padding = new Padding(5, 0, 0, 0);
                    label1.Visible = true;
                }
            }
          
        }
        private void MBtn_Train_Click(object sender, EventArgs e)
        {
            if (instaTrain== null)
            {
                instaTrain = new frmT_Main();
                instaTrain.FormClosed += instaTrain_FormClosed;
            }
            OpenChildForm(instaTrain);
        }

        private void btnLoadDf_Click(object sender, EventArgs e)
        {
            if(IsInternetAvailable())
            {
                var popupLoad = new frmDfLoad();
                popupLoad.DataSent += PopUpForm_DataSent;
                //popupLoad.Owner = this;
                popupLoad.ShowDialog();
            }
            else
            {
                MessageBox.Show("Network Connection not established. Check your Connection", "Network Error");
            }
        }
        private void PopUpForm_DataSent(object sender, Shared.DataSentEventArgs e)
        {
            Console.WriteLine(e.name + e.path);
            //MpBtn_Prepare.Text = e.name;
            dfName = e.name;
            //PathModel.Path = e.path;
        }

        private void btnUpld_Click(object sender, EventArgs e)
        {
            if(IsInternetAvailable())
            {
                DfUpload dfObj = new DfUpload();
                dfObj.ShowDialog();
            }
            else
            {
                MessageBox.Show("Network Connection not established. Check your Connection", "Network Error");
            }

        }

        private void Mpbtn_template_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Template.FrmTemp_Main());
        }

        private void icBtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void icBtnfrmSize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                // Maximize the form
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                // Restore down the form
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void icBtnMinmz_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public static bool IsInternetAvailable()
        {
            try
            {
                using (var ping = new Ping())
                {
                    const string pingAddress = "8.8.8.8"; // Google's DNS server IP address
                    const int timeout = 3000; // Timeout value in milliseconds

                    PingReply reply = ping.Send(pingAddress, timeout);

                    return (reply != null && reply.Status == IPStatus.Success);
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        private void iconButton2_Click(object sender, EventArgs e)
        {
            if(IsInternetAvailable())
            {
                OpenChildForm(new Store.frmStore());
            }else
            {
                MessageBox.Show("Network Connection not established. Check your Connection", "Network Error");
            }

        }

    }
}
