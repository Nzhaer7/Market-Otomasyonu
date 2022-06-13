using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarketOtomasyonu.Data;

namespace MarketOtomasyonu
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
			
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
			MOContext MODB = new MOContext();
			MODB.Database.EnsureDeleted();
			MODB.Database.EnsureCreated();
			//Application.Run(new Formlar.Suleymanogrk.Personel());
			//Application.Run(new Formlar.kamiltrn.Giris_Yap());
			Application.Run(new Formlar.besir.kaydol());
        }
    }
}
