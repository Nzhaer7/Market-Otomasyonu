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
    public partial class Mudur_Anasayfa : Form
    {
        public Mudur_Anasayfa()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Formlar.kamiltrn.Malzeme_Guncelleme guncelle_ekle = new Malzeme_Guncelleme();
           guncelle_ekle.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formlar.kamiltrn.Şifre_yenile sifreyenile = new Şifre_yenile();
            sifreyenile.Show();
        }
    }
}
