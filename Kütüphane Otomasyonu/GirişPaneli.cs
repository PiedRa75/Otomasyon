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
    public partial class Form1 : Form
    {
        Kütüphane_OtomasyonuEntities db = new Kütüphane_OtomasyonuEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGiris_Click(object sender, EventArgs e)
        {
            string gelenAd = textBoxAd.Text;
            string gelenSifre = textBoxSifre.Text;

            var personel = db.Personeller.Where(x => x.personel_kullaniciad.Equals(gelenAd) && x.personel_sifre.Equals(gelenSifre)).FirstOrDefault();

            if (personel == null)
            {
                MessageBox.Show(text: "Kullanıcı adı veya şifre hatalı");
            }

            else
            {
                MessageBox.Show(text: "Giriş Başarılı");
                İşlem_Paneli panel = new İşlem_Paneli();
                panel.Show();
                this.Hide();
            }

            

        }
    }
}
