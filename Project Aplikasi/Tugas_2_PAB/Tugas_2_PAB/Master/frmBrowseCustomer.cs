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
    public partial class frmBrowseCustomer : Form
    {
        public frmBrowseCustomer()
        {
            InitializeComponent();
        }

        frmCustomer mstCustomer;
        public frmBrowseCustomer(frmCustomer mstCustomer)
        {
            InitializeComponent();
            this.mstCustomer = mstCustomer;
        }

        Transaction.frmSale Penjualan;
        public frmBrowseCustomer(Transaction.frmSale Penjualan)
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

            query = "SELECT * FROM Pelanggan";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Pelanggan");
            dc[0] = ds.Tables["Pelanggan"].Columns[0];
            ds.Tables["Pelanggan"].PrimaryKey = dc;
        }



        private void TampilData()
        {
            dgvData.DataSource = ds.Tables["Pelanggan"];

            dgvData.Columns[0].HeaderText = "Kode Pelanggan";
            dgvData.Columns[1].HeaderText = "Nama Pelanggan";
            dgvData.Columns[2].HeaderText = "Alamat Pelanggan";
            dgvData.Columns[3].HeaderText = "No HP Pelanggan";
            dgvData.Columns[4].HeaderText = "Email Pelanggan";

            dgvData.AllowUserToAddRows = false;
            dgvData.ReadOnly = true;
            dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            lblRecord.Text = dgvData.Rows.Count.ToString();
        }
        private void frmBrowseCustomer_Load(object sender, EventArgs e)
        {
            koneksi();
            loaddata();
            TampilData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loaddata();
            TampilData();

            rdoKodePelanggan.Checked = true;
            rdoNamaPelanggan.Checked = false;
            txtSearch.Clear();
            txtSearch.Select();
        }

        private void rdoKodePelanggan_CheckedChanged(object sender, EventArgs e)
        {
            if(rdoKodePelanggan.Checked == true)
            {
                urut = "KodePelanggan";
            }
            else if (rdoNamaPelanggan.Checked == true)
            {
                urut = "NamaPelanggan";
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ds = new DataSet();
            query = "SELECT * FROM Pelanggan WHERE " + urut + " LIKE '%" + txtSearch.Text + "%'";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Pelanggan");
            dc[0] = ds.Tables["Pelanggan"].Columns[0];
            ds.Tables["Pelanggan"].PrimaryKey = dc;

            TampilData();
        }

        private void dgvData_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int baris = dgvData.CurrentCell.RowIndex;
            if (this.Tag == mstCustomer)
            {
                mstCustomer.txtKodePelanggan.Text = dgvData[0, baris].Value.ToString();
                mstCustomer.txtNamaPelanggan.Text = dgvData.Rows[baris].Cells[1].Value.ToString();
                mstCustomer.txtAlamatPelanggan.Text = dgvData.Rows[baris].Cells[2].Value.ToString();
                mstCustomer.txtNoHPPelanggan.Text = dgvData.Rows[baris].Cells[3].Value.ToString();
                mstCustomer.txtEmailPelanggan.Text = dgvData.Rows[baris].Cells[4].Value.ToString();
            }
            else if (this.Tag == Penjualan)
            {
                Penjualan.lblKodePelanggan.Text = dgvData[0, baris].Value.ToString();
                Penjualan.lblNamaPelanggan.Text = dgvData[1, baris].Value.ToString();
            }
            this.Close();
        }
    }
}
