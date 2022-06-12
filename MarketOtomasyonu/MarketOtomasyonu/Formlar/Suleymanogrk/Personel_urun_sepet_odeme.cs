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
    public partial class Personel_urun_sepet_odeme : Form
    {
        public Personel_urun_sepet_odeme()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Formlar.Suleymanogrk.Personel_fis personel_Fis = new Personel_fis();
            personel_Fis.Show();
        }

        private void Personel_urun_sepet_odeme_Load(object sender, EventArgs e)
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
    }
}
