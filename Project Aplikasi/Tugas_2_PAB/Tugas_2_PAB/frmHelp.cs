﻿using System;
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
    public partial class frmHelp : Form
    {
        public frmHelp()
        {
            InitializeComponent();
        }

        frmMain Main;
        public frmHelp(frmMain Main)
        {
            InitializeComponent();
            this.Main = Main;
        }

        private void frmHelp_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMain.formAktif = null;
        }
    }
}
