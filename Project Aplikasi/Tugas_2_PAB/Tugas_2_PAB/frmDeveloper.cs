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
    public partial class frmDeveloper : Form
    {
        public frmDeveloper()
        {
            InitializeComponent();
        }

        private void Hover(Label lbl)
        {
            lbl.Height = 50;
            lbl.Font = new Font("Segoe UI", 22, FontStyle.Bold);
            lbl.ForeColor = Color.White;
        }

        private void Leave(Label lbl)
        {
            lbl.Height = 40;
            lbl.Font = new Font("Segoe UI", 14, FontStyle.Regular);
            lbl.ForeColor = Color.FromArgb(74, 144, 226);
        }

        frmMain Main;
        public frmDeveloper(frmMain Main)
        {
            InitializeComponent();
            this.Main = Main;
        }

        private void frmDeveloper_FormClosing(object sender, FormClosingEventArgs e)
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

        private void lblAndi_MouseHover(object sender, EventArgs e)
        {
            Hover(lblAndi);
        }

        private void lblAndi_MouseLeave(object sender, EventArgs e)
        {
            Leave(lblAndi);
        }

        private void lblRudi_MouseHover(object sender, EventArgs e)
        {
            Hover(lblRudi);
        }

        private void lblRudi_MouseLeave(object sender, EventArgs e)
        {
            Leave(lblRudi);
        }

        private void lblAgnes_MouseHover(object sender, EventArgs e)
        {
            Hover(lblAgnes);
        }

        private void lblAgnes_MouseLeave(object sender, EventArgs e)
        {
            Leave(lblAgnes);
        }

        private void lblMichael_MouseHover(object sender, EventArgs e)
        {
            Hover(lblMichael);
        }

        private void lblMichael_MouseLeave(object sender, EventArgs e)
        {
            Leave(lblMichael);
        }

        private void lblBelen_MouseHover(object sender, EventArgs e)
        {
            Hover(lblBelen);
        }

        private void lblBelen_MouseLeave(object sender, EventArgs e)
        {
            Leave(lblBelen);
        }

        private void lblYona_MouseHover(object sender, EventArgs e)
        {
            Hover(lblYona);
        }

        private void lblYona_MouseLeave(object sender, EventArgs e)
        {
            Leave(lblYona);
        }
    }
}
