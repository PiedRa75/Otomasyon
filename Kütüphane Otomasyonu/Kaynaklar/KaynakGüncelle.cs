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
    public partial class KaynakGüncelle : Form
    {
        public KaynakGüncelle()
        {
            InitializeComponent();
        }

        Kütüphane_OtomasyonuEntities db = new Kütüphane_OtomasyonuEntities();

        private void KaynakGüncelle_Load(object sender, EventArgs e)
        {
            var kaynaklar = db.Kaynaklar.ToList();
            dataGridView1.DataSource = kaynaklar.ToList();

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[6].Visible = false;

            dataGridView1.Columns[1].HeaderText = "Kitap Adı";
            dataGridView1.Columns[2].HeaderText = "Yazar";
            dataGridView1.Columns[3].HeaderText = "Yayıncı";
            dataGridView1.Columns[4].HeaderText = "Sayfa Sayısı";
            dataGridView1.Columns[5].HeaderText = "Basım Tarihi";
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxAdKaynak.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxYazarKaynak.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxYayinciKaynak.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            numericUpDown1.Value = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[4].Value);
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[5].Value);
        }

        private void buttonKaynakGüncelle_Click(object sender, EventArgs e)
        {
            int secilenKaynak = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            var güncellenecekKaynak = db.Kaynaklar.Where(x => x.kaynak_id == secilenKaynak).FirstOrDefault();

            güncellenecekKaynak.kaynak_ad = textBoxAdKaynak.Text;
            güncellenecekKaynak.kaynak_yazar = textBoxYazarKaynak.Text;
            güncellenecekKaynak.kaynak_yayinci = textBoxYayinciKaynak.Text;
            güncellenecekKaynak.kaynak_sayfasayisi = Convert.ToInt16(numericUpDown1.Value);
            güncellenecekKaynak.kaynak_basimtarihi = dateTimePicker1.Value;

            db.SaveChanges();

            var kaynaklar = db.Kaynaklar.ToList();
            dataGridView1.DataSource = kaynaklar.ToList();
        }
    }
}
