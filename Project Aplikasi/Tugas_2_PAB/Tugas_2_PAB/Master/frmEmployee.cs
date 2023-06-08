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
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
        }

        private void frmEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMain.formAktif = null;
        }
        frmBrowseEmployee Employee;
        public frmEmployee(frmBrowseEmployee browseEmployee)
        {
            InitializeComponent();
            this.Employee = browseEmployee;
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
        private void Hapus()
        {
            txtKodeKaryawan.Clear();
            txtNamaKaryawan.Clear();
            txtNoHPKaryawan.Clear();
            txtAlamatKaryawan.Clear();
            cboJabatan.SelectedIndex = -1;
            cboJenisKelamin.SelectedIndex = -1;
            txtKodeKaryawan.Focus();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            Koneksi();
            
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            LoadData();
            

            dr = ds.Tables["Karyawan"].Rows.Find(txtKodeKaryawan.Text);

            if (dr == null)
            {
                if (txtKodeKaryawan.Text == "" || txtNamaKaryawan.Text == "" || txtAlamatKaryawan.Text == "" || cboJenisKelamin.SelectedIndex == -1||cboJabatan.SelectedIndex == -1)
                {
                    MessageBox.Show($"Semua inputan harus diisi terlebih dahulu", "Tambah Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dr = ds.Tables["Karyawan"].NewRow();

                    dr[0] = txtKodeKaryawan.Text;
                    dr[1] = txtNamaKaryawan.Text;
                    dr[2] = txtAlamatKaryawan.Text;
                    dr[3] = cboJenisKelamin.SelectedItem;
                    dr[4] = txtNoHPKaryawan.Text;
                    dr[5] = cboJabatan.SelectedItem;

                    ds.Tables["Karyawan"].Rows.Add(dr);

                    UpdateData();
                    MessageBox.Show($"Data {txtKodeKaryawan.Text} Berhail Di Simpan", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Hapus();
                }
                
            }
            else
            {
                MessageBox.Show($"Data {txtKodeKaryawan.Text} Sudah Ada Di Database", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            LoadData();
            

            dr = ds.Tables["Karyawan"].Rows.Find(txtKodeKaryawan.Text);
            if(dr != null)
            {
                if (MessageBox.Show("Data Yang Dihapus Bersifat Permanent, Apakah Anda Yakin?","Hapus Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    dr.Delete();
                    UpdateData(); 
                    
                    MessageBox.Show($"Data {txtKodeKaryawan.Text} Berhasil Di Hapus", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Hapus();
                }
                
            }
            else
            {
                MessageBox.Show($"Data {txtKodeKaryawan.Text} Tidak Ada", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnTampil_Click(object sender, EventArgs e)
        {
            frmBrowseEmployee brwEmployee = new frmBrowseEmployee(this);
            brwEmployee.Tag = this;
            brwEmployee.ShowDialog();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            LoadData();

            
            dr = ds.Tables["Karyawan"].Rows.Find(txtKodeKaryawan.Text);

            if (dr != null)
            {
                dr[1] = txtNamaKaryawan.Text;
                dr[2] = txtAlamatKaryawan.Text;
                dr[3] = cboJenisKelamin.SelectedItem;
                dr[4] = txtNoHPKaryawan.Text;
                dr[5] = cboJabatan.SelectedItem;

                UpdateData();

                MessageBox.Show($"Data {txtKodeKaryawan.Text} Berhasil Di Ubah", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Hapus();
            }
            else
            {

                MessageBox.Show($"Data {txtKodeKaryawan.Text} Tidak Ada", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            Koneksi();

            cboJabatan.Text = "---JABATAN---";
            cboJenisKelamin.Text = "---JENIS KELAMIN---";
            cboJenisKelamin.Items.Add("L");
            cboJenisKelamin.Items.Add("P");

            cboJabatan.Items.Add("Supervisor");
            cboJabatan.Items.Add("Manajer");
            cboJabatan.Items.Add("Accounting");
            cboJabatan.Items.Add("Intern");

            cboJabatan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboJenisKelamin.DropDownStyle = ComboBoxStyle.DropDownList;

            
        }

        private void txtNamaKaryawan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar)&& !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNoHPKaryawan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
