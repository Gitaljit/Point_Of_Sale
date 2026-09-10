namespace WindowsFormsApp2
{
    partial class Orders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orders));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtcategory = new System.Windows.Forms.TextBox();
            this.comboccode = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.Label();
            this.txtproduct_name = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtphoneno = new System.Windows.Forms.TextBox();
            this.txtdate_created = new System.Windows.Forms.DateTimePicker();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.txtSave = new System.Windows.Forms.Button();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtcustomername = new System.Windows.Forms.TextBox();
            this.txtordername = new System.Windows.Forms.TextBox();
            this.txtorderno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.txtcategory);
            this.panel1.Controls.Add(this.comboccode);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Controls.Add(this.txtproduct_name);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtprice);
            this.panel1.Controls.Add(this.txtphoneno);
            this.panel1.Controls.Add(this.txtdate_created);
            this.panel1.Controls.Add(this.txtquantity);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.txtSave);
            this.panel1.Controls.Add(this.txtemail);
            this.panel1.Controls.Add(this.txtcustomername);
            this.panel1.Controls.Add(this.txtordername);
            this.panel1.Controls.Add(this.txtorderno);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 356);
            this.panel1.TabIndex = 29;
            // 
            // txtcategory
            // 
            this.txtcategory.Location = new System.Drawing.Point(596, 114);
            this.txtcategory.Name = "txtcategory";
            this.txtcategory.Size = new System.Drawing.Size(200, 30);
            this.txtcategory.TabIndex = 64;
            // 
            // comboccode
            // 
            this.comboccode.FormattingEnabled = true;
            this.comboccode.Location = new System.Drawing.Point(189, 107);
            this.comboccode.Name = "comboccode";
            this.comboccode.Size = new System.Drawing.Size(191, 33);
            this.comboccode.TabIndex = 63;
            this.comboccode.SelectedIndexChanged += new System.EventHandler(this.comboccode_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(24, 114);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 16);
            this.label13.TabIndex = 62;
            this.label13.Text = "Customer Code:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(596, 261);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 22);
            this.textBox1.TabIndex = 61;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // txtTotal
            // 
            this.txtTotal.AutoSize = true;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(473, 264);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(51, 16);
            this.txtTotal.TabIndex = 60;
            this.txtTotal.Text = "Total :";
            this.txtTotal.Click += new System.EventHandler(this.txtTotal_Click);
            // 
            // txtproduct_name
            // 
            this.txtproduct_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproduct_name.FormattingEnabled = true;
            this.txtproduct_name.Items.AddRange(new object[] {
            "Electronic",
            "Grocery"});
            this.txtproduct_name.Location = new System.Drawing.Point(596, 67);
            this.txtproduct_name.Name = "txtproduct_name";
            this.txtproduct_name.Size = new System.Drawing.Size(200, 24);
            this.txtproduct_name.TabIndex = 57;
            this.txtproduct_name.Text = "---Select---";
            this.txtproduct_name.SelectedIndexChanged += new System.EventHandler(this.txtproduct_name_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(544, 304);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 25);
            this.label12.TabIndex = 55;
            this.label12.Text = "Orders :";
            // 
            // txtprice
            // 
            this.txtprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprice.Location = new System.Drawing.Point(596, 208);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(200, 22);
            this.txtprice.TabIndex = 54;
            this.txtprice.TextChanged += new System.EventHandler(this.txtprice_TextChanged);
            // 
            // txtphoneno
            // 
            this.txtphoneno.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphoneno.Location = new System.Drawing.Point(189, 211);
            this.txtphoneno.Name = "txtphoneno";
            this.txtphoneno.Size = new System.Drawing.Size(191, 22);
            this.txtphoneno.TabIndex = 53;
            // 
            // txtdate_created
            // 
            this.txtdate_created.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdate_created.Location = new System.Drawing.Point(596, 24);
            this.txtdate_created.Name = "txtdate_created";
            this.txtdate_created.Size = new System.Drawing.Size(200, 22);
            this.txtdate_created.TabIndex = 52;
            this.txtdate_created.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtquantity
            // 
            this.txtquantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquantity.Location = new System.Drawing.Point(596, 161);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(200, 22);
            this.txtquantity.TabIndex = 51;
            this.txtquantity.TextChanged += new System.EventHandler(this.txtquantity_TextChanged);
            this.txtquantity.Leave += new System.EventHandler(this.txtquantity_Leave_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(473, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 47;
            this.label2.Text = "Quantity :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(473, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 46;
            this.label3.Text = "Price :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(454, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 16);
            this.label4.TabIndex = 45;
            this.label4.Text = "Product Name :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(473, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 44;
            this.label5.Text = "Category :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(473, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 16);
            this.label11.TabIndex = 43;
            this.label11.Text = "Date Created :";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(381, 303);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 34);
            this.button5.TabIndex = 41;
            this.button5.Text = "Close";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(220, 303);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(93, 32);
            this.button7.TabIndex = 39;
            this.button7.Text = "Reset";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // txtSave
            // 
            this.txtSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSave.Image = ((System.Drawing.Image)(resources.GetObject("txtSave.Image")));
            this.txtSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtSave.Location = new System.Drawing.Point(78, 305);
            this.txtSave.Name = "txtSave";
            this.txtSave.Size = new System.Drawing.Size(92, 32);
            this.txtSave.TabIndex = 38;
            this.txtSave.Text = "Save";
            this.txtSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.txtSave.UseVisualStyleBackColor = true;
            this.txtSave.Click += new System.EventHandler(this.button8_Click);
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(189, 258);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(191, 22);
            this.txtemail.TabIndex = 37;
            // 
            // txtcustomername
            // 
            this.txtcustomername.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcustomername.Location = new System.Drawing.Point(189, 164);
            this.txtcustomername.Name = "txtcustomername";
            this.txtcustomername.Size = new System.Drawing.Size(191, 22);
            this.txtcustomername.TabIndex = 36;
            // 
            // txtordername
            // 
            this.txtordername.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtordername.Location = new System.Drawing.Point(189, 64);
            this.txtordername.Name = "txtordername";
            this.txtordername.Size = new System.Drawing.Size(191, 22);
            this.txtordername.TabIndex = 35;
            // 
            // txtorderno
            // 
            this.txtorderno.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtorderno.Location = new System.Drawing.Point(189, 24);
            this.txtorderno.Name = "txtorderno";
            this.txtorderno.Size = new System.Drawing.Size(191, 22);
            this.txtorderno.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 33;
            this.label6.Text = "Email :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 16);
            this.label7.TabIndex = 32;
            this.label7.Text = "Phone No :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 16);
            this.label8.TabIndex = 31;
            this.label8.Text = "Custermer Name :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(29, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 16);
            this.label9.TabIndex = 30;
            this.label9.Text = "OrderName";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(29, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 16);
            this.label10.TabIndex = 29;
            this.label10.Text = "Order No :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Purple;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-3, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(871, 90);
            this.panel2.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(384, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 32);
            this.label1.TabIndex = 56;
            this.label1.Text = "Orders";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 473);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(844, 153);
            this.dataGridView1.TabIndex = 60;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(857, 638);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Orders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Orders_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button txtSave;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtcustomername;
        private System.Windows.Forms.TextBox txtordername;
        private System.Windows.Forms.TextBox txtorderno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker txtdate_created;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtphoneno;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox txtproduct_name;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtTotal;
        private System.Windows.Forms.ComboBox comboccode;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtcategory;
    }
}