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

namespace Tugas_2_PAB.Master
{
    public partial class frmBrowseProduct : Form
    {
        public frmBrowseProduct()
        {
            InitializeComponent();
        }
        frmProduct mstProduct;

        public frmBrowseProduct(frmProduct mstProduct)
        {
            InitializeComponent();
            this.mstProduct = mstProduct;
        }

        Transaction.frmSale Penjualan;
        public frmBrowseProduct(Transaction.frmSale Penjualan)
        {
            InitializeComponent();
            this.Penjualan = Penjualan;
        }

        SqlConnection con;
        string sourcedata;

        SqlDataAdapter da;
        SqlCommand cmd;
        string query;

        DataSet ds;
        DataColumn[] dc = new DataColumn[1];
        DataRow dr;
        SqlCommandBuilder cb;
        string urut;

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


        private void loaddata()
        {
            ds = new DataSet();

            query = "SELECT * FROM Produk";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Produk");
            dc[0] = ds.Tables["Produk"].Columns[0];
            ds.Tables["Produk"].PrimaryKey = dc;
        }



        private void TampilData()
        {
            dgvData.DataSource = ds.Tables["Produk"];

            dgvData.Columns[0].HeaderText = "Kode Produk";
            dgvData.Columns[1].HeaderText = "Nama Produk";
            dgvData.Columns[2].HeaderText = "Warna";
            dgvData.Columns[3].HeaderText = "Harga";
            dgvData.Columns[4].HeaderText = "Stok";
            dgvData.Columns[5].HeaderText = "Kode Kategori";
            dgvData.Columns[6].HeaderText = "Kode Material";

            dgvData.AllowUserToAddRows = false;
            dgvData.ReadOnly = true;
            dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            lblRecord.Text = dgvData.Rows.Count.ToString();
        }

        private void frmBrowseProduct_Load(object sender, EventArgs e)
        {
            koneksi();
            loaddata();
            TampilData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loaddata();
            TampilData();

            rdoKodeProduk.Checked = true;
            rdoNamaProduk.Checked = false;
            txtSearch.Clear();
            txtSearch.Select();
        }

        private void rdoKodeProduk_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoKodeProduk.Checked == true)
            {
                urut = "KodeProduk";
            }
            else if (rdoNamaProduk.Checked == true)
            {
                urut = "NamaProduk";
            }
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = dgvData.CurrentCell.RowIndex;
            if (this.Tag == mstProduct)
            {
                mstProduct.txtKodeProduk.Text = dgvData.Rows[baris].Cells[0].Value.ToString();
                mstProduct.txtNamaProduk.Text = dgvData.Rows[baris].Cells[1].Value.ToString();
                mstProduct.cboWarna.SelectedItem = dgvData.Rows[baris].Cells[2].Value.ToString();
                mstProduct.nudHarga.Value = decimal.Parse(dgvData.Rows[baris].Cells[3].Value.ToString());
                mstProduct.nudStok.Value = decimal.Parse(dgvData.Rows[baris].Cells[4].Value.ToString());
                mstProduct.lblKodeKategori.Text = dgvData.Rows[baris].Cells[5].Value.ToString();
                mstProduct.lblKodeMaterial.Text = dgvData.Rows[baris].Cells[6].Value.ToString();
            }
            else if (this.Tag == Penjualan)
            {
                Penjualan.lblKodeProduk.Text = dgvData[0, baris].Value.ToString();
                Penjualan.lblNamaProduk.Text = dgvData[1, baris].Value.ToString();
                Penjualan.lblKodeKategori.Text = dgvData[5, baris].Value.ToString();
                Penjualan.lblKodeMaterial.Text = dgvData[6, baris].Value.ToString();
                Penjualan.lblHarga.Text =dgvData.Rows[baris].Cells[3].Value.ToString();
                Penjualan.lblWarna.Text = dgvData.Rows[baris].Cells[2].Value.ToString();

                Penjualan.nudQty.Maximum = decimal.Parse(dgvData[4, baris].Value.ToString());
            }
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ds = new DataSet();
            query = "SELECT * FROM Produk WHERE " + urut + " LIKE '%" + txtSearch.Text + "%'";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Produk");
            dc[0] = ds.Tables["Produk"].Columns[0];
            ds.Tables["Produk"].PrimaryKey = dc;

            TampilData();
        }
    }

}
