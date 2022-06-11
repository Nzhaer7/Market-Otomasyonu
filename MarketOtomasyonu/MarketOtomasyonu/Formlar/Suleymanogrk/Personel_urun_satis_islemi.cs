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
    public partial class Personel_urun_satis_islemi : Form
    {
        public Personel_urun_satis_islemi()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Formlar.Suleymanogrk.Personel_sepet_urun_ekle personel_Sepet_Urun_Ekle = new Personel_sepet_urun_ekle();
            personel_Sepet_Urun_Ekle.Show();
        }

        private void Personel_urun_satis_islemi_Load(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Formlar.Suleymanogrk.Personel_urun_sepet_odeme personel_Urun_Sepet_Odeme = new Personel_urun_sepet_odeme();
            personel_Urun_Sepet_Odeme.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Formlar.Suleymanogrk.Personel_urun_iptal personel_Urun_İptal = new Personel_urun_iptal();
            personel_Urun_İptal.Show();
        }
    }
}
