using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketOtomasyonu.Formlar.Suleymanogrk
{
    public partial class Personel : Form
    {
        public Personel()
        {
            InitializeComponent();
        }

        private void Personel_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formlar.Suleymanogrk.Personel_Giris_Ekle personel_giris = new Personel_Giris_Ekle();
            personel_giris.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Formlar.Suleymanogrk.Personel_cıkıs personel_cikis = new Personel_cıkıs();
            personel_cikis.Show();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Formlar.Suleymanogrk.Personel_urun_ekle personel_Urun_Ekle = new Personel_urun_ekle();
            personel_Urun_Ekle.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Formlar.Suleymanogrk.Personel_urun_guncelle personel_Urun_Guncelle = new Personel_urun_guncelle();
            personel_Urun_Guncelle.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Formlar.Suleymanogrk.Personel_urun_guncelle personel_Urun_Guncelle = new Personel_urun_guncelle();
            personel_Urun_Guncelle.Show();
        }
    }
}
