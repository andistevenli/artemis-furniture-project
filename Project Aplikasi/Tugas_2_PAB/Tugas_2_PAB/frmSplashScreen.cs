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
    public partial class frmSplashScreen : Form
    {
        frmLogin Login = new frmLogin();

        public frmSplashScreen()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.A;
        }

        private void timLoading_Tick(object sender, EventArgs e)
        {
            if (lblLoading.Width >= 300)
            {
                timLoading.Stop();
                label1.Text = "Successfully connected to database";
                btnStart.Enabled = true;
                btnStart.Focus();
            }
            else
            {
                lblLoading.Width += 10;
            }
        }

        private void frmSplashScreen_Load(object sender, EventArgs e)
        {
            lblLoading.Width = 0;
            btnStart.Enabled = false;

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login.Show();
        }
    }
}
