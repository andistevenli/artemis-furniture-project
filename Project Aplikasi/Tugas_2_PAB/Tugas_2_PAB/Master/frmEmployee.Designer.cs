
namespace Tugas_2_PAB.Master
{
    partial class frmEmployee
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
            this.cboJabatan = new System.Windows.Forms.ComboBox();
            this.cboJenisKelamin = new System.Windows.Forms.ComboBox();
            this.txtNoHPKaryawan = new System.Windows.Forms.TextBox();
            this.txtAlamatKaryawan = new System.Windows.Forms.TextBox();
            this.txtNamaKaryawan = new System.Windows.Forms.TextBox();
            this.txtKodeKaryawan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTampil = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboJabatan);
            this.groupBox1.Controls.Add(this.cboJenisKelamin);
            this.groupBox1.Controls.Add(this.txtNoHPKaryawan);
            this.groupBox1.Controls.Add(this.txtAlamatKaryawan);
            this.groupBox1.Controls.Add(this.txtNamaKaryawan);
            this.groupBox1.Controls.Add(this.txtKodeKaryawan);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(454, 314);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cboJabatan
            // 
            this.cboJabatan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboJabatan.FormattingEnabled = true;
            this.cboJabatan.Location = new System.Drawing.Point(157, 276);
            this.cboJabatan.Name = "cboJabatan";
            this.cboJabatan.Size = new System.Drawing.Size(280, 26);
            this.cboJabatan.TabIndex = 11;
            // 
            // cboJenisKelamin
            // 
            this.cboJenisKelamin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboJenisKelamin.FormattingEnabled = true;
            this.cboJenisKelamin.Location = new System.Drawing.Point(157, 192);
            this.cboJenisKelamin.Name = "cboJenisKelamin";
            this.cboJenisKelamin.Size = new System.Drawing.Size(280, 26);
            this.cboJenisKelamin.TabIndex = 10;
            // 
            // txtNoHPKaryawan
            // 
            this.txtNoHPKaryawan.Location = new System.Drawing.Point(157, 233);
            this.txtNoHPKaryawan.Margin = new System.Windows.Forms.Padding(2);
            this.txtNoHPKaryawan.Multiline = true;
            this.txtNoHPKaryawan.Name = "txtNoHPKaryawan";
            this.txtNoHPKaryawan.Size = new System.Drawing.Size(280, 25);
            this.txtNoHPKaryawan.TabIndex = 9;
            this.txtNoHPKaryawan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoHPKaryawan_KeyPress);
            // 
            // txtAlamatKaryawan
            // 
            this.txtAlamatKaryawan.Location = new System.Drawing.Point(157, 108);
            this.txtAlamatKaryawan.Margin = new System.Windows.Forms.Padding(2);
            this.txtAlamatKaryawan.Multiline = true;
            this.txtAlamatKaryawan.Name = "txtAlamatKaryawan";
            this.txtAlamatKaryawan.Size = new System.Drawing.Size(280, 75);
            this.txtAlamatKaryawan.TabIndex = 7;
            // 
            // txtNamaKaryawan
            // 
            this.txtNamaKaryawan.Location = new System.Drawing.Point(157, 65);
            this.txtNamaKaryawan.Margin = new System.Windows.Forms.Padding(2);
            this.txtNamaKaryawan.Multiline = true;
            this.txtNamaKaryawan.Name = "txtNamaKaryawan";
            this.txtNamaKaryawan.Size = new System.Drawing.Size(280, 25);
            this.txtNamaKaryawan.TabIndex = 6;
            this.txtNamaKaryawan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNamaKaryawan_KeyPress);
            // 
            // txtKodeKaryawan
            // 
            this.txtKodeKaryawan.Location = new System.Drawing.Point(157, 24);
            this.txtKodeKaryawan.Margin = new System.Windows.Forms.Padding(2);
            this.txtKodeKaryawan.Multiline = true;
            this.txtKodeKaryawan.Name = "txtKodeKaryawan";
            this.txtKodeKaryawan.Size = new System.Drawing.Size(280, 25);
            this.txtKodeKaryawan.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 195);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Jenis Kelamin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 236);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "No.HP Karyawan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alamat Karyawan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Karyawan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 279);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Jabatan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kode Karyawan";
            // 
            // btnTampil
            // 
            this.btnTampil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(57)))), ((int)(((byte)(94)))));
            this.btnTampil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTampil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTampil.ForeColor = System.Drawing.Color.White;
            this.btnTampil.Image = global::Tugas_2_PAB.Properties.Resources.icons8_browse_page_24;
            this.btnTampil.Location = new System.Drawing.Point(384, 323);
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
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(57)))), ((int)(((byte)(94)))));
            this.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambah.ForeColor = System.Drawing.Color.White;
            this.btnTambah.Image = global::Tugas_2_PAB.Properties.Resources.icons8_add_24;
            this.btnTambah.Location = new System.Drawing.Point(150, 323);
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
            // btnUbah
            // 
            this.btnUbah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(57)))), ((int)(((byte)(94)))));
            this.btnUbah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUbah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUbah.ForeColor = System.Drawing.Color.White;
            this.btnUbah.Image = global::Tugas_2_PAB.Properties.Resources.icons8_edit_24;
            this.btnUbah.Location = new System.Drawing.Point(228, 323);
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
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(57)))), ((int)(((byte)(94)))));
            this.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.ForeColor = System.Drawing.Color.White;
            this.btnHapus.Image = global::Tugas_2_PAB.Properties.Resources.icons8_delete_24;
            this.btnHapus.Location = new System.Drawing.Point(306, 323);
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
            // frmEmployee
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(465, 400);
            this.Controls.Add(this.btnTampil);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnHapus);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "frmEmployee";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MASTER DATA KARYAWAN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEmployee_FormClosing);
            this.Load += new System.EventHandler(this.frmEmployee_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txtNoHPKaryawan;
        public System.Windows.Forms.TextBox txtAlamatKaryawan;
        public System.Windows.Forms.TextBox txtNamaKaryawan;
        public System.Windows.Forms.TextBox txtKodeKaryawan;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnTambah;
        public System.Windows.Forms.Button btnTampil;
        public System.Windows.Forms.Button btnUbah;
        public System.Windows.Forms.Button btnHapus;
        public System.Windows.Forms.ComboBox cboJenisKelamin;
        public System.Windows.Forms.ComboBox cboJabatan;
    }
}