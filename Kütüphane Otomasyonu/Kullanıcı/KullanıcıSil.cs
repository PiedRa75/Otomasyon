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
    public partial class KullanıcıSil : Form
    {
        Kütüphane_OtomasyonuEntities db = new Kütüphane_OtomasyonuEntities();
        public KullanıcıSil()
        {
            InitializeComponent();
        }
        public void Listele()
        {
            var kullanicilar = db.Kullanıcılar.ToList();
            dataGridView1.DataSource = kullanicilar.ToList();
        }

        private void KullanıcıSil_Load(object sender, EventArgs e)
        {
            Listele(); 
        }

        private void buttonKullaniciSil_Click(object sender, EventArgs e)
        {
            int secilenId = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            var kullanici = db.Kullanıcılar.Where(x => x.kullanici_id == secilenId).FirstOrDefault();
            db.Kullanıcılar.Remove(kullanici);
            db.SaveChanges();
            Listele();
        }
    }
}
