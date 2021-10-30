using Kütüphane_Otomasyonu.Kullanıcı;
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
    public partial class İşlem_Paneli : Form
    {
        Kütüphane_OtomasyonuEntities db = new Kütüphane_OtomasyonuEntities();

        public İşlem_Paneli()
        {
            InitializeComponent();
        }

        private void İşlem_Paneli_Load(object sender, EventArgs e)
        {
            buttonEkleKullanici.Visible = false;
            buttonGüncelleKullanici.Visible = false;
            buttonSilKullanici.Visible = false;

            buttonEkleKaynak.Visible = false;
            buttonGüncelleKaynak.Visible = false;
            buttonSilKaynak.Visible = false;
        }

        private void buttonKullanicilar_Click(object sender, EventArgs e)
        {

            if (buttonEkleKullanici.Visible == false) 
            {
                buttonEkleKullanici.Visible = true;
                buttonGüncelleKullanici.Visible = true;
                buttonSilKullanici.Visible = true;
            }
            else
            {
                buttonEkleKullanici.Visible = false;
                buttonGüncelleKullanici.Visible = false;
                buttonSilKullanici.Visible = false;
            }

            Kullanıcı_Listesi klistesi = new Kullanıcı_Listesi();
            klistesi.MdiParent = this;
            klistesi.Show();

        }

        private void buttonEkleKullanici_Click(object sender, EventArgs e)
        {
            Kullanıcı_Ekle ekleform = new Kullanıcı_Ekle();
            ekleform.MdiParent = this;
            ekleform.Show();
        }

        private void buttonSilKullanici_Click(object sender, EventArgs e)
        {
            KullanıcıSil silform = new KullanıcıSil();
            silform.MdiParent = this;
            silform.Show();
        }

        private void buttonGüncelleKullanici_Click(object sender, EventArgs e)
        {
            KullanıcıGüncelle güncelleform = new KullanıcıGüncelle();
            güncelleform.MdiParent = this;
            güncelleform.Show();
        }

        private void buttonKaynaklar_Click(object sender, EventArgs e)
        {
            if (buttonEkleKaynak.Visible == false)
            {
                buttonEkleKaynak.Visible = true;
                buttonGüncelleKaynak.Visible = true;
                buttonSilKaynak.Visible = true;
            }
            else
            {
                buttonEkleKaynak.Visible = false;
                buttonGüncelleKaynak.Visible = false;
                buttonSilKaynak.Visible = false;        
            }

            KaynakListele lkaynak = new KaynakListele();
            lkaynak.MdiParent = this;
            lkaynak.Show();
        }

        private void buttonEkleKaynak_Click(object sender, EventArgs e)
        {
            KaynakEkle kEkle = new KaynakEkle();
            kEkle.MdiParent = this;
            kEkle.Show();
        }

        private void buttonSilKaynak_Click(object sender, EventArgs e)
        {
            KaynakSil ksil = new KaynakSil();
            ksil.MdiParent = this;
            ksil.Show();
        }

        private void buttonGüncelleKaynak_Click(object sender, EventArgs e)
        {
            KaynakGüncelle kGüncelle = new KaynakGüncelle();
            kGüncelle.MdiParent = this;
            kGüncelle.Show();
        }

        private void buttonOduncVer_Click(object sender, EventArgs e)
        {
            OduncVer odunc = new OduncVer();
            odunc.MdiParent = this;
            odunc.Show();
        }

        private void buttonGeriAl_Click(object sender, EventArgs e)
        {
            GeriAl geri = new GeriAl();
            geri.MdiParent = this;
            geri.Show();
        }
    }
}
