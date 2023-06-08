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
    public partial class frmMaterial : Form
    {
        public frmMaterial()
        {
            InitializeComponent();
        }

        private void frmMaterial_FormClosing(object sender, FormClosingEventArgs e)
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

            query = "SELECT * FROM Material";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Material");
            dc[0] = ds.Tables["Material"].Columns[0];
            ds.Tables["Material"].PrimaryKey = dc;
        }

        private void UpdateData()
        {
            cb = new SqlCommandBuilder(da);
            da = cb.DataAdapter;
            da.Update(ds.Tables["Material"]);
        }

        private void kosong()
        {
            txtKodeMaterial.Clear();
            txtNamaMaterial.Clear();
        }

        private void frmMaterial_Load(object sender, EventArgs e)
        {
            koneksi();
            loaddata();

            txtKodeMaterial.MaxLength = 6;
        }

        private void txtNamaMaterial_KeyPress(object sender, KeyPressEventArgs e)
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

            dr = ds.Tables["Material"].Rows.Find(txtKodeMaterial.Text);
            if (dr == null)
            {
                if (txtKodeMaterial.Text == "" || txtNamaMaterial.Text == "")
                {
                    MessageBox.Show($"Semua inputan harus diisi terlebih dahulu", "Tambah Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dr = ds.Tables["Material"].NewRow();

                    dr[0] = txtKodeMaterial.Text;
                    dr[1] = txtNamaMaterial.Text;


                    ds.Tables["Material"].Rows.Add(dr);

                    UpdateData();

                    MessageBox.Show($"Kode Kategori {txtKodeMaterial.Text} sudah berhasil ditambahkan", "Tambah Data", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    kosong();
                }

            }
            else//datanya sudah ada, maka tidak akan diizinkan untuk menginput data yang sama
            {
                MessageBox.Show($"Kode Kategori {txtKodeMaterial.Text} sudah ada di dalam database", "Tambah Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            loaddata();

            dr = ds.Tables["Material"].Rows.Find(txtKodeMaterial.Text);

            if (dr != null)
            {
                dr.Delete();
                UpdateData();

                MessageBox.Show($"Kode Material {txtKodeMaterial.Text} berhasil dihapus", "Hapus data", MessageBoxButtons.OK, MessageBoxIcon.Information);

                kosong();
            }
            else
            {
                MessageBox.Show($"Kode Material {txtKodeMaterial.Text} tidak ada di dalam database", "Hapus data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            loaddata();

            dr = ds.Tables["Material"].Rows.Find(txtKodeMaterial.Text);

            if (dr != null)
            {
                dr[1] = txtKodeMaterial.Text;

                UpdateData();

                MessageBox.Show($"Kode Material {txtKodeMaterial.Text} sudah berhasil di ubah", "Ubah Data", MessageBoxButtons.OK, MessageBoxIcon.Information);

                kosong();
            }
            else //berarti datanya belum ada atau memang tidak ada
            {
                MessageBox.Show($"Kode Material {txtKodeMaterial.Text} tidak ada di dalam database", "Ubah Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTampil_Click(object sender, EventArgs e)
        {
            frmBrowseMaterial brwMaterial = new frmBrowseMaterial(this);
            brwMaterial.Tag = this;
            brwMaterial.ShowDialog();
        }
    }
}
