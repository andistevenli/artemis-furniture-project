using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Tugas_2_PAB.Transaction
{
    public partial class frmSale : Form
    {
        public frmSale()
        {
            InitializeComponent();
        }

        private void frmSale_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMain.formAktif = null;
        }

        SqlConnection con;
        string sourcedata;

        SqlDataAdapter da;
        SqlCommand cmd;
        string query;

        DataSet ds;
        DataSet dsproduk;
        DataRow dr;
        DataColumn[] dc_1PK = new DataColumn[1];
        DataColumn[] dc_2PK = new DataColumn[2];
        SqlCommandBuilder cb;



        //prosedur
        private void koneksi()
        {
            try
            {
                sourcedata = "Data Source = localhost; Initial Catalog = Tugas2_PAB; Integrated Security = true";
                con = new SqlConnection(sourcedata);
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void LoadDataPenjualan()
        {
            ds = new DataSet();
            query = "SELECT * FROM Penjualan";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Penjualan");
            dc_1PK[0] = ds.Tables["Penjualan"].Columns[0];
            ds.Tables["Penjualan"].PrimaryKey = dc_1PK;
        }

        public void LoadDataDetailPenjualan()
        {
            ds = new DataSet();
            query = "SELECT * FROM DetailPenjualan";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "DetailPenjualan");
            dc_2PK[0] = ds.Tables["DetailPenjualan"].Columns[0];
            dc_2PK[1] = ds.Tables["DetailPenjualan"].Columns[1];
            ds.Tables["DetailPenjualan"].PrimaryKey = dc_2PK;
        }

        public void LoadDataProduk()
        {
            dsproduk = new DataSet();
            query = "SELECT * FROM Produk";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(dsproduk, "Produk");
            dc_1PK[0] = dsproduk.Tables["Produk"].Columns[0];
            dsproduk.Tables["Produk"].PrimaryKey = dc_1PK;
        }

        public void UpdateDataPenjualan()
        {
            cb = new SqlCommandBuilder(da);
            da = cb.DataAdapter;
            da.Update(ds, "Penjualan");
        }

        public void UpdateDataDetailPenjualan()
        {
            cb = new SqlCommandBuilder(da);
            da = cb.DataAdapter;
            da.Update(ds, "DetailPenjualan");
        }

        public void UpdateDataProduk()
        {
            cb = new SqlCommandBuilder(da);
            da = cb.DataAdapter;
            da.Update(dsproduk, "Produk");
        }

        private void KosongHeaderDanPembayaran()
        {
            txtNoFaktur.Clear();
            dtpTanggalPemesanan.Value = DateTime.Today;
            lblKodePelanggan.Text = "";
            lblNamaPelanggan.Text = "";
            lblKodeCabang.Text = "";
            lblNamaCabang.Text = "";
            lblLokasiCabang.Text = "";
            lblKodeKaryawan.Text = "";
            lblNamaKaryawan.Text = "";
            cboMetodePembayaran.SelectedItem = -1;
            nudPajak.Value = 10;
            lblTotal.Text = "";
            dgvData.Rows.Clear();
        }

        private void KosongDetail()
        {
            lblKodeProduk.Text = "";
            lblNamaProduk.Text = "";
            lblKodeKategori.Text = "";
            lblKodeMaterial.Text = "";
            lblHarga.Text = "";
            lblWarna.Text = "";
            lblSubtotal.Text = "0";
            nudQty.Value = 0;
        }

        private void HitungSubtotal()
        {
            decimal harga, subtotal;
            if (!string.IsNullOrWhiteSpace(lblHarga.Text))
            {
                harga = decimal.Parse(lblHarga.Text);
            }
            else
            {
                harga = 0;
            }
            subtotal = harga * nudQty.Value;
            lblSubtotal.Text = subtotal.ToString();
        }

        private void HitungTotal()
        {
            decimal total = 0;
            for (int i = 0; i < dgvData.Rows.Count; i++)
            {
                total += int.Parse(dgvData.Rows[i].Cells[7].Value.ToString());
            }
            total += (total * nudPajak.Value / 100);
            lblTotal.Text = total.ToString();
        }



        //event
        private void frmSale_Load(object sender, EventArgs e)
        {
            koneksi();
            txtNoFaktur.MaxLength = 13;
            cboMetodePembayaran.Items.Add("Kredit");
            cboMetodePembayaran.Items.Add("Cash");
            cboMetodePembayaran.Items.Add("Cicilan");
            cboMetodePembayaran.Items.Add("COD");
            cboMetodePembayaran.DropDownStyle = ComboBoxStyle.DropDownList;

            dgvData.ColumnCount = 8;
            dgvData.Columns[0].HeaderText = "Kode Produk";
            dgvData.Columns[1].HeaderText = "Nama Produk";
            dgvData.Columns[2].HeaderText = "Kode Kategori";
            dgvData.Columns[3].HeaderText = "Kode Material";
            dgvData.Columns[4].HeaderText = "Warna";
            dgvData.Columns[5].HeaderText = "Harga";
            dgvData.Columns[6].HeaderText = "Qty";
            dgvData.Columns[7].HeaderText = "Subtotal";
            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvData.AllowUserToAddRows = false;
            dgvData.ReadOnly = true;
        }

        private void btnBrowsePelanggan_Click(object sender, EventArgs e)
        {
            Master.frmBrowseCustomer brwPelanggan = new Master.frmBrowseCustomer(this);
            brwPelanggan.Tag = this;
            brwPelanggan.ShowDialog();  
        }

        private void btnBrowseCabang_Click(object sender, EventArgs e)
        {
            Master.frmBrowseBranch brwCabang = new Master.frmBrowseBranch(this);
            brwCabang.Tag = this;
            brwCabang.ShowDialog();
        }

        private void btnBrowseProduk_Click(object sender, EventArgs e)
        {
            Master.frmBrowseProduct brwProduk = new Master.frmBrowseProduct(this);
            brwProduk.Tag = this;
            brwProduk.ShowDialog();
        }

        private void btnBroseKaryawan_Click(object sender, EventArgs e)
        {
            Master.frmBrowseEmployee brwKaryawan = new Master.frmBrowseEmployee(this);
            brwKaryawan.Tag = this;
            brwKaryawan.ShowDialog();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (lblKodeProduk.Text == "" || lblNamaProduk.Text == "" || lblKodeKategori.Text == "" || lblKodeMaterial.Text == "" || lblHarga.Text == "" || lblWarna.Text == "" || nudQty.Value == 0 || lblSubtotal.Text == "")
            {
                MessageBox.Show("Mohon mengisi semua inputan yang tersedia pada Detail Penjualan", "Tambah Penjualan Produk", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                bool cari = false;
                for (int i = 0; i < dgvData.Rows.Count; i++)
                {
                    if (lblKodeProduk.Text == dgvData.Rows[i].Cells[0].Value.ToString())
                    {
                        cari = true;
                    }
                }

                if (cari == false)
                {
                    dgvData.Rows.Add(lblKodeProduk.Text, lblNamaProduk.Text, lblKodeKategori.Text, lblKodeMaterial.Text, lblWarna.Text, lblHarga.Text, nudQty.Value, lblSubtotal.Text);
                    HitungTotal();
                    KosongDetail();
                    MessageBox.Show("Kode Produk " + lblKodeProduk.Text + " berhasil ditambahkan", "Tambah Penjualan Produk", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Kode Produk " + lblKodeProduk.Text + " sudah pernah ditambahkan", "Tambah Penjualan Produk", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (lblKodeProduk.Text == "" || lblNamaProduk.Text == "" || lblKodeKategori.Text == "" || lblKodeMaterial.Text == "" || lblHarga.Text == "" || lblWarna.Text == "" || nudQty.Value == 0 || lblSubtotal.Text == "")
            {
                MessageBox.Show("Mohon mengisi semua inputan yang tersedia pada Detail Penjualan", "Ubah Penjualan Produk", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                bool cari = false;
                for (int i = 0; i < dgvData.Rows.Count; i++)
                {
                    if (lblKodeProduk.Text == dgvData.Rows[i].Cells[0].Value.ToString())
                    {
                        cari = true;
                        dgvData.Rows[i].Cells[1].Value = lblNamaProduk.Text;
                        dgvData.Rows[i].Cells[2].Value = lblKodeKategori.Text;
                        dgvData.Rows[i].Cells[3].Value = lblKodeMaterial.Text;
                        dgvData.Rows[i].Cells[4].Value = lblWarna.Text;
                        dgvData.Rows[i].Cells[5].Value = lblHarga.Text;
                        dgvData.Rows[i].Cells[6].Value = nudQty.Value;
                        dgvData.Rows[i].Cells[7].Value = lblSubtotal.Text;
                    }
                }

                if (cari == true)
                {
                    HitungTotal();
                    KosongDetail();
                    MessageBox.Show("Kode Produk " + lblKodeProduk.Text + " berhasil diubah", "Ubah Penjualan Produk", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Kode Produk " + lblKodeProduk.Text + " belum pernah ditambahkan", "Ubah Penjualan Produk", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (lblKodeProduk.Text == "" || lblNamaProduk.Text == "" || lblKodeKategori.Text == "" || lblKodeMaterial.Text == "" || lblHarga.Text == "" || lblWarna.Text == "" || nudQty.Value == 0 || lblSubtotal.Text == "")
            {
                MessageBox.Show("Mohon mengisi semua inputan yang tersedia pada Detail Penjualan", "Hapus Penjualan Produk", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("Penghapusan bersifat permanen. Apakah Anda yakin ingin menghapus Kode Produk " + lblKodeProduk.Text + " ?", "Hapus Penjualan Produk", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    bool cari = false;
                    for (int i = 0; i < dgvData.Rows.Count; i++)
                    {
                        if (lblKodeProduk.Text == dgvData.Rows[i].Cells[0].Value.ToString())
                        {
                            cari = true;
                            dgvData.Rows.Remove(dgvData.Rows[i]);
                        }
                    }

                    if (cari == true)
                    {
                        HitungTotal();
                        KosongDetail();
                        MessageBox.Show("Kode Produk " + lblKodeProduk.Text + " berhasil dihapus", "Hapus Penjualan Produk", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Kode Produk " + lblKodeProduk.Text + " belum pernah ditambahkan", "Hapus Penjualan Produk", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            } 
        }

        private void btnBrowseSale_Click(object sender, EventArgs e)
        {
            frmBrowseSale brwPenjualan = new frmBrowseSale(this);
            brwPenjualan.ShowDialog();
        }

        private void nudQty_ValueChanged(object sender, EventArgs e)
        {
            //tabel Produk untuk mengecek jumlah stok
            LoadDataProduk();
            dr = dsproduk.Tables["Produk"].Rows.Find(lblKodeProduk.Text);
            if (dr != null)
            {
                nudQty.Maximum = decimal.Parse(dr[4].ToString());
            }
            HitungSubtotal();
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = dgvData.CurrentCell.RowIndex;
            lblKodeProduk.Text = dgvData[0, baris].Value.ToString();
            lblNamaProduk.Text = dgvData[1, baris].Value.ToString();
            lblKodeKategori.Text =dgvData[2, baris].Value.ToString();
            lblKodeMaterial.Text = dgvData[3, baris].Value.ToString();
            lblWarna.Text = dgvData[4, baris].Value.ToString();
            lblHarga.Text = dgvData[5, baris].Value.ToString();
            nudQty.Value = decimal.Parse(dgvData[6, baris].Value.ToString());
            lblSubtotal.Text = dgvData[7, baris].Value.ToString();
        }

        private void btnSimpanPenjualan_Click(object sender, EventArgs e)
        {
            if (txtNoFaktur.Text == "" || lblKodePelanggan.Text == "" || lblNamaPelanggan.Text == "" || lblKodeCabang.Text == "" || lblNamaCabang.Text == "" || lblLokasiCabang.Text == "" || lblKodeKaryawan.Text == "" || lblNamaKaryawan.Text == "" || cboMetodePembayaran.SelectedIndex == -1)
            {
                MessageBox.Show("Mohon mengisi semua inputan yang tersedia", "Simpan Transaksi Penjualan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //tabel Penjualan
                LoadDataPenjualan();
                dr = ds.Tables["Penjualan"].Rows.Find(txtNoFaktur.Text);
                if (dr == null)//simpan
                {
                    dr = ds.Tables["Penjualan"].NewRow();
                    dr[0] = txtNoFaktur.Text;
                    dr[1] = dtpTanggalPemesanan.Value;
                    dr[2] = lblKodePelanggan.Text;
                    dr[3] = lblKodeCabang.Text;
                    dr[4] = nudPajak.Value;
                    dr[5] = cboMetodePembayaran.SelectedItem;
                    dr[6] = lblKodeKaryawan.Text;
                    dr[7] = lblTotal.Text;
                    ds.Tables["Penjualan"].Rows.Add(dr);
                    UpdateDataPenjualan();

                    for (int i = 0; i < dgvData.Rows.Count; i++)
                    {
                        //tabel DetailPenjualan
                        LoadDataDetailPenjualan();
                        dr = ds.Tables["DetailPenjualan"].NewRow();
                        dr[0] = txtNoFaktur.Text;
                        dr[1] = dgvData[0, i].Value.ToString();
                        dr[2] = dgvData[6, i].Value.ToString();
                        ds.Tables["DetailPenjualan"].Rows.Add(dr);
                        UpdateDataDetailPenjualan();

                        //tabel Produk
                        LoadDataProduk();
                        dr = dsproduk.Tables["Produk"].Rows.Find(dgvData[0, i].Value);
                        if (dr == null)
                        {
                            MessageBox.Show("Kode produk tidak tersedia", "Simpan Transaksi Penjualan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (dr != null)
                        {
                            dr[4] = decimal.Parse(dr[4].ToString())/*stok*/ - decimal.Parse(dgvData[6, i].Value.ToString());//qty yang mau dijual
                        }
                        UpdateDataProduk();
                    }
                    MessageBox.Show("Transaksi penjualan dengan No Faktur " + txtNoFaktur.Text + " berhasil disimpan", "Simpan Transaksi Penjualan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    KosongHeaderDanPembayaran();
                }
                else//edit
                {
                    //update penjualan
                    dr[1] = dtpTanggalPemesanan.Value;
                    dr[2] = lblKodePelanggan.Text;
                    dr[3] = lblKodeCabang.Text;
                    dr[4] = nudPajak.Value;
                    dr[5] = cboMetodePembayaran.SelectedItem;
                    dr[6] = lblKodeKaryawan.Text;
                    dr[7] = lblTotal.Text;
                    UpdateDataPenjualan();

                    //hapus nilai lama kemudian berikan nilai baru
                    ds = new DataSet();
                    query = "SELECT * FROM DetailPenjualan WHERE NoFaktur = '" + txtNoFaktur.Text + "'";
                    cmd = new SqlCommand(query, con);
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "DetailPenjualan");
                    foreach (DataRow baris in ds.Tables["DetailPenjualan"].Rows)
                    {
                        LoadDataProduk();
                        dr = dsproduk.Tables["Produk"].Rows.Find(baris[1].ToString());
                        if (dr != null)//dr ada
                        {
                            dr[4] = int.Parse(dr[4].ToString())/*stok*/ - int.Parse(baris[2].ToString());//qty yg mau dijual
                        }
                        UpdateDataProduk();
                    }

                    //hapus data detail
                    ds = new DataSet();
                    query = "SELECT * FROM DetailPenjualan WHERE NoFaktur = '" + txtNoFaktur.Text + "'";
                    cmd = new SqlCommand(query, con);
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "DetailPenjualan");
                    foreach (DataRow baris in ds.Tables["DetailPenjualan"].Rows)
                    {
                        baris.Delete();
                    }
                    UpdateDataDetailPenjualan();

                    //simpan ke detail penjualan
                    for (int i = 0; i < dgvData.Rows.Count; i++)
                    {
                        LoadDataDetailPenjualan();
                        dr = ds.Tables["DetailPenjualan"].NewRow();
                        dr[0] = txtNoFaktur.Text;
                        dr[1] = dgvData[0, i].Value.ToString();
                        dr[2] = dgvData[6, i].Value.ToString();
                        ds.Tables["DetailPenjualan"].Rows.Add(dr);
                        UpdateDataDetailPenjualan();

                        //simpan ke inventory
                        LoadDataProduk();
                        dr = dsproduk.Tables["Produk"].Rows.Find(dgvData.Rows[i].Cells[0].Value);
                        if (dr != null)
                        {
                            dr[4] = int.Parse(dr[4].ToString())/*stok*/ - int.Parse(dgvData.Rows[i].Cells[6].Value.ToString());//qty yang mau dijual dan sudah diubah
                        }
                        UpdateDataProduk();
                    }
                    MessageBox.Show("Transaksi penjualan dengan No Faktur " + txtNoFaktur.Text + " berhasil diubah dan disimpan", "Simpan Transaksi Penjualan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    KosongHeaderDanPembayaran();
                }
            }
        }

        private void btnHapusPenjualan_Click(object sender, EventArgs e)
        {
            if (txtNoFaktur.Text == "" || lblKodePelanggan.Text == "" || lblNamaPelanggan.Text == "" || lblKodeCabang.Text == "" || lblNamaCabang.Text == "" || lblLokasiCabang.Text == "" || lblKodeKaryawan.Text == "" || lblNamaKaryawan.Text == "" || cboMetodePembayaran.SelectedIndex == -1)
            {
                MessageBox.Show("Mohon mengisi semua inputan yang tersedia", "Hapus Transaksi Penjualan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("Penghapusan bersifat permanen. Apakah Anda yakin ingin menghapus Kode Produk " + lblKodeProduk.Text + " ?", "Hapus Penjualan Produk", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    LoadDataPenjualan();
                    dr = ds.Tables["Penjualan"].Rows.Find(txtNoFaktur.Text);
                    if (dr != null)//jika dr ada
                    {
                        dr.Delete();
                        UpdateDataPenjualan();

                        //mengembalikan qty yang dijual ke jumlah stok
                        ds = new DataSet();
                        query = "SELECT * FROM DetailPenjualan WHERE NoFaktur = '" + txtNoFaktur.Text + "'";
                        cmd = new SqlCommand(query, con);
                        da = new SqlDataAdapter(cmd);
                        da.Fill(ds, "DetailPenjualan");
                        foreach (DataRow baris in ds.Tables["DetailPenjualan"].Rows)
                        {
                            LoadDataProduk();
                            dr = dsproduk.Tables["Produk"].Rows.Find(baris[1].ToString());//kode produk
                            if (dr != null)//dr ada
                            {
                                dr[4] = int.Parse(dr[4].ToString())/*stok*/ + int.Parse(baris[2].ToString());//qty yang sudah dijual
                            }
                            UpdateDataProduk();
                        }

                        //hapus data detail
                        ds = new DataSet();
                        query = "SELECT * FROM DetailPenjualan WHERE NoFaktur = '" + txtNoFaktur.Text + "'";
                        cmd = new SqlCommand(query, con);
                        da = new SqlDataAdapter(cmd);
                        da.Fill(ds, "DetailPenjualan");
                        foreach (DataRow baris in ds.Tables["DetailPenjualan"].Rows)
                        {
                            baris.Delete();
                        }
                        UpdateDataDetailPenjualan();

                        MessageBox.Show("Transaksi penjualan dengan No Faktur " + txtNoFaktur.Text + " berhasil dihapus", "Hapus Transaksi Penjualan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        KosongHeaderDanPembayaran();
                    }
                    else//jika dr tidak ada
                    {
                        MessageBox.Show("Transaksi penjualan dengan No Faktur " + txtNoFaktur.Text + " belum pernah disimpan", "Hapus Transaksi Penjualan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        KosongHeaderDanPembayaran();
                    }
                } 
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lblWarna_Click(object sender, EventArgs e)
        {

        }
    }
}
