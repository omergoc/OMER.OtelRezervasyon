using DevExpress.XtraEditors;
using System;
using System.Linq;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using OMER.OtelRezervasyon.Odalar.Model;

namespace OMER.OtelRezervasyon.Odalar.Forms
{
    public partial class OdaKayitlari :XtraForm
    {
        public OdaKayitlari()
        {
            InitializeComponent();
        }

        [Obsolete]
        Veritabani veritabani = new Veritabani();
        MongoCollection collectionOda;

        [Obsolete]
        private void OdaKayitlari_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            collectionOda = veritabani.Database.GetCollection<OdaKayit>("OdaKayit");

            var goster = collectionOda.AsQueryable<OdaKayit>().ToList();

            foreach (var item in goster)
            {
                string[] array =
                    {
                    item.Id.ToString(),
                    item.Ad.ToString(),
                    item.Soyad.ToString(),
                    item.Tc.ToString(),
                    item.Telefon.ToString(),
                    item.Mail.ToString(),
                    item.GirisTarih.ToString(),
                    item.CikisTarih.ToString(),
                    item.Adres.ToString(),
                    item.OdaNo.ToString(),
                    item.Fiyat.ToString()
                };
                listView1.Items.Add(new ListViewItem(array));
            }
        }
    }
}