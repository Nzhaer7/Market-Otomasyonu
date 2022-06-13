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
    public partial class Giris_Yap : Form
    {
        public Giris_Yap()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Formlar.besir.kaydol Kayıt = new besir.kaydol();
            Kayıt.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formlar.kamiltrn.Müdür_Giris MüdürGiris = new Müdür_Giris();
            MüdürGiris.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Formlar.kamiltrn.Personel_giris personelgiris = new Personel_giris();
            personelgiris.Show();
        }
    }
}
