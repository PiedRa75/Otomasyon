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
            kullanicilar.kullanici_ceza = Convert.ToDouble(textBoxCezaEkle.Text);

            db.Kullanıcılar.Add(kullanicilar);
            db.SaveChanges();
            Listele();
        }

        public void Listele()
        {
            var kullanicilar = db.Kullanıcılar.ToList();
            dataGridView1.DataSource = kullanicilar.ToList();
        }

        private void Kullanıcı_Ekle_Load(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
