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
	public partial class GenelMailOnayla : Form
	{
		public GenelMailOnayla()
		{
			InitializeComponent();
		}

		private void GenelMailOnayla_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			Formlar.kamiltrn.Giris_Yap giris_Yap = new kamiltrn.Giris_Yap();
			giris_Yap.Show();
			Close();
		}
	}
}
