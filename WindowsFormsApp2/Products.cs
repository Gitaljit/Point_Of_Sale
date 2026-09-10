using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Products : Form
    {
        private readonly string connectionString =
            @"Data Source=DESKTOP-PHEQIRB\SQLEXPRESS;
              Initial Catalog=COLLEGEDB;
              Integrated Security=True;
              TrustServerCertificate=True;";

        public Products()
        {
            InitializeComponent();

            txtSave.Enabled = false;
            txtProductCode.Text = "202425/PID/00";
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetProductsData();
            GetcategoryData();
        }

        // Load categories
        private void GetcategoryData()
        {
            try
            {
                txtCategory.Items.Clear();

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string sql = "SELECT category_name FROM Category";

                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            txtCategory.Items.Add(dr["category_name"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading categories:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        // Save Product
        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtProductName.Text))
                {
                    MessageBox.Show("Please enter product name.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtPrice.Text))
                {
                    MessageBox.Show("Please enter price.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtQuantity.Text))
                {
                    MessageBox.Show("Please enter quantity.");
                    return;
                }

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string sql = @"
                        INSERT INTO Products
                        (ProductCode, ProductName, Category, Price, Quantity, Status)
                        VALUES
                        (@ProductCode, @ProductName, @Category, @Price, @Quantity, @Status)";

                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@ProductCode", txtProductCode.Text);
                        cmd.Parameters.AddWithValue("@ProductName", txtProductName.Text);
                        cmd.Parameters.AddWithValue("@Category", txtCategory.Text);
                        cmd.Parameters.AddWithValue("@Price", txtPrice.Text);
                        cmd.Parameters.AddWithValue("@Quantity", txtQuantity.Text);
                        cmd.Parameters.AddWithValue("@Status", txtStatus.Text);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Product has been saved successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                clear();
                GetProductsData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error while saving product:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Clear fields
        public void clear()
        {
            txtProductCode.Text = "202425/PID/00";
            txtProductName.Clear();
            txtCategory.Text = "--Select--";
            txtPrice.Clear();
            txtQuantity.Clear();
            txtStatus.Text = "--Select--";

            txtSave.Enabled = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void txtproductCode_TextChanged(object sender, EventArgs e)
        {
        }

        // Close form
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
        }

        // Load products into DataGridView
        public void GetProductsData()
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

        // Enable Save button when quantity is entered
        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            txtSave.Enabled =
                !string.IsNullOrWhiteSpace(txtQuantity.Text);
        }

        // Clear button
        private void button7_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}