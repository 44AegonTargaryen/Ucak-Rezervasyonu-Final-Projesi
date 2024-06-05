namespace UcakRezervasyonu
{
    partial class LokasyonForm
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
            this.cmbUlke = new System.Windows.Forms.ComboBox();
            this.txtSehir = new System.Windows.Forms.TextBox();
            this.txtHavaalani = new System.Windows.Forms.TextBox();
            this.chkAktif = new System.Windows.Forms.CheckBox();
            this.lblUlke = new System.Windows.Forms.Label();
            this.lblSehir = new System.Windows.Forms.Label();
            this.lblHavaalani = new System.Windows.Forms.Label();
            this.lblAktif = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbUlke
            // 
            this.cmbUlke.FormattingEnabled = true;
            this.cmbUlke.Location = new System.Drawing.Point(140, 30);
            this.cmbUlke.Name = "cmbUlke";
            this.cmbUlke.Size = new System.Drawing.Size(121, 21);
            this.cmbUlke.TabIndex = 0;
            // 
            // txtSehir
            // 
            this.txtSehir.Location = new System.Drawing.Point(140, 70);
            this.txtSehir.Name = "txtSehir";
            this.txtSehir.Size = new System.Drawing.Size(100, 20);
            this.txtSehir.TabIndex = 1;
            // 
            // txtHavaalani
            // 
            this.txtHavaalani.Location = new System.Drawing.Point(140, 110);
            this.txtHavaalani.Name = "txtHavaalani";
            this.txtHavaalani.Size = new System.Drawing.Size(100, 20);
            this.txtHavaalani.TabIndex = 2;
            // 
            // chkAktif
            // 
            this.chkAktif.AutoSize = true;
            this.chkAktif.Location = new System.Drawing.Point(140, 150);
            this.chkAktif.Name = "chkAktif";
            this.chkAktif.Size = new System.Drawing.Size(47, 17);
            this.chkAktif.TabIndex = 3;
            this.chkAktif.Text = "Aktif";
            this.chkAktif.UseVisualStyleBackColor = true;
            // 
            // lblUlke
            // 
            this.lblUlke.AutoSize = true;
            this.lblUlke.Location = new System.Drawing.Point(50, 30);
            this.lblUlke.Name = "lblUlke";
            this.lblUlke.Size = new System.Drawing.Size(32, 13);
            this.lblUlke.TabIndex = 4;
            this.lblUlke.Text = "Ülke:";
            // 
            // lblSehir
            // 
            this.lblSehir.AutoSize = true;
            this.lblSehir.Location = new System.Drawing.Point(50, 70);
            this.lblSehir.Name = "lblSehir";
            this.lblSehir.Size = new System.Drawing.Size(35, 13);
            this.lblSehir.TabIndex = 5;
            this.lblSehir.Text = "Şehir:";
            // 
            // lblHavaalani
            // 
            this.lblHavaalani.AutoSize = true;
            this.lblHavaalani.Location = new System.Drawing.Point(50, 110);
            this.lblHavaalani.Name = "lblHavaalani";
            this.lblHavaalani.Size = new System.Drawing.Size(59, 13);
            this.lblHavaalani.TabIndex = 6;
            this.lblHavaalani.Text = "Havaalanı:";
            // 
            // lblAktif
            // 
            this.lblAktif.AutoSize = true;
            this.lblAktif.Location = new System.Drawing.Point(50, 150);
            this.lblAktif.Name = "lblAktif";
            this.lblAktif.Size = new System.Drawing.Size(31, 13);
            this.lblAktif.TabIndex = 7;
            this.lblAktif.Text = "Aktif:";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(140, 190);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(100, 23);
            this.btnKaydet.TabIndex = 8;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // LokasyonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.lblAktif);
            this.Controls.Add(this.lblHavaalani);
            this.Controls.Add(this.lblSehir);
            this.Controls.Add(this.lblUlke);
            this.Controls.Add(this.chkAktif);
            this.Controls.Add(this.txtHavaalani);
            this.Controls.Add(this.txtSehir);
            this.Controls.Add(this.cmbUlke);
            this.Name = "LokasyonForm";
            this.Text = "Lokasyon Formu";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ComboBox cmbUlke;
        private System.Windows.Forms.TextBox txtSehir;
        private System.Windows.Forms.TextBox txtHavaalani;
        private System.Windows.Forms.CheckBox chkAktif;
        private System.Windows.Forms.Label lblUlke;
        private System.Windows.Forms.Label lblSehir;
        private System.Windows.Forms.Label lblHavaalani;
        private System.Windows.Forms.Label lblAktif;
        private System.Windows.Forms.Button btnKaydet;
    }
}
