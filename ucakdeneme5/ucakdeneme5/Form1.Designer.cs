namespace UcakRezervasyonu
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnUcakFormuAc = new System.Windows.Forms.Button();
            this.btnLokasyonFormuAc = new System.Windows.Forms.Button();
            this.btnRezervasyonFormuAc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUcakFormuAc
            // 
            this.btnUcakFormuAc.Location = new System.Drawing.Point(100, 30);
            this.btnUcakFormuAc.Name = "btnUcakFormuAc";
            this.btnUcakFormuAc.Size = new System.Drawing.Size(150, 23);
            this.btnUcakFormuAc.TabIndex = 0;
            this.btnUcakFormuAc.Text = "Uçak Formu Aç";
            this.btnUcakFormuAc.UseVisualStyleBackColor = true;
            this.btnUcakFormuAc.Click += new System.EventHandler(this.btnUcakFormuAc_Click);
            // 
            // btnLokasyonFormuAc
            // 
            this.btnLokasyonFormuAc.Location = new System.Drawing.Point(100, 70);
            this.btnLokasyonFormuAc.Name = "btnLokasyonFormuAc";
            this.btnLokasyonFormuAc.Size = new System.Drawing.Size(150, 23);
            this.btnLokasyonFormuAc.TabIndex = 1;
            this.btnLokasyonFormuAc.Text = "Lokasyon Formu Aç";
            this.btnLokasyonFormuAc.UseVisualStyleBackColor = true;
            this.btnLokasyonFormuAc.Click += new System.EventHandler(this.btnLokasyonFormuAc_Click);
            // 
            // btnRezervasyonFormuAc
            // 
            this.btnRezervasyonFormuAc.Location = new System.Drawing.Point(100, 110);
            this.btnRezervasyonFormuAc.Name = "btnRezervasyonFormuAc";
            this.btnRezervasyonFormuAc.Size = new System.Drawing.Size(150, 23);
            this.btnRezervasyonFormuAc.TabIndex = 2;
            this.btnRezervasyonFormuAc.Text = "Rezervasyon Formu Aç";
            this.btnRezervasyonFormuAc.UseVisualStyleBackColor = true;
            this.btnRezervasyonFormuAc.Click += new System.EventHandler(this.btnRezervasyonFormuAc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.btnRezervasyonFormuAc);
            this.Controls.Add(this.btnLokasyonFormuAc);
            this.Controls.Add(this.btnUcakFormuAc);
            this.Name = "Form1";
            this.Text = "Ana Menü";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnUcakFormuAc;
        private System.Windows.Forms.Button btnLokasyonFormuAc;
        private System.Windows.Forms.Button btnRezervasyonFormuAc;
    }
}
