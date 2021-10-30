using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüphane_Otomasyonu.Kullanıcı
{
    public partial class Kullanıcı_Ekle : Form
    {
        public Kullanıcı_Ekle()
        {
            InitializeComponent();
        }

        Kütüphane_OtomasyonuEntities db = new Kütüphane_OtomasyonuEntities();

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            Kullanıcılar kullanicilar = new Kullanıcılar();
            kullanicilar.kullanici_ad = textBoxAdEkle.Text;
            kullanicilar.kullanici_soyad = textBoxSoyadEkle.Text;
            kullanicilar.kullanici_tc = textBoxTcEkle.Text;
            kullanicilar.kullanici_mail = textBoxMailEkle.Text;
            kullanicilar.kullanici_tel = textBoxTelEkle.Text;

            db.Kullanıcılar.Add(kullanicilar);
            db.SaveChanges();
            Listele();
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

        private void Kullanıcı_Ekle_Load(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
