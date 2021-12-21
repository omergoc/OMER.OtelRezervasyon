using DevExpress.XtraEditors;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using OMER.OtelRezervasyon.Musteriler.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace OMER.OtelRezervasyon.Musteriler
{
    public partial class MusteriListesi : XtraForm
    {
        [Obsolete]
        Veritabani veritabani = new Veritabani();
        MongoCollection collectionMusteri;
        public MusteriListesi()
        {
            InitializeComponent();
        }

        [Obsolete]
        private void MusteriListesi_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;

            collectionMusteri = veritabani.Database.GetCollection<Musteri>("Musteri");

            var musteriler = collectionMusteri.AsQueryable<Musteri>().ToList();

            foreach (var item in musteriler)
            {
                string[] array =
                    {
                    item.Ad.ToString(),
                    item.Soyad.ToString(),
                    item.Tc.ToString(),
                    item.Telefon.ToString(),
                    item.Mail.ToString(),
                    item.Tarih.ToString(),
                    item.Adres.ToString(),
                    item.Resim.ToString()
                };
                listView1.Items.Add(new ListViewItem(array));
            }

            listView2.View = View.Details;
            listView2.FullRowSelect = true;
            collectionMusteri = veritabani.Database.GetCollection<Mesajlar>("Mesajlar");

            var mesajlar = collectionMusteri.AsQueryable<Mesajlar>().ToList();
            foreach (var item in mesajlar)
            {
                string[] array =
                    { item.MusteriAd.ToString(),
                    item.MusteriSoyad.ToString(),
                    item.MusteriTC.ToString(),
                    item.MusteriTarih.ToString(),
                    item.MusteriMesaj.ToString()
                };
                listView2.Items.Add(new ListViewItem(array));
            }
        }
    }
}