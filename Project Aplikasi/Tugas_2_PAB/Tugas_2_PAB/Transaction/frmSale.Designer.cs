
namespace Tugas_2_PAB.Transaction
{
    partial class frmSale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSale));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNoFaktur = new System.Windows.Forms.TextBox();
            this.dtpTanggalPemesanan = new System.Windows.Forms.DateTimePicker();
            this.lblKodePelanggan = new System.Windows.Forms.Label();
            this.lblNamaPelanggan = new System.Windows.Forms.Label();
            this.lblNamaCabang = new System.Windows.Forms.Label();
            this.lblKodeProduk = new System.Windows.Forms.Label();
            this.lblNamaProduk = new System.Windows.Forms.Label();
            this.lblKodeMaterial = new System.Windows.Forms.Label();
            this.lblKodeKategori = new System.Windows.Forms.Label();
            this.lblLokasiCabang = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblKodeCabang = new System.Windows.Forms.Label();
            this.nudPajak = new System.Windows.Forms.NumericUpDown();
            this.nudQty = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.lblKodeKaryawan = new System.Windows.Forms.Label();
            this.lblNamaKaryawan = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBrowseKaryawan = new System.Windows.Forms.Button();
            this.btnBrowseSale = new System.Windows.Forms.Button();
            this.btnBrowsePelanggan = new System.Windows.Forms.Button();
            this.btnBrowseCabang = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnBrowseProduk = new System.Windows.Forms.Button();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblWarna = new System.Windows.Forms.Label();
            this.lblHarga = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cboMetodePembayaran = new System.Windows.Forms.ComboBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.label18 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnSimpanPenjualan = new System.Windows.Forms.Button();
            this.btnHapusPenjualan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudPajak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "No Faktur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tanggal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kode Pelanggan";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(319, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "% (persen)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Pajak";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Kode Produk";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "Kode Material";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 18);
            this.label11.TabIndex = 0;
            this.label11.Text = "Kode Kategori";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 149);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 18);
            this.label12.TabIndex = 0;
            this.label12.Text = "Qty";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(145, 18);
            this.label13.TabIndex = 0;
            this.label13.Text = "Metode Pembayaran";
            // 
            // txtNoFaktur
            // 
            this.txtNoFaktur.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNoFaktur.Location = new System.Drawing.Point(156, 19);
            this.txtNoFaktur.Name = "txtNoFaktur";
            this.txtNoFaktur.Size = new System.Drawing.Size(403, 24);
            this.txtNoFaktur.TabIndex = 1;
            // 
            // dtpTanggalPemesanan
            // 
            this.dtpTanggalPemesanan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpTanggalPemesanan.CustomFormat = "dddd, dd MMMM yyyy";
            this.dtpTanggalPemesanan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTanggalPemesanan.Location = new System.Drawing.Point(155, 298);
            this.dtpTanggalPemesanan.Name = "dtpTanggalPemesanan";
            this.dtpTanggalPemesanan.Size = new System.Drawing.Size(445, 24);
            this.dtpTanggalPemesanan.TabIndex = 2;
            // 
            // lblKodePelanggan
            // 
            this.lblKodePelanggan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKodePelanggan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKodePelanggan.Location = new System.Drawing.Point(156, 56);
            this.lblKodePelanggan.Name = "lblKodePelanggan";
            this.lblKodePelanggan.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblKodePelanggan.Size = new System.Drawing.Size(403, 24);
            this.lblKodePelanggan.TabIndex = 3;
            this.lblKodePelanggan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNamaPelanggan
            // 
            this.lblNamaPelanggan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNamaPelanggan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNamaPelanggan.Location = new System.Drawing.Point(156, 83);
            this.lblNamaPelanggan.Name = "lblNamaPelanggan";
            this.lblNamaPelanggan.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblNamaPelanggan.Size = new System.Drawing.Size(444, 24);
            this.lblNamaPelanggan.TabIndex = 3;
            this.lblNamaPelanggan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNamaCabang
            // 
            this.lblNamaCabang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNamaCabang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNamaCabang.Location = new System.Drawing.Point(156, 146);
            this.lblNamaCabang.Name = "lblNamaCabang";
            this.lblNamaCabang.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblNamaCabang.Size = new System.Drawing.Size(444, 24);
            this.lblNamaCabang.TabIndex = 3;
            this.lblNamaCabang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblKodeProduk
            // 
            this.lblKodeProduk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKodeProduk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKodeProduk.Location = new System.Drawing.Point(120, 17);
            this.lblKodeProduk.Name = "lblKodeProduk";
            this.lblKodeProduk.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblKodeProduk.Size = new System.Drawing.Size(468, 24);
            this.lblKodeProduk.TabIndex = 3;
            this.lblKodeProduk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNamaProduk
            // 
            this.lblNamaProduk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNamaProduk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNamaProduk.Location = new System.Drawing.Point(120, 44);
            this.lblNamaProduk.Name = "lblNamaProduk";
            this.lblNamaProduk.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblNamaProduk.Size = new System.Drawing.Size(506, 24);
            this.lblNamaProduk.TabIndex = 3;
            this.lblNamaProduk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblKodeMaterial
            // 
            this.lblKodeMaterial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKodeMaterial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKodeMaterial.Location = new System.Drawing.Point(120, 180);
            this.lblKodeMaterial.Name = "lblKodeMaterial";
            this.lblKodeMaterial.Size = new System.Drawing.Size(506, 24);
            this.lblKodeMaterial.TabIndex = 3;
            this.lblKodeMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblKodeKategori
            // 
            this.lblKodeKategori.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKodeKategori.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKodeKategori.Location = new System.Drawing.Point(120, 82);
            this.lblKodeKategori.Name = "lblKodeKategori";
            this.lblKodeKategori.Size = new System.Drawing.Size(506, 24);
            this.lblKodeKategori.TabIndex = 3;
            this.lblKodeKategori.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLokasiCabang
            // 
            this.lblLokasiCabang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLokasiCabang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLokasiCabang.Location = new System.Drawing.Point(156, 173);
            this.lblLokasiCabang.Name = "lblLokasiCabang";
            this.lblLokasiCabang.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblLokasiCabang.Size = new System.Drawing.Size(444, 48);
            this.lblLokasiCabang.TabIndex = 3;
            this.lblLokasiCabang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 122);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 18);
            this.label14.TabIndex = 0;
            this.label14.Text = "Kode Cabang";
            // 
            // lblKodeCabang
            // 
            this.lblKodeCabang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKodeCabang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKodeCabang.Location = new System.Drawing.Point(156, 119);
            this.lblKodeCabang.Name = "lblKodeCabang";
            this.lblKodeCabang.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblKodeCabang.Size = new System.Drawing.Size(403, 24);
            this.lblKodeCabang.TabIndex = 3;
            this.lblKodeCabang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudPajak
            // 
            this.nudPajak.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudPajak.Location = new System.Drawing.Point(171, 63);
            this.nudPajak.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudPajak.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudPajak.Name = "nudPajak";
            this.nudPajak.ReadOnly = true;
            this.nudPajak.Size = new System.Drawing.Size(142, 24);
            this.nudPajak.TabIndex = 5;
            this.nudPajak.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudPajak.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // nudQty
            // 
            this.nudQty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudQty.Location = new System.Drawing.Point(120, 147);
            this.nudQty.Name = "nudQty";
            this.nudQty.Size = new System.Drawing.Size(451, 24);
            this.nudQty.TabIndex = 6;
            this.nudQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudQty.ValueChanged += new System.EventHandler(this.nudQty_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "Kode Karyawan";
            // 
            // lblKodeKaryawan
            // 
            this.lblKodeKaryawan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKodeKaryawan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKodeKaryawan.Location = new System.Drawing.Point(156, 235);
            this.lblKodeKaryawan.Name = "lblKodeKaryawan";
            this.lblKodeKaryawan.Size = new System.Drawing.Size(406, 24);
            this.lblKodeKaryawan.TabIndex = 3;
            this.lblKodeKaryawan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNamaKaryawan
            // 
            this.lblNamaKaryawan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNamaKaryawan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNamaKaryawan.Location = new System.Drawing.Point(156, 262);
            this.lblNamaKaryawan.Name = "lblNamaKaryawan";
            this.lblNamaKaryawan.Size = new System.Drawing.Size(444, 24);
            this.lblNamaKaryawan.TabIndex = 3;
            this.lblNamaKaryawan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpTanggalPemesanan);
            this.groupBox1.Controls.Add(this.btnBrowseKaryawan);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblNamaKaryawan);
            this.groupBox1.Controls.Add(this.txtNoFaktur);
            this.groupBox1.Controls.Add(this.lblKodePelanggan);
            this.groupBox1.Controls.Add(this.lblNamaPelanggan);
            this.groupBox1.Controls.Add(this.lblKodeKaryawan);
            this.groupBox1.Controls.Add(this.btnBrowseSale);
            this.groupBox1.Controls.Add(this.btnBrowsePelanggan);
            this.groupBox1.Controls.Add(this.btnBrowseCabang);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblKodeCabang);
            this.groupBox1.Controls.Add(this.lblNamaCabang);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.lblLokasiCabang);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(614, 337);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Header Penjualan";
            // 
            // btnBrowseKaryawan
            // 
            this.btnBrowseKaryawan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseKaryawan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(57)))), ((int)(((byte)(94)))));
            this.btnBrowseKaryawan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseKaryawan.ForeColor = System.Drawing.Color.White;
            this.btnBrowseKaryawan.Image = global::Tugas_2_PAB.Properties.Resources.icons8_browse_page_24;
            this.btnBrowseKaryawan.Location = new System.Drawing.Point(568, 235);
            this.btnBrowseKaryawan.Name = "btnBrowseKaryawan";
            this.btnBrowseKaryawan.Size = new System.Drawing.Size(32, 25);
            this.btnBrowseKaryawan.TabIndex = 4;
            this.btnBrowseKaryawan.UseVisualStyleBackColor = false;
            this.btnBrowseKaryawan.Click += new System.EventHandler(this.btnBroseKaryawan_Click);
            // 
            // btnBrowseSale
            // 
            this.btnBrowseSale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(57)))), ((int)(((byte)(94)))));
            this.btnBrowseSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseSale.ForeColor = System.Drawing.Color.White;
            this.btnBrowseSale.Image = global::Tugas_2_PAB.Properties.Resources.icons8_browse_page_24;
            this.btnBrowseSale.Location = new System.Drawing.Point(568, 18);
            this.btnBrowseSale.Name = "btnBrowseSale";
            this.btnBrowseSale.Size = new System.Drawing.Size(32, 25);
            this.btnBrowseSale.TabIndex = 4;
            this.btnBrowseSale.UseVisualStyleBackColor = false;
            this.btnBrowseSale.Click += new System.EventHandler(this.btnBrowseSale_Click);
            // 
            // btnBrowsePelanggan
            // 
            this.btnBrowsePelanggan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowsePelanggan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(57)))), ((int)(((byte)(94)))));
            this.btnBrowsePelanggan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowsePelanggan.ForeColor = System.Drawing.Color.White;
            this.btnBrowsePelanggan.Image = global::Tugas_2_PAB.Properties.Resources.icons8_browse_page_24;
            this.btnBrowsePelanggan.Location = new System.Drawing.Point(568, 56);
            this.btnBrowsePelanggan.Name = "btnBrowsePelanggan";
            this.btnBrowsePelanggan.Size = new System.Drawing.Size(32, 25);
            this.btnBrowsePelanggan.TabIndex = 4;
            this.btnBrowsePelanggan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBrowsePelanggan.UseVisualStyleBackColor = false;
            this.btnBrowsePelanggan.Click += new System.EventHandler(this.btnBrowsePelanggan_Click);
            // 
            // btnBrowseCabang
            // 
            this.btnBrowseCabang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseCabang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(57)))), ((int)(((byte)(94)))));
            this.btnBrowseCabang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseCabang.ForeColor = System.Drawing.Color.White;
            this.btnBrowseCabang.Image = global::Tugas_2_PAB.Properties.Resources.icons8_browse_page_24;
            this.btnBrowseCabang.Location = new System.Drawing.Point(568, 118);
            this.btnBrowseCabang.Name = "btnBrowseCabang";
            this.btnBrowseCabang.Size = new System.Drawing.Size(32, 25);
            this.btnBrowseCabang.TabIndex = 4;
            this.btnBrowseCabang.UseVisualStyleBackColor = false;
            this.btnBrowseCabang.Click += new System.EventHandler(this.btnBrowseCabang_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.btnTambah);
            this.groupBox3.Controls.Add(this.lblKodeProduk);
            this.groupBox3.Controls.Add(this.btnUbah);
            this.groupBox3.Controls.Add(this.btnHapus);
            this.groupBox3.Controls.Add(this.btnBrowseProduk);
            this.groupBox3.Controls.Add(this.lblNamaProduk);
            this.groupBox3.Controls.Add(this.nudQty);
            this.groupBox3.Controls.Add(this.lblSubtotal);
            this.groupBox3.Controls.Add(this.lblWarna);
            this.groupBox3.Controls.Add(this.lblHarga);
            this.groupBox3.Controls.Add(this.lblKodeKategori);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.lblKodeMaterial);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(632, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(640, 332);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detail Penjualan";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(577, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 22);
            this.label4.TabIndex = 19;
            this.label4.Text = "pcs";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(57)))), ((int)(((byte)(94)))));
            this.btnTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambah.ForeColor = System.Drawing.Color.White;
            this.btnTambah.Image = global::Tugas_2_PAB.Properties.Resources.icons8_add_24;
            this.btnTambah.Location = new System.Drawing.Point(169, 247);
            this.btnTambah.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnTambah.Size = new System.Drawing.Size(147, 39);
            this.btnTambah.TabIndex = 1;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnUbah
            // 
            this.btnUbah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(57)))), ((int)(((byte)(94)))));
            this.btnUbah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUbah.ForeColor = System.Drawing.Color.White;
            this.btnUbah.Image = global::Tugas_2_PAB.Properties.Resources.icons8_edit_24;
            this.btnUbah.Location = new System.Drawing.Point(479, 247);
            this.btnUbah.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnUbah.Size = new System.Drawing.Size(147, 39);
            this.btnUbah.TabIndex = 2;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUbah.UseVisualStyleBackColor = false;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(57)))), ((int)(((byte)(94)))));
            this.btnHapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.ForeColor = System.Drawing.Color.White;
            this.btnHapus.Image = global::Tugas_2_PAB.Properties.Resources.icons8_delete_24;
            this.btnHapus.Location = new System.Drawing.Point(324, 247);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnHapus.Size = new System.Drawing.Size(147, 39);
            this.btnHapus.TabIndex = 3;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnBrowseProduk
            // 
            this.btnBrowseProduk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseProduk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(57)))), ((int)(((byte)(94)))));
            this.btnBrowseProduk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseProduk.ForeColor = System.Drawing.Color.White;
            this.btnBrowseProduk.Image = global::Tugas_2_PAB.Properties.Resources.icons8_browse_page_24;
            this.btnBrowseProduk.Location = new System.Drawing.Point(594, 16);
            this.btnBrowseProduk.Name = "btnBrowseProduk";
            this.btnBrowseProduk.Size = new System.Drawing.Size(32, 25);
            this.btnBrowseProduk.TabIndex = 4;
            this.btnBrowseProduk.UseVisualStyleBackColor = false;
            this.btnBrowseProduk.Click += new System.EventHandler(this.btnBrowseProduk_Click);
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.ForeColor = System.Drawing.Color.Black;
            this.lblSubtotal.Location = new System.Drawing.Point(217, 296);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(409, 24);
            this.lblSubtotal.TabIndex = 3;
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWarna
            // 
            this.lblWarna.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWarna.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWarna.Location = new System.Drawing.Point(120, 216);
            this.lblWarna.Name = "lblWarna";
            this.lblWarna.Size = new System.Drawing.Size(506, 24);
            this.lblWarna.TabIndex = 3;
            this.lblWarna.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblWarna.Click += new System.EventHandler(this.lblWarna_Click);
            // 
            // lblHarga
            // 
            this.lblHarga.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHarga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHarga.Location = new System.Drawing.Point(120, 115);
            this.lblHarga.Name = "lblHarga";
            this.lblHarga.Size = new System.Drawing.Size(506, 24);
            this.lblHarga.TabIndex = 3;
            this.lblHarga.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 18);
            this.label10.TabIndex = 0;
            this.label10.Text = "Harga";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(116, 296);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(85, 24);
            this.label17.TabIndex = 0;
            this.label17.Text = "Subtotal";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 219);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 18);
            this.label16.TabIndex = 0;
            this.label16.Text = "Warna";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox4.Controls.Add(this.cboMetodePembayaran);
            this.groupBox4.Controls.Add(this.nudPajak);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Location = new System.Drawing.Point(859, 346);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(413, 105);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pembayaran";
            // 
            // cboMetodePembayaran
            // 
            this.cboMetodePembayaran.FormattingEnabled = true;
            this.cboMetodePembayaran.Location = new System.Drawing.Point(171, 20);
            this.cboMetodePembayaran.Name = "cboMetodePembayaran";
            this.cboMetodePembayaran.Size = new System.Drawing.Size(228, 26);
            this.cboMetodePembayaran.TabIndex = 6;
            // 
            // dgvData
            // 
            this.dgvData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(12, 346);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(839, 306);
            this.dgvData.TabIndex = 6;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(854, 600);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(88, 41);
            this.label18.TabIndex = 17;
            this.label18.Text = "TOTAL";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Red;
            this.lblTotal.Location = new System.Drawing.Point(947, 585);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(325, 67);
            this.lblTotal.TabIndex = 18;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSimpanPenjualan
            // 
            this.btnSimpanPenjualan.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSimpanPenjualan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(57)))), ((int)(((byte)(94)))));
            this.btnSimpanPenjualan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpanPenjualan.ForeColor = System.Drawing.Color.White;
            this.btnSimpanPenjualan.Image = global::Tugas_2_PAB.Properties.Resources.icons8_save_24;
            this.btnSimpanPenjualan.Location = new System.Drawing.Point(947, 528);
            this.btnSimpanPenjualan.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnSimpanPenjualan.Name = "btnSimpanPenjualan";
            this.btnSimpanPenjualan.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSimpanPenjualan.Size = new System.Drawing.Size(158, 50);
            this.btnSimpanPenjualan.TabIndex = 4;
            this.btnSimpanPenjualan.Text = " Simpan";
            this.btnSimpanPenjualan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSimpanPenjualan.UseVisualStyleBackColor = false;
            this.btnSimpanPenjualan.Click += new System.EventHandler(this.btnSimpanPenjualan_Click);
            // 
            // btnHapusPenjualan
            // 
            this.btnHapusPenjualan.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnHapusPenjualan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(57)))), ((int)(((byte)(94)))));
            this.btnHapusPenjualan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapusPenjualan.ForeColor = System.Drawing.Color.White;
            this.btnHapusPenjualan.Image = global::Tugas_2_PAB.Properties.Resources.icons8_delete_24;
            this.btnHapusPenjualan.Location = new System.Drawing.Point(1113, 528);
            this.btnHapusPenjualan.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnHapusPenjualan.Name = "btnHapusPenjualan";
            this.btnHapusPenjualan.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnHapusPenjualan.Size = new System.Drawing.Size(158, 50);
            this.btnHapusPenjualan.TabIndex = 4;
            this.btnHapusPenjualan.Text = "Hapus";
            this.btnHapusPenjualan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHapusPenjualan.UseVisualStyleBackColor = false;
            this.btnHapusPenjualan.Click += new System.EventHandler(this.btnHapusPenjualan_Click);
            // 
            // frmSale
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.btnSimpanPenjualan);
            this.Controls.Add(this.btnHapusPenjualan);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmSale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TRANSAKSI PENJUALAN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSale_FormClosing);
            this.Load += new System.EventHandler(this.frmSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPajak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button btnHapusPenjualan;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox txtNoFaktur;
        public System.Windows.Forms.DateTimePicker dtpTanggalPemesanan;
        public System.Windows.Forms.Label lblKodePelanggan;
        public System.Windows.Forms.Label lblNamaPelanggan;
        public System.Windows.Forms.Label lblNamaCabang;
        public System.Windows.Forms.Label lblKodeProduk;
        public System.Windows.Forms.Label lblNamaProduk;
        public System.Windows.Forms.Label lblKodeMaterial;
        public System.Windows.Forms.Label lblKodeKategori;
        public System.Windows.Forms.Label lblLokasiCabang;
        public System.Windows.Forms.Button btnBrowsePelanggan;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.Label lblKodeCabang;
        public System.Windows.Forms.Button btnBrowseCabang;
        public System.Windows.Forms.Button btnBrowseProduk;
        public System.Windows.Forms.NumericUpDown nudPajak;
        public System.Windows.Forms.NumericUpDown nudQty;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label lblKodeKaryawan;
        public System.Windows.Forms.Label lblNamaKaryawan;
        public System.Windows.Forms.Button btnBrowseKaryawan;
        public System.Windows.Forms.Label lblSubtotal;
        public System.Windows.Forms.Label lblWarna;
        public System.Windows.Forms.Label lblHarga;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label17;
        public System.Windows.Forms.Label label16;
        public System.Windows.Forms.Button btnTambah;
        public System.Windows.Forms.Button btnUbah;
        public System.Windows.Forms.Button btnHapus;
        public System.Windows.Forms.Button btnBrowseSale;
        public System.Windows.Forms.Button btnSimpanPenjualan;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.DataGridView dgvData;
        public System.Windows.Forms.ComboBox cboMetodePembayaran;
        public System.Windows.Forms.Label label18;
        public System.Windows.Forms.Label lblTotal;
        public System.Windows.Forms.Label label4;
    }
}