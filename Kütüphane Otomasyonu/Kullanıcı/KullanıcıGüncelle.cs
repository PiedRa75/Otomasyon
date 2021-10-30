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

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[6].Visible = false;

            dataGridView1.Columns[1].HeaderText = "Ad";
            dataGridView1.Columns[2].HeaderText = "Soyad";
            dataGridView1.Columns[3].HeaderText = "TC";
            dataGridView1.Columns[4].HeaderText = "Mail";
            dataGridView1.Columns[5].HeaderText = "Telefon";
        }

        private void KullanıcıGüncelle_Load(object sender, EventArgs e)
        {
            Listele();
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

            db.SaveChanges();
            Listele();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxAdEkle.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxSoyadEkle.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxTcEkle.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBoxMailEkle.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBoxTelEkle.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
