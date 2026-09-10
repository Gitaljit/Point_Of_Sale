using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Category : Form
    {
        private readonly string connectionString =
            @"Data Source=DESKTOP-PHEQIRB\SQLEXPRESS;
              Initial Catalog=COLLEGEDB;
              Integrated Security=True;
              TrustServerCertificate=True;";

        public Category()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtcategoryname.Text))
            {
                MessageBox.Show("Please enter category name.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string sql = @"
                        INSERT INTO Category
                        (category_name, remarks, status)
                        VALUES
                        (@category_name, @remarks, @status)";

                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue(
                            "@category_name",
                            txtcategoryname.Text.Trim());

                        cmd.Parameters.AddWithValue(
                            "@remarks",
                            txtremarks.Text.Trim());

                        cmd.Parameters.AddWithValue(
                            "@status",
                            txtstatus.Text);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Category saved successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                clear();
                GetCategoryData();
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
            txtcategoryname.Clear();
            txtremarks.Clear();
            txtstatus.Text = "--Select--";
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

        public void GetCategoryData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string sql = "SELECT * FROM Category";

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

        private void Category_Load(object sender, EventArgs e)
        {
            GetCategoryData();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}