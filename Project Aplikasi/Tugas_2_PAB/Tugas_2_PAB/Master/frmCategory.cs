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
    public partial class frmCategory : Form
    {
        public frmCategory()
        {
            InitializeComponent();
        }

        private void frmCategory_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMain.formAktif = null;
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

        private void UpdateData() 
        {
            cb = new SqlCommandBuilder(da);
            da = cb.DataAdapter;
            da.Update(ds.Tables["Kategori"]);
        }

        private void kosong()
        {
            txtKodeKategori.Clear();
            txtNamaKategori.Clear();
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            koneksi();
            loaddata();

            txtKodeKategori.MaxLength = 6;
        }

        private void txtNamaKategori_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            loaddata();

            dr = ds.Tables["Kategori"].Rows.Find(txtKodeKategori.Text);
            if (dr == null)
            {
                if (txtKodeKategori.Text == "" || txtNamaKategori.Text == "")
                {
                    MessageBox.Show($"Semua inputan harus diisi terlebih dahulu", "Tambah Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dr = ds.Tables["Kategori"].NewRow();

                    dr[0] = txtKodeKategori.Text;
                    dr[1] = txtNamaKategori.Text;


                    ds.Tables["Kategori"].Rows.Add(dr);

                    UpdateData();

                    MessageBox.Show($"Kode Kategori {txtKodeKategori.Text} sudah berhasil ditambahkan", "Tambah Data", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    kosong();
                }

            }
            else//datanya sudah ada, maka tidak akan diizinkan untuk menginput data yang sama
            {
                MessageBox.Show($"Kode Kategori {txtKodeKategori.Text} sudah ada di dalam database", "Tambah Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            loaddata();

            dr = ds.Tables["Kategori"].Rows.Find(txtKodeKategori.Text);

            if (dr != null)
            {
                dr.Delete();
                UpdateData();

                MessageBox.Show($"Kode Kategori {txtKodeKategori.Text} berhasil dihapus", "Hapus data", MessageBoxButtons.OK, MessageBoxIcon.Information);

                kosong();
            }
            else
            {
                MessageBox.Show($"Kode Kategori {txtKodeKategori.Text} tidak ada di dalam database", "Hapus data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            loaddata();

            dr = ds.Tables["Kategori"].Rows.Find(txtKodeKategori.Text);

            if (dr != null)
            {
                dr[1] = txtNamaKategori.Text;

                UpdateData();

                MessageBox.Show($"Kode Kategori {txtKodeKategori.Text} sudah berhasil di ubah", "Ubah Data", MessageBoxButtons.OK, MessageBoxIcon.Information);

                kosong();
            }
            else //berarti datanya belum ada atau memang tidak ada
            {
                MessageBox.Show($"Kode Kategori {txtKodeKategori.Text} tidak ada di dalam database", "Ubah Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTampil_Click(object sender, EventArgs e)
        {
            frmBrowseCategory brwKategori = new frmBrowseCategory(this);
            brwKategori.Tag = this;
            brwKategori.ShowDialog();
        }
    }
}
