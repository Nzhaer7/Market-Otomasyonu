using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOtomasyonu.Classes
{
	public class musteriSepetDb
	{
		public int id { get; set; }
		public string adi { get; set; }
		public string urunKodu { get; set; }
		public int adedi { get; set; }
		public float fiyat { get; set; }
		public float toplam { get; set; }
		public string gelirid { get; set; }
		public string giderid { get; set; }
		public string urunid { get; set; }
	}
}
