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
    public partial class frmChangePassword : Form
    {
        public frmChangePassword()
        {
            InitializeComponent();
        }

        frmMain Main;
        public frmChangePassword(frmMain Main)
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
            txtOldPassword.Clear();
            txtNewPassword.Clear();
            txtConfirmNewPassword.Clear();
            txtUsername.Focus();
        }




        //event
        private void frmChangePassword_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnGanti_Click(object sender, EventArgs e)
        {
            loaddata();

            dr = ds.Tables["Users"].Rows.Find(txtUsername.Text);

            if (dr != null)
            {
                if (txtOldPassword.Text == "")
                {
                    MessageBox.Show("Silakan masukkan password lama Anda", "Ganti Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (txtOldPassword.Text == dr[1].ToString())
                    {
                        if (txtNewPassword.Text == "")
                        {
                            MessageBox.Show("Password tidak boleh kosong, silakan masukkan password baru Anda", "Ganti Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (txtNewPassword.Text == txtConfirmNewPassword.Text)
                            {
                                dr[1] = txtConfirmNewPassword.Text;
                                UpdateData();
                                MessageBox.Show($"Password dari Username {txtUsername.Text} sudah berhasil diganti", "Ganti Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                kosong();
                            }
                            else
                            {
                                MessageBox.Show("Konfirmasi password baru Anda salah, silakan isi dengan benar", "Ganti Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Password lama yang Anda masukkan salah, silakan isi kembali password lama Anda dengan benar", "Ganti Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
                
            }
            else //berarti datanya belum ada atau memang tidak ada
            {
                MessageBox.Show($"Harap masukkan username Anda terlebih dahulu untuk mengganti password", "Ganti Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            koneksi();
            loaddata();
            txtNewPassword.Enabled = false;
            txtConfirmNewPassword.Enabled = false;
            chkShowPassword.Enabled = false;
            txtOldPassword.PasswordChar = '*';
            txtNewPassword.PasswordChar = '*';
            txtConfirmNewPassword.PasswordChar = '*';
        }

        private void txtOldPassword_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtOldPassword.Text))
            {
                txtNewPassword.Enabled = true;
                txtConfirmNewPassword.Enabled = false;
                chkShowPassword.Enabled = false;
                chkShowPassword.Checked = false;
            }
            else
            {
                txtNewPassword.Enabled = false;
                txtConfirmNewPassword.Enabled = false;
                chkShowPassword.Enabled = false;
                chkShowPassword.Checked = false;
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsWhiteSpace(e.KeyChar) && !char.IsPunctuation(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNewPassword.Text))
            {
                txtConfirmNewPassword.Enabled = true;
                chkShowPassword.Enabled = false;
                chkShowPassword.Checked = false;
            }
            else
            {
                txtConfirmNewPassword.Enabled = false;
                chkShowPassword.Enabled = false;
                chkShowPassword.Checked = false;
            }
        }

        private void txtConfirmNewPassword_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtConfirmNewPassword.Text))
            {
                chkShowPassword.Enabled = true;
                chkShowPassword.Checked = false;
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
                txtOldPassword.PasswordChar = '\0';
                txtNewPassword.PasswordChar = '\0';
                txtConfirmNewPassword.PasswordChar = '\0';
            }
            else
            {
                txtOldPassword.PasswordChar = '*';
                txtNewPassword.PasswordChar = '*';
                txtConfirmNewPassword.PasswordChar = '*';
            }
        }
    }
}
