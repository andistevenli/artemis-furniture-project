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
    public partial class frmBrowseEmployee : Form
    {
        public frmBrowseEmployee()
        {
            InitializeComponent();
        }
        frmEmployee employee;
        public frmBrowseEmployee(frmEmployee employee)
        {
            InitializeComponent();
            this.employee = employee;
        }

        Transaction.frmSale Penjualan;
        public frmBrowseEmployee(Transaction.frmSale Penjualan)
        {
            InitializeComponent();
            this.Penjualan = Penjualan;
        }


        SqlConnection conn;
        string constr;
        SqlDataAdapter da;
        DataSet ds;
        string query;
        SqlCommand cmd;
        SqlCommandBuilder cb;
        DataColumn[] dc = new DataColumn[1];
        DataRow dr;

        private void Koneksi()
        {
            constr = "Data Source = localhost; Initial Catalog = Tugas2_PAB; Integrated Security = true";
            conn = new SqlConnection(constr);
            conn.Open();
        }
        private void LoadData()
        {
            ds = new DataSet();
            query = "SELECT * FROM Karyawan";
            cmd = new SqlCommand(query, conn);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Karyawan");
            dc[0] = ds.Tables["Karyawan"].Columns[0];
            ds.Tables["Karyawan"].PrimaryKey = dc;
        }
        private void UpdateData()
        {
            cb = new SqlCommandBuilder(da);
            da = cb.DataAdapter;
            da.Update(ds.Tables["Karyawan"]);
        }
        private void TampilData()
        {
            
            dgvData.DataSource = ds.Tables["Karyawan"];

            dgvData.Columns[0].HeaderText = "Kode Karyawan";
            dgvData.Columns[1].HeaderText = "Nama Karyawan";
            dgvData.Columns[2].HeaderText = "Alamat Karyawan";
            dgvData.Columns[3].HeaderText = "Jenis Kelamin";
            dgvData.Columns[4].HeaderText = "No Hp";
            dgvData.Columns[5].HeaderText = "Jabatan";

            dgvData.AllowUserToAddRows = false;
            dgvData.ReadOnly = true;
            dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            lblRecord.Text = dgvData.Rows.Count.ToString();
        }
        

        private void frmBrowseEmployee_Load(object sender, EventArgs e)
        {
            Koneksi();
            LoadData();
            TampilData();
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            ds = new DataSet();

            if (rdoKodeKaryawan.Checked)
            {
                query = $"SELECT * FROM Karyawan WHERE KodeKaryawan LIKE '%{txtSearch.Text}%'"; cmd = new SqlCommand(query, conn);
            }
            else
            {

                query = $"SELECT * FROM Karyawan WHERE NamaKaryawan LIKE '%{txtSearch.Text}%'"; cmd = new SqlCommand(query, conn);
            }
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Karyawan");
            dc[0] = ds.Tables["Karyawan"].Columns[0];
            ds.Tables["Karyawan"].PrimaryKey = dc;

            TampilData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
            TampilData();
            txtSearch.Clear();
            rdoKodeKaryawan.Checked = false;
            rdoNamaKaryawan.Checked = false;
        }

       
        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = dgvData.CurrentCell.RowIndex;
            if (this.Tag == employee)
            {
                employee.txtKodeKaryawan.Text = dgvData[0, baris].Value.ToString();
                employee.txtNamaKaryawan.Text = dgvData[1, baris].Value.ToString();
                employee.txtAlamatKaryawan.Text = dgvData[2, baris].Value.ToString();
                employee.cboJenisKelamin.SelectedItem = dgvData[3, baris].Value.ToString();
                employee.txtNoHPKaryawan.Text = dgvData[4, baris].Value.ToString();
                employee.cboJabatan.SelectedItem = dgvData[5, baris].Value.ToString();
            }
            else if (this.Tag == Penjualan)
            {
                Penjualan.lblKodeKaryawan.Text = dgvData[0, baris].Value.ToString();
                Penjualan.lblNamaKaryawan.Text = dgvData[1, baris].Value.ToString();
            }
            this.Close();
        }
    }
}
