using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_2_PAB
{
    public partial class frmApplication : Form
    {
        public frmApplication()
        {
            InitializeComponent();
        }

        frmMain Main;
        public frmApplication(frmMain Main)
        {
            InitializeComponent();
            this.Main = Main;
        }



        //event
        private void frmApplication_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMain.formAktif = null;
            Main.pnlSetting.Visible = false;
            Main.pnlAbout.Visible = false;
            Main.pnlSidebar.Width = 60;
            Main.btnSideBarExpand.Image = Tugas_2_PAB.Properties.Resources.sidebar_menu;
            Main.picLogo.Width = 60;
            Main.picLogo.Height = 100;
            Main.picLogo.Image = Tugas_2_PAB.Properties.Resources.Artemis3_white;
            Main.picLogo.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void frmApplication_Load(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            pnl2.Visible = false;
            pnl3.Visible = false;
            btn1.Image = Tugas_2_PAB.Properties.Resources.sort_right;
            btn2.Image = Tugas_2_PAB.Properties.Resources.sort_right;
            btn3.Image = Tugas_2_PAB.Properties.Resources.sort_right;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (pnl1.Visible == false)
            {
                pnl1.Visible = true;
                btn1.Image = Tugas_2_PAB.Properties.Resources.sort_down;
            }
            else
            {
                pnl1.Visible = false;
                btn1.Image = Tugas_2_PAB.Properties.Resources.sort_right;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (pnl2.Visible == false)
            {
                pnl2.Visible = true;
                btn2.Image = Tugas_2_PAB.Properties.Resources.sort_down;
            }
            else
            {
                pnl2.Visible = false;
                btn2.Image = Tugas_2_PAB.Properties.Resources.sort_right;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (pnl3.Visible == false)
            {
                pnl3.Visible = true;
                btn3.Image = Tugas_2_PAB.Properties.Resources.sort_down;
            }
            else
            {
                pnl3.Visible = false;
                btn3.Image = Tugas_2_PAB.Properties.Resources.sort_right;
            }
        }
    }
}
