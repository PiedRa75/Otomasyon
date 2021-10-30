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
    public partial class KaynakSil : Form
    {
        public KaynakSil()
        {
            InitializeComponent();
        }
        Kütüphane_OtomasyonuEntities db = new Kütüphane_OtomasyonuEntities();

        private void KaynakSil_Load(object sender, EventArgs e)
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

        private void buttonSilKaynak_Click(object sender, EventArgs e)
        {
            DialogResult sorsil = MessageBox.Show("Bu öğe kalıcı olarak silinsin mi ?",
            "Silme İşlemi", MessageBoxButtons.YesNo);

            if (sorsil == DialogResult.Yes)
            {
                int secilenİd = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
                var silinenkaynak = db.Kaynaklar.Where(x => x.kaynak_id == secilenİd).FirstOrDefault();
                db.Kaynaklar.Remove(silinenkaynak);
                db.SaveChanges();

                var kaynaklar = db.Kaynaklar.ToList();
                dataGridView1.DataSource = kaynaklar.ToList();

                MessageBox.Show("Silme işlemi başarılı");
            }


        }
    }
}
