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
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void frmCustomer_FormClosing(object sender, FormClosingEventArgs e)
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

        private void loaddata() //kita akan mengambil data dari DB dan di letakkan ke dlm dataset
        {
            ds = new DataSet();

            query = "SELECT * FROM Pelanggan";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Pelanggan");
            dc[0] = ds.Tables["Pelanggan"].Columns[0];
            ds.Tables["Pelanggan"].PrimaryKey = dc;
        }

        private void UpdateData() //untuk mengirimkan data dari dataset kita ke database, untuk mengubah data
        {
            cb = new SqlCommandBuilder(da);
            da = cb.DataAdapter;
            da.Update(ds.Tables["Pelanggan"]);
        }

        private void kosong()
        {
            txtKodePelanggan.Clear();
            txtKodePelanggan.Select();
            txtNamaPelanggan.Clear();
            txtAlamatPelanggan.Clear();
            txtNoHPPelanggan.Clear();
            txtEmailPelanggan.Clear();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            koneksi();
            loaddata();

            txtKodePelanggan.MaxLength = 6;

        }

        private void txtNamaPelanggan_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtNoHPPelanggan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void btnTampil_Click(object sender, EventArgs e)
        {
            frmBrowseCustomer brwCustomer = new frmBrowseCustomer(this);
            brwCustomer.Tag = this;
            brwCustomer.ShowDialog();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            loaddata();

            dr = ds.Tables["Pelanggan"].Rows.Find(txtKodePelanggan.Text);

            if (dr != null) 
            {
                dr.Delete();
                UpdateData();

                MessageBox.Show($"Kode Pelanggan {txtKodePelanggan.Text} berhasil dihapus", "Hapus data", MessageBoxButtons.OK, MessageBoxIcon.Information);

                kosong();
            }
            else 
            {
                MessageBox.Show($"Kode Pelanggan {txtKodePelanggan.Text} tidak ada di dalam database", "Hapus data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            loaddata();

            dr = ds.Tables["Pelanggan"].Rows.Find(txtKodePelanggan.Text);

            if (dr != null)
            {
                dr[1] = txtNamaPelanggan.Text;
                dr[2] = txtAlamatPelanggan.Text;
                dr[3] = txtNoHPPelanggan.Text;
                dr[4] = txtEmailPelanggan.Text;

                UpdateData();

                MessageBox.Show($"Kode Pelanggan {txtKodePelanggan.Text} sudah berhasil di ubah", "Ubah Data", MessageBoxButtons.OK, MessageBoxIcon.Information);

                kosong();
            }
            else //berarti datanya belum ada atau memang tidak ada
            {
                MessageBox.Show($"Kode Pelanggan {txtKodePelanggan.Text} tidak ada di dalam database", "Ubah Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            loaddata();

            dr = ds.Tables["Pelanggan"].Rows.Find(txtKodePelanggan.Text);

            if (dr == null)
            {
                if(txtKodePelanggan.Text == "" || txtNamaPelanggan.Text == "" || txtAlamatPelanggan.Text == "" || txtNoHPPelanggan.Text == "" || txtEmailPelanggan.Text == "")
                {
                    MessageBox.Show($"Semua inputan harus diisi terlebih dahulu", "Tambah Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dr = ds.Tables["Pelanggan"].NewRow();

                    dr[0] = txtKodePelanggan.Text;
                    dr[1] = txtNamaPelanggan.Text;
                    dr[2] = txtAlamatPelanggan.Text;
                    dr[3] = txtNoHPPelanggan.Text;
                    dr[4] = txtEmailPelanggan.Text;


                    ds.Tables["Pelanggan"].Rows.Add(dr);

                    UpdateData();

                    MessageBox.Show($"Kode Pelanggan {txtKodePelanggan.Text} sudah berhasil ditambahkan", "Tambah Data", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    kosong();
                }
                
            }
            else//datanya sudah ada, maka tidak akan diizinkan untuk menginput data yang sama
            {
                MessageBox.Show($"Kode Pelanggan {txtKodePelanggan.Text} sudah ada di dalam database", "Tambah Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
