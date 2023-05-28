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
    public partial class ProductControl : UserControl
    {
        Product_DBDataContext db_dc;
        public int Product_ID { get; set; }

        public string ProductNameText
        {
            get
            {
                return Nazwa_TextBox.Text;
            }
            set
            {
                Nazwa_TextBox.Text = value;
            }
        }

        public int ProductQuantity
        {
            get
            {
                return (int)Ilosc_NumericUD.Value;
            }
            set
            {
                Ilosc_NumericUD.Value = value;
            }
        }

        public decimal ProductPrice
        {
            get
            {
                return Cena_NumericUD.Value;
            }
            set
            {
                Cena_NumericUD.Value = value;
            }
        }


        public ProductControl(Product_DBDataContext db_dc)
        {
            InitializeComponent();
            Ilosc_NumericUD.Maximum = 1000;
            Cena_NumericUD.Maximum = 100000;
            Iloczyn_NumericUD.Maximum = 1000000;
            this.db_dc = db_dc;
            this.product_ID_lablel.Text = Product_ID.ToString();
        }

        public void iniValues(string name, int quantity, decimal price, int ID)
        {
            Nazwa_TextBox.Text = name.Trim();
            Ilosc_NumericUD.Value = quantity;
            Cena_NumericUD.Value = price;
            Product_ID = ID;
            product_ID_lablel.Text = ID.ToString();
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            Product pr = db_dc.Products.FirstOrDefault(p => p.Id == this.Product_ID);
            
            if(pr != null)
            {
                db_dc.Products.DeleteOnSubmit(pr);
                try
                {
                    db_dc.SubmitChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    return;
                }
            }

            ValueChanged?.Invoke(this, -(Iloczyn_NumericUD.Value));

            if(this.Parent != null)
            {
                this.Parent.Controls.Remove(this);
            }
        }

        private void Multiply()
        {
            Iloczyn_NumericUD.Value = Ilosc_NumericUD.Value * Cena_NumericUD.Value;
        }

        private void Ilosc_NumericUD_ValueChanged(object sender, EventArgs e)
        {
            Multiply();
        }

        private void Cena_NumericUD_ValueChanged(object sender, EventArgs e)
        {
            Multiply();
        }

        public delegate void IloczynValueChangedEvent(object sender, decimal newVal);
        public event IloczynValueChangedEvent ValueChanged;


        decimal previousValue = 0;
        private void Iloczyn_NumericUD_ValueChanged(object sender, EventArgs e)
        {
            if(previousValue > Iloczyn_NumericUD.Value)
            {
                ValueChanged?.Invoke(this, -(previousValue - Iloczyn_NumericUD.Value));
            }
            else
            {
                ValueChanged?.Invoke(this, (Iloczyn_NumericUD.Value - previousValue));
            }
            previousValue = Iloczyn_NumericUD.Value;

        }
    }
}
