using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Payment_Type : Form
    {
        private readonly string connectionString =
            @"Data Source=DESKTOP-PHEQIRB\SQLEXPRESS;
              Initial Catalog=COLLEGEDB;
              Integrated Security=True;
              TrustServerCertificate=True;";

        public Payment_Type()
        {
            InitializeComponent();
            txtpaymenttime.Text = DateTime.Now.ToString("HH:mm");
        }

        private void Payment_Type_Load(object sender, EventArgs e)
        {
            GetPayment_TypeData();
            GetPaymentDetail();
        }

        // Load order numbers into ComboBox
        private void GetPaymentDetail()
        {
            try
            {
                txtorderno.Items.Clear();

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string sql = "SELECT orderno FROM Orders";

                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            txtorderno.Items.Add(dr["orderno"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading order numbers:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
        }

        // Save Payment
        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string sql = @"
                        INSERT INTO Payment_Type1
                        (orderno, customername, productname, quantity, price,
                         discount, tax, paymenttype, paymenttime, paymentdate, totalamount)
                        VALUES
                        (@orderno, @customername, @productname, @quantity, @price,
                         @discount, @tax, @paymenttype, @paymenttime, @paymentdate, @totalamount)";

                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@orderno", txtorderno.Text);
                        cmd.Parameters.AddWithValue("@customername", txtcustomername.Text);
                        cmd.Parameters.AddWithValue("@productname", txtproductname.Text);
                        cmd.Parameters.AddWithValue("@quantity", txtquantity.Text);
                        cmd.Parameters.AddWithValue("@price", txtprice.Text);
                        cmd.Parameters.AddWithValue("@discount", txtdiscount.Text);
                        cmd.Parameters.AddWithValue("@tax", txttax.Text);
                        cmd.Parameters.AddWithValue("@paymenttype", txtpaymenttype.Text);
                        cmd.Parameters.AddWithValue("@paymenttime", txtpaymenttime.Text);
                        cmd.Parameters.AddWithValue("@paymentdate", txtpaymentdate.Text);
                        cmd.Parameters.AddWithValue("@totalamount", txttotalamount.Text);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Data has been saved successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                clear();
                GetPayment_TypeData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error while saving payment:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        public void clear()
        {
            txtorderno.Text = "---Select---";
            txtcustomername.Clear();
            txtproductname.Clear();
            txtquantity.Clear();
            txtprice.Clear();
            txtdiscount.Clear();
            txttax.Clear();
            txtpaymenttype.Text = "---Select---";
            txttotalamount.Clear();
            txtpaymenttime.Text = DateTime.Now.ToString("HH:mm");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtPTid_TextChanged(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        // Load payment data into DataGridView
        public void GetPayment_TypeData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string sql = "SELECT * FROM Payment_Type1";

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
                    "Error loading payment data:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // When order number is selected
        private void txtorderno_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string sql = @"
                        SELECT customername, product_name, quantity, price
                        FROM Orders
                        WHERE orderno = @orderno";

                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@orderno", txtorderno.Text);

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                txtcustomername.Text = dr["customername"].ToString();
                                txtproductname.Text = dr["product_name"].ToString();
                                txtquantity.Text = dr["quantity"].ToString();
                                txtprice.Text = dr["price"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading order details:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Calculate total after discount
        private void txtdiscount_Leave(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        // Calculate total after tax
        private void txttax_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void CalculateTotal()
        {
            try
            {
                float price = float.Parse(txtprice.Text);
                float discount = 0;
                float tax = 0;

                if (!string.IsNullOrWhiteSpace(txtdiscount.Text))
                    discount = float.Parse(txtdiscount.Text);

                if (!string.IsNullOrWhiteSpace(txttax.Text))
                    tax = float.Parse(txttax.Text);

                float total = price - discount + tax;

                txttotalamount.Text = total.ToString("0.00");
            }
            catch
            {
                // Ignore invalid/empty numbers
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}