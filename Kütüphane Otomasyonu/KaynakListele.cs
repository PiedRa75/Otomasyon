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
        public void Listele()
        {
            Kütüphane_OtomasyonuEntities db = new Kütüphane_OtomasyonuEntities();
            var kaynak = db.Kaynaklar.ToList();
            dataGridView1.DataSource = kaynak.ToList();
        }
        
        private void KaynakListele_Load(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
