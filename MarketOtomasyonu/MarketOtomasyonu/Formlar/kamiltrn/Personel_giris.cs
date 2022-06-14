using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketOtomasyonu.Formlar.kamiltrn
{
    public partial class Personel_giris : Form
    {
        public Personel_giris()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Formlar.kamiltrn.Şifre_unuttum_sayfası sifreyenile = new Şifre_unuttum_sayfası();
            sifreyenile.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formlar.Suleymanogrk.Personel personelanasayfa = new Suleymanogrk.Personel();
            personelanasayfa.Show();
        }
    }
}
