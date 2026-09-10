using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class forgetpassword : Form
    {
        private readonly string connectionString =
            @"Data Source=DESKTOP-PHEQIRB\SQLEXPRESS;
              Initial Catalog=COLLEGEDB;
              Integrated Security=True;
              TrustServerCertificate=True;";

        public forgetpassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please enter email and phone number.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string str = @"
                        SELECT password
                        FROM Register1
                        WHERE email = @email
                        AND phone_no = @phone_no";

                    using (SqlCommand cmd = new SqlCommand(str, con))
                    {
                        cmd.Parameters.AddWithValue(
                            "@email",
                            textBox1.Text.Trim());

                        cmd.Parameters.AddWithValue(
                            "@phone_no",
                            textBox2.Text.Trim());

                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            MessageBox.Show(
                                "Are you sure you want to get your password?",
                                "Password Recovery",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Question);

                            label4.Text = result.ToString();
                        }
                        else
                        {
                            label4.Text = "";
                            MessageBox.Show(
                                "Email or phone number is incorrect.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                }

                textBox1.Clear();
                textBox2.Clear();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Database error:\n\n" + ex.Message,
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            Login l = new Login();
            l.Show();
        }
    }
}