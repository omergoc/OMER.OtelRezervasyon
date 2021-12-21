using DevExpress.XtraEditors;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using OMER.OtelRezervasyon.Odalar.Model;
using System;
using System.Drawing;
using System.Linq;

namespace OMER.OtelRezervasyon.Odalar.Forms
{
    public partial class OdaDurum : XtraForm
    {
        public OdaDurum()
        {
            InitializeComponent();
        }

        [Obsolete]
        Veritabani veritabani = new Veritabani();
        MongoCollection collectionOdA;

        [Obsolete]
        private void OdaDurum_Load(object sender, EventArgs e)
        {
            collectionOdA = veritabani.Database.GetCollection<OdaEkle>("Oda1");

            var gosterOda1 = collectionOdA.AsQueryable<OdaEkle>().ToList();

            foreach (var item in gosterOda1)
            {
                string[] array = { item.Ad.ToString(), item.Soyad.ToString() };
                btnOda1.Text = item.Ad.ToString();
            }

            if (btnOda1.Text != "Oda 1")
            {
                btnOda1.BackColor = Color.Red;
            }

            collectionOdA = veritabani.Database.GetCollection<OdaEkle>("Oda2");

            var gosterOda2 = collectionOdA.AsQueryable<OdaEkle>().ToList();

            foreach (var item in gosterOda2)
            {
                string[] array = { item.Ad.ToString(), item.Soyad.ToString() };
                btnOda2.Text = item.Ad.ToString();
            }

            if (btnOda2.Text != "Oda 2")
            {
                btnOda2.BackColor = Color.Red;
            }

            collectionOdA = veritabani.Database.GetCollection<OdaEkle>("Oda3");

            var gosterOda3 = collectionOdA.AsQueryable<OdaEkle>().ToList();

            foreach (var item in gosterOda3)
            {
                string[] array = { item.Ad.ToString(), item.Soyad.ToString() };
                btnOda3.Text = item.Ad.ToString();
            }

            if (btnOda3.Text != "Oda 3")
            {
                btnOda3.BackColor = Color.Red;
            }

            collectionOdA = veritabani.Database.GetCollection<OdaEkle>("Oda4");

            var gosterOda4 = collectionOdA.AsQueryable<OdaEkle>().ToList();

            foreach (var item in gosterOda4)
            {
                string[] array = { item.Ad.ToString(), item.Soyad.ToString() };
                btnOda4.Text = item.Ad.ToString();
            }

            if (btnOda4.Text != "Oda 4")
            {
                btnOda4.BackColor = Color.Red;
            }


            collectionOdA = veritabani.Database.GetCollection<OdaEkle>("Oda5");

            var gosterOda5 = collectionOdA.AsQueryable<OdaEkle>().ToList();

            foreach (var item in gosterOda5)
            {
                string[] array = { item.Ad.ToString(), item.Soyad.ToString() };
                btnOda5.Text = item.Ad.ToString();
            }

            if (btnOda5.Text != "Oda 5")
            {
                btnOda5.BackColor = Color.Red;
            }


            collectionOdA = veritabani.Database.GetCollection<OdaEkle>("Oda6");

            var gosterOda6 = collectionOdA.AsQueryable<OdaEkle>().ToList();

            foreach (var item in gosterOda6)
            {
                string[] array = { item.Ad.ToString(), item.Soyad.ToString() };
                btnOda6.Text = item.Ad.ToString();
            }

            if (btnOda6.Text != "Oda 6")
            {
                btnOda6.BackColor = Color.Red;
            }


            collectionOdA = veritabani.Database.GetCollection<OdaEkle>("Oda7");

            var gosterOda7 = collectionOdA.AsQueryable<OdaEkle>().ToList();

            foreach (var item in gosterOda7)
            {
                string[] array = { item.Ad.ToString(), item.Soyad.ToString() };
                btnOda7.Text = item.Ad.ToString();
            }

            if (btnOda7.Text != "Oda 7")
            {
                btnOda7.BackColor = Color.Red;
            }


            collectionOdA = veritabani.Database.GetCollection<OdaEkle>("Oda8");

            var gosterOda8 = collectionOdA.AsQueryable<OdaEkle>().ToList();

            foreach (var item in gosterOda8)
            {
                string[] array = { item.Ad.ToString(), item.Soyad.ToString() };
                btnOda8.Text = item.Ad.ToString();
            }

            if (btnOda8.Text != "Oda 8")
            {
                btnOda8.BackColor = Color.Red;
            }


            collectionOdA = veritabani.Database.GetCollection<OdaEkle>("Oda9");

            var gosterOda9 = collectionOdA.AsQueryable<OdaEkle>().ToList();

            foreach (var item in gosterOda9)
            {
                string[] array = { item.Ad.ToString(), item.Soyad.ToString() };
                btnOda9.Text = item.Ad.ToString();
            }

            if (btnOda9.Text != "Oda 9")
            {
                btnOda9.BackColor = Color.Red;
            }

            collectionOdA = veritabani.Database.GetCollection<OdaEkle>("Oda10");

            var gosterOda10 = collectionOdA.AsQueryable<OdaEkle>().ToList();

            foreach (var item in gosterOda10)
            {
                string[] array = { item.Ad.ToString(), item.Soyad.ToString() };
                btnOda10.Text = item.Ad.ToString();
            }

            if (btnOda10.Text != "Oda 10")
            {
                btnOda10.BackColor = Color.Red;
            }

            collectionOdA = veritabani.Database.GetCollection<OdaEkle>("Oda11");

            var gosterOda11 = collectionOdA.AsQueryable<OdaEkle>().ToList();

            foreach (var item in gosterOda11)
            {
                string[] array = { item.Ad.ToString(), item.Soyad.ToString() };
                btnOda11.Text = item.Ad.ToString();
            }

            if (btnOda11.Text != "Oda 11")
            {
                btnOda11.BackColor = Color.Red;
            }

            collectionOdA = veritabani.Database.GetCollection<OdaEkle>("Oda12");

            var gosterOda12 = collectionOdA.AsQueryable<OdaEkle>().ToList();

            foreach (var item in gosterOda12)
            {
                string[] array = { item.Ad.ToString(), item.Soyad.ToString() };
                btnOda12.Text = item.Ad.ToString();
            }

            if (btnOda12.Text != "Oda 12")
            {
                btnOda12.BackColor = Color.Red;
            }

            collectionOdA = veritabani.Database.GetCollection<OdaEkle>("Oda13");

            var gosterOda13 = collectionOdA.AsQueryable<OdaEkle>().ToList();

            foreach (var item in gosterOda13)
            {
                string[] array = { item.Ad.ToString(), item.Soyad.ToString() };
                btnOda13.Text = item.Ad.ToString();
            }

            if (btnOda13.Text != "Oda 13")
            {
                btnOda13.BackColor = Color.Red;
            }

            collectionOdA = veritabani.Database.GetCollection<OdaEkle>("Oda14");

            var gosterOda14 = collectionOdA.AsQueryable<OdaEkle>().ToList();

            foreach (var item in gosterOda14)
            {
                string[] array = { item.Ad.ToString(), item.Soyad.ToString() };
                btnOda14.Text = item.Ad.ToString();
            }

            if (btnOda14.Text != "Oda 14")
            {
                btnOda14.BackColor = Color.Red;
            }

            collectionOdA = veritabani.Database.GetCollection<OdaEkle>("Oda15");

            var gosterOda15 = collectionOdA.AsQueryable<OdaEkle>().ToList();

            foreach (var item in gosterOda15)
            {
                string[] array = { item.Ad.ToString(), item.Soyad.ToString() };
                btnOda15.Text = item.Ad.ToString();
            }

            if (btnOda15.Text != "Oda 15")
            {
                btnOda15.BackColor = Color.Red;
            }
        }
    }
}