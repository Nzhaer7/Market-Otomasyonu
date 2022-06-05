using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace MarketOtomasyonu.Formlar.besir
{
	public partial class mudur_kaydol : Form
	{
		Regex kullaniciAdiKontrol = new Regex(@"^+[\w-]{4,10}$");
		Regex emailKontrol = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
		Regex sifreKontrol = new Regex(@"^([a-zA-Z0-9@*#]{8,15})$");

		String ad = null;
		String soyad = null;
		String mail = null;
		String kullaniciadi = null;
		String sifre = null;

		public mudur_kaydol()
		{
			InitializeComponent();
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			bool check = true;
			if (kullaniciAdiKontrol.IsMatch(textBox1.Text))
			{
				kullaniciadi = textBox1.Text;
			}
			else
			{
				MessageBox.Show("Kullanici adi gerekli kriterlere sahip degil");
				check = false;
			}
			if (kullaniciAdiKontrol.IsMatch(textBox2.Text))
			{
				kullaniciadi = textBox2.Text;
			}
			else
			{
				MessageBox.Show("Kullanici adi gerekli kriterlere sahip degil");
				check = false;
			}
			if (kullaniciAdiKontrol.IsMatch(textBox3.Text))
			{
				kullaniciadi = textBox3.Text;
			}
			else
			{
				MessageBox.Show("Kullanici adi gerekli kriterlere sahip degil");
				check = false;
			}
			if (emailKontrol.IsMatch(textBox4.Text))
			{
				mail = textBox4.Text;
			}

			else
			{
				MessageBox.Show("Hatalı E-posta");
				check = false;
			}
			if (sifreKontrol.IsMatch(textBox5.Text))
			{
				if (textBox5.Text == textBox6.Text)
				{
					sifre = textBox5.Text;
				}
				else
				{
					MessageBox.Show("Sifreler ayni degil");
					check = false;
				}
			}
			else
			{
				MessageBox.Show("Sifre kurallara uygun degil lutfen yeniden yaziniz");
				check = false;
			}
		}
	}
}
