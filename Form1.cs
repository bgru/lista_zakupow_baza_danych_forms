using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LISTA_ZAK_BAZA_DANYCH
{
    public partial class Form1 : Form
    {
        Product_DBDataContext db_dc;


        public Form1()
        {
            InitializeComponent();
            db_dc = new Product_DBDataContext();
            List<Product> product_list = db_dc.Products.ToList();

            foreach(Product i in product_list)
            {
                ProductControl sc = new ProductControl(db_dc);
                sc.iniValues(i.Name, (int)i.Quantity, (decimal)i.Price, i.Id);
                sc.ValueChanged += UserControl_ValueChanged;
                FlowPanel.Controls.Add(sc);
                Suma_NumericUD.Value += ((int)i.Quantity * (decimal)i.Price);
            }


        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            Product newProduct = new Product
            {
                Name = "",
                Quantity = 0,
                Price = 0
            };
            db_dc.Products.InsertOnSubmit(newProduct);
            //db_dc.SubmitChanges();

            // Submit changes to the database
            try
            {
                db_dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }

            ProductControl sc = new ProductControl(db_dc);
            sc.ValueChanged += UserControl_ValueChanged;
            sc.Product_ID = newProduct.Id;
            FlowPanel.Controls.Add(sc);
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (ProductControl control in FlowPanel.Controls.OfType<ProductControl>())
            {
                // Find the product in the database
                Product product = db_dc.Products.First(p => p.Id == control.Product_ID);

                // Update the product properties from the UI
                product.Name = control.ProductNameText;
                product.Quantity = (int)control.ProductQuantity;
                product.Price = control.ProductPrice;
            }

            // Save all changes to the database
            db_dc.SubmitChanges();
        }

        private void UserControl_ValueChanged(object sender, decimal newVal)
        {
            Suma_NumericUD.Value += newVal;
        }


    }
}
