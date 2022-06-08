using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketOtomasyonu.Formlar.besir
{
	public partial class kaydol : Form
	{
		public kaydol()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Formlar.besir.mudur_kaydol mudur_Kaydol = new mudur_kaydol();
			mudur_Kaydol.Show();	
				}

		private void button2_Click(object sender, EventArgs e)
		{
			Formlar.besir.PersonelKayitOl personel_Kaydol = new PersonelKayitOl();
			personel_Kaydol.Show();
		}
	}
}
