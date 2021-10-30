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

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[6].Visible = false;

            dataGridView1.Columns[1].HeaderText = "Ad";
            dataGridView1.Columns[2].HeaderText = "Soyad";
            dataGridView1.Columns[3].HeaderText = "TC";
            dataGridView1.Columns[4].HeaderText = "Mail";
            dataGridView1.Columns[5].HeaderText = "Telefon";
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
