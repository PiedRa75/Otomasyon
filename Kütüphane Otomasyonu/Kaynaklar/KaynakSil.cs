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
        }

        private void buttonSilKaynak_Click(object sender, EventArgs e)
        {
            int secilenİd = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            var silinenkaynak = db.Kaynaklar.Where(x => x.kaynak_id == secilenİd).FirstOrDefault();
            db.Kaynaklar.Remove(silinenkaynak);
            db.SaveChanges();

            var kaynaklar = db.Kaynaklar.ToList();
            dataGridView1.DataSource = kaynaklar.ToList();
        }
    }
}
