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
    public partial class Kullanıcı_Listesi : Form
    {
        public Kullanıcı_Listesi()
        {
            InitializeComponent();
        }

        public void Listele()
        {
            Kütüphane_OtomasyonuEntities db = new Kütüphane_OtomasyonuEntities();
            var kullanicilar = db.Kullanıcılar.ToList();
            dataGridView1.DataSource = kullanicilar.ToList();
        }

        private void Kullanıcı_Listesi_Load(object sender, EventArgs e)
        {
            Listele();
        }

    }
}
