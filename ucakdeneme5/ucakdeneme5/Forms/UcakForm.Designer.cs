namespace UcakRezervasyonu
{
    partial class UcakForm
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
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.txtSeriNo = new System.Windows.Forms.TextBox();
            this.txtKoltukKapasitesi = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblMarka = new System.Windows.Forms.Label();
            this.lblSeriNo = new System.Windows.Forms.Label();
            this.lblKoltukKapasitesi = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(140, 30);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 20);
            this.txtModel.TabIndex = 0;
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(140, 70);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(100, 20);
            this.txtMarka.TabIndex = 1;
            // 
            // txtSeriNo
            // 
            this.txtSeriNo.Location = new System.Drawing.Point(140, 110);
            this.txtSeriNo.Name = "txtSeriNo";
            this.txtSeriNo.Size = new System.Drawing.Size(100, 20);
            this.txtSeriNo.TabIndex = 2;
            // 
            // txtKoltukKapasitesi
            // 
            this.txtKoltukKapasitesi.Location = new System.Drawing.Point(140, 150);
            this.txtKoltukKapasitesi.Name = "txtKoltukKapasitesi";
            this.txtKoltukKapasitesi.Size = new System.Drawing.Size(100, 20);
            this.txtKoltukKapasitesi.TabIndex = 3;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(50, 30);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(39, 13);
            this.lblModel.TabIndex = 4;
            this.lblModel.Text = "Model:";
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.Location = new System.Drawing.Point(50, 70);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(37, 13);
            this.lblMarka.TabIndex = 5;
            this.lblMarka.Text = "Marka:";
            // 
            // lblSeriNo
            // 
            this.lblSeriNo.AutoSize = true;
            this.lblSeriNo.Location = new System.Drawing.Point(50, 110);
            this.lblSeriNo.Name = "lblSeriNo";
            this.lblSeriNo.Size = new System.Drawing.Size(46, 13);
            this.lblSeriNo.TabIndex = 6;
            this.lblSeriNo.Text = "Seri No:";
            // 
            // lblKoltukKapasitesi
            // 
            this.lblKoltukKapasitesi.AutoSize = true;
            this.lblKoltukKapasitesi.Location = new System.Drawing.Point(50, 150);
            this.lblKoltukKapasitesi.Name = "lblKoltukKapasitesi";
            this.lblKoltukKapasitesi.Size = new System.Drawing.Size(87, 13);
            this.lblKoltukKapasitesi.TabIndex = 7;
            this.lblKoltukKapasitesi.Text = "Koltuk Kapasitesi:";
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
            // UcakForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.lblKoltukKapasitesi);
            this.Controls.Add(this.lblSeriNo);
            this.Controls.Add(this.lblMarka);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.txtKoltukKapasitesi);
            this.Controls.Add(this.txtSeriNo);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.txtModel);
            this.Name = "UcakForm";
            this.Text = "Uçak Formu";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.TextBox txtSeriNo;
        private System.Windows.Forms.TextBox txtKoltukKapasitesi;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.Label lblSeriNo;
        private System.Windows.Forms.Label lblKoltukKapasitesi;
        private System.Windows.Forms.Button btnKaydet;
    }
}
