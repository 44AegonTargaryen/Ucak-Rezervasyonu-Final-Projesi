using System;
using System.Windows.Forms;

namespace UcakRezervasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUcakFormuAc_Click(object sender, EventArgs e)
        {
            UcakForm ucakForm = new UcakForm();
            ucakForm.Show();
        }

        private void btnLokasyonFormuAc_Click(object sender, EventArgs e)
        {
            LokasyonForm lokasyonForm = new LokasyonForm();
            lokasyonForm.Show();
        }

        private void btnRezervasyonFormuAc_Click(object sender, EventArgs e)
        {
            RezervasyonForm rezervasyonForm = new RezervasyonForm();
            rezervasyonForm.Show();
        }
    }
}
