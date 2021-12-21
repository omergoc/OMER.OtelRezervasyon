using DevExpress.XtraEditors;
using System;
using System.Linq;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace OMER.OtelRezervasyon.Musteriler
{
    public partial class MusteriKarti : XtraForm
    {
        [Obsolete]
        Veritabani veritabani = new Veritabani();
        MongoCollection collectionMusteri;

        public MusteriKarti()
        {
            InitializeComponent();
        }
        public string ad;
        public string soyad;
        public string tc;
        public string telefon;
        public string mail;
        public string adres;
        [Obsolete]
        private void MusteriKarti_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            var musteriListesi = veritabani.Database.GetCollection<Musteri>("Musteri");

            var musteriler = musteriListesi.AsQueryable().ToList();
            foreach (var item in musteriler)
            {
                string[] array = { item.Id.ToString(), item.Ad.ToString(), item.Soyad.ToString(), item.Tc.ToString(), item.Telefon.ToString(), item.Mail.ToString(), item.Tarih.ToString(), item.Adres.ToString(), item.Resim.ToString() };
                listView1.Items.Add(new ListViewItem(array));
            }
        }
        private void Listele()
        {
            openFileDialog1.FileName = txtResim.Text;
            label1.Text = openFileDialog1.SafeFileName;
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void btnResimSec_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            txtResim.Text = openFileDialog1.FileName;
            label1.Text = openFileDialog1.SafeFileName;
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        [Obsolete]
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            collectionMusteri = veritabani.Database.GetCollection<Musteri>("Musteri");
            var musteriKarti = new Musteri { };

            musteriKarti.Ad = txtAd.Text;
            musteriKarti.Soyad = txtSoyad.Text;
            musteriKarti.Tc = txtTC.Text;
            musteriKarti.Telefon = txtTelefon.Text;
            musteriKarti.Mail = txtMail.Text;
            musteriKarti.Tarih = txtTarih.Text;
            musteriKarti.Adres = txtAdres.Text;
            musteriKarti.Resim = txtResim.Text;
            collectionMusteri.Insert(musteriKarti);

            DialogResult result = MessageBox.Show("Müşteri Adı: " + txtAd.Text + " Ve " + "Müşteri Soyadı: " + txtSoyad.Text);
            MusteriKarti frm1 = new MusteriKarti();
            frm1.Show();
            this.Hide();

        }

        [Obsolete]
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            collectionMusteri = veritabani.Database.GetCollection<Musteri>("Musteri");

            ListViewItem items = listView1.SelectedItems[0];
           
            var musteri = new Musteri { };

            musteri.Id = ObjectId.Parse(items.SubItems[0].Text);
            txtAd.Text = items.SubItems[1].Text;
            txtSoyad.Text = items.SubItems[2].Text;
            txtTC.Text = items.SubItems[3].Text;
            txtGuncellenecekTC.Text = items.SubItems[3].Text;
            txtTelefon.Text = items.SubItems[4].Text;
            txtMail.Text = items.SubItems[5].Text;
            txtTarih.Text = items.SubItems[6].Text;
            txtAdres.Text = items.SubItems[7].Text;
            txtResim.Text = items.SubItems[8].Text;

            musteri.Ad = txtAd.Text;
            musteri.Soyad = txtSoyad.Text;
            musteri.Tc = txtTC.Text;
            musteri.Telefon = txtTelefon.Text;
            musteri.Mail = txtMail.Text;
            musteri.Tarih = txtTarih.Text;
            musteri.Adres = txtAdres.Text;
            musteri.Resim = txtResim.Text;

            collectionMusteri.Save(musteri);

            Listele();

            ad = txtAd.Text;
            soyad = txtSoyad.Text;
            tc = txtTC.Text;
            telefon = txtTelefon.Text;
            mail = txtMail.Text;
            adres = txtAdres.Text;

            this.DialogResult = DialogResult.OK;
        }

        [Obsolete]
        private void btnSil_Click(object sender, EventArgs e)
        {
            collectionMusteri = veritabani.Database.GetCollection<Musteri>("Musteri");
            var sorgu = new QueryDocument("Tc", txtTC.Text);
            collectionMusteri.Remove(sorgu);

            MusteriKarti frm1 = new MusteriKarti();
            frm1.Show();
            this.Hide();
        }

        [Obsolete]
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            collectionMusteri = veritabani.Database.GetCollection<Musteri>("Musteri");

            var sorgu = new QueryDocument { {"Tc", txtGuncellenecekTC.Text } };

            var guncelleAd = new UpdateDocument()
            {
                {"$set",new BsonDocument ("Ad", txtAd.Text) }
            };
            collectionMusteri.Update(sorgu, guncelleAd);

            var guncelleSoyad = new UpdateDocument()
            {
                {"$set",new BsonDocument ("Soyad", txtSoyad.Text) }
            };
            collectionMusteri.Update(sorgu, guncelleSoyad);

            var guncelleTelefon = new UpdateDocument()
            {
                {"$set",new BsonDocument ("Telefon", txtTelefon.Text) }
            };
            collectionMusteri.Update(sorgu, guncelleTelefon);

            var guncelleMail = new UpdateDocument()
            {
                {"$set",new BsonDocument ("Mail", txtMail.Text) }
            };
            collectionMusteri.Update(sorgu, guncelleMail);

            var guncelleTarih = new UpdateDocument()
            {
                {"$set",new BsonDocument ("Tarih", txtTarih.Text) }
            };
            collectionMusteri.Update(sorgu, guncelleTarih);

            var guncelleAdres = new UpdateDocument()
            {
                {"$set",new BsonDocument ("Adres", txtAdres.Text) }
            };
            collectionMusteri.Update(sorgu, guncelleAdres);

            var guncelleResim = new UpdateDocument()
            {
                {"$set",new BsonDocument ("Resim", txtResim.Text) }
            };
            collectionMusteri.Update(sorgu, guncelleResim);

            var guncelleTc = new UpdateDocument()
            {
                {"$set",new BsonDocument ("Tc", txtTC.Text) }
            };
            collectionMusteri.Update(sorgu, guncelleTc);

            DialogResult result = MessageBox.Show("Güncelleme İşlemi Başarılı.");
            MusteriKarti frm1 = new MusteriKarti();
            frm1.Show();
            this.Hide();
        }
    }
}