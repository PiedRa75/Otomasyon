using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüphane_Otomasyonu
{
    public partial class KaynakListele : Form
    {
        public KaynakListele()
        {
            InitializeComponent();
        }

         Kütüphane_OtomasyonuEntities db = new Kütüphane_OtomasyonuEntities();
     
        private void KaynakListele_Load(object sender, EventArgs e)
        {
            var kaynaklar = db.Kaynaklar.ToList();
            dataGridView1.DataSource = kaynaklar.ToList();
        }
    }
}
