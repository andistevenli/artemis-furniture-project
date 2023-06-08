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
    public partial class frmBrowseSale : Form
    {
        public frmBrowseSale()
        {
            InitializeComponent();
        }

        frmSale Penjualan;
        public frmBrowseSale(frmSale Penjualan)
        {
            InitializeComponent();
            this.Penjualan = Penjualan;
        }

        SqlConnection con;
        string constr;
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
        private void Koneksi()
        {
            try
            {
                constr = "data source = localhost; initial catalog = Tugas2_PAB; integrated security=true";
                con = new SqlConnection(constr);
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void LoadData()
        {
            ds = new DataSet();
            query = "SELECT p.NoFaktur, p.TanggalJual, pl.KodePelanggan, pl.NamaPelanggan, c.KodeCabang,c.NamaCabang,c.LokasiCabang, k.KodeKaryawan,k.NamaKaryawan, p.Pajak, p.MetodePembayaran, p.Total FROM Penjualan AS p INNER JOIN Pelanggan AS pl ON p.KodePelanggan = pl.KodePelanggan INNER JOIN Cabang AS c ON p.KodeCabang = c.KodeCabang INNER JOIN Karyawan AS k ON p.KodeKaryawan = k.KodeKaryawan";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "vwPenjualan");
        }

        private void TampilData()
        {
            dgvDataPenjualan.DataSource = ds.Tables["vwPenjualan"];
            dgvDataPenjualan.Columns[0].HeaderText = "No Faktur";
            dgvDataPenjualan.Columns[1].HeaderText = "Tanggal Penjualan";
            dgvDataPenjualan.Columns[2].HeaderText = "Kode Pelanggan";
            dgvDataPenjualan.Columns[3].HeaderText = "Nama Pelanggan";
            dgvDataPenjualan.Columns[4].HeaderText = "Kode Cabang";
            dgvDataPenjualan.Columns[5].HeaderText = "Nama Cabang";
            dgvDataPenjualan.Columns[6].HeaderText = "Lokasi Cabang";
            dgvDataPenjualan.Columns[7].HeaderText = "Kode Karyawan";
            dgvDataPenjualan.Columns[8].HeaderText = "Nama Karyawan";
            dgvDataPenjualan.Columns[9].HeaderText = "Pajak (%)";
            dgvDataPenjualan.Columns[10].HeaderText = "Metode Pembayaran";
            dgvDataPenjualan.Columns[11].HeaderText = "Total";
            dgvDataPenjualan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvDataPenjualan.ReadOnly = true;
            dgvDataPenjualan.AllowUserToAddRows = false;
            lblRecord.Text = dgvDataPenjualan.Rows.Count.ToString();
        }

        private void frmBrowseSale_Load(object sender, EventArgs e)
        {
            Koneksi();
            LoadData();
            TampilData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Koneksi();
            LoadData();

            txtSearch.Clear();
            dtpDari.Value = DateTime.Today;
            dtpSampai.Value = DateTime.Today;
            rdoNoFaktur.Checked = true;
            txtSearch.Focus();
            TampilData();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ds = new DataSet();
            if (rdoKodePelanggan.Checked)
            {
                query = "SELECT p.NoFaktur, p.TanggalJual, pl.KodePelanggan, pl.NamaPelanggan, c.KodeCabang,c.NamaCabang,c.LokasiCabang, k.KodeKaryawan,k.NamaKaryawan, p.Pajak, p.MetodePembayaran, p.Total FROM Penjualan AS p INNER JOIN Pelanggan AS pl ON p.KodePelanggan = pl.KodePelanggan INNER JOIN Cabang AS c ON p.KodeCabang = c.KodeCabang INNER JOIN Karyawan AS k ON p.KodeKaryawan = k.KodeKaryawan WHERE pl.KodePelanggan LIKE '%" + txtSearch.Text + "%' AND p.TanggalJual BETWEEN '" + dtpDari.Value.ToString("yyyy-MM-dd") + "' AND '" + dtpSampai.Value.ToString("yyyy-MM-dd") + "'";
            }
            else if (rdoNoFaktur.Checked)
            {
                query = "SELECT p.NoFaktur, p.TanggalJual, pl.KodePelanggan, pl.NamaPelanggan, c.KodeCabang,c.NamaCabang,c.LokasiCabang, k.KodeKaryawan,k.NamaKaryawan, p.Pajak, p.MetodePembayaran, p.Total FROM Penjualan AS p INNER JOIN Pelanggan AS pl ON p.KodePelanggan = pl.KodePelanggan INNER JOIN Cabang AS c ON p.KodeCabang = c.KodeCabang INNER JOIN Karyawan AS k ON p.KodeKaryawan = k.KodeKaryawan WHERE p.NoFaktur LIKE '%" + txtSearch.Text + "%' AND p.TanggalJual BETWEEN '" + dtpDari.Value.ToString("yyyy-MM-dd") + "' AND '" + dtpSampai.Value.ToString("yyyy-MM-dd") + "'";
            } 
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "vwPenjualan");
            TampilData();   
        }

        private void dgvDataPenjualan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = dgvDataPenjualan.CurrentCell.RowIndex;
            Penjualan.txtNoFaktur.Text = dgvDataPenjualan[0, baris].Value.ToString();
            Penjualan.dtpTanggalPemesanan.Value = DateTime.Parse(dgvDataPenjualan[1, baris].Value.ToString());
            Penjualan.lblKodePelanggan.Text = dgvDataPenjualan[2, baris].Value.ToString();
            Penjualan.lblNamaPelanggan.Text = dgvDataPenjualan[3, baris].Value.ToString();
            Penjualan.lblKodeCabang.Text = dgvDataPenjualan[4, baris].Value.ToString();
            Penjualan.lblNamaCabang.Text = dgvDataPenjualan[5, baris].Value.ToString();
            Penjualan.lblLokasiCabang.Text = dgvDataPenjualan[6, baris].Value.ToString();
            Penjualan.lblKodeKaryawan.Text = dgvDataPenjualan[7, baris].Value.ToString();
            Penjualan.lblNamaKaryawan.Text = dgvDataPenjualan[8, baris].Value.ToString();
            Penjualan.nudPajak.Value = decimal.Parse(dgvDataPenjualan[9, baris].Value.ToString());
            Penjualan.cboMetodePembayaran.SelectedItem = dgvDataPenjualan[10, baris].Value.ToString();
            Penjualan.lblTotal.Text = dgvDataPenjualan[11, baris].Value.ToString();

            //munculkan sales detail
            ds = new DataSet();
            query = "SELECT dp.KodeProduk, p.NamaProduk, p.KodeKategori, p.KodeMaterial, p.Warna, p.Harga, dp.Qty, p.Harga * dp.Qty FROM DetailPenjualan AS dp INNER JOIN Produk AS p ON dp.KodeProduk = p.KodeProduk WHERE dp.NoFaktur = '" + dgvDataPenjualan[0, baris].Value + "'";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "JoinDpP");

            //munculkan ke data grid view di form Penjualan
            Penjualan.dgvData.Rows.Clear();
            foreach (DataRow dr in ds.Tables["JoinDpP"].Rows)
            {
                Penjualan.dgvData.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], dr[5], dr[6], dr[7]);
            }
            this.Close();
        }

        private void TanggalPenjualan_ValueChanged(object sender, EventArgs e)
        {
            ds = new DataSet();
            if (rdoKodePelanggan.Checked)
            {
                query = "SELECT p.NoFaktur, p.TanggalJual, pl.KodePelanggan, pl.NamaPelanggan, c.KodeCabang,c.NamaCabang,c.LokasiCabang, k.KodeKaryawan,k.NamaKaryawan, p.Pajak, p.MetodePembayaran, p.Total FROM Penjualan AS p INNER JOIN Pelanggan AS pl ON p.KodePelanggan = pl.KodePelanggan INNER JOIN Cabang AS c ON p.KodeCabang = c.KodeCabang INNER JOIN Karyawan AS k ON p.KodeKaryawan = k.KodeKaryawan WHERE pl.KodePelanggan LIKE '%" + txtSearch.Text + "%' AND p.TanggalJual BETWEEN '" + dtpDari.Value.ToString("yyyy-MM-dd") + "' AND '" + dtpSampai.Value.ToString("yyyy-MM-dd") + "'";
            }
            else if (rdoNoFaktur.Checked)
            {
                query = "SELECT p.NoFaktur, p.TanggalJual, pl.KodePelanggan, pl.NamaPelanggan, c.KodeCabang,c.NamaCabang,c.LokasiCabang, k.KodeKaryawan,k.NamaKaryawan, p.Pajak, p.MetodePembayaran, p.Total FROM Penjualan AS p INNER JOIN Pelanggan AS pl ON p.KodePelanggan = pl.KodePelanggan INNER JOIN Cabang AS c ON p.KodeCabang = c.KodeCabang INNER JOIN Karyawan AS k ON p.KodeKaryawan = k.KodeKaryawan WHERE p.NoFaktur LIKE '%" + txtSearch.Text + "%' AND p.TanggalJual BETWEEN '" + dtpDari.Value.ToString("yyyy-MM-dd") + "' AND '" + dtpSampai.Value.ToString("yyyy-MM-dd") + "'";
            }
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "vwPenjualan");
            TampilData();
        }
    }
}
