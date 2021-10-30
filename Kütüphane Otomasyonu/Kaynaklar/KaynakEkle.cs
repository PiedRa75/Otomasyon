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
    public partial class KaynakEkle : Form
    {
        public KaynakEkle()
        {
            InitializeComponent();
        }

        Kütüphane_OtomasyonuEntities db = new Kütüphane_OtomasyonuEntities();

        private void button1_Click(object sender, EventArgs e)
        {
            Kaynaklar k_ekle = new Kaynaklar();
            k_ekle.kaynak_ad = textBoxAdKaynak.Text;
            k_ekle.kaynak_yazar = textBoxYazarKaynak.Text;
            k_ekle.kaynak_yayinci = textBoxYayinciKaynak.Text;
            k_ekle.kaynak_sayfasayisi = Convert.ToInt16(numericUpDown1.Value);
            k_ekle.kaynak_basimtarihi = dateTimePicker1.Value;

            db.Kaynaklar.Add(k_ekle);
            db.SaveChanges();

            var lkaynak = db.Kaynaklar.ToList();
            dataGridView1.DataSource = lkaynak.ToList();

        }

        private void KaynakEkle_Load(object sender, EventArgs e)
        {
            var lkaynak = db.Kaynaklar.ToList();
            dataGridView1.DataSource = lkaynak.ToList();

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[6].Visible = false;

            dataGridView1.Columns[1].HeaderText = "Kitap Adı";
            dataGridView1.Columns[2].HeaderText = "Yazar";
            dataGridView1.Columns[3].HeaderText = "Yayıncı";
            dataGridView1.Columns[4].HeaderText = "Sayfa Sayısı";
            dataGridView1.Columns[5].HeaderText = "Basım Tarihi";
        }
    }
}
