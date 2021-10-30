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
    public partial class KullanıcıGüncelle : Form
    {
        Kütüphane_OtomasyonuEntities db = new Kütüphane_OtomasyonuEntities();

        public KullanıcıGüncelle()
        {
            InitializeComponent();
        }
        public void Listele()
        {
            var kullanicilar = db.Kullanıcılar.ToList();
            dataGridView1.DataSource = kullanicilar.ToList();
        }

        private void KullanıcıGüncelle_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxAdEkle.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxSoyadEkle.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxTcEkle.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBoxMailEkle.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBoxTelEkle.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBoxCezaEkle.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void buttonGüncelle_Click(object sender, EventArgs e)
        {
            int secilenId = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            var kullanici = db.Kullanıcılar.Where(x => x.kullanici_id == secilenId).FirstOrDefault();
            kullanici.kullanici_ad = textBoxAdEkle.Text;
            kullanici.kullanici_soyad = textBoxSoyadEkle.Text;
            kullanici.kullanici_tc = textBoxTcEkle.Text;
            kullanici.kullanici_mail = textBoxMailEkle.Text;
            kullanici.kullanici_tel = textBoxTelEkle.Text;
            kullanici.kullanici_ceza = Convert.ToDouble(textBoxCezaEkle.Text);

            db.SaveChanges();
            Listele();
        }
    }
}
