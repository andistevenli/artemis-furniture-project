
namespace Tugas_2_PAB.Master
{
    partial class frmProduct
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBrowseMaterial = new System.Windows.Forms.Button();
            this.btnBrowseKategori = new System.Windows.Forms.Button();
            this.lblKodeMaterial = new System.Windows.Forms.Label();
            this.lblKodeKategori = new System.Windows.Forms.Label();
            this.nudStok = new System.Windows.Forms.NumericUpDown();
            this.nudHarga = new System.Windows.Forms.NumericUpDown();
            this.cboWarna = new System.Windows.Forms.ComboBox();
            this.txtNamaProduk = new System.Windows.Forms.TextBox();
            this.txtKodeProduk = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnTampil = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHarga)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBrowseMaterial);
            this.groupBox1.Controls.Add(this.btnBrowseKategori);
            this.groupBox1.Controls.Add(this.lblKodeMaterial);
            this.groupBox1.Controls.Add(this.lblKodeKategori);
            this.groupBox1.Controls.Add(this.nudStok);
            this.groupBox1.Controls.Add(this.nudHarga);
            this.groupBox1.Controls.Add(this.cboWarna);
            this.groupBox1.Controls.Add(this.txtNamaProduk);
            this.groupBox1.Controls.Add(this.txtKodeProduk);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(516, 319);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // btnBrowseMaterial
            // 
            this.btnBrowseMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(57)))), ((int)(((byte)(94)))));
            this.btnBrowseMaterial.Image = global::Tugas_2_PAB.Properties.Resources.icons8_browse_page_24;
            this.btnBrowseMaterial.Location = new System.Drawing.Point(443, 272);
            this.btnBrowseMaterial.Name = "btnBrowseMaterial";
            this.btnBrowseMaterial.Size = new System.Drawing.Size(54, 29);
            this.btnBrowseMaterial.TabIndex = 10;
            this.btnBrowseMaterial.Text = ". . .";
            this.btnBrowseMaterial.UseVisualStyleBackColor = false;
            this.btnBrowseMaterial.Click += new System.EventHandler(this.btnBrowseMaterial_Click);
            // 
            // btnBrowseKategori
            // 
            this.btnBrowseKategori.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(57)))), ((int)(((byte)(94)))));
            this.btnBrowseKategori.Image = global::Tugas_2_PAB.Properties.Resources.icons8_browse_page_24;
            this.btnBrowseKategori.Location = new System.Drawing.Point(443, 229);
            this.btnBrowseKategori.Name = "btnBrowseKategori";
            this.btnBrowseKategori.Size = new System.Drawing.Size(54, 29);
            this.btnBrowseKategori.TabIndex = 10;
            this.btnBrowseKategori.UseVisualStyleBackColor = false;
            this.btnBrowseKategori.Click += new System.EventHandler(this.btnBrowseKategori_Click);
            // 
            // lblKodeMaterial
            // 
            this.lblKodeMaterial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKodeMaterial.Location = new System.Drawing.Point(157, 276);
            this.lblKodeMaterial.Name = "lblKodeMaterial";
            this.lblKodeMaterial.Size = new System.Drawing.Size(280, 25);
            this.lblKodeMaterial.TabIndex = 9;
            this.lblKodeMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblKodeKategori
            // 
            this.lblKodeKategori.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKodeKategori.Location = new System.Drawing.Point(157, 233);
            this.lblKodeKategori.Name = "lblKodeKategori";
            this.lblKodeKategori.Size = new System.Drawing.Size(280, 25);
            this.lblKodeKategori.TabIndex = 9;
            this.lblKodeKategori.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudStok
            // 
            this.nudStok.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudStok.Location = new System.Drawing.Point(157, 192);
            this.nudStok.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.nudStok.Name = "nudStok";
            this.nudStok.ReadOnly = true;
            this.nudStok.Size = new System.Drawing.Size(280, 24);
            this.nudStok.TabIndex = 8;
            this.nudStok.ThousandsSeparator = true;
            // 
            // nudHarga
            // 
            this.nudHarga.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudHarga.Increment = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudHarga.Location = new System.Drawing.Point(157, 154);
            this.nudHarga.Maximum = new decimal(new int[] {
            300000,
            0,
            0,
            0});
            this.nudHarga.Name = "nudHarga";
            this.nudHarga.ReadOnly = true;
            this.nudHarga.Size = new System.Drawing.Size(280, 24);
            this.nudHarga.TabIndex = 8;
            this.nudHarga.ThousandsSeparator = true;
            // 
            // cboWarna
            // 
            this.cboWarna.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboWarna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboWarna.FormattingEnabled = true;
            this.cboWarna.Items.AddRange(new object[] {
            "Hitam",
            "Biru",
            "Merah",
            "Kuning",
            "Hijau",
            "Abu-Abu",
            "Putih"});
            this.cboWarna.Location = new System.Drawing.Point(157, 108);
            this.cboWarna.Name = "cboWarna";
            this.cboWarna.Size = new System.Drawing.Size(280, 26);
            this.cboWarna.TabIndex = 7;
            // 
            // txtNamaProduk
            // 
            this.txtNamaProduk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNamaProduk.Location = new System.Drawing.Point(157, 65);
            this.txtNamaProduk.Margin = new System.Windows.Forms.Padding(2);
            this.txtNamaProduk.Multiline = true;
            this.txtNamaProduk.Name = "txtNamaProduk";
            this.txtNamaProduk.Size = new System.Drawing.Size(280, 25);
            this.txtNamaProduk.TabIndex = 6;
            this.txtNamaProduk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNamaProduk_KeyPress);
            // 
            // txtKodeProduk
            // 
            this.txtKodeProduk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKodeProduk.Location = new System.Drawing.Point(157, 24);
            this.txtKodeProduk.Margin = new System.Windows.Forms.Padding(2);
            this.txtKodeProduk.Multiline = true;
            this.txtKodeProduk.Name = "txtKodeProduk";
            this.txtKodeProduk.Size = new System.Drawing.Size(280, 25);
            this.txtKodeProduk.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(11, 281);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 18);
            this.label7.TabIndex = 4;
            this.label7.Text = "Kode Material";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(11, 238);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Kode Kategori";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 194);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Stok";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(11, 156);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Harga";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(11, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Warna";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(11, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Produk";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(11, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kode Produk";
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(57)))), ((int)(((byte)(94)))));
            this.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.ForeColor = System.Drawing.Color.White;
            this.btnHapus.Image = global::Tugas_2_PAB.Properties.Resources.icons8_delete_24;
            this.btnHapus.Location = new System.Drawing.Point(368, 328);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnHapus.Size = new System.Drawing.Size(70, 70);
            this.btnHapus.TabIndex = 3;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnUbah
            // 
            this.btnUbah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(57)))), ((int)(((byte)(94)))));
            this.btnUbah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUbah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUbah.ForeColor = System.Drawing.Color.White;
            this.btnUbah.Image = global::Tugas_2_PAB.Properties.Resources.icons8_edit_24;
            this.btnUbah.Location = new System.Drawing.Point(290, 328);
            this.btnUbah.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnUbah.Size = new System.Drawing.Size(70, 70);
            this.btnUbah.TabIndex = 2;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUbah.UseVisualStyleBackColor = false;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(57)))), ((int)(((byte)(94)))));
            this.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambah.ForeColor = System.Drawing.Color.White;
            this.btnTambah.Image = global::Tugas_2_PAB.Properties.Resources.icons8_add_24;
            this.btnTambah.Location = new System.Drawing.Point(212, 328);
            this.btnTambah.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnTambah.Size = new System.Drawing.Size(70, 70);
            this.btnTambah.TabIndex = 1;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnTampil
            // 
            this.btnTampil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(57)))), ((int)(((byte)(94)))));
            this.btnTampil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTampil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTampil.ForeColor = System.Drawing.Color.White;
            this.btnTampil.Image = global::Tugas_2_PAB.Properties.Resources.icons8_browse_page_24;
            this.btnTampil.Location = new System.Drawing.Point(446, 328);
            this.btnTampil.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnTampil.Name = "btnTampil";
            this.btnTampil.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnTampil.Size = new System.Drawing.Size(70, 70);
            this.btnTampil.TabIndex = 4;
            this.btnTampil.Text = " Tampil";
            this.btnTampil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTampil.UseVisualStyleBackColor = false;
            this.btnTampil.Click += new System.EventHandler(this.btnTampil_Click);
            // 
            // frmProduct
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(527, 403);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTampil);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmProduct";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MASTER DATA PRODUK";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmProduct_FormClosing);
            this.Load += new System.EventHandler(this.frmProduk_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHarga)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txtNamaProduk;
        public System.Windows.Forms.TextBox txtKodeProduk;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnTambah;
        public System.Windows.Forms.Button btnTampil;
        public System.Windows.Forms.Button btnUbah;
        public System.Windows.Forms.Button btnHapus;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox cboWarna;
        public System.Windows.Forms.NumericUpDown nudStok;
        public System.Windows.Forms.NumericUpDown nudHarga;
        public System.Windows.Forms.Button btnBrowseMaterial;
        public System.Windows.Forms.Button btnBrowseKategori;
        public System.Windows.Forms.Label lblKodeMaterial;
        public System.Windows.Forms.Label lblKodeKategori;
    }
}