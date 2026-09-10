using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class progressbar : Form
    {
        int a = 0;

        public progressbar()
        {
            InitializeComponent();

            // Start progress bar
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;

            label3.Text = "0%";
        }

        private void progressbar_Load(object sender, EventArgs e)
        {
            // Start timer when form loads
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 1;
                a++;

                label3.Text = a + "%";
            }

            if (progressBar1.Value >= 100)
            {
                timer1.Stop();

                label2.Text = "Completed";

                this.Hide();

                POS menu = new POS();
                menu.Show();
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
        }
    }
}