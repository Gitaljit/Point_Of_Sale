using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Customers : Form
    {
        private readonly string connectionString =
            @"Data Source=DESKTOP-PHEQIRB\SQLEXPRESS;
              Initial Catalog=COLLEGEDB;
              Integrated Security=True;
              TrustServerCertificate=True;";

        public Customers()
        {
            InitializeComponent();

            txtcustomercode.Text = "202425/CID/00";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtcustomercode.Text) ||
                string.IsNullOrWhiteSpace(txtcustomername.Text))
            {
                MessageBox.Show("Please enter customer code and customer name.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string sql = @"
                        INSERT INTO Customers
                        (customer_code, customer_name, email, address, phone_no)
                        VALUES
                        (@customer_code, @customer_name, @email, @address, @phone_no)";

                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue(
                            "@customer_code",
                            txtcustomercode.Text.Trim());

                        cmd.Parameters.AddWithValue(
                            "@customer_name",
                            txtcustomername.Text.Trim());

                        cmd.Parameters.AddWithValue(
                            "@email",
                            txtemail.Text.Trim());

                        cmd.Parameters.AddWithValue(
                            "@address",
                            txtAddress.Text.Trim());

                        cmd.Parameters.AddWithValue(
                            "@phone_no",
                            txtphoneno.Text.Trim());

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Customer saved successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                clear();
                GetCustomersData();
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

        public void clear()
        {
            txtcustomercode.Clear();
            txtcustomername.Clear();
            txtemail.Clear();
            txtAddress.Clear();
            txtphoneno.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
        }

        public void GetCustomersData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string sql = "SELECT * FROM Customers";

                    SqlDataAdapter adp =
                        new SqlDataAdapter(sql, con);

                    DataTable dt = new DataTable();

                    adp.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Database error:\n\n" + ex.Message,
                    "SQL Server Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            GetCustomersData();
        }
    }
}