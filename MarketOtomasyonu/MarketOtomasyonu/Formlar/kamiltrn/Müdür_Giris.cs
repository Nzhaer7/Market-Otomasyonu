﻿using System;
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
    public partial class Müdür_Giris : Form
    {
        public Müdür_Giris()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Formlar.kamiltrn.Şifre_unuttum_sayfası sifredegis2 = new Şifre_unuttum_sayfası();
            sifredegis2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dbContext = new Data.MOContext();
            var kullanicilar = dbContext.Kullanici.ToList();
            foreach (var item in kullanicilar)
            {
                if (item.kullaniciAdi == textBox1.Text && item.sifre == textBox2.Text)
                {
                    Formlar.kamiltrn.Mudur_Anasayfa müdürsayfa = new Mudur_Anasayfa();
                    müdürsayfa.Show();
                    return;
                }
        
            }
            MessageBox.Show("Hatalı Bilgi Girdiniz!!!");
        }
    }
}
