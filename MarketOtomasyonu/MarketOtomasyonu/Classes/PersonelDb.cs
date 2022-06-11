using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOtomasyonu.Classes
{
	public class PersonelDb
	{
		public int id { get; set; }
		public string gorev { get; set; }
		public DateTime girisTarihi { get; set; }
		public DateTime cikisTarihi { get; set; }
		public float maas { get; set; }
		public string durumu { get; set; }
		public string adi { get; set; }
		public string girisid { get; set; }
	}
}
