using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace UcakRezervasyonu
{
    public partial class UcakForm : Form
    {
        public UcakForm()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string model = txtModel.Text;
            string marka = txtMarka.Text;
            string seriNo = txtSeriNo.Text;
            int koltukKapasitesi = int.Parse(txtKoltukKapasitesi.Text);

            string connectionString = "Data Source=UcakRezervasyonu.db;Version=3;";
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Ucak (Model, Marka, SeriNo, KoltukKapasitesi) VALUES (@model, @marka, @seriNo, @koltukKapasitesi)";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@model", model);
                    cmd.Parameters.AddWithValue("@marka", marka);
                    cmd.Parameters.AddWithValue("@seriNo", seriNo);
                    cmd.Parameters.AddWithValue("@koltukKapasitesi", koltukKapasitesi);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Uçak başarıyla kaydedildi.");
        }
    }
}
