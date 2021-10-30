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
    public partial class OduncVer : Form
    {
        public OduncVer()
        {
            InitializeComponent();
        }

        Kütüphane_OtomasyonuEntities db = new Kütüphane_OtomasyonuEntities();

        private void OduncVer_Load(object sender, EventArgs e)
        {

            var kayitliste = from kayit in db.Kayıtlar 
            select new { kayit.Kullanıcılar.kullanici_id, kayit.Kullanıcılar.kullanici_ad, kayit.Kaynaklar.kaynak_ad, kayit.alis_tarihi, kayit.son_teslim_tarihi, kayit.durum};
            dataGridView1.DataSource = kayitliste.ToList();

            var kaynakliste = from kayit in db.Kayıtlar
            select new { kayit.Kaynaklar.kaynak_id ,kayit.Kaynaklar.kaynak_ad, kayit.Kaynaklar.kaynak_yazar, kayit.Kaynaklar.kaynak_yayinci, kayit.Kaynaklar.kaynak_sayfasayisi, kayit.Kaynaklar.kaynak_basimtarihi};
            dataGridView2.DataSource = kaynakliste.ToList();

            dataGridView1.Columns[0].HeaderText = "Kullanıcı ID";
            dataGridView1.Columns[1].HeaderText = "Kullanıcı";
            dataGridView1.Columns[2].HeaderText = "Kaynak Adı";
            dataGridView1.Columns[3].HeaderText = "Alış Tarihi";
            dataGridView1.Columns[4].HeaderText = "Son Teslim Tarihi";
            dataGridView1.Columns[5].HeaderText = "Teslim Durumu";

            dataGridView2.Columns[0].HeaderText = "Kitap ID";
            dataGridView2.Columns[1].HeaderText = "Kitap Adı";
            dataGridView2.Columns[2].HeaderText = "Yazar";
            dataGridView2.Columns[3].HeaderText = "Yayıncı";
            dataGridView2.Columns[4].HeaderText = "Sayfa Sayısı";
            dataGridView2.Columns[5].HeaderText = "Basım Tarihi";
        }

        private void buttonBul_Click(object sender, EventArgs e)
        {
            string arananTc = textBoxTcBul.Text;
            var kullaniciBul = db.Kullanıcılar.Where(x => x.kullanici_tc == arananTc).FirstOrDefault();

            if(kullaniciBul != null)
            { 
                label2.Text = kullaniciBul.kullanici_ad + "" + kullaniciBul.kullanici_soyad;
            }
            else
            {
                label2.Text = "Kullanıcı bulunamadı";
            }
        }

        private void textBoxFiltrele_TextChanged(object sender, EventArgs e)
        {
            string gelenAd = textBoxFiltrele.Text;
            var bulunanKaynaklar = db.Kaynaklar.Where(x => x.kaynak_ad.Contains(gelenAd)).ToList();
            dataGridView2.DataSource = bulunanKaynaklar;
        }

        private void buttonOduncVer_Click(object sender, EventArgs e)
        {
            string secilenKisiTC = textBoxTcBul.Text;
            var secilenKisi = db.Kullanıcılar.Where(x => x.kullanici_tc.Equals(secilenKisiTC)).FirstOrDefault();

            int secilenKitapId = Convert.ToInt16(dataGridView2.CurrentRow.Cells[0].Value);
            var secilenKitap = db.Kaynaklar.Where(x => x.kaynak_id == secilenKitapId).FirstOrDefault();

            Kayıtlar yeniKayit = new Kayıtlar();
            yeniKayit.kitap_id = secilenKitap.kaynak_id;
            yeniKayit.kullanici_id = secilenKisi.kullanici_id;
            yeniKayit.alis_tarihi = DateTime.Today;
            yeniKayit.son_teslim_tarihi = DateTime.Today.AddDays(20);
            yeniKayit.durum = false;

            db.Kayıtlar.Add(yeniKayit);
            db.SaveChanges();


            var kayitliste = from kayit in db.Kayıtlar
            select new { kayit.Kullanıcılar.kullanici_ad, kayit.Kaynaklar.kaynak_ad, kayit.alis_tarihi, kayit.son_teslim_tarihi, kayit.durum };
            dataGridView1.DataSource = kayitliste.ToList();

            var kaynakliste = from kayit in db.Kayıtlar
            select new { kayit.Kaynaklar.kaynak_id, kayit.Kaynaklar.kaynak_ad, kayit.Kaynaklar.kaynak_yazar, kayit.Kaynaklar.kaynak_yayinci, kayit.Kaynaklar.kaynak_sayfasayisi, kayit.Kaynaklar.kaynak_basimtarihi };
            dataGridView2.DataSource = kaynakliste.ToList();
        }
    }
}
