
namespace LISTA_ZAK_BAZA_DANYCH
{
    partial class Form1
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
            this.Add_button = new System.Windows.Forms.Button();
            this.FlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Suma_NumericUD = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Suma_NumericUD)).BeginInit();
            this.SuspendLayout();
            // 
            // Add_button
            // 
            this.Add_button.Location = new System.Drawing.Point(12, 12);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(75, 23);
            this.Add_button.TabIndex = 0;
            this.Add_button.Text = "Add";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // FlowPanel
            // 
            this.FlowPanel.AutoSize = true;
            this.FlowPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FlowPanel.Location = new System.Drawing.Point(12, 42);
            this.FlowPanel.MaximumSize = new System.Drawing.Size(650, 0);
            this.FlowPanel.MinimumSize = new System.Drawing.Size(650, 100);
            this.FlowPanel.Name = "FlowPanel";
            this.FlowPanel.Size = new System.Drawing.Size(650, 100);
            this.FlowPanel.TabIndex = 1;
            // 
            // Suma_NumericUD
            // 
            this.Suma_NumericUD.DecimalPlaces = 2;
            this.Suma_NumericUD.Enabled = false;
            this.Suma_NumericUD.Location = new System.Drawing.Point(432, 15);
            this.Suma_NumericUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.Suma_NumericUD.Name = "Suma_NumericUD";
            this.Suma_NumericUD.Size = new System.Drawing.Size(120, 20);
            this.Suma_NumericUD.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(389, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Suma:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(683, 288);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Suma_NumericUD);
            this.Controls.Add(this.FlowPanel);
            this.Controls.Add(this.Add_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.Suma_NumericUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.FlowLayoutPanel FlowPanel;
        private System.Windows.Forms.NumericUpDown Suma_NumericUD;
        private System.Windows.Forms.Label label1;
    }
}

