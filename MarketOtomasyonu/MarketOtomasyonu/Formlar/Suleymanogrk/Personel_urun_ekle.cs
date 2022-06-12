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

        private void Personel_urun_ekle_Load(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Formlar.Suleymanogrk.Personel_indirime_girecek_urunler personel_İndirime_Girecek_Urunler = new Personel_indirime_girecek_urunler();
            personel_İndirime_Girecek_Urunler.Show();
        }
    }
}
