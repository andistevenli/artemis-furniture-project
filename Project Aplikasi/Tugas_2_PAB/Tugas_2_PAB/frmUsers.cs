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
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }

        frmMain Main;
        public frmUsers(frmMain Main)
        {
            InitializeComponent();
            this.Main = Main;
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

        private void loaddata() //kita akan mengambil data dari DB dan di letakkan ke dlm dataset
        {
            ds = new DataSet();

            query = "SELECT * FROM Users";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Users");
            dc[0] = ds.Tables["Users"].Columns[0];
            ds.Tables["Users"].PrimaryKey = dc;
        }

        private void UpdateData() //untuk mengirimkan data dari dataset kita ke database, untuk mengubah data
        {
            cb = new SqlCommandBuilder(da);
            da = cb.DataAdapter;
            da.Update(ds.Tables["Users"]);
        }

        private void kosong()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            chkShowPassword.Checked = false;
            chkShowPassword.Enabled = false;
            txtConfirmPassword.Enabled = false;
            txtPassword.ReadOnly = false;
            txtConfirmPassword.ReadOnly = false;
            txtUsername.Focus();
        }



        //event
        private void frmAddUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMain.formAktif = null;
            Main.pnlSetting.Visible = false;
            Main.pnlAbout.Visible = false;
            Main.pnlSidebar.Width = 60;
            Main.btnSideBarExpand.Image = Tugas_2_PAB.Properties.Resources.sidebar_menu;
            Main.picLogo.Width = 60;
            Main.picLogo.Height = 100;
            Main.picLogo.Image = Tugas_2_PAB.Properties.Resources.Artemis3_white;
            Main.picLogo.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            koneksi();
            loaddata();
            txtPassword.PasswordChar = '*';
            txtConfirmPassword.Enabled = false;
            chkShowPassword.Enabled = false;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtConfirmPassword.Enabled = true;
            }
            else
            {
                txtConfirmPassword.Enabled = false;
                txtConfirmPassword.Clear();
                
            }
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                txtConfirmPassword.PasswordChar = '*';
                chkShowPassword.Enabled = true;
            }
            else
            {
                chkShowPassword.Enabled = false;
                chkShowPassword.Checked = false;
            }

        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtConfirmPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
                txtConfirmPassword.PasswordChar = '*';
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsWhiteSpace(e.KeyChar)&&!char.IsPunctuation(e.KeyChar)&&!char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnTampil_Click(object sender, EventArgs e)
        {
            frmBrowseUsers brwPengguna = new frmBrowseUsers(this);
            brwPengguna.ShowDialog();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            loaddata();
            dr = ds.Tables["Users"].Rows.Find(txtUsername.Text);
            if (dr == null)
            {
                if (txtUsername.Text == "" || txtPassword.Text == "" || txtConfirmPassword.Text == "")
                {
                    MessageBox.Show($"Semua inputan harus diisi terlebih dahulu", "Tambah Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (txtPassword.Text == txtConfirmPassword.Text)
                    {
                        dr = ds.Tables["Users"].NewRow();
                        dr[0] = txtUsername.Text;
                        dr[1] = txtConfirmPassword.Text;
                        ds.Tables["Users"].Rows.Add(dr);
                        UpdateData();
                        MessageBox.Show($"Username {txtUsername.Text} sudah berhasil ditambahkan", "Tambah Pengguna", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        kosong();
                    }
                    else
                    {
                        MessageBox.Show("Konfirmasi password salah, silakan isi kembali", "Tambah Pengguna", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else//datanya sudah ada, maka tidak akan diizinkan untuk menginput data yang sama
            {
                MessageBox.Show($"Username {txtUsername.Text} sudah ada di dalam database", "Tambah Pengguna", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            loaddata();

            dr = ds.Tables["Users"].Rows.Find(txtUsername.Text);

            if (dr != null)
            {
                if(MessageBox.Show("Username dan password pengguna ini akan hilang secara permanen. Apakah Anda yakin ingin menghapus pengguna ini ?", "Hapus Pengguna", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dr.Delete();
                    UpdateData();
                    MessageBox.Show($"Username {txtUsername.Text} berhasil dihapus", "Hapus Pengguna", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    kosong();
                }
            }
            else
            {
                MessageBox.Show($"Username {txtUsername.Text} tidak ada di dalam database", "Hapus Pengguna", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
