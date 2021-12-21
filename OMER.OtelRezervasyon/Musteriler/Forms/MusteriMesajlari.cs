using DevExpress.XtraEditors;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using OMER.OtelRezervasyon.Musteriler.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace OMER.OtelRezervasyon.Musteriler
{
    public partial class MusteriMesajlari : XtraForm
    {
        [Obsolete]
        Veritabani veritabani = new Veritabani();
        MongoCollection collectionMusteri;
        
        public MusteriMesajlari()
        {
            InitializeComponent();
        }

        [Obsolete]
        private void MusteriMesajlari_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            collectionMusteri = veritabani.Database.GetCollection<Mesajlar>("Mesajlar");

            var mesajlar = collectionMusteri.AsQueryable<Mesajlar>().ToList();
            foreach (var item in mesajlar)
            {
                string[] array =
                    {
                    item.Id.ToString(),
                    item.MusteriAd.ToString(),
                    item.MusteriSoyad.ToString(),
                    item.MusteriTC.ToString(),
                    item.MusteriTarih.ToString(),
                    item.MusteriMesaj.ToString()
                };
                listView1.Items.Add(new ListViewItem(array));
            }
        }

        [Obsolete]
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            collectionMusteri = veritabani.Database.GetCollection<Mesajlar>("Mesajlar");

            ListViewItem items = listView1.SelectedItems[0];

            var mesajlar = new Mesajlar { };

            mesajlar.Id = ObjectId.Parse(items.SubItems[0].Text);

            txtMusteriAd.Text = items.SubItems[1].Text;

            txtSoyad.Text = items.SubItems[2].Text;

            txtTC.Text = items.SubItems[3].Text;

            txtTarih.Text = items.SubItems[4].Text;

            txtMesaj.Text = items.SubItems[5].Text;
            txtGuncellenecekMesaj.Text = items.SubItems[5].Text;

            mesajlar.MusteriAd = txtMusteriAd.Text;
            mesajlar.MusteriSoyad = txtSoyad.Text;
            mesajlar.MusteriTC = txtTC.Text;
            mesajlar.MusteriTarih = txtTarih.Text;
            mesajlar.MusteriMesaj = txtMesaj.Text;

            collectionMusteri.Save(mesajlar);
        }

        [Obsolete]
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            collectionMusteri = veritabani.Database.GetCollection<Mesajlar>("Mesajlar");
            var musterimesaj = new Mesajlar { };

            musterimesaj.MusteriAd = txtMusteriAd.Text;
            musterimesaj.MusteriSoyad = txtSoyad.Text;
            musterimesaj.MusteriTC = txtTC.Text;
            musterimesaj.MusteriTarih = txtTarih.Text;
            musterimesaj.MusteriMesaj = txtMesaj.Text;
            collectionMusteri.Insert(musterimesaj);

            DialogResult result = MessageBox.Show("Müşteri Mesajı: " + txtMesaj.Text);

            MusteriMesajlari fr1 = new MusteriMesajlari();
            fr1.Show();
            this.Hide();
        }

        [Obsolete]
        private void btnSil_Click(object sender, EventArgs e)
        {
            collectionMusteri = veritabani.Database.GetCollection<Mesajlar>("Mesajlar");

            var mesaj = new QueryDocument("MusteriMesaj", txtMesaj.Text);
            collectionMusteri.Remove(mesaj = new QueryDocument("MusteriMesaj", txtMesaj.Text));

            MusteriMesajlari fr1 = new MusteriMesajlari();
            fr1.Show();
            this.Hide();
        }

        private void txtMusteriAd_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            MusteriKarti frm = new MusteriKarti();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtMusteriAd.Text = frm.ad;
                txtSoyad.Text = frm.soyad;
                txtTC.Text = frm.tc;
            }
        }

        [Obsolete]
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            collectionMusteri = veritabani.Database.GetCollection<Mesajlar>("Mesajlar");

            var sorguMesaj = new QueryDocument("MusteriMesaj", txtGuncellenecekMesaj.Text);
            var guncelleMesaj = new UpdateDocument()
            {
                {"$set", new BsonDocument("MusteriMesaj",txtMesaj.Text)}
            };
            collectionMusteri.Update(sorguMesaj, guncelleMesaj);

            DialogResult result = MessageBox.Show("Güncelleme İşlemi Başarılı.");

            MusteriMesajlari fr1 = new MusteriMesajlari();
            fr1.Show();
            this.Hide();
        }
    }
}