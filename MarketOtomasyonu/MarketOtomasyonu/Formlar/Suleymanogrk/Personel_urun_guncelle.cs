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
    public partial class Personel_urun_guncelle : Form
    {
        public Personel_urun_guncelle()
        {
            InitializeComponent();
        }

        private Data.MOContext dbContext;

        private void Personel_urun_guncelle_Load(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            refreshpersonel();
            refreshurun();
        }
        public void refreshpersonel()
        {
            dbContext = new Data.MOContext();
            dataGridView1.DataSource = null;
            var kisilerListesi = dbContext.Personeller.ToList();
            dataGridView1.DataSource = kisilerListesi;
        }
        public void refreshurun()
        {
            dbContext = new Data.MOContext();
            dataGridView2.DataSource = null;
            var kisilerListesi = dbContext.Urunler.ToList();
            dataGridView2.DataSource = kisilerListesi;
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
        int id;

        private void button3_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells[0].Value);
            textBox1.Text = dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells[1].Value.ToString();
            textBox5.Text = dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells[2].Value.ToString();
            dateTimePicker1.Value = (DateTime)dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells[6].Value;
            textBox3.Text= dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells[4].Value.ToString();
            textBox4.Text = dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells[3].Value.ToString();
            numericUpDown1.Value= decimal.Parse(dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells[5].Value.ToString());
            dateTimePicker3.Value = (DateTime)dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells[7].Value;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            Classes.UrunDb urunDb = new Classes.UrunDb()
            {
                id = this.id,
                adi = textBox1.Text,
                durumu = numericUpDown1.Value,
                girisTarihi = dateTimePicker1.Value,
                fiyat = textBox3.Text,
                kodu = textBox5.Text,
                sinifi = textBox4.Text,
                sonKullanimTarihi = dateTimePicker3.Value
            };
            dbContext = new Data.MOContext();
            dbContext.Urunler.Update(urunDb);
            int result = dbContext.SaveChanges();
            string message = result > 0 ? "Urun Güncellendi" : "Başarısız";
            MessageBox.Show(message);
            refreshurun();
        }
    }
}
