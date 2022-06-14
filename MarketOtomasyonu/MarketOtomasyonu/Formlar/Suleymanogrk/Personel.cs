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

        private void button5_Click(object sender, EventArgs e)
        {
            Formlar.Suleymanogrk.Personel_gun_sonu_kasa_ozeti personel_Gun_Sonu_Kasa_Ozeti = new Personel_gun_sonu_kasa_ozeti();
            personel_Gun_Sonu_Kasa_Ozeti.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Formlar.Suleymanogrk.Personel_gun_sonu_urun_ozeti personel_Gun_Sonu_Urun_Ozeti = new Personel_gun_sonu_urun_ozeti();
            personel_Gun_Sonu_Urun_Ozeti.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Formlar.Suleymanogrk.Personel_urun_satis_islemi personel_Urun_Satis_İslemi = new Personel_urun_satis_islemi();
            personel_Urun_Satis_İslemi.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Formlar.Suleymanogrk.Personel_indirimli_urunler personel_İndirimli_Urunler = new Personel_indirimli_urunler();
            personel_İndirimli_Urunler.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Formlar.Suleymanogrk.Personel_indirime_girecek_urunler personel_İndirime_Girecek_Urunler = new Personel_indirime_girecek_urunler();
            personel_İndirime_Girecek_Urunler.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Formlar.Suleymanogrk.Personel_markete_gelecek_urunler personel_Markete_Gelecek_Urunler = new Personel_markete_gelecek_urunler();
            personel_Markete_Gelecek_Urunler.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Formlar.Suleymanogrk.Persoenl_yeni_urunler_sayfası persoenl_Yeni_Urunler_Sayfası = new Persoenl_yeni_urunler_sayfası();
            persoenl_Yeni_Urunler_Sayfası.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Formlar.Suleymanogrk.Personel_arıza_bildirm personel_Arıza_Bildirm = new Personel_arıza_bildirm();
            personel_Arıza_Bildirm.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Formlar.Suleymanogrk.Personel_sifre_yenileme personel_Sifre_Yenileme = new Personel_sifre_yenileme();
            personel_Sifre_Yenileme.Show();
        }
    }
}
