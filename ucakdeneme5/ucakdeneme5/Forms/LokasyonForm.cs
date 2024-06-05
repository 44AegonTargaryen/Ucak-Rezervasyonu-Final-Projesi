using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace UcakRezervasyonu
{
    public partial class LokasyonForm : Form
    {
        public LokasyonForm()
        {
            InitializeComponent();
            LoadComboBoxes();
        }

        private void LoadComboBoxes()
        {
            string[] ulkeler = { "Türkiye", "ABD", "Almanya" }; // Örnek ülke listesi, gerçekte veritabanından çekilebilir
            cmbUlke.Items.AddRange(ulkeler);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string ulke = cmbUlke.SelectedItem.ToString();
            string sehir = txtSehir.Text;
            string havaalani = txtHavaalani.Text;
            bool aktif = chkAktif.Checked;

            string connectionString = "Data Source=UcakRezervasyonu.db;Version=3;";
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Lokasyon (Ulke, Sehir, Havaalani, Aktif) VALUES (@ulke, @sehir, @havaalani, @aktif)";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ulke", ulke);
                    cmd.Parameters.AddWithValue("@sehir", sehir);
                    cmd.Parameters.AddWithValue("@havaalani", havaalani);
                    cmd.Parameters.AddWithValue("@aktif", aktif);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Lokasyon başarıyla kaydedildi.");
        }
    }
}
