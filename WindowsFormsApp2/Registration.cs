using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Registration : Form
    {
        private readonly string connectionString =
            @"Data Source=DESKTOP-PHEQIRB\SQLEXPRESS;
              Initial Catalog=COLLEGEDB;
              Integrated Security=True;
              TrustServerCertificate=True;";

        public Registration()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check required fields
            if (string.IsNullOrWhiteSpace(txtun.Text) ||
                string.IsNullOrWhiteSpace(txtpw.Text) ||
                string.IsNullOrWhiteSpace(txtcpw.Text) ||
                string.IsNullOrWhiteSpace(txtemail.Text))
            {
                MessageBox.Show(
                    "Please fill in all required fields.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Check password
            if (txtpw.Text != txtcpw.Text)
            {
                MessageBox.Show(
                    "Password and Confirm Password do not match.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con =
                       new SqlConnection(connectionString))
                {
                    con.Open();

                    // Generate next ID
                    string idQuery =
                        "SELECT ISNULL(MAX(id), 0) + 1 FROM Register1";

                    int newId;

                    using (SqlCommand idCmd =
                           new SqlCommand(idQuery, con))
                    {
                        newId = Convert.ToInt32(
                            idCmd.ExecuteScalar());
                    }

                    // Insert registration
                    string sql = @"
                        INSERT INTO Register1
                        (
                            id,
                            name,
                            password,
                            confirm_password,
                            gender,
                            email,
                            phone_no,
                            dob,
                            address
                        )
                        VALUES
                        (
                            @id,
                            @name,
                            @password,
                            @confirm_password,
                            @gender,
                            @email,
                            @phone_no,
                            @dob,
                            @address
                        )";

                    using (SqlCommand cmd =
                           new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue(
                            "@id", newId);

                        cmd.Parameters.AddWithValue(
                            "@name", txtun.Text.Trim());

                        cmd.Parameters.AddWithValue(
                            "@password", txtpw.Text);

                        cmd.Parameters.AddWithValue(
                            "@confirm_password", txtcpw.Text);

                        cmd.Parameters.AddWithValue(
                            "@gender", txtgen.Text.Trim());

                        cmd.Parameters.AddWithValue(
                            "@email", txtemail.Text.Trim());

                        cmd.Parameters.AddWithValue(
                            "@phone_no", txtph.Text.Trim());

                        cmd.Parameters.AddWithValue(
                            "@dob", DOB.Text);

                        cmd.Parameters.AddWithValue(
                            "@address", txtadd.Text.Trim());

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Registration successful!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                clear();
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

        // Clear all fields
        public void clear()
        {
            txtun.Clear();
            txtpw.Clear();
            txtcpw.Clear();
            txtgen.Clear();
            txtemail.Clear();
            txtph.Clear();
            txtadd.Clear();
        }

        // Back to Login
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            Login login = new Login();
            login.Show();
        }

        // Close
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Clear
        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void txtpw_TextChanged(object sender, EventArgs e)
        {
        }
    }
}