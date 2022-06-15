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
    public partial class Personel_urun_iptal : Form
    {
        public Personel_urun_iptal()
        {
            InitializeComponent();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private Data.MOContext dbContext;

        private void Personel_urun_iptal_Load(object sender, EventArgs e)
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

        private void button5_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(dataGridView3.Rows[dataGridView3.CurrentCell.RowIndex].Cells[0].Value);
            textBox1.Text = dataGridView3.Rows[dataGridView3.CurrentCell.RowIndex].Cells[1].Value.ToString();
            textBox2.Text= dataGridView3.Rows[dataGridView3.CurrentCell.RowIndex].Cells[2].Value.ToString();
            numericUpDown1.Value = decimal.Parse(dataGridView3.Rows[dataGridView3.CurrentCell.RowIndex].Cells[5].Value.ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Classes.UrunDb urunDb = new Classes.UrunDb()
            {
                id = this.id,
                adi = textBox1.Text,
                kodu = textBox2.Text,
                durumu = numericUpDown1.Value

            };
            dbContext = new Data.MOContext();
            dbContext.Urunler.Remove(urunDb);
            int result = dbContext.SaveChanges();
            string message = result > 0 ? "Urun Silindi" : "Başarısız";
            MessageBox.Show(message);
            refreshurun();
            Close();
        }
    }
}
