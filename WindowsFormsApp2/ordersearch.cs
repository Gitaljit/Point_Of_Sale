using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class ordersearch : Form
    {
        private readonly string connectionString =
            @"Data Source=DESKTOP-PHEQIRB\SQLEXPRESS;
              Initial Catalog=COLLEGEDB;
              Integrated Security=True;
              TrustServerCertificate=True;";

        public ordersearch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string sql = @"
                        SELECT *
                        FROM Orders
                        WHERE orderno LIKE @orderno";

                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue(
                            "@orderno",
                            "%" + txtorderno.Text.Trim() + "%"
                        );

                        using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
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
                    "Error while searching orders:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void ordersearch_Load(object sender, EventArgs e)
        {
            GetOrderSearchData();
        }

        public void GetOrderSearchData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string sql = "SELECT * FROM Orders";

                    using (SqlDataAdapter adp = new SqlDataAdapter(sql, con))
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
                    "Error loading orders:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}