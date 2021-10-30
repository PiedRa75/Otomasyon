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

        private Kullanıcı_Listesi klistesi;

        private void buttonKullanicilar_Click(object sender, EventArgs e)
        {

            if (buttonEkleKullanici.Visible == false)
            {
                buttonEkleKullanici.Visible = true;
                buttonGüncelleKullanici.Visible = true;
                buttonSilKullanici.Visible = true;

                klistesi = new Kullanıcı_Listesi();
                klistesi.MdiParent = this;
                klistesi.Show();
            }
            else
            {
                buttonEkleKullanici.Visible = false;
                buttonGüncelleKullanici.Visible = false;
                buttonSilKullanici.Visible = false;
                klistesi.Close();
            }

        }

        private Kullanıcı_Ekle ekleform;
        private bool eklekullanicidurum = false;

        private void buttonEkleKullanici_Click(object sender, EventArgs e)
        {

            if (eklekullanicidurum == false)
            {
                ekleform = new Kullanıcı_Ekle();
                ekleform.MdiParent = this;
                ekleform.Show();
                eklekullanicidurum = true;
            }
            else
            {
                ekleform.Close();
                eklekullanicidurum = false;
            }


        }

        private KullanıcıSil silform;
        private bool silkullanicidurum = false;

        private void buttonSilKullanici_Click(object sender, EventArgs e)
        {

            if (silkullanicidurum == false)
            {
                silform = new KullanıcıSil();
                silform.MdiParent = this;
                silform.Show();
                silkullanicidurum = true;
            }
            else
            {
                silform.Close();
                silkullanicidurum = false;
            }
        }

        private KullanıcıGüncelle güncelleform;
        private bool güncellekullanicidurum = false;

        private void buttonGüncelleKullanici_Click(object sender, EventArgs e)
        {

            if (güncellekullanicidurum == false)
            {
                güncelleform = new KullanıcıGüncelle();
                güncelleform.MdiParent = this;
                güncelleform.Show();
                güncellekullanicidurum = true;
            }
            else
            {
                güncelleform.Close();
                güncellekullanicidurum = false;
            }

        }

        private KaynakListele lkaynak;

        private void buttonKaynaklar_Click(object sender, EventArgs e)
        {
            if (buttonEkleKaynak.Visible == false)
            {
                buttonEkleKaynak.Visible = true;
                buttonGüncelleKaynak.Visible = true;
                buttonSilKaynak.Visible = true;

                lkaynak = new KaynakListele();
                lkaynak.MdiParent = this;
                lkaynak.Show();
            }
            else
            {
                buttonEkleKaynak.Visible = false;
                buttonGüncelleKaynak.Visible = false;
                buttonSilKaynak.Visible = false;
                lkaynak.Close();
            }


        }

        private KaynakEkle kEkle;
        private bool eklekaynakdurum = false;

        private void buttonEkleKaynak_Click(object sender, EventArgs e)
        {
            if (eklekaynakdurum == false)
            {
                kEkle = new KaynakEkle();
                kEkle.MdiParent = this;
                kEkle.Show();
                eklekaynakdurum = true;
            }
            else
            {
                kEkle.Close();
                eklekaynakdurum = false;
            }
        }

        private KaynakSil ksil;
        private bool silkaynakdurum = false;

        private void buttonSilKaynak_Click(object sender, EventArgs e)
        {

            if (silkaynakdurum == false)
            {
                ksil = new KaynakSil();
                ksil.MdiParent = this;
                ksil.Show();
                silkaynakdurum = true;
            }
            else
            {
                ksil.Close();
                silkaynakdurum = false;
            }

        }

        private KaynakGüncelle kGüncelle;
        private bool güncellekaynakdurum = false;

        private void buttonGüncelleKaynak_Click(object sender, EventArgs e)
        {
            if (güncellekaynakdurum == false)
            {
                kGüncelle = new KaynakGüncelle();
                kGüncelle.MdiParent = this;
                kGüncelle.Show();
                güncellekaynakdurum = true;
            }
            else
            {
                kGüncelle.Close();
                güncellekaynakdurum = false;
            }

        }

        private OduncVer odunc;
        private bool oduncverme = false;

        private void buttonOduncVer_Click(object sender, EventArgs e)
        {
            if (oduncverme == false)
            {
                odunc = new OduncVer();
                odunc.MdiParent = this;
                odunc.Show();
                oduncverme = true;
            }
            else
            {
                odunc.Close();
                oduncverme = false;
            }

        }

        private GeriAl geri;
        private bool gerialma = false;

        private void buttonGeriAl_Click(object sender, EventArgs e)
        {
            if (gerialma == false)
            {
                geri = new GeriAl();
                geri.MdiParent = this;
                geri.Show();
                gerialma = true;
            }
            else
            {
                geri.Close();
                gerialma = false;
            }

        }
    }
}
