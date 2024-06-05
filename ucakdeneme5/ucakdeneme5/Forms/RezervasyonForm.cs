using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace UcakRezervasyonu
{
    public partial class RezervasyonForm : Form
    {
        public RezervasyonForm()
        {
            InitializeComponent();
            LoadComboBoxes();
            LoadSeats();
        }

        private void LoadComboBoxes()
        {
            string connectionString = "Data Source=UcakRezervasyonu.db;Version=3;";
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                // Uçakları yükleme
                string query = "SELECT Id, Model || ' - ' || Marka AS UcakBilgisi FROM Ucak";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cmbUcak.Items.Add(new { Text = reader["UcakBilgisi"].ToString(), Value = reader["Id"] });
                    }
                }

                // Lokasyonları yükleme
                query = "SELECT Id, Ulke || ' - ' || Sehir AS LokasyonBilgisi FROM Lokasyon WHERE Aktif = 1";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cmbLokasyon.Items.Add(new { Text = reader["LokasyonBilgisi"].ToString(), Value = reader["Id"] });
                    }
                }
            }

            cmbUcak.DisplayMember = "Text";
            cmbUcak.ValueMember = "Value";
            cmbLokasyon.DisplayMember = "Text";
            cmbLokasyon.ValueMember = "Value";
        }

        private void LoadSeats()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Button btnSeat = new Button();
                    btnSeat.Width = btnSeat.Height = 40;
                    btnSeat.BackColor = System.Drawing.Color.Green;
                    btnSeat.Click += BtnSeat_Click;
                    tblSeats.Controls.Add(btnSeat, j, i);
                }
            }
        }

        private void BtnSeat_Click(object sender, EventArgs e)
        {
            Button btnSeat = sender as Button;
            if (btnSeat.BackColor == System.Drawing.Color.Green)
            {
                btnSeat.BackColor = System.Drawing.Color.Red;
                // Müşteri bilgilerini kaydetme ve gösterme kodları burada olacak
            }
            else
            {
                btnSeat.BackColor = System.Drawing.Color.Green;
                // Müşteri bilgilerini silme kodları burada olacak
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            int ucakId = ((dynamic)cmbUcak.SelectedItem).Value;
            int lokasyonId = ((dynamic)cmbLokasyon.SelectedItem).Value;
            DateTime tarih = dtpTarih.Value;
            string yolcuAdi = txtYolcuAdi.Text;

            string connectionString = "Data Source=UcakRezervasyonu.db;Version=3;";
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Rezervasyon (UcakId, LokasyonId, Tarih, YolcuAdi) VALUES (@ucakId, @lokasyonId, @tarih, @yolcuAdi)";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ucakId", ucakId);
                    cmd.Parameters.AddWithValue("@lokasyonId", lokasyonId);
                    cmd.Parameters.AddWithValue("@tarih", tarih);
                    cmd.Parameters.AddWithValue("@yolcuAdi", yolcuAdi);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Rezervasyon başarıyla kaydedildi.");
        }
    }
}
