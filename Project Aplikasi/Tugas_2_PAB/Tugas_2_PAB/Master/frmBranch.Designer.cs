
namespace Tugas_2_PAB.Master
{
    partial class frmBranch
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKodeCabang = new System.Windows.Forms.TextBox();
            this.txtNamaCabang = new System.Windows.Forms.TextBox();
            this.txtLokasiCabang = new System.Windows.Forms.TextBox();
            this.btnTampil = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kode Cabang";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Cabang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lokasi Cabang";
            // 
            // txtKodeCabang
            // 
            this.txtKodeCabang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKodeCabang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKodeCabang.Location = new System.Drawing.Point(121, 12);
            this.txtKodeCabang.Margin = new System.Windows.Forms.Padding(2);
            this.txtKodeCabang.Multiline = true;
            this.txtKodeCabang.Name = "txtKodeCabang";
            this.txtKodeCabang.Size = new System.Drawing.Size(211, 25);
            this.txtKodeCabang.TabIndex = 5;
            this.txtKodeCabang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKodeCabang_KeyPress);
            // 
            // txtNamaCabang
            // 
            this.txtNamaCabang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNamaCabang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamaCabang.Location = new System.Drawing.Point(121, 64);
            this.txtNamaCabang.Margin = new System.Windows.Forms.Padding(2);
            this.txtNamaCabang.Multiline = true;
            this.txtNamaCabang.Name = "txtNamaCabang";
            this.txtNamaCabang.Size = new System.Drawing.Size(211, 25);
            this.txtNamaCabang.TabIndex = 6;
            this.txtNamaCabang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNamaCabang_KeyPress);
            // 
            // txtLokasiCabang
            // 
            this.txtLokasiCabang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLokasiCabang.Location = new System.Drawing.Point(14, 123);
            this.txtLokasiCabang.Margin = new System.Windows.Forms.Padding(2);
            this.txtLokasiCabang.Multiline = true;
            this.txtLokasiCabang.Name = "txtLokasiCabang";
            this.txtLokasiCabang.Size = new System.Drawing.Size(318, 75);
            this.txtLokasiCabang.TabIndex = 7;
            // 
            // btnTampil
            // 
            this.btnTampil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(57)))), ((int)(((byte)(94)))));
            this.btnTampil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTampil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTampil.ForeColor = System.Drawing.Color.White;
            this.btnTampil.Image = global::Tugas_2_PAB.Properties.Resources.icons8_browse_page_24;
            this.btnTampil.Location = new System.Drawing.Point(247, 207);
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
            // btnUbah
            // 
            this.btnUbah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(57)))), ((int)(((byte)(94)))));
            this.btnUbah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUbah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUbah.ForeColor = System.Drawing.Color.White;
            this.btnUbah.Image = global::Tugas_2_PAB.Properties.Resources.icons8_edit_24;
            this.btnUbah.Location = new System.Drawing.Point(91, 207);
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
            this.btnHapus.Location = new System.Drawing.Point(169, 207);
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
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(57)))), ((int)(((byte)(94)))));
            this.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambah.ForeColor = System.Drawing.Color.White;
            this.btnTambah.Image = global::Tugas_2_PAB.Properties.Resources.icons8_add_24;
            this.btnTambah.Location = new System.Drawing.Point(13, 207);
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
            // frmBranch
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(336, 287);
            this.Controls.Add(this.btnTampil);
            this.Controls.Add(this.txtLokasiCabang);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNamaCabang);
            this.Controls.Add(this.txtKodeCabang);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmBranch";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MASTER DATA CABANG";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBranch_FormClosing);
            this.Load += new System.EventHandler(this.frmBranch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtKodeCabang;
        public System.Windows.Forms.TextBox txtNamaCabang;
        public System.Windows.Forms.Button btnTambah;
        public System.Windows.Forms.Button btnHapus;
        public System.Windows.Forms.Button btnUbah;
        public System.Windows.Forms.TextBox txtLokasiCabang;
        public System.Windows.Forms.Button btnTampil;
    }
}