using FormSample.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormSample
{
    public partial class Form2 : Form
    {
        List<Product> products = new List<Product>();
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Name = txtName.Text;
            product.Stock = Convert.ToInt32(txtStock.Text);
            product.Price = Convert.ToDecimal(txtPrice.Text);
       

            //listede ayni isimle bir urun varsa mesaj versin
            bool urunVarMi = false;
            foreach (var item in products)
            {
                if (item.Name == txtName.Text)
                {
                    urunVarMi = true;
                    MessageBox.Show("Bu urun mevcut");
                }
            }

            if (urunVarMi == false)
            {
                products.Add(product);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = products;

                lblCount.Text = products.Count.ToString();
            }


        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text;

            List<Product> searchProducts = new List<Product>();   

            foreach (var item in products) { 
            
                if (item.Name.Contains(search))
                {
                    searchProducts.Add(item);
                }
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = searchProducts;

            lblCount.Text = searchProducts.Count.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                int number = Convert.ToInt32(txtDelete.Text);

                products.RemoveAt(number - 1);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = products;
            }
            catch (Exception)
            {
                MessageBox.Show("Duzgun bir sayi lutfen");
            }
      
        }
    }
}
//products.Add(product);

//dataGridView1.DataSource = null;
//dataGridView1.DataSource = products;

//lblCount.Text = products.Count.ToString();