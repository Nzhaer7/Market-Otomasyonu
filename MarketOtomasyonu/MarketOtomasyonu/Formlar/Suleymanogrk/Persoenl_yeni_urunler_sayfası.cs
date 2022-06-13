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
    public partial class Persoenl_yeni_urunler_sayfası : Form
    {
        public Persoenl_yeni_urunler_sayfası()
        {
            InitializeComponent();
        }

        private void Persoenl_yeni_urunler_sayfası_Load(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Formlar.Suleymanogrk.Personel_arıza_bildirm personel_Arıza_Bildirm = new Personel_arıza_bildirm();
            personel_Arıza_Bildirm.Show();
        }
    }
}
