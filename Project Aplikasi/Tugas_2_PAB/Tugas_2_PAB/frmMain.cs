using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Data.SqlClient;

namespace Tugas_2_PAB
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.A;
        }

        //mengkoneksikan form login dengan form main
        frmLogin Login;
        public frmMain(frmLogin Login)
        {
            InitializeComponent();
            this.Login = Login;
        }

        string query;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet dsArtemis;
        private void LoadDataCabang()
        {
            dsArtemis = new DataSet();
            query = "SELECT * FROM Cabang";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(dsArtemis, "Cabang");
        }

        SqlConnection con;
        string constr;
        private void koneksi()
        {
            constr = "Data Source = localhost; Initial Catalog = Tugas2_PAB; Integrated Security = true";
            con = new SqlConnection(constr);
            con.Open();
        }

        
        private void LoadDataKategori()
        {
            dsArtemis = new DataSet();
            query = "SELECT * FROM Kategori";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(dsArtemis, "Kategori");
        }
        private void loaddataMaterial()
        {
            dsArtemis = new DataSet();

            query = "SELECT * FROM Material";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(dsArtemis, "Material");
        }
        private void loaddataKaryawan()
        {
            dsArtemis = new DataSet();
            query = "SELECT * FROM Karyawan";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(dsArtemis, "Karyawan");
        }
        private void loaddataProduk()
        {
            dsArtemis = new DataSet();
            query = "SELECT * FROM Produk";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(dsArtemis, "Produk");
        }
        private void loaddataPelanggan()
        {
            dsArtemis = new DataSet();

            query = "SELECT * FROM Pelanggan";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(dsArtemis, "Pelanggan");
        }

        private void loaddataFaktur()
        {
            dsArtemis = new DataSet();
            query = "SELECT dp.NoFaktur, pr.KodeProduk, dp.Qty, pr.NamaProduk, pr.Warna, pr.Harga, pj.TanggalJual, pj.Pajak, pj.MetodePembayaran, pj.Total, pe.KodePelanggan, pe.NamaPelanggan, pe.AlamatPelanggan, pe.NoHpPelanggan, pe.EmailPelanggan, ka.KodeKaryawan, ka.NamaKaryawan, ca.KodeCabang, ca.NamaCabang, ca.LokasiCabang FROM DetailPenjualan dp INNER JOIN Penjualan pj ON dp.NoFaktur = pj.NoFaktur INNER JOIN Produk pr ON dp.KodeProduk = pr.KodeProduk INNER JOIN Pelanggan pe ON pe.KodePelanggan = pj.KodePelanggan INNER JOIN Cabang ca ON pj.KodeCabang = ca.KodeCabang INNER JOIN  Karyawan ka ON ka.KodeKaryawan = pj.KodeKaryawan";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(dsArtemis, "Faktur");
        }

        bool SideBarExpand;
        public static Form formAktif = null;
        public static char frm;
        CultureInfo ci = new CultureInfo("id-ID");

        //prosedur
        private void TombolTerpilih(Button btnDiklik,Image img)
        {
            btnDiklik.Image = img;
            btnDiklik.ForeColor = Color.White;
        }

        private void Biru()
        {
            btnHome.Image = Tugas_2_PAB.Properties.Resources.home_blue;
            btnSetting.Image = Tugas_2_PAB.Properties.Resources.setting_blue;
            btnUsers.Image = Tugas_2_PAB.Properties.Resources.user_blue;
            btnChangePassword.Image = Tugas_2_PAB.Properties.Resources.password_blue;
            btnAbout.Image = Tugas_2_PAB.Properties.Resources.about_blue;
            btnApplication.Image = Tugas_2_PAB.Properties.Resources.application_blue;
            btnDeveloper.Image = Tugas_2_PAB.Properties.Resources.developer_blue;
            btnHelp.Image = Tugas_2_PAB.Properties.Resources.help_blue;

            btnHome.ForeColor = Color.FromArgb(74, 144, 226);
            btnSetting.ForeColor = Color.FromArgb(74, 144, 226);
            btnChangePassword.ForeColor = Color.FromArgb(74, 144, 226);
            btnUsers.ForeColor = Color.FromArgb(74, 144, 226);
            btnAbout.ForeColor = Color.FromArgb(74, 144, 226);
            btnApplication.ForeColor = Color.FromArgb(74, 144, 226);
            btnDeveloper.ForeColor = Color.FromArgb(74, 144, 226);
            btnHelp.ForeColor = Color.FromArgb(74, 144, 226);
        }

        public void preventChildForm(Form childForm)
        {
            if (formAktif != null)
            {
                MessageBox.Show("Sudah ada form yang aktif. Jika ingin membuka form lain, tutup form yang sedang aktif", "Form Aktif", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                formAktif = childForm;
                childForm.MdiParent = this;
                childForm.Show();
            }
        }

        private void loaddataTransaksi()
        {
            dsArtemis = new DataSet();
            query = "SELECT p.KodePelanggan,pe.NamaPelanggan,pe.AlamatPelanggan,pe.NoHPPelanggan,pe.EmailPelanggan, p.NoFaktur,p.TanggalJual, dp.KodeProduk ,pr.NamaProduk,pr.Harga, dp.Qty, p.Pajak, p.Total FROM Penjualan p INNER JOIN DetailPenjualan dp ON p.NoFaktur = dp.NoFaktur INNER JOIN Pelanggan pe ON pe.KodePelanggan = p.KodePelanggan INNER JOIN Produk pr ON pr.KodeProduk = dp.KodeProduk";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(dsArtemis, "Sale");
        }



        //class
        public class Pewarnaan : ProfessionalColorTable
        {
            public override Color ToolStripDropDownBackground => Color.MidnightBlue;
            public override Color ImageMarginGradientBegin => Color.MidnightBlue;
            public override Color ImageMarginGradientMiddle => Color.MidnightBlue;
            public override Color ImageMarginGradientEnd => Color.MidnightBlue;
            public override Color MenuBorder => Color.MidnightBlue;
            public override Color MenuItemBorder => Color.FromArgb(74,144,226);
            public override Color MenuItemSelected => Color.FromArgb(74, 144, 226);
            public override Color MenuItemSelectedGradientBegin => Color.FromArgb(74, 144, 226);
            public override Color MenuItemSelectedGradientEnd => Color.FromArgb(74, 144, 226);
            public override Color MenuItemPressedGradientBegin => Color.MidnightBlue;
            public override Color MenuItemPressedGradientEnd => Color.MidnightBlue;
            public override Color ButtonSelectedBorder => Color.FromArgb(74, 144, 226);
            public override Color ButtonSelectedGradientBegin => Color.FromArgb(74, 144, 226);
            public override Color ButtonSelectedGradientEnd => Color.FromArgb(74, 144, 226);
        }



        //event
        private void frmMain_Load(object sender, EventArgs e)
        {
            koneksi();
            pnlSetting.Visible = false;
            pnlAbout.Visible = false;
            Biru();
            TombolTerpilih(btnHome, Tugas_2_PAB.Properties.Resources.home_white);
            mnuBar.Visible = true;
            stbUsername.Text = "Username : " + Login.txtUsername.Text;
            stbLoginTime.Text = "Login Time >> " + DateTime.Now.ToString("HH : mm : ss");
            stbLoginDate.Text = "Login Date >> " + DateTime.Now.ToString("dddd, dd MMMM yyyy", ci);
            stbRunningTime.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy   HH : mm : ss", ci);
            timRunningTime.Interval = 1000;
            timRunningTime.Enabled = true;
            pnlSidebar.Width = 60;
            mnuBar.RenderMode = ToolStripRenderMode.Professional;
            mnuBar.Renderer = new ToolStripProfessionalRenderer(new Pewarnaan());
            stsBar.RenderMode = ToolStripRenderMode.Professional;
            stsBar.Renderer = new ToolStripProfessionalRenderer(new Pewarnaan());
            mnuBar.BackColor = Color.FromArgb(17, 57, 94);
            mnuBar.ForeColor = Color.White;
            stsBar.BackColor = Color.FromArgb(17, 57, 94);
            stsBar.ForeColor = Color.White;
            stbLoginDate.ForeColor = Color.White;
            stbLoginTime.ForeColor = Color.White;
            btnExit.Image = Tugas_2_PAB.Properties.Resources.exit_white;
            btnExit.ForeColor = Color.White;

            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.White;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Login = new frmLogin(this);
            this.Hide();
            Login.Show();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Biru();
            pnlSidebar.Width = 60;
            btnSideBarExpand.Image = Tugas_2_PAB.Properties.Resources.sidebar_menu;
            TombolTerpilih(btnHelp, Tugas_2_PAB.Properties.Resources.help_white);
            picLogo.Width = 60;
            picLogo.Height = 100;
            picLogo.Image = Tugas_2_PAB.Properties.Resources.Artemis3_white;
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pnlSetting.Visible = false;
            pnlAbout.Visible = false;
            mnuBar.Visible = false;
            frmHelp Bantuan = new frmHelp();
            if (formAktif != null)
            {
                MessageBox.Show("Sudah ada form yang aktif. Jika ingin membuka form lain, tutup form yang sedang aktif", "Form Aktif", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                formAktif = Bantuan;
                Bantuan.MdiParent = this;
                Bantuan.BringToFront();
                Bantuan.Show();
                btnHelp.Image = Tugas_2_PAB.Properties.Resources.help_white;
                btnHelp.ForeColor = Color.FromArgb(74, 144, 226);
            }

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Biru();
            TombolTerpilih(btnHome, Tugas_2_PAB.Properties.Resources.home_white);
            picLogo.Width = 60;
            picLogo.Height = 100;
            picLogo.Image = Tugas_2_PAB.Properties.Resources.Artemis3_white;
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pnlSetting.Visible = false;
            pnlAbout.Visible = false;
            mnuBar.Visible = true;
            foreach(Form frm in this.MdiChildren)
            {
                if (frm != null)
                {
                    frm.Close();
                }
            }
            pnlSidebar.Width = 60;
            btnSideBarExpand.Image = Tugas_2_PAB.Properties.Resources.sidebar_menu;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            TombolTerpilih(btnChangePassword, Tugas_2_PAB.Properties.Resources.password_white);
            mnuBar.Visible = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm != null)
                {
                    frm.Close();
                }
            }
            frmChangePassword UbahPassword = new frmChangePassword(this);
            UbahPassword.ShowDialog();
        }

        private void btnApplication_Click(object sender, EventArgs e)
        {
            TombolTerpilih(btnApplication, Tugas_2_PAB.Properties.Resources.application_white);
            mnuBar.Visible = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm != null)
                {
                    frm.Close();
                }
            }
            frmApplication Aplikasi = new frmApplication(this);
            Aplikasi.ShowDialog();
        }

        private void btnDeveloper_Click(object sender, EventArgs e)
        {
            TombolTerpilih(btnDeveloper, Tugas_2_PAB.Properties.Resources.developer_white);
            mnuBar.Visible = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm != null)
                {
                    frm.Close();
                }
            }
            frmDeveloper Pengembang = new frmDeveloper(this);
            Pengembang.ShowDialog();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            TombolTerpilih(btnUsers, Tugas_2_PAB.Properties.Resources.user_white);
            mnuBar.Visible = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm != null)
                {
                    frm.Close();
                }
            }
            frmUsers Pengguna = new frmUsers(this);
            Pengguna.ShowDialog();
        }

        //MASTER DATA
        private void submnuMDKaryawan_Click(object sender, EventArgs e)
        {
            Master.frmEmployee Karyawan = new Master.frmEmployee();
            preventChildForm(Karyawan);
        }

        private void submnuMDPelanggan_Click(object sender, EventArgs e)
        {
            Master.frmCustomer Pelanggan = new Master.frmCustomer();
            preventChildForm(Pelanggan);
        }

        private void submnuMDProduk_Click(object sender, EventArgs e)
        {
            Master.frmProduct Produk = new Master.frmProduct();
            preventChildForm(Produk);
        }

        private void submnuMDKategori_Click(object sender, EventArgs e)
        {
            Master.frmCategory Kategori = new Master.frmCategory();
            preventChildForm(Kategori);
        }

        private void submnuMDMaterial_Click(object sender, EventArgs e)
        {
            Master.frmMaterial Material = new Master.frmMaterial();
            preventChildForm(Material);
        }

        private void submnuMDCabang_Click(object sender, EventArgs e)
        {
            Master.frmBranch Cabang = new Master.frmBranch();
            preventChildForm(Cabang);
        }
        
        private void submnuTransPenjualan_Click(object sender, EventArgs e)
        {
            Transaction.frmSale Penjualan = new Transaction.frmSale();
            Penjualan.ShowDialog();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void timRunningTime_Tick(object sender, EventArgs e)
        {
            stbRunningTime.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy   HH : mm : ss", ci);
        }

        private void btnSideBarExpand_Click(object sender, EventArgs e)
        {
            if (pnlSidebar.Width == 60)
            {
                SideBarExpand = true;
                timSideBar.Start();
                btnSideBarExpand.Image = Tugas_2_PAB.Properties.Resources.x;
                picLogo.Image = Tugas_2_PAB.Properties.Resources.Artemis2_white;
                picLogo.Width = 250;
                picLogo.Height = 100;
                picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                SideBarExpand = false;
                timSideBar.Start();
                btnSideBarExpand.Image = Tugas_2_PAB.Properties.Resources.sidebar_menu;
                picLogo.Width = 60;
                picLogo.Height = 100;
                picLogo.Image = Tugas_2_PAB.Properties.Resources.Artemis3_white;
                picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            }
            pnlSetting.Visible = false;
            pnlAbout.Visible = false;

        }

        private void timSideBar_Tick(object sender, EventArgs e)
        {
            if (SideBarExpand == true)
            {
                pnlSidebar.Width += 10;
                if (pnlSidebar.Width == 250)
                {
                    timSideBar.Stop();
                    SideBarExpand = false;
                }
            }
            else
            {
                pnlSidebar.Width -= 10;
                if (pnlSidebar.Width == 60)
                {
                    timSideBar.Stop();
                    SideBarExpand = true;
                }
            }
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            Biru();
            TombolTerpilih(btnSetting, Tugas_2_PAB.Properties.Resources.setting_white);
            if (pnlSidebar.Width == 60)
            {
                pnlSetting.Location = new Point(60, 183);
            }
            else
            {
                pnlSetting.Location = new Point(250, 183);
            }
            pnlSetting.Visible = true;
            pnlAbout.Visible = false;
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            Biru();
            TombolTerpilih(btnAbout, Tugas_2_PAB.Properties.Resources.about_white);
            if (pnlSidebar.Width == 60)
            {
                pnlAbout.Location = new Point(60, 223);
            }
            else
            {
                pnlAbout.Location = new Point(250, 223);
            }
            pnlSetting.Visible = false;
            pnlAbout.Visible = true;
        }

        private void frmMain_Click(object sender, EventArgs e)
        {
            pnlSetting.Visible = false;
            pnlAbout.Visible = false;
            pnlSidebar.Width = 60;
            btnSideBarExpand.Image = Tugas_2_PAB.Properties.Resources.sidebar_menu;
            picLogo.Image = Tugas_2_PAB.Properties.Resources.Artemis3_white;
        }

        private void statusStrip1_Click(object sender, EventArgs e)
        {
            pnlSetting.Visible = false;
            pnlAbout.Visible = false;
            pnlSidebar.Width = 60;
            btnSideBarExpand.Image = Tugas_2_PAB.Properties.Resources.sidebar_menu;
            picLogo.Image = Tugas_2_PAB.Properties.Resources.Artemis3_white;
        }

        private void mnuBar_Click(object sender, EventArgs e)
        {
            pnlSetting.Visible = false;
            pnlAbout.Visible = false;
            pnlSidebar.Width = 60;
            btnSideBarExpand.Image = Tugas_2_PAB.Properties.Resources.sidebar_menu;
            picLogo.Image = Tugas_2_PAB.Properties.Resources.Artemis3_white;
        }

        private void submnuInfoCabang_Click(object sender, EventArgs e)
        {
            Report.crCabang cr = new Report.crCabang();
            Report.frmViewer viewer = new Report.frmViewer();
            LoadDataCabang();
            cr.SetDataSource(dsArtemis);
            viewer.crystalReportViewer1.ReportSource = cr;
            viewer.WindowState = FormWindowState.Maximized;
            viewer.Text = "INFORMASI CABANG";
            viewer.Show();
        }

        private void submnuInfoKategori_Click(object sender, EventArgs e)
        {
            Report.crKategori crKategori = new Report.crKategori();
            Report.frmViewer viewer = new Report.frmViewer();
            LoadDataKategori();
            crKategori.SetDataSource(dsArtemis);
            viewer.crystalReportViewer1.ReportSource = crKategori;
            viewer.WindowState = FormWindowState.Maximized;
            viewer.Text = "INFORMASI KATEGORI";
            viewer.Show();
        }

        private void submnuInfoPelanggan_Click(object sender, EventArgs e)
        {
            Report.crPelanggan crPelanggan = new Report.crPelanggan();
            Report.frmViewer viewer = new Report.frmViewer();
            loaddataPelanggan();
            crPelanggan.SetDataSource(dsArtemis);
            viewer.crystalReportViewer1.ReportSource = crPelanggan;
            viewer.WindowState = FormWindowState.Maximized;
            viewer.Text = "INFORMASI PELANGGAN";
            viewer.Show();
        }

        private void submnuInfoKaryawan_Click(object sender, EventArgs e)
        {
            Report.crKaryawan crKaryawan = new Report.crKaryawan();
            Report.frmViewer viewer = new Report.frmViewer();
            loaddataKaryawan();
            crKaryawan.SetDataSource(dsArtemis);
            viewer.crystalReportViewer1.ReportSource = crKaryawan;
            viewer.WindowState = FormWindowState.Maximized;
            viewer.Text = "INFORMASI KARYAWAN";
            viewer.Show();
        }

        private void submnuInfoProduk_Click(object sender, EventArgs e)
        {
            Report.crProduk crProduk = new Report.crProduk();
            Report.frmViewer viewer = new Report.frmViewer();
            loaddataProduk();
            crProduk.SetDataSource(dsArtemis);
            viewer.crystalReportViewer1.ReportSource = crProduk;
            viewer.WindowState = FormWindowState.Maximized;
            viewer.Text = "INFORMASI PRODUK";
            viewer.Show();
        }

        private void submnuLapPenjualan_Click(object sender, EventArgs e)
        {
            Report.crLaporanPenjualan crLapJual = new Report.crLaporanPenjualan();
            Report.frmViewer viewer = new Report.frmViewer();
            loaddataTransaksi();
            crLapJual.SetDataSource(dsArtemis);
            viewer.crystalReportViewer1.ReportSource = crLapJual;
            viewer.WindowState = FormWindowState.Maximized;
            viewer.Text = "LAPORAN TRANSAKSI PENJUALAN";
            viewer.Show();
        }

        private void submnuInfoMaterial_Click(object sender, EventArgs e)
        {
            Report.crMaterial crMaterial = new Report.crMaterial();
            Report.frmViewer viewer = new Report.frmViewer();
            loaddataMaterial();
            crMaterial.SetDataSource(dsArtemis);
            viewer.crystalReportViewer1.ReportSource = crMaterial;
            viewer.WindowState = FormWindowState.Maximized;
            viewer.Text = "INFORMASI MATERIAL";
            viewer.Show();
        }

        private void submnuFakturPenjualan_Click(object sender, EventArgs e)
        {
            //MENAMPILKAN CRYSTAL REPORT PADA frmCrystalReportViewer
            Report.crFakturPenjualan crFaktur = new Report.crFakturPenjualan();
            Report.frmViewer viewer = new Report.frmViewer();
            loaddataFaktur();
            crFaktur.SetDataSource(dsArtemis);
            viewer.crystalReportViewer1.ReportSource = crFaktur;
            viewer.WindowState = FormWindowState.Maximized;
            viewer.Text = "FAKTUR TRANSAKSI PENJUALAN";
            viewer.Show();
        }

        private void pnlSidebar_Click(object sender, EventArgs e)
        {
            pnlSetting.Visible = false;
            pnlAbout.Visible = false;
            pnlSidebar.Width = 60;
            picLogo.Image = Tugas_2_PAB.Properties.Resources.Artemis3_white;
            btnSideBarExpand.Image = Tugas_2_PAB.Properties.Resources.sidebar_menu;
        }
    }
}
