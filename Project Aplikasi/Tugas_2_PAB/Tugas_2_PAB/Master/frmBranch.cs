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
    public partial class frmBranch : Form
    {
        public frmBranch()
        {
            InitializeComponent();
        }

        private void frmBranch_FormClosing(object sender, FormClosingEventArgs e)
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

            query = "SELECT * FROM Cabang";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Cabang");
            dc[0] = ds.Tables["Cabang"].Columns[0];
            ds.Tables["Cabang"].PrimaryKey = dc;
        }

        private void UpdateData() //untuk mengirimkan data dari dataset kita ke database, untuk mengubah data
        {
            cb = new SqlCommandBuilder(da);
            da = cb.DataAdapter;
            da.Update(ds.Tables["Cabang"]);
        }
        private void kosong()
        {
            txtKodeCabang.Clear();
            txtKodeCabang.Clear();
            txtNamaCabang.Clear();
            txtLokasiCabang.Clear();
            
        }



        //event
        private void frmBranch_Load(object sender, EventArgs e)
        {
            koneksi();
            loaddata();

            txtKodeCabang.MaxLength = 6;

        }

        private void txtKodeCabang_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtNamaCabang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
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
            frmBrowseBranch brwBranch = new frmBrowseBranch(this);
            brwBranch.Tag = this;
            brwBranch.ShowDialog();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            loaddata();

            dr = ds.Tables["Cabang"].Rows.Find(txtKodeCabang.Text);

            if (dr != null)
            {
                dr.Delete();
                UpdateData();

                MessageBox.Show($"Kode Cabang {txtKodeCabang.Text} berhasil dihapus", "Hapus data", MessageBoxButtons.OK, MessageBoxIcon.Information);

                kosong();
            }
            else
            {
                MessageBox.Show($"Kode Cabang {txtKodeCabang.Text} tidak ada di dalam database", "Hapus data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            loaddata();

            dr = ds.Tables["Cabang"].Rows.Find(txtKodeCabang.Text);

            if (dr != null)
            {
                dr[1] = txtNamaCabang.Text;
                dr[2] = txtLokasiCabang.Text;
               

                UpdateData();

                MessageBox.Show($"Kode Pelanggan {txtKodeCabang.Text} sudah berhasil di ubah", "Ubah Data", MessageBoxButtons.OK, MessageBoxIcon.Information);

                kosong();
            }
            else //berarti datanya belum ada atau memang tidak ada
            {
                MessageBox.Show($"Kode Pelanggan {txtKodeCabang.Text} tidak ada di dalam database", "Ubah Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            loaddata();

            dr = ds.Tables["Cabang"].Rows.Find(txtKodeCabang.Text);

            if (dr == null)
            {
                if (txtKodeCabang.Text == "" || txtNamaCabang.Text == "" || txtLokasiCabang.Text == "" )
                {
                    MessageBox.Show($"Semua inputan harus diisi terlebih dahulu", "Tambah Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dr = ds.Tables["Cabang"].NewRow();

                    dr[0] = txtKodeCabang.Text;
                    dr[1] = txtNamaCabang.Text;
                    dr[2] = txtLokasiCabang.Text;
                   


                    ds.Tables["Cabang"].Rows.Add(dr);

                    UpdateData();

                    MessageBox.Show($"Kode Pelanggan {txtKodeCabang.Text} sudah berhasil ditambahkan", "Tambah Data", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    kosong();
                }
            }
            else//datanya sudah ada, maka tidak akan diizinkan untuk menginput data yang sama
            {
                MessageBox.Show($"Kode Pelanggan {txtKodeCabang.Text} sudah ada di dalam database", "Tambah Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
