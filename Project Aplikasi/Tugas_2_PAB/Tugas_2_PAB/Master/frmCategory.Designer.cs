
namespace Tugas_2_PAB.Master
{
    partial class frmCategory
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
            this.txtNamaKategori = new System.Windows.Forms.TextBox();
            this.txtKodeKategori = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.groupBox1.Controls.Add(this.txtNamaKategori);
            this.groupBox1.Controls.Add(this.txtKodeKategori);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(484, 109);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // txtNamaKategori
            // 
            this.txtNamaKategori.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNamaKategori.Location = new System.Drawing.Point(157, 65);
            this.txtNamaKategori.Margin = new System.Windows.Forms.Padding(2);
            this.txtNamaKategori.Multiline = true;
            this.txtNamaKategori.Name = "txtNamaKategori";
            this.txtNamaKategori.Size = new System.Drawing.Size(280, 25);
            this.txtNamaKategori.TabIndex = 6;
            this.txtNamaKategori.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNamaKategori_KeyPress);
            // 
            // txtKodeKategori
            // 
            this.txtKodeKategori.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKodeKategori.Location = new System.Drawing.Point(157, 24);
            this.txtKodeKategori.Margin = new System.Windows.Forms.Padding(2);
            this.txtKodeKategori.Multiline = true;
            this.txtKodeKategori.Name = "txtKodeKategori";
            this.txtKodeKategori.Size = new System.Drawing.Size(280, 25);
            this.txtKodeKategori.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Kategori";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kode Kategori";
            // 
            // btnTampil
            // 
            this.btnTampil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(57)))), ((int)(((byte)(94)))));
            this.btnTampil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTampil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTampil.ForeColor = System.Drawing.Color.White;
            this.btnTampil.Image = global::Tugas_2_PAB.Properties.Resources.icons8_browse_page_24;
            this.btnTampil.Location = new System.Drawing.Point(425, 118);
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
            this.btnTambah.Location = new System.Drawing.Point(190, 118);
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
            this.btnUbah.Location = new System.Drawing.Point(268, 118);
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
            this.btnHapus.Location = new System.Drawing.Point(347, 118);
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
            // frmCategory
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(506, 197);
            this.Controls.Add(this.btnTampil);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnHapus);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmCategory";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MASTER DATA KATEGORI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCategory_FormClosing);
            this.Load += new System.EventHandler(this.frmCategory_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txtNamaKategori;
        public System.Windows.Forms.TextBox txtKodeKategori;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnTambah;
        public System.Windows.Forms.Button btnTampil;
        public System.Windows.Forms.Button btnUbah;
        public System.Windows.Forms.Button btnHapus;
    }
}