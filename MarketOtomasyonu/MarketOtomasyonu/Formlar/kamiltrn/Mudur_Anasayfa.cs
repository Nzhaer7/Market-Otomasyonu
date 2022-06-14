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



        private Data.MOContext dbContext;

        private void Mudur_Anasayfa_Load(object sender, EventArgs e)
        {
            refreshPersonel();
            refreshUrun();
            //refreshCiroTakip();
            refreshMalzemeTakip();
        }



        public void refreshPersonel()
        {
            // Personel Giriş/Çıkış
            dbContext = new Data.MOContext();
            dataGridView4.DataSource = null;
            var kisilerListesi = dbContext.Personeller.ToList();
            dataGridView4.DataSource = kisilerListesi;                     


        }
        // ürün takip
        public void refreshUrun()
        {
             
            dbContext = new Data.MOContext();
            dataGridView1.DataSource = null;
            var urunlerListesi = dbContext.Urunler.ToList();
            dataGridView1.DataSource = urunlerListesi;


        }
        /*
        //Ciro Takip
        public void refreshCiroTakip()
        {
         
            dbContext = new Data.MOContext();
            dataGridView2.DataSource = null;
            var ciroListesi = dbContext.Personeller.ToList();
            dataGridView2.DataSource = ciroListesi;


        }
        */

        //Malzeme Takip
        public void refreshMalzemeTakip()
        {

            dbContext = new Data.MOContext();
            dataGridView3.DataSource = null;
            var MalzemeListesi = dbContext.Personeller.ToList();
            dataGridView3.DataSource = MalzemeListesi;


        }





        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
