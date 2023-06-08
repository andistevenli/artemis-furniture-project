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
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
        }

        private void frmProduct_FormClosing(object sender, FormClosingEventArgs e)
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

            query = "SELECT * FROM Produk";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Produk");
            dc[0] = ds.Tables["Produk"].Columns[0];
            ds.Tables["Produk"].PrimaryKey = dc;
        }

        private void UpdateData()
        {
            cb = new SqlCommandBuilder(da);
            da = cb.DataAdapter;
            da.Update(ds.Tables["Produk"]);
        }

        private void kosong()
        {
            txtKodeProduk.Clear();
            txtKodeProduk.Select();
            txtNamaProduk.Clear();
            cboWarna.SelectedIndex = -1;
            nudHarga.Value = 0;
            nudStok.Value = 0;
            lblKodeKategori.Text = "";
            lblKodeMaterial.Text = "";
        }




        //event
        private void frmProduk_Load(object sender, EventArgs e)
        {
            koneksi();
            loaddata();
            txtKodeProduk.MaxLength = 6;
            nudHarga.ReadOnly = true;
            nudHarga.Increment = 5000;
            nudHarga.ThousandsSeparator = true;
            nudHarga.Maximum = 300000;
            nudStok.Maximum = 150;
            nudStok.ReadOnly = true;
        }

        private void txtNamaProduk_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnTampil_Click(object sender, EventArgs e)
        {
            frmBrowseProduct brwProduk = new frmBrowseProduct(this);
            brwProduk.Tag = this;
            brwProduk.ShowDialog();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            loaddata();

            dr = ds.Tables["Produk"].Rows.Find(txtKodeProduk.Text);

            if (dr != null)
            {
                dr.Delete();
                UpdateData();

                MessageBox.Show($"Kode Produk {txtKodeProduk.Text} berhasil dihapus", "Hapus data", MessageBoxButtons.OK, MessageBoxIcon.Information);

                kosong();
            }
            else
            {
                MessageBox.Show($"Kode Produk {txtKodeProduk.Text} tidak ada di dalam database", "Hapus data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            loaddata();

            dr = ds.Tables["Produk"].Rows.Find(txtKodeProduk.Text);

            if (dr != null)
            {
                dr[1] = txtNamaProduk.Text;
                dr[2] = cboWarna.SelectedItem;
                dr[3] = nudHarga.Value;
                dr[4] = nudStok.Value;
                dr[5] = lblKodeKategori.Text;
                dr[6] = lblKodeMaterial.Text;

                UpdateData();

                MessageBox.Show($"Kode Produk {txtKodeProduk.Text} sudah berhasil di ubah", "Ubah Data", MessageBoxButtons.OK, MessageBoxIcon.Information);

                kosong();
            }
            else
            {
                MessageBox.Show($"Kode Produk {txtKodeProduk.Text} tidak ada di dalam database", "Ubah Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            loaddata();

            dr = ds.Tables["Produk"].Rows.Find(txtKodeProduk.Text);

            if (dr == null)
            {
                if (txtKodeProduk.Text == "" || txtNamaProduk.Text == "" || cboWarna.SelectedIndex == -1 || nudHarga.Value == 0 || nudStok.Value == 0 || lblKodeKategori.Text == ""||lblKodeMaterial.Text == "")
                {
                    MessageBox.Show($"Semua inputan harus diisi terlebih dahulu", "Tambah Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dr = ds.Tables["Produk"].NewRow();

                    dr[0] = txtKodeProduk.Text;
                    dr[1] = txtNamaProduk.Text;
                    dr[2] = cboWarna.SelectedItem;
                    dr[3] = nudHarga.Value;
                    dr[4] = nudStok.Value;
                    dr[5] = lblKodeKategori.Text;
                    dr[6] = lblKodeMaterial.Text;

                    ds.Tables["Produk"].Rows.Add(dr);

                    UpdateData();

                    MessageBox.Show($"Kode Produk {txtKodeProduk.Text} sudah berhasil ditambahkan", "Tambah Data", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    kosong();
                }

            }
            else
            {
                MessageBox.Show($"Kode Produk {txtKodeProduk.Text} sudah ada di dalam database", "Tambah Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBrowseKategori_Click(object sender, EventArgs e)
        {
            frmBrowseCategory brwKategori = new frmBrowseCategory(this);
            brwKategori.Tag = this;
            brwKategori.ShowDialog();
        }

        private void btnBrowseMaterial_Click(object sender, EventArgs e)
        {
            frmBrowseMaterial brwMaterial = new frmBrowseMaterial(this);
            brwMaterial.Tag = this;
            brwMaterial.ShowDialog();
        }
    }
}
