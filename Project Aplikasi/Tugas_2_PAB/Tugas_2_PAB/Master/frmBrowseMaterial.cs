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
    public partial class frmBrowseMaterial : Form
    {
        public frmBrowseMaterial()
        {
            InitializeComponent();
        }

        frmMaterial mstMaterial;
        public frmBrowseMaterial(frmMaterial mstMaterial)
        {
            InitializeComponent();
            this.mstMaterial = mstMaterial;
        }

        frmProduct mstProduct;
        public frmBrowseMaterial(frmProduct mstProduct)
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

            query = "SELECT * FROM Material";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Material");
            dc[0] = ds.Tables["Material"].Columns[0];
            ds.Tables["Material"].PrimaryKey = dc;
        }



        private void TampilData()
        {
            dgvData.DataSource = ds.Tables["Material"];

            dgvData.Columns[0].HeaderText = "Kode Material";
            dgvData.Columns[1].HeaderText = "Nama Material";

            dgvData.AllowUserToAddRows = false;
            dgvData.ReadOnly = true;

            lblRecord.Text = dgvData.Rows.Count.ToString();
        }

        private void frmBrowseMaterial_Load(object sender, EventArgs e)
        {
            koneksi();
            loaddata();
            TampilData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loaddata();
            TampilData();

            rdoKodeMaterial.Checked = true;
            rdoNamaMaterial.Checked = false;
            txtSearch.Clear();
            txtSearch.Select();
        }

        private void rdoKodeMaterial_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoKodeMaterial.Checked == true)
            {
                urut = "KodeMaterial";
            }
            else if (rdoNamaMaterial.Checked == true)
            {
                urut = "NamaMaterial";
            }
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = dgvData.CurrentCell.RowIndex;
            if (this.Tag == mstMaterial)
            {
                mstMaterial.txtKodeMaterial.Text = dgvData.Rows[baris].Cells[0].Value.ToString();
                mstMaterial.txtNamaMaterial.Text = dgvData.Rows[baris].Cells[1].Value.ToString();
            }
            else if (this.Tag == mstProduct)
            {
                mstProduct.lblKodeMaterial.Text = dgvData.Rows[baris].Cells[0].Value.ToString();

            }
;
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ds = new DataSet();
            query = "SELECT * FROM Material WHERE " + urut + " LIKE '%" + txtSearch.Text + "%'";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Material");
            dc[0] = ds.Tables["Material"].Columns[0];
            ds.Tables["Material"].PrimaryKey = dc;
            TampilData();
        }
    }
}
