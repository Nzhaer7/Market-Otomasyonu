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
    public partial class Personel_indirime_girecek_urunler : Form
    {
        public Personel_indirime_girecek_urunler()
        {
            InitializeComponent();
        }

        private void Personel_indirime_girecek_urunler_Load(object sender, EventArgs e)
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
