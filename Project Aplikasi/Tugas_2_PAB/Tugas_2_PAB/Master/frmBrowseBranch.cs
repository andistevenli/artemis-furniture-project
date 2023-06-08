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
    public partial class frmBrowseBranch : Form
    {
        public frmBrowseBranch()
        {
            InitializeComponent();
        }

        frmBranch mstBranch;
        public frmBrowseBranch(frmBranch mstBranch)
        {
            InitializeComponent();
            this.mstBranch = mstBranch;
        }

        Transaction.frmSale Penjualan;
        public frmBrowseBranch(Transaction.frmSale Penjualan)
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
            query = "SELECT * FROM Cabang";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Cabang");
            dc[0] = ds.Tables["Cabang"].Columns[0];
            ds.Tables["Cabang"].PrimaryKey = dc;
        }
        private void TampilData()
        {
            dgvData.DataSource = ds.Tables["Cabang"];

            dgvData.Columns[0].HeaderText = "Kode Cabang";
            dgvData.Columns[1].HeaderText = "Nama Cabang";
            dgvData.Columns[2].HeaderText = "Lokasi Cabang";
         

            dgvData.AllowUserToAddRows = false;
            dgvData.ReadOnly = true;
            dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            lblRecord.Text = dgvData.Rows.Count.ToString();
        }

        private void frmBrowseBranch_Load(object sender, EventArgs e)
        {
            koneksi();
            loaddata();
            TampilData();
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loaddata();
            TampilData();

            rdoKodeCabang.Checked = true;
            rdoNamaCabang.Checked = false;
            txtSearch.Clear();
            txtSearch.Focus();
        }

        private void rdoNamaCabang_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoKodeCabang.Checked == true)
            {
                urut = "KodeCabang";
            }
            else if (rdoNamaCabang.Checked == true)
            {
                urut = "NamaCabang";
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ds = new DataSet();
            query = "SELECT * FROM Cabang WHERE " + urut + " LIKE '%" + txtSearch.Text + "%'";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Cabang");
            dc[0] = ds.Tables["Cabang"].Columns[0];
            ds.Tables["Cabang"].PrimaryKey = dc;

            TampilData();
        }

        private void dgvData_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int baris = dgvData.CurrentCell.RowIndex;
            if (this.Tag == mstBranch)
            {
                mstBranch.txtKodeCabang.Text = dgvData.Rows[baris].Cells[0].Value.ToString();
                mstBranch.txtNamaCabang.Text = dgvData.Rows[baris].Cells[1].Value.ToString();
                mstBranch.txtLokasiCabang.Text = dgvData.Rows[baris].Cells[2].Value.ToString();
            }
            else if (this.Tag == Penjualan)
            {
                Penjualan.lblKodeCabang.Text = dgvData[0, baris].Value.ToString();
                Penjualan.lblNamaCabang.Text = dgvData[1, baris].Value.ToString();
                Penjualan.lblLokasiCabang.Text = dgvData[2, baris].Value.ToString();
            }
            this.Close();
        }


    }
}
