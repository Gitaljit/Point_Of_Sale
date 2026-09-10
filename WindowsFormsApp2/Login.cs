using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Login : Form
    {
        private readonly string connectionString =
            @"Data Source=DESKTOP-PHEQIRB\SQLEXPRESS;
              Initial Catalog=COLLEGEDB;
              Integrated Security=True;
              TrustServerCertificate=True;";

        public Login()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void Username_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check that username and password are entered
            if (string.IsNullOrWhiteSpace(txtun.Text) ||
                string.IsNullOrWhiteSpace(txtpw.Text))
            {
                MessageBox.Show("Please enter username and password.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"
                        SELECT COUNT(*)
                        FROM Register1
                        WHERE name = @name
                        AND password = @password";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@name", txtun.Text.Trim());
                        cmd.Parameters.AddWithValue("@password", txtpw.Text);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("Login successful!");

                            progressbar p = new progressbar();
                            p.Show();

                            txtun.Clear();
                            txtpw.Clear();

                            this.Hide();
                        }
                        else
                        {
                            txtun.Clear();
                            txtpw.Clear();

                            MessageBox.Show("Username or password is wrong.");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Database connection error:\n\n" + ex.Message,
                    "SQL Server Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void linkLabel1(object sender, EventArgs e)
        {
        }

        private void linkLabel2_LinkClicked(
            object sender,
            LinkLabelLinkClickedEventArgs e)
        {
            if (linkLabel2.Text == "show")
            {
                linkLabel2.Text = "hide";
                txtpw.UseSystemPasswordChar = false;
            }
            else
            {
                linkLabel2.Text = "show";
                txtpw.UseSystemPasswordChar = true;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void linkLabel4_LinkClicked(
            object sender,
            LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            Registration r = new Registration();
            r.Show();
        }

        private void linkLabel3_LinkClicked(
            object sender,
            LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            forgetpassword f = new forgetpassword();
            f.Show();
        }
    }
}