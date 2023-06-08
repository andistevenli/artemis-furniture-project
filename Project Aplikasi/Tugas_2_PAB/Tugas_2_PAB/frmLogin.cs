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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.A;
        }

        frmMain Main;
        public frmLogin(frmMain Main)
        {
            InitializeComponent();
            this.Main = Main;
        }


        SqlConnection con;
        string constr;
        SqlDataAdapter da;
        SqlCommand cmd;
        string query;
        DataSet ds;
        DataRow dr;
        DataColumn[] dc = new DataColumn[1];//ada 1 primary key



        //prosedur
        private void Koneksi()
        {
            try
            {
                constr = "data source = localhost; initial catalog = Tugas2_PAB; integrated security=true";
                con = new SqlConnection(constr);
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void LoadData()
        {
            ds = new DataSet();
            query = "select * from Users";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Users");
            dc[0] = ds.Tables["Users"].Columns[0];
            ds.Tables["Users"].PrimaryKey = dc;
        }



        //event
        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoadData();
            dr = ds.Tables["Users"].Rows.Find(txtUsername.Text);
            if (dr == null)//datanya tidak ketemu
            {
                if (txtUsername.Text == "")
                {
                    MessageBox.Show("Silakan masukkan username Anda", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Username " + txtUsername.Text + " tidak ditemukan", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Clear();
                    txtPassword.Clear();
                    txtUsername.Focus();
                } 
            }
            else//datanya ketemu atau datanya ada
            {
                if (txtPassword.Text == "")
                {
                    MessageBox.Show("Silakan masukkan password Anda", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (dr[1].ToString() == txtPassword.Text)//passwordnya benar
                    {

                        Main = new frmMain(this);
                        this.Hide();
                        Main.Show();
                    }
                    else//passwordnya salah
                    {
                        MessageBox.Show("Password salah", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPassword.Clear();
                        txtPassword.Focus();
                    }
                }
                
            }

            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            Koneksi();
            txtPassword.PasswordChar = '*';
            this.AcceptButton = btnLogin;
            btnLogin.Enabled = false;
            chkShowPassword.Enabled = false;
            txtUsername.Focus();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';//ketika diceklis, karakter di textbox password akan terlihat
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            btnLogin.Enabled = true;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                chkShowPassword.Enabled = false;
                chkShowPassword.Checked = false;
            }
            else
            {
                chkShowPassword.Enabled = true;
            }
            
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);   
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
