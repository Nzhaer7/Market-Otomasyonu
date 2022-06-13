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
    public partial class Personel_gun_sonu_urun_ozeti : Form
    {
        public Personel_gun_sonu_urun_ozeti()
        {
            InitializeComponent();
        }

        private void Personel_gun_sonu_urun_ozeti_Load(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
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
    }
}
