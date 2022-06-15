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
    public partial class Personel_urun_ekle : Form
    {
        public Personel_urun_ekle()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private Data.MOContext dbContext;
        private void Personel_urun_ekle_Load(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            refreshpersonel();
            refreshurun();
        }
        public void refreshpersonel()
        {
            dbContext = new Data.MOContext();
            dataGridView1.DataSource = null;
            var kisilerListesi = dbContext.Personeller.ToList();
            dataGridView1.DataSource = kisilerListesi;
        }
        public void refreshurun()
        {
            dbContext = new Data.MOContext();
            dataGridView2.DataSource = null;
            var kisilerListesi = dbContext.Urunler.ToList();
            dataGridView2.DataSource = kisilerListesi;
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

        private void button3_Click(object sender, EventArgs e)
        {
            var yeniurun = new Classes.UrunDb()
            {
                adi = textBox1.Text,
                durumu = numericUpDown1.Value,
                girisTarihi = dateTimePicker1.Value,
                fiyat = textBox3.Text,
                sinifi = textBox4.Text,
                kodu = textBox5.Text,
                sonKullanimTarihi=dateTimePicker2.Value

            };
            dbContext.Urunler.Add(yeniurun);
            int result = dbContext.SaveChanges();
            string message = result > 0 ? "Urun Eklendi" : "Başarısız";
            MessageBox.Show(message);
            refreshurun();
            Close();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Formlar.Suleymanogrk.Personel_sifre_yenileme personel_Sifre_Yenileme = new Personel_sifre_yenileme();
            personel_Sifre_Yenileme.Show();
        }
    }
}
