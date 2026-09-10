using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class productsearch : Form
    {
        private readonly string connectionString =
            @"Data Source=DESKTOP-PHEQIRB\SQLEXPRESS;
              Initial Catalog=COLLEGEDB;
              Integrated Security=True;
              TrustServerCertificate=True;";

        public productsearch()
        {
            InitializeComponent();
        }

        // Search Product by Product Code
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string sql = @"
                        SELECT *
                        FROM Products
                        WHERE ProductCode LIKE @ProductCode";

                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue(
                            "@ProductCode",
                            "%" + txtproductno.Text.Trim() + "%"
                        );

                        using (SqlDataAdapter adp =
                               new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adp.Fill(dt);

                            dataGridView1.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error while searching products:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Load form
        private void productsearch_Load(object sender, EventArgs e)
        {
            GetProductSearchData();
        }

        // Display all products
        public void GetProductSearchData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string sql = "SELECT * FROM Products";

                    using (SqlDataAdapter adp =
                           new SqlDataAdapter(sql, con))
                    {
                        DataTable dt = new DataTable();
                        adp.Fill(dt);

                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading products:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}