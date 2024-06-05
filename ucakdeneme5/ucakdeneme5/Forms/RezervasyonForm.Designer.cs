namespace UcakRezervasyonu
{
    partial class RezervasyonForm
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
            this.cmbUcak = new System.Windows.Forms.ComboBox();
            this.cmbLokasyon = new System.Windows.Forms.ComboBox();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.txtYolcuAdi = new System.Windows.Forms.TextBox();
            this.lblUcak = new System.Windows.Forms.Label();
            this.lblLokasyon = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblYolcuAdi = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.tblSeats = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // cmbUcak
            // 
            this.cmbUcak.FormattingEnabled = true;
            this.cmbUcak.Location = new System.Drawing.Point(140, 30);
            this.cmbUcak.Name = "cmbUcak";
            this.cmbUcak.Size = new System.Drawing.Size(200, 21);
            this.cmbUcak.TabIndex = 0;
            // 
            // cmbLokasyon
            // 
            this.cmbLokasyon.FormattingEnabled = true;
            this.cmbLokasyon.Location = new System.Drawing.Point(140, 70);
            this.cmbLokasyon.Name = "cmbLokasyon";
            this.cmbLokasyon.Size = new System.Drawing.Size(200, 21);
            this.cmbLokasyon.TabIndex = 1;
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(140, 110);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(200, 20);
            this.dtpTarih.TabIndex = 2;
            // 
            // txtYolcuAdi
            // 
            this.txtYolcuAdi.Location = new System.Drawing.Point(140, 150);
            this.txtYolcuAdi.Name = "txtYolcuAdi";
            this.txtYolcuAdi.Size = new System.Drawing.Size(200, 20);
            this.txtYolcuAdi.TabIndex = 3;
            // 
            // lblUcak
            // 
            this.lblUcak.AutoSize = true;
            this.lblUcak.Location = new System.Drawing.Point(50, 30);
            this.lblUcak.Name = "lblUcak";
            this.lblUcak.Size = new System.Drawing.Size(35, 13);
            this.lblUcak.TabIndex = 4;
            this.lblUcak.Text = "Uçak:";
            // 
            // lblLokasyon
            // 
            this.lblLokasyon.AutoSize = true;
            this.lblLokasyon.Location = new System.Drawing.Point(50, 70);
            this.lblLokasyon.Name = "lblLokasyon";
            this.lblLokasyon.Size = new System.Drawing.Size(54, 13);
            this.lblLokasyon.TabIndex = 5;
            this.lblLokasyon.Text = "Lokasyon:";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(50, 110);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(34, 13);
            this.lblTarih.TabIndex = 6;
            this.lblTarih.Text = "Tarih:";
            // 
            // lblYolcuAdi
            // 
            this.lblYolcuAdi.AutoSize = true;
            this.lblYolcuAdi.Location = new System.Drawing.Point(50, 150);
            this.lblYolcuAdi.Name = "lblYolcuAdi";
            this.lblYolcuAdi.Size = new System.Drawing.Size(54, 13);
            this.lblYolcuAdi.TabIndex = 7;
            this.lblYolcuAdi.Text = "Yolcu Adı:";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(140, 190);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(200, 23);
            this.btnKaydet.TabIndex = 8;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // tblSeats
            // 
            this.tblSeats.ColumnCount = 5;
            this.tblSeats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblSeats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblSeats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblSeats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblSeats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblSeats.Location = new System.Drawing.Point(50, 230);
            this.tblSeats.Name = "tblSeats";
            this.tblSeats.RowCount = 5;
            this.tblSeats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblSeats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblSeats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblSeats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblSeats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblSeats.Size = new System.Drawing.Size(290, 200);
            this.tblSeats.TabIndex = 9;
            // 
            // RezervasyonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.tblSeats);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.lblYolcuAdi);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.lblLokasyon);
            this.Controls.Add(this.lblUcak);
            this.Controls.Add(this.txtYolcuAdi);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.cmbLokasyon);
            this.Controls.Add(this.cmbUcak);
            this.Name = "RezervasyonForm";
            this.Text = "Rezervasyon Formu";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ComboBox cmbUcak;
        private System.Windows.Forms.ComboBox cmbLokasyon;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.TextBox txtYolcuAdi;
        private System.Windows.Forms.Label lblUcak;
        private System.Windows.Forms.Label lblLokasyon;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblYolcuAdi;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TableLayoutPanel tblSeats;
    }
}
