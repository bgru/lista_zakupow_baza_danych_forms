
namespace LISTA_ZAK_BAZA_DANYCH
{
    partial class ProductControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Nazwa_TextBox = new System.Windows.Forms.TextBox();
            this.Ilosc_NumericUD = new System.Windows.Forms.NumericUpDown();
            this.Cena_NumericUD = new System.Windows.Forms.NumericUpDown();
            this.Iloczyn_NumericUD = new System.Windows.Forms.NumericUpDown();
            this.Delete_button = new System.Windows.Forms.Button();
            this.product_ID_lablel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Ilosc_NumericUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cena_NumericUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Iloczyn_NumericUD)).BeginInit();
            this.SuspendLayout();
            // 
            // Nazwa_TextBox
            // 
            this.Nazwa_TextBox.Location = new System.Drawing.Point(15, 11);
            this.Nazwa_TextBox.Name = "Nazwa_TextBox";
            this.Nazwa_TextBox.Size = new System.Drawing.Size(117, 20);
            this.Nazwa_TextBox.TabIndex = 0;
            // 
            // Ilosc_NumericUD
            // 
            this.Ilosc_NumericUD.Location = new System.Drawing.Point(138, 11);
            this.Ilosc_NumericUD.Name = "Ilosc_NumericUD";
            this.Ilosc_NumericUD.Size = new System.Drawing.Size(68, 20);
            this.Ilosc_NumericUD.TabIndex = 1;
            this.Ilosc_NumericUD.ValueChanged += new System.EventHandler(this.Ilosc_NumericUD_ValueChanged);
            // 
            // Cena_NumericUD
            // 
            this.Cena_NumericUD.DecimalPlaces = 2;
            this.Cena_NumericUD.Location = new System.Drawing.Point(212, 11);
            this.Cena_NumericUD.Name = "Cena_NumericUD";
            this.Cena_NumericUD.Size = new System.Drawing.Size(104, 20);
            this.Cena_NumericUD.TabIndex = 2;
            this.Cena_NumericUD.ValueChanged += new System.EventHandler(this.Cena_NumericUD_ValueChanged);
            // 
            // Iloczyn_NumericUD
            // 
            this.Iloczyn_NumericUD.DecimalPlaces = 2;
            this.Iloczyn_NumericUD.Enabled = false;
            this.Iloczyn_NumericUD.Location = new System.Drawing.Point(322, 11);
            this.Iloczyn_NumericUD.Name = "Iloczyn_NumericUD";
            this.Iloczyn_NumericUD.Size = new System.Drawing.Size(106, 20);
            this.Iloczyn_NumericUD.TabIndex = 3;
            this.Iloczyn_NumericUD.ValueChanged += new System.EventHandler(this.Iloczyn_NumericUD_ValueChanged);
            // 
            // Delete_button
            // 
            this.Delete_button.Location = new System.Drawing.Point(434, 11);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(75, 23);
            this.Delete_button.TabIndex = 4;
            this.Delete_button.Text = "delete";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // product_ID_lablel
            // 
            this.product_ID_lablel.AutoSize = true;
            this.product_ID_lablel.Location = new System.Drawing.Point(525, 13);
            this.product_ID_lablel.Name = "product_ID_lablel";
            this.product_ID_lablel.Size = new System.Drawing.Size(35, 13);
            this.product_ID_lablel.TabIndex = 5;
            this.product_ID_lablel.Text = "label1";
            // 
            // ProductControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.product_ID_lablel);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Iloczyn_NumericUD);
            this.Controls.Add(this.Cena_NumericUD);
            this.Controls.Add(this.Ilosc_NumericUD);
            this.Controls.Add(this.Nazwa_TextBox);
            this.MinimumSize = new System.Drawing.Size(600, 30);
            this.Name = "ProductControl";
            this.Size = new System.Drawing.Size(600, 37);
            ((System.ComponentModel.ISupportInitialize)(this.Ilosc_NumericUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cena_NumericUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Iloczyn_NumericUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Nazwa_TextBox;
        private System.Windows.Forms.NumericUpDown Ilosc_NumericUD;
        private System.Windows.Forms.NumericUpDown Cena_NumericUD;
        private System.Windows.Forms.NumericUpDown Iloczyn_NumericUD;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Label product_ID_lablel;
    }
}
