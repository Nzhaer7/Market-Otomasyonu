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

        private void Personel_urun_guncelle_Load(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }
    }
}
