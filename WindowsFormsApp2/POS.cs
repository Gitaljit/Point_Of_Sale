using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class POS : Form
    {
        public POS()
        {
            InitializeComponent();
        }

        private void POS_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
        }

        // Products
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            products.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        // Orders
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders();
            orders.Show();
        }

        // Customers
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers();
            customers.Show();
        }

        // Payment
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Payment_Type payment = new Payment_Type();
            payment.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        // Category
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        // Product Search
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            productsearch productSearch = new productsearch();
            productSearch.Show();
        }

        // Order Search
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            ordersearch orderSearch = new ordersearch();
            orderSearch.Show();
        }
    }
}