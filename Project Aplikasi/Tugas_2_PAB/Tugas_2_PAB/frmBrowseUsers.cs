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

namespace Tugas_2_PAB
{
    public partial class frmBrowseUsers : Form
    {
        public frmBrowseUsers()
        {
            InitializeComponent();
        }

        frmUsers Pengguna;
        public frmBrowseUsers(frmUsers Pengguna)
        {
            InitializeComponent();
            this.Pengguna = Pengguna;
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

        private void loaddata()
        {
            ds = new DataSet();

            query = "SELECT * FROM Users";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Users");
            dc[0] = ds.Tables["Users"].Columns[0];
            ds.Tables["Users"].PrimaryKey = dc;
        }

        private void TampilData()
        {
            dgvData.DataSource = ds.Tables["Users"];

            dgvData.Columns[0].HeaderText = "Username";
            dgvData.Columns[1].Visible = false;

            dgvData.AllowUserToAddRows = false;
            dgvData.ReadOnly = true;
            dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            lblRecord.Text = dgvData.Rows.Count.ToString();
        }

        private void frmBrowseUsers_Load(object sender, EventArgs e)
        {
            koneksi();
            loaddata();
            TampilData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loaddata();
            TampilData();
            txtSearch.Clear();
            txtSearch.Focus();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ds = new DataSet();
            query = "SELECT * FROM Users WHERE Username LIKE '%" + txtSearch.Text + "%'";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Users");
            dc[0] = ds.Tables["Users"].Columns[0];
            ds.Tables["Users"].PrimaryKey = dc;

            TampilData();
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = dgvData.CurrentCell.RowIndex;

            Pengguna.txtUsername.Text = dgvData.Rows[baris].Cells[0].Value.ToString();
            Pengguna.txtPassword.Text = dgvData.Rows[baris].Cells[1].Value.ToString();
            Pengguna.txtConfirmPassword.Text = dgvData.Rows[baris].Cells[1].Value.ToString();
            Pengguna.txtPassword.ReadOnly = true;
            Pengguna.txtConfirmPassword.ReadOnly = true;
            Pengguna.txtPassword.PasswordChar = '*';
            Pengguna.txtConfirmPassword.PasswordChar = '*';
            Pengguna.chkShowPassword.Enabled = false;

            this.Close();
        }
    }
}
