
namespace Tugas_2_PAB
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mnuBar = new System.Windows.Forms.MenuStrip();
            this.mnuMasterData = new System.Windows.Forms.ToolStripMenuItem();
            this.submnuMDKaryawan = new System.Windows.Forms.ToolStripMenuItem();
            this.submnuMDPelanggan = new System.Windows.Forms.ToolStripMenuItem();
            this.submnuMDProduk = new System.Windows.Forms.ToolStripMenuItem();
            this.submnuMDKategori = new System.Windows.Forms.ToolStripMenuItem();
            this.submnuMDMaterial = new System.Windows.Forms.ToolStripMenuItem();
            this.submnuMDCabang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTransaksi = new System.Windows.Forms.ToolStripMenuItem();
            this.submnuTransPenjualan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFaktur = new System.Windows.Forms.ToolStripMenuItem();
            this.submnuFakturPenjualan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInformasi = new System.Windows.Forms.ToolStripMenuItem();
            this.submnuInfoKaryawan = new System.Windows.Forms.ToolStripMenuItem();
            this.submnuInfoPelanggan = new System.Windows.Forms.ToolStripMenuItem();
            this.submnuInfoProduk = new System.Windows.Forms.ToolStripMenuItem();
            this.submnuInfoKategori = new System.Windows.Forms.ToolStripMenuItem();
            this.submnuInfoMaterial = new System.Windows.Forms.ToolStripMenuItem();
            this.submnuInfoCabang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLaporan = new System.Windows.Forms.ToolStripMenuItem();
            this.submnuLapPenjualan = new System.Windows.Forms.ToolStripMenuItem();
            this.stsBar = new System.Windows.Forms.StatusStrip();
            this.stbRunningTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.stbLoginDate = new System.Windows.Forms.ToolStripMenuItem();
            this.stbLoginTime = new System.Windows.Forms.ToolStripMenuItem();
            this.stbUsername = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlSetting = new System.Windows.Forms.Panel();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnSideBarExpand = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.timRunningTime = new System.Windows.Forms.Timer(this.components);
            this.pnlAbout = new System.Windows.Forms.Panel();
            this.btnApplication = new System.Windows.Forms.Button();
            this.btnDeveloper = new System.Windows.Forms.Button();
            this.timSideBar = new System.Windows.Forms.Timer(this.components);
            this.mnuBar.SuspendLayout();
            this.stsBar.SuspendLayout();
            this.pnlSetting.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuBar
            // 
            this.mnuBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mnuBar.AutoSize = false;
            this.mnuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(57)))), ((int)(((byte)(94)))));
            this.mnuBar.Dock = System.Windows.Forms.DockStyle.None;
            this.mnuBar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMasterData,
            this.mnuTransaksi,
            this.mnuFaktur,
            this.mnuInformasi,
            this.mnuLaporan});
            this.mnuBar.Location = new System.Drawing.Point(60, 0);
            this.mnuBar.Name = "mnuBar";
            this.mnuBar.Size = new System.Drawing.Size(924, 40);
            this.mnuBar.TabIndex = 1;
            this.mnuBar.Text = "menuStrip1";
            this.mnuBar.Click += new System.EventHandler(this.mnuBar_Click);
            // 
            // mnuMasterData
            // 
            this.mnuMasterData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submnuMDKaryawan,
            this.submnuMDPelanggan,
            this.submnuMDProduk,
            this.submnuMDKategori,
            this.submnuMDMaterial,
            this.submnuMDCabang});
            this.mnuMasterData.Name = "mnuMasterData";
            this.mnuMasterData.Size = new System.Drawing.Size(126, 36);
            this.mnuMasterData.Text = "Master Data";
            // 
            // submnuMDKaryawan
            // 
            this.submnuMDKaryawan.BackColor = System.Drawing.SystemColors.Control;
            this.submnuMDKaryawan.ForeColor = System.Drawing.Color.White;
            this.submnuMDKaryawan.Name = "submnuMDKaryawan";
            this.submnuMDKaryawan.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.submnuMDKaryawan.Size = new System.Drawing.Size(239, 30);
            this.submnuMDKaryawan.Text = "&Karyawan";
            this.submnuMDKaryawan.Click += new System.EventHandler(this.submnuMDKaryawan_Click);
            // 
            // submnuMDPelanggan
            // 
            this.submnuMDPelanggan.ForeColor = System.Drawing.Color.White;
            this.submnuMDPelanggan.Name = "submnuMDPelanggan";
            this.submnuMDPelanggan.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.submnuMDPelanggan.Size = new System.Drawing.Size(239, 30);
            this.submnuMDPelanggan.Text = "&Pelanggan";
            this.submnuMDPelanggan.Click += new System.EventHandler(this.submnuMDPelanggan_Click);
            // 
            // submnuMDProduk
            // 
            this.submnuMDProduk.ForeColor = System.Drawing.Color.White;
            this.submnuMDProduk.Name = "submnuMDProduk";
            this.submnuMDProduk.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.submnuMDProduk.Size = new System.Drawing.Size(239, 30);
            this.submnuMDProduk.Text = "P&roduk";
            this.submnuMDProduk.Click += new System.EventHandler(this.submnuMDProduk_Click);
            // 
            // submnuMDKategori
            // 
            this.submnuMDKategori.ForeColor = System.Drawing.Color.White;
            this.submnuMDKategori.Name = "submnuMDKategori";
            this.submnuMDKategori.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.submnuMDKategori.Size = new System.Drawing.Size(239, 30);
            this.submnuMDKategori.Text = "K&ategori";
            this.submnuMDKategori.Click += new System.EventHandler(this.submnuMDKategori_Click);
            // 
            // submnuMDMaterial
            // 
            this.submnuMDMaterial.ForeColor = System.Drawing.Color.White;
            this.submnuMDMaterial.Name = "submnuMDMaterial";
            this.submnuMDMaterial.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.submnuMDMaterial.Size = new System.Drawing.Size(239, 30);
            this.submnuMDMaterial.Text = "&Material";
            this.submnuMDMaterial.Click += new System.EventHandler(this.submnuMDMaterial_Click);
            // 
            // submnuMDCabang
            // 
            this.submnuMDCabang.ForeColor = System.Drawing.Color.White;
            this.submnuMDCabang.Name = "submnuMDCabang";
            this.submnuMDCabang.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.submnuMDCabang.Size = new System.Drawing.Size(239, 30);
            this.submnuMDCabang.Text = "&Cabang";
            this.submnuMDCabang.Click += new System.EventHandler(this.submnuMDCabang_Click);
            // 
            // mnuTransaksi
            // 
            this.mnuTransaksi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submnuTransPenjualan});
            this.mnuTransaksi.ForeColor = System.Drawing.Color.White;
            this.mnuTransaksi.Name = "mnuTransaksi";
            this.mnuTransaksi.Size = new System.Drawing.Size(100, 36);
            this.mnuTransaksi.Text = "Transaksi";
            // 
            // submnuTransPenjualan
            // 
            this.submnuTransPenjualan.ForeColor = System.Drawing.Color.White;
            this.submnuTransPenjualan.Name = "submnuTransPenjualan";
            this.submnuTransPenjualan.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.submnuTransPenjualan.Size = new System.Drawing.Size(232, 30);
            this.submnuTransPenjualan.Text = "Penjualan";
            this.submnuTransPenjualan.Click += new System.EventHandler(this.submnuTransPenjualan_Click);
            // 
            // mnuFaktur
            // 
            this.mnuFaktur.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submnuFakturPenjualan});
            this.mnuFaktur.ForeColor = System.Drawing.Color.White;
            this.mnuFaktur.Name = "mnuFaktur";
            this.mnuFaktur.Size = new System.Drawing.Size(75, 36);
            this.mnuFaktur.Text = "Faktur";
            // 
            // submnuFakturPenjualan
            // 
            this.submnuFakturPenjualan.ForeColor = System.Drawing.Color.White;
            this.submnuFakturPenjualan.Name = "submnuFakturPenjualan";
            this.submnuFakturPenjualan.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F)));
            this.submnuFakturPenjualan.Size = new System.Drawing.Size(282, 30);
            this.submnuFakturPenjualan.Text = "Penjualan";
            this.submnuFakturPenjualan.Click += new System.EventHandler(this.submnuFakturPenjualan_Click);
            // 
            // mnuInformasi
            // 
            this.mnuInformasi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submnuInfoKaryawan,
            this.submnuInfoPelanggan,
            this.submnuInfoProduk,
            this.submnuInfoKategori,
            this.submnuInfoMaterial,
            this.submnuInfoCabang});
            this.mnuInformasi.ForeColor = System.Drawing.Color.White;
            this.mnuInformasi.Name = "mnuInformasi";
            this.mnuInformasi.Size = new System.Drawing.Size(103, 36);
            this.mnuInformasi.Text = "Informasi";
            // 
            // submnuInfoKaryawan
            // 
            this.submnuInfoKaryawan.ForeColor = System.Drawing.Color.White;
            this.submnuInfoKaryawan.Name = "submnuInfoKaryawan";
            this.submnuInfoKaryawan.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.K)));
            this.submnuInfoKaryawan.Size = new System.Drawing.Size(290, 30);
            this.submnuInfoKaryawan.Text = "&Karyawan";
            this.submnuInfoKaryawan.Click += new System.EventHandler(this.submnuInfoKaryawan_Click);
            // 
            // submnuInfoPelanggan
            // 
            this.submnuInfoPelanggan.ForeColor = System.Drawing.Color.White;
            this.submnuInfoPelanggan.Name = "submnuInfoPelanggan";
            this.submnuInfoPelanggan.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.P)));
            this.submnuInfoPelanggan.Size = new System.Drawing.Size(290, 30);
            this.submnuInfoPelanggan.Text = "&Pelanggan";
            this.submnuInfoPelanggan.Click += new System.EventHandler(this.submnuInfoPelanggan_Click);
            // 
            // submnuInfoProduk
            // 
            this.submnuInfoProduk.ForeColor = System.Drawing.Color.White;
            this.submnuInfoProduk.Name = "submnuInfoProduk";
            this.submnuInfoProduk.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.R)));
            this.submnuInfoProduk.Size = new System.Drawing.Size(290, 30);
            this.submnuInfoProduk.Text = "P&roduk";
            this.submnuInfoProduk.Click += new System.EventHandler(this.submnuInfoProduk_Click);
            // 
            // submnuInfoKategori
            // 
            this.submnuInfoKategori.ForeColor = System.Drawing.Color.White;
            this.submnuInfoKategori.Name = "submnuInfoKategori";
            this.submnuInfoKategori.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.submnuInfoKategori.Size = new System.Drawing.Size(290, 30);
            this.submnuInfoKategori.Text = "K&ategori";
            this.submnuInfoKategori.Click += new System.EventHandler(this.submnuInfoKategori_Click);
            // 
            // submnuInfoMaterial
            // 
            this.submnuInfoMaterial.ForeColor = System.Drawing.Color.White;
            this.submnuInfoMaterial.Name = "submnuInfoMaterial";
            this.submnuInfoMaterial.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.M)));
            this.submnuInfoMaterial.Size = new System.Drawing.Size(290, 30);
            this.submnuInfoMaterial.Text = "&Material";
            this.submnuInfoMaterial.Click += new System.EventHandler(this.submnuInfoMaterial_Click);
            // 
            // submnuInfoCabang
            // 
            this.submnuInfoCabang.ForeColor = System.Drawing.Color.White;
            this.submnuInfoCabang.Name = "submnuInfoCabang";
            this.submnuInfoCabang.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.submnuInfoCabang.Size = new System.Drawing.Size(290, 30);
            this.submnuInfoCabang.Text = "&Cabang";
            this.submnuInfoCabang.Click += new System.EventHandler(this.submnuInfoCabang_Click);
            // 
            // mnuLaporan
            // 
            this.mnuLaporan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submnuLapPenjualan});
            this.mnuLaporan.ForeColor = System.Drawing.Color.White;
            this.mnuLaporan.Name = "mnuLaporan";
            this.mnuLaporan.Size = new System.Drawing.Size(93, 36);
            this.mnuLaporan.Text = "Laporan";
            // 
            // submnuLapPenjualan
            // 
            this.submnuLapPenjualan.ForeColor = System.Drawing.Color.White;
            this.submnuLapPenjualan.Name = "submnuLapPenjualan";
            this.submnuLapPenjualan.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.L)));
            this.submnuLapPenjualan.Size = new System.Drawing.Size(282, 30);
            this.submnuLapPenjualan.Text = "Penjualan";
            this.submnuLapPenjualan.Click += new System.EventHandler(this.submnuLapPenjualan_Click);
            // 
            // stsBar
            // 
            this.stsBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stsBar.AutoSize = false;
            this.stsBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(57)))), ((int)(((byte)(94)))));
            this.stsBar.Dock = System.Windows.Forms.DockStyle.None;
            this.stsBar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stsBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stsBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stbRunningTime,
            this.toolStripDropDownButton1,
            this.stbUsername});
            this.stsBar.Location = new System.Drawing.Point(60, 568);
            this.stsBar.Name = "stsBar";
            this.stsBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.stsBar.Size = new System.Drawing.Size(924, 41);
            this.stsBar.TabIndex = 3;
            this.stsBar.Text = "statusStrip1";
            this.stsBar.Click += new System.EventHandler(this.statusStrip1_Click);
            // 
            // stbRunningTime
            // 
            this.stbRunningTime.AutoSize = false;
            this.stbRunningTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(57)))), ((int)(((byte)(94)))));
            this.stbRunningTime.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stbRunningTime.Name = "stbRunningTime";
            this.stbRunningTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.stbRunningTime.Size = new System.Drawing.Size(400, 36);
            this.stbRunningTime.Text = "[running_time]";
            this.stbRunningTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stbLoginDate,
            this.stbLoginTime});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(64, 39);
            this.toolStripDropDownButton1.Text = "LOGIN";
            // 
            // stbLoginDate
            // 
            this.stbLoginDate.Name = "stbLoginDate";
            this.stbLoginDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.stbLoginDate.Size = new System.Drawing.Size(152, 24);
            this.stbLoginDate.Text = "Login Date";
            this.stbLoginDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // stbLoginTime
            // 
            this.stbLoginTime.Name = "stbLoginTime";
            this.stbLoginTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.stbLoginTime.Size = new System.Drawing.Size(152, 24);
            this.stbLoginTime.Text = "Login Time";
            this.stbLoginTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // stbUsername
            // 
            this.stbUsername.AutoSize = false;
            this.stbUsername.Name = "stbUsername";
            this.stbUsername.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.stbUsername.Size = new System.Drawing.Size(220, 36);
            this.stbUsername.Text = "Username :";
            this.stbUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stbUsername.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // pnlSetting
            // 
            this.pnlSetting.Controls.Add(this.btnUsers);
            this.pnlSetting.Controls.Add(this.btnChangePassword);
            this.pnlSetting.Location = new System.Drawing.Point(60, 183);
            this.pnlSetting.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSetting.Name = "pnlSetting";
            this.pnlSetting.Size = new System.Drawing.Size(250, 80);
            this.pnlSetting.TabIndex = 3;
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(57)))), ((int)(((byte)(94)))));
            this.btnUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.Image = global::Tugas_2_PAB.Properties.Resources.icons8_user_30;
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.Location = new System.Drawing.Point(0, 0);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(0);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnUsers.Size = new System.Drawing.Size(250, 40);
            this.btnUsers.TabIndex = 2;
            this.btnUsers.Text = "     Users";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(57)))), ((int)(((byte)(94)))));
            this.btnChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.Image = global::Tugas_2_PAB.Properties.Resources.password_black;
            this.btnChangePassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangePassword.Location = new System.Drawing.Point(0, 40);
            this.btnChangePassword.Margin = new System.Windows.Forms.Padding(0);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnChangePassword.Size = new System.Drawing.Size(250, 40);
            this.btnChangePassword.TabIndex = 2;
            this.btnChangePassword.Text = "     Change Password";
            this.btnChangePassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangePassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(57)))), ((int)(((byte)(94)))));
            this.pnlSidebar.Controls.Add(this.picLogo);
            this.pnlSidebar.Controls.Add(this.btnSideBarExpand);
            this.pnlSidebar.Controls.Add(this.btnHelp);
            this.pnlSidebar.Controls.Add(this.btnHome);
            this.pnlSidebar.Controls.Add(this.btnAbout);
            this.pnlSidebar.Controls.Add(this.btnSetting);
            this.pnlSidebar.Controls.Add(this.btnExit);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(60, 608);
            this.pnlSidebar.TabIndex = 0;
            this.pnlSidebar.Click += new System.EventHandler(this.pnlSidebar_Click);
            // 
            // picLogo
            // 
            this.picLogo.Image = global::Tugas_2_PAB.Properties.Resources.Artemis3_white;
            this.picLogo.Location = new System.Drawing.Point(0, 40);
            this.picLogo.Margin = new System.Windows.Forms.Padding(0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(60, 100);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 3;
            this.picLogo.TabStop = false;
            // 
            // btnSideBarExpand
            // 
            this.btnSideBarExpand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSideBarExpand.FlatAppearance.BorderSize = 0;
            this.btnSideBarExpand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSideBarExpand.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSideBarExpand.Image = global::Tugas_2_PAB.Properties.Resources.sidebar_menu;
            this.btnSideBarExpand.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSideBarExpand.Location = new System.Drawing.Point(0, 0);
            this.btnSideBarExpand.Margin = new System.Windows.Forms.Padding(0);
            this.btnSideBarExpand.Name = "btnSideBarExpand";
            this.btnSideBarExpand.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnSideBarExpand.Size = new System.Drawing.Size(250, 40);
            this.btnSideBarExpand.TabIndex = 2;
            this.btnSideBarExpand.Text = "     Side Bar Menu";
            this.btnSideBarExpand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSideBarExpand.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSideBarExpand.UseVisualStyleBackColor = true;
            this.btnSideBarExpand.Click += new System.EventHandler(this.btnSideBarExpand_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Image = global::Tugas_2_PAB.Properties.Resources.icons8_question_30;
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.Location = new System.Drawing.Point(0, 263);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(0);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnHelp.Size = new System.Drawing.Size(250, 40);
            this.btnHelp.TabIndex = 2;
            this.btnHelp.Text = "   Help";
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Black;
            this.btnHome.Image = global::Tugas_2_PAB.Properties.Resources.icons8_home_30;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 140);
            this.btnHome.Margin = new System.Windows.Forms.Padding(0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(250, 40);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "     Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.Image = ((System.Drawing.Image)(resources.GetObject("btnAbout.Image")));
            this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.Location = new System.Drawing.Point(0, 223);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(0);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnAbout.Size = new System.Drawing.Size(250, 40);
            this.btnAbout.TabIndex = 2;
            this.btnAbout.Text = "     About";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.Image = global::Tugas_2_PAB.Properties.Resources.icons8_setting_30;
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Location = new System.Drawing.Point(0, 183);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(0);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnSetting.Size = new System.Drawing.Size(250, 40);
            this.btnSetting.TabIndex = 2;
            this.btnSetting.Text = "     Setting";
            this.btnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Image = global::Tugas_2_PAB.Properties.Resources.icons8_logout_30;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 568);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(250, 40);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "     Logout";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // timRunningTime
            // 
            this.timRunningTime.Tick += new System.EventHandler(this.timRunningTime_Tick);
            // 
            // pnlAbout
            // 
            this.pnlAbout.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pnlAbout.Controls.Add(this.btnApplication);
            this.pnlAbout.Controls.Add(this.btnDeveloper);
            this.pnlAbout.Location = new System.Drawing.Point(365, 183);
            this.pnlAbout.Margin = new System.Windows.Forms.Padding(0);
            this.pnlAbout.Name = "pnlAbout";
            this.pnlAbout.Size = new System.Drawing.Size(250, 80);
            this.pnlAbout.TabIndex = 5;
            // 
            // btnApplication
            // 
            this.btnApplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(57)))), ((int)(((byte)(94)))));
            this.btnApplication.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApplication.FlatAppearance.BorderSize = 0;
            this.btnApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplication.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplication.Image = ((System.Drawing.Image)(resources.GetObject("btnApplication.Image")));
            this.btnApplication.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApplication.Location = new System.Drawing.Point(0, 0);
            this.btnApplication.Margin = new System.Windows.Forms.Padding(0);
            this.btnApplication.Name = "btnApplication";
            this.btnApplication.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnApplication.Size = new System.Drawing.Size(250, 40);
            this.btnApplication.TabIndex = 2;
            this.btnApplication.Text = "     Application";
            this.btnApplication.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApplication.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnApplication.UseVisualStyleBackColor = false;
            this.btnApplication.Click += new System.EventHandler(this.btnApplication_Click);
            // 
            // btnDeveloper
            // 
            this.btnDeveloper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(57)))), ((int)(((byte)(94)))));
            this.btnDeveloper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeveloper.FlatAppearance.BorderSize = 0;
            this.btnDeveloper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeveloper.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeveloper.Image = ((System.Drawing.Image)(resources.GetObject("btnDeveloper.Image")));
            this.btnDeveloper.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeveloper.Location = new System.Drawing.Point(0, 40);
            this.btnDeveloper.Margin = new System.Windows.Forms.Padding(0);
            this.btnDeveloper.Name = "btnDeveloper";
            this.btnDeveloper.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnDeveloper.Size = new System.Drawing.Size(250, 40);
            this.btnDeveloper.TabIndex = 2;
            this.btnDeveloper.Text = "     Developer";
            this.btnDeveloper.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeveloper.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeveloper.UseVisualStyleBackColor = false;
            this.btnDeveloper.Click += new System.EventHandler(this.btnDeveloper_Click);
            // 
            // timSideBar
            // 
            this.timSideBar.Interval = 1;
            this.timSideBar.Tick += new System.EventHandler(this.timSideBar_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 608);
            this.Controls.Add(this.pnlAbout);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.mnuBar);
            this.Controls.Add(this.stsBar);
            this.Controls.Add(this.pnlSetting);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ARTEMIS FURNITURE";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Click += new System.EventHandler(this.frmMain_Click);
            this.mnuBar.ResumeLayout(false);
            this.mnuBar.PerformLayout();
            this.stsBar.ResumeLayout(false);
            this.stsBar.PerformLayout();
            this.pnlSetting.ResumeLayout(false);
            this.pnlSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlAbout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.MenuStrip mnuBar;
        public System.Windows.Forms.ToolStripMenuItem mnuMasterData;
        public System.Windows.Forms.ToolStripMenuItem submnuMDKaryawan;
        public System.Windows.Forms.ToolStripMenuItem submnuMDPelanggan;
        public System.Windows.Forms.ToolStripMenuItem submnuMDProduk;
        public System.Windows.Forms.ToolStripMenuItem submnuMDKategori;
        public System.Windows.Forms.ToolStripMenuItem submnuMDMaterial;
        public System.Windows.Forms.ToolStripMenuItem submnuMDCabang;
        public System.Windows.Forms.ToolStripMenuItem mnuTransaksi;
        public System.Windows.Forms.ToolStripMenuItem submnuTransPenjualan;
        public System.Windows.Forms.ToolStripMenuItem mnuFaktur;
        public System.Windows.Forms.ToolStripMenuItem submnuFakturPenjualan;
        public System.Windows.Forms.ToolStripMenuItem mnuInformasi;
        public System.Windows.Forms.ToolStripMenuItem submnuInfoKaryawan;
        public System.Windows.Forms.ToolStripMenuItem submnuInfoPelanggan;
        public System.Windows.Forms.ToolStripMenuItem submnuInfoProduk;
        public System.Windows.Forms.ToolStripMenuItem submnuInfoKategori;
        public System.Windows.Forms.ToolStripMenuItem submnuInfoMaterial;
        public System.Windows.Forms.ToolStripMenuItem submnuInfoCabang;
        public System.Windows.Forms.ToolStripMenuItem mnuLaporan;
        public System.Windows.Forms.ToolStripMenuItem submnuLapPenjualan;
        public System.Windows.Forms.Button btnHelp;
        public System.Windows.Forms.Button btnAbout;
        public System.Windows.Forms.Button btnChangePassword;
        public System.Windows.Forms.Button btnUsers;
        public System.Windows.Forms.Button btnSetting;
        public System.Windows.Forms.Button btnHome;
        public System.Windows.Forms.StatusStrip stsBar;
        public System.Windows.Forms.ToolStripStatusLabel stbRunningTime;
        public System.Windows.Forms.ToolStripStatusLabel stbUsername;
        public System.Windows.Forms.PictureBox picLogo;
        public System.Windows.Forms.Panel pnlSetting;
        public System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.Panel pnlSidebar;
        public System.Windows.Forms.Timer timRunningTime;
        public System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        public System.Windows.Forms.ToolStripMenuItem stbLoginTime;
        public System.Windows.Forms.ToolStripMenuItem stbLoginDate;
        public System.Windows.Forms.Panel pnlAbout;
        public System.Windows.Forms.Button btnApplication;
        public System.Windows.Forms.Button btnDeveloper;
        public System.Windows.Forms.Button btnSideBarExpand;
        public System.Windows.Forms.Timer timSideBar;
    }
}