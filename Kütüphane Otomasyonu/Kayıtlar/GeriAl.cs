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
    public partial class GeriAl : Form
    {
        public GeriAl()
        {
            InitializeComponent();
        }

        Kütüphane_OtomasyonuEntities db = new Kütüphane_OtomasyonuEntities();

        private void GeriAl_Load(object sender, EventArgs e)
        {
            var kayitlar = db.Kayıtlar.Where(x => x.durum == false).ToList();
            dataGridView1.DataSource = kayitlar.ToList();

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;

            dataGridView1.Columns[1].HeaderText = "Kullanıcı ID";
            dataGridView1.Columns[2].HeaderText = "Kitap ID";
            dataGridView1.Columns[3].HeaderText = "Alış Tarihi";
            dataGridView1.Columns[4].HeaderText = "Son Teslim Tarihi";
            dataGridView1.Columns[5].HeaderText = "Teslim Durumu";
        }

        private void buttonGeriAl_Click(object sender, EventArgs e)
        {
            int secilenKayit = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            var kayit = db.Kayıtlar.Where(x => x.kayit_id == secilenKayit).FirstOrDefault();
            kayit.durum = true;
            db.SaveChanges();

            var kayitlar = db.Kayıtlar.Where(x => x.durum == false).ToList();
            dataGridView1.DataSource = kayitlar.ToList();
            
        }
    }
}
