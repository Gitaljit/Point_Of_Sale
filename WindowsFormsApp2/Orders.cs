using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Orders : Form
    {
        private readonly string connectionString =
            @"Data Source=DESKTOP-PHEQIRB\SQLEXPRESS;
              Initial Catalog=COLLEGEDB;
              Integrated Security=True;
              TrustServerCertificate=True;";

        public Orders()
        {
            InitializeComponent();

            txtSave.Enabled = false;
            txtorderno.Text = "202526/ORDER/00";
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void txtdatecreated_ValueChanged(object sender, EventArgs e)
        {
        }

        // SAVE ORDER
        private void button8_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtorderno.Text) ||
                string.IsNullOrWhiteSpace(txtordername.Text) ||
                string.IsNullOrWhiteSpace(comboccode.Text) ||
                string.IsNullOrWhiteSpace(txtcustomername.Text) ||
                string.IsNullOrWhiteSpace(txtproduct_name.Text) ||
                string.IsNullOrWhiteSpace(txtquantity.Text))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            try
            {
                using (SqlConnection con =
                    new SqlConnection(connectionString))
                {
                    con.Open();

                    string sql = @"
                        INSERT INTO Orders
                        (orderno, ordername, customer_code, customername,
                         phone_no, email, date_created, category,
                         product_name, quantity, price, total)
                        VALUES
                        (@orderno, @ordername, @customer_code, @customername,
                         @phone_no, @email, @date_created, @category,
                         @product_name, @quantity, @price, @total)";

                    using (SqlCommand cmd =
                        new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue(
                            "@orderno", txtorderno.Text.Trim());

                        cmd.Parameters.AddWithValue(
                            "@ordername", txtordername.Text.Trim());

                        cmd.Parameters.AddWithValue(
                            "@customer_code", comboccode.Text.Trim());

                        cmd.Parameters.AddWithValue(
                            "@customername", txtcustomername.Text.Trim());

                        cmd.Parameters.AddWithValue(
                            "@phone_no", txtphoneno.Text.Trim());

                        cmd.Parameters.AddWithValue(
                            "@email", txtemail.Text.Trim());

                        cmd.Parameters.AddWithValue(
                            "@date_created", txtdate_created.Text);

                        cmd.Parameters.AddWithValue(
                            "@category", txtcategory.Text);

                        cmd.Parameters.AddWithValue(
                            "@product_name", txtproduct_name.Text);

                        cmd.Parameters.AddWithValue(
                            "@quantity", txtquantity.Text);

                        cmd.Parameters.AddWithValue(
                            "@price", txtprice.Text);

                        cmd.Parameters.AddWithValue(
                            "@total", textBox1.Text);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Order saved successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                clear();
                GetOrderData();
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

        // CLEAR
        public void clear()
        {
            txtorderno.Clear();
            txtordername.Clear();

            comboccode.Text = "--Select--";

            txtcustomername.Clear();
            txtphoneno.Clear();
            txtemail.Clear();

            txtcategory.Text = "---Select---";
            txtproduct_name.Text = "---Select---";

            txtquantity.Clear();
            txtprice.Clear();
            textBox1.Clear();

            txtSave.Enabled = false;

            txtorderno.Text = "202526/ORDER/00";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
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

        // DISPLAY ORDERS
        public void GetOrderData()
        {
            try
            {
                using (SqlConnection con =
                    new SqlConnection(connectionString))
                {
                    con.Open();

                    string SQL = "SELECT * FROM Orders";

                    SqlDataAdapter ADP =
                        new SqlDataAdapter(SQL, con);

                    DataTable DT = new DataTable();

                    ADP.Fill(DT);

                    dataGridView1.DataSource = DT;
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

        private void Orders_Load(object sender, EventArgs e)
        {
            GetCustomerDetails();
            GetOrderData();
            GetProductDetails();
        }

        // LOAD PRODUCTS
        private void GetProductDetails()
        {
            try
            {
                txtproduct_name.Items.Clear();

                using (SqlConnection con =
                    new SqlConnection(connectionString))
                {
                    con.Open();

                    string str =
                        "SELECT ProductName FROM Products";

                    using (SqlCommand cmd =
                        new SqlCommand(str, con))
                    {
                        using (SqlDataReader dr =
                            cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                txtproduct_name.Items.Add(
                                    dr["ProductName"].ToString());
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Could not load products:\n\n" + ex.Message);
            }
        }

        // LOAD CUSTOMERS
        private void GetCustomerDetails()
        {
            try
            {
                // IMPORTANT:
                // Clear customer combo, not product combo
                comboccode.Items.Clear();

                using (SqlConnection con =
                    new SqlConnection(connectionString))
                {
                    con.Open();

                    string str =
                        "SELECT customer_code FROM Customers";

                    using (SqlCommand cmd =
                        new SqlCommand(str, con))
                    {
                        using (SqlDataReader dr =
                            cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                comboccode.Items.Add(
                                    dr["customer_code"].ToString());
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Could not load customers:\n\n" + ex.Message);
            }
        }

        // PRODUCT SELECTED
        private void txtproduct_name_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtproduct_name.Text))
                return;

            try
            {
                using (SqlConnection con =
                    new SqlConnection(connectionString))
                {
                    con.Open();

                    string str = @"
                        SELECT ProductName, Price, Category
                        FROM Products
                        WHERE ProductName = @ProductName";

                    using (SqlCommand cmd =
                        new SqlCommand(str, con))
                    {
                        cmd.Parameters.AddWithValue(
                            "@ProductName",
                            txtproduct_name.Text);

                        using (SqlDataReader dr =
                            cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                txtprice.Text =
                                    dr["Price"].ToString();

                                txtcategory.Text =
                                    dr["Category"].ToString();
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Could not load product details:\n\n" +
                    ex.Message);
            }
        }

        private void txtquantity_TextChanged(
            object sender,
            EventArgs e)
        {
            txtSave.Enabled =
                !string.IsNullOrWhiteSpace(txtquantity.Text);
        }

        private void txtquantity_Leave(object sender, EventArgs e)
        {
        }

        private void txtquantity_Leave_1(
            object sender,
            EventArgs e)
        {
            CalculateTotal();
        }

        private void CalculateTotal()
        {
            try
            {
                float quantity =
                    float.Parse(txtquantity.Text);

                float price =
                    float.Parse(txtprice.Text);

                textBox1.Text =
                    (quantity * price).ToString("0.00");
            }
            catch
            {
                textBox1.Clear();
            }
        }

        private void textBox1_Leave(
            object sender,
            EventArgs e)
        {
        }

        private void textBox1_TextChanged(
            object sender,
            EventArgs e)
        {
        }

        private void txtTotal_Click(
            object sender,
            EventArgs e)
        {
        }

        private void txtprice_TextChanged(
            object sender,
            EventArgs e)
        {
        }

        // CUSTOMER SELECTED
        private void comboccode_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboccode.Text))
                return;

            try
            {
                using (SqlConnection con =
                    new SqlConnection(connectionString))
                {
                    con.Open();

                    string str = @"
                        SELECT customer_name,
                               phone_no,
                               email
                        FROM Customers
                        WHERE customer_code = @customer_code";

                    using (SqlCommand cmd =
                        new SqlCommand(str, con))
                    {
                        cmd.Parameters.AddWithValue(
                            "@customer_code",
                            comboccode.Text);

                        using (SqlDataReader dr =
                            cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                txtcustomername.Text =
                                    dr["customer_name"].ToString();

                                txtphoneno.Text =
                                    dr["phone_no"].ToString();

                                txtemail.Text =
                                    dr["email"].ToString();
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Could not load customer details:\n\n" +
                    ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}