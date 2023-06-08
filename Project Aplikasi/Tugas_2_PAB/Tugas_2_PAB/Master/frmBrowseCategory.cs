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
    public partial class frmBrowseCategory : Form
    {
        public frmBrowseCategory()
        {
            InitializeComponent();
        }

        frmCategory mstKategori;
        public frmBrowseCategory(frmCategory mstKategori)
        {
            InitializeComponent();
            this.mstKategori = mstKategori;
        }

        frmProduct mstProduct;
        public frmBrowseCategory(frmProduct mstProduct)
        {
            InitializeComponent();
            this.mstProduct = mstProduct;
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

            query = "SELECT * FROM Kategori";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Kategori");
            dc[0] = ds.Tables["Kategori"].Columns[0];
            ds.Tables["Kategori"].PrimaryKey = dc;
        }
       
        private void TampilData()
        {
            dgvData.DataSource = ds.Tables["Kategori"];

            dgvData.Columns[0].HeaderText = "Kode Kategori";
            dgvData.Columns[1].HeaderText = "Nama Kategori";

            dgvData.AllowUserToAddRows = false;
            dgvData.ReadOnly = true;

            lblRecord.Text = dgvData.Rows.Count.ToString();
        }

        private void frmBrowseCategory_Load(object sender, EventArgs e)
        {
            koneksi();
            loaddata();
            TampilData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loaddata();
            TampilData();

            rdoKodeKategori.Checked = true;
            rdoNamaKategori.Checked = false;
            txtSearch.Clear();
            txtSearch.Select();
        }

        private void rdoKodeKategori_CheckedChanged(object sender, EventArgs e)
        {

            if (rdoKodeKategori.Checked == true)
            {
                urut = "KodeKategori";
            }
            else if (rdoNamaKategori.Checked == true)
            {
                urut = "NamaKategori";
            }
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = dgvData.CurrentCell.RowIndex;
            if (this.Tag == mstKategori)
            {
                mstKategori.txtKodeKategori.Text = dgvData.Rows[baris].Cells[0].Value.ToString();
                mstKategori.txtNamaKategori.Text = dgvData.Rows[baris].Cells[1].Value.ToString();
            }
            else if (this.Tag == mstProduct)
            {
                mstProduct.lblKodeKategori.Text = dgvData.Rows[baris].Cells[0].Value.ToString();
            }
            
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ds = new DataSet();
            query = "SELECT * FROM Kategori WHERE " + urut + " LIKE '%" + txtSearch.Text + "%'";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Kategori");
            dc[0] = ds.Tables["Kategori"].Columns[0];
            ds.Tables["Kategori"].PrimaryKey = dc;
            TampilData();
        }

        
    }
}
