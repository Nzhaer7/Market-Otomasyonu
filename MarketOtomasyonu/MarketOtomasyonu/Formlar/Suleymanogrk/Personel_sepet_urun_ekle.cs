﻿using System;
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
    public partial class Personel_sepet_urun_ekle : Form
    {
        public Personel_sepet_urun_ekle()
        {
            InitializeComponent();
        }

        private Data.MOContext dbContext;

        private void Personel_sepet_urun_ekle_Load(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
            refreshurun();
        }

        public void refreshurun()
        {
            dbContext = new Data.MOContext();
            dataGridView3.DataSource = null;
            var kisilerListesi = dbContext.Urunler.ToList();
            dataGridView3.DataSource = kisilerListesi;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var urunekle = new Classes.UrunDb()
            {
                adi=textBox1.Text,
                kodu=textBox3.Text,
                durumu=numericUpDown1.Value
            };
            dbContext.Urunler.Add(urunekle);
            int result = dbContext.SaveChanges();
            string message = result > 0 ? "Bilgiler Eklendi" : "Başarısız";
            MessageBox.Show(message);
            refreshurun();
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

        private void button14_Click(object sender, EventArgs e)
        {
            Formlar.Suleymanogrk.Personel_arıza_bildirm personel_Arıza_Bildirm = new Personel_arıza_bildirm();
            personel_Arıza_Bildirm.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Formlar.Suleymanogrk.Personel_sifre_yenileme personel_Sifre_Yenileme = new Personel_sifre_yenileme();
            personel_Sifre_Yenileme.Show();
        }

        private void refresh(object sender, EventArgs e)
        {
            refreshurun();
        }
    }
}
