using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOtomasyonu.Classes
{
	public class UrunDb
	{
		public int id { get; set; }
        public string adi { get; set; }
		public string kodu { get; set; }
        public string sinifi { get; set; }
        public string fiyat { get; set; }
        public decimal durumu { get; set; }
		public DateTime girisTarihi { get; set; }
		public DateTime sonKullanimTarihi { get; set; }
	}
}
