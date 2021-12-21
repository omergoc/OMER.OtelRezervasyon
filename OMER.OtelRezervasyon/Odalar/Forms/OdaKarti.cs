using DevExpress.XtraEditors;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using OMER.OtelRezervasyon.Musteriler;
using System.Windows.Forms;
using OMER.OtelRezervasyon.Odalar.Model;
using System;
using System.Drawing;
using System.Linq;

namespace OMER.OtelRezervasyon.Odalar.Forms
{
    public partial class OdaKarti : XtraForm
    {
        public OdaKarti()
        {
            InitializeComponent();
        }
        [Obsolete]
        Veritabani veritabani = new Veritabani();
        MongoCollection collectionOda;

        private void txtAd_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            MusteriKarti frm = new MusteriKarti();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtAd.Text = frm.ad;
                txtSoyad.Text = frm.soyad;
                txtTC.Text = frm.tc;
                txtAdres.Text = frm.adres;
                txtMail.Text = frm.mail;
                txtTelefon.Text = frm.telefon;
            }
        }

        [Obsolete]
        private void OdaKarti_Load(object sender, EventArgs e)
        {
            collectionOda = veritabani.Database.GetCollection<OdaEkle>("Oda1");

            var gosterOda1 = collectionOda.AsQueryable<OdaEkle>().ToList();

            foreach (var item in gosterOda1)
            {
                string[] array = { item.Ad.ToString(), item.Soyad.ToString() };
                btnOda1.Text = item.Ad.ToString();
            }

            if (btnOda1.Text != "Oda 1")
            {
                btnOda1.BackColor = Color.Red;
                btnOda1.Enabled = false;
            }

            collectionOda = veritabani.Database.GetCollection<OdaEkle>("Oda2");

            var gosterOda2 = collectionOda.AsQueryable<OdaEkle>().ToList();

            foreach (var item in gosterOda2)
            {
                string[] array = { item.Ad.ToString(), item.Soyad.ToString() };
                btnOda2.Text = item.Ad.ToString();
            }

            if (btnOda2.Text != "Oda 2")
            {
                btnOda1.Enabled = false;
                btnOda2.BackColor = Color.Red;
            }

            collectionOda = veritabani.Database.GetCollection<OdaEkle>("Oda3");

            var gosterOda3 = collectionOda.AsQueryable<OdaEkle>().ToList();

            foreach (var item in gosterOda3)
            {
                string[] array = { item.Ad.ToString(), item.Soyad.ToString() };
                btnOda3.Text = item.Ad.ToString();
            }

            if (btnOda3.Text != "Oda 3")
            {
                btnOda1.Enabled = false;
                btnOda3.BackColor = Color.Red;
            }

            collectionOda = veritabani.Database.GetCollection<OdaEkle>("Oda4");

            var gosterOda4 = collectionOda.AsQueryable<OdaEkle>().ToList();

            foreach (var item in gosterOda4)
            {
                string[] array = { item.Ad.ToString(), item.Soyad.ToString() };
                btnOda4.Text = item.Ad.ToString();
            }

            if (btnOda4.Text != "Oda 4")
            {
                btnOda1.Enabled = false;
                btnOda4.BackColor = Color.Red;
            }


            collectionOda = veritabani.Database.GetCollection<OdaEkle>("Oda5");

            var gosterOda5 = collectionOda.AsQueryable<OdaEkle>().ToList();

            foreach (var item in gosterOda5)
            {
                string[] array = { item.Ad.ToString(), item.Soyad.ToString() };
                btnOda5.Text = item.Ad.ToString();
            }

            if (btnOda5.Text != "Oda 5")
            {
                btnOda1.Enabled = false;
                btnOda5.BackColor = Color.Red;
            }


            collectionOda = veritabani.Database.GetCollection<OdaEkle>("Oda6");

            var gosterOda6 = collectionOda.AsQueryable<OdaEkle>().ToList();

            foreach (var item in gosterOda6)
            {
                string[] array = { item.Ad.ToString(), item.Soyad.ToString() };
                btnOda6.Text = item.Ad.ToString();
            }

            if (btnOda6.Text != "Oda 6")
            {
                btnOda1.Enabled = false;
                btnOda6.BackColor = Color.Red;
            }


            collectionOda = veritabani.Database.GetCollection<OdaEkle>("Oda7");

            var gosterOda7 = collectionOda.AsQueryable<OdaEkle>().ToList();

            foreach (var item in gosterOda7)
            {
                string[] array = { item.Ad.ToString(), item.Soyad.ToString() };
                btnOda7.Text = item.Ad.ToString();
            }

            if (btnOda7.Text != "Oda 7")
            {
                btnOda1.Enabled = false;
                btnOda7.BackColor = Color.Red;
            }


            collectionOda = veritabani.Database.GetCollection<OdaEkle>("Oda8");

            var gosterOda8 = collectionOda.AsQueryable<OdaEkle>().ToList();

            foreach (var item in gosterOda8)
            {
                string[] array = { item.Ad.ToString(), item.Soyad.ToString() };
                btnOda8.Text = item.Ad.ToString();
            }

            if (btnOda8.Text != "Oda 8")
            {
                btnOda1.Enabled = false;
                btnOda8.BackColor = Color.Red;
            }


            collectionOda = veritabani.Database.GetCollection<OdaEkle>("Oda9");

            var gosterOda9 = collectionOda.AsQueryable<OdaEkle>().ToList();

            foreach (var item in gosterOda9)
            {
                string[] array = { item.Ad.ToString(), item.Soyad.ToString() };
                btnOda9.Text = item.Ad.ToString();
            }

            if (btnOda9.Text != "Oda 9")
            {
                btnOda1.Enabled = false;
                btnOda9.BackColor = Color.Red;
            }

            collectionOda = veritabani.Database.GetCollection<OdaEkle>("Oda10");

            var gosterOda10 = collectionOda.AsQueryable<OdaEkle>().ToList();

            foreach (var item in gosterOda10)
            {
                string[] array = { item.Ad.ToString(), item.Soyad.ToString() };
                btnOda10.Text = item.Ad.ToString();
            }

            if (btnOda10.Text != "Oda 10")
            {
                btnOda1.Enabled = false;
                btnOda10.BackColor = Color.Red;
            }

            collectionOda = veritabani.Database.GetCollection<OdaEkle>("Oda11");

            var gosterOda11 = collectionOda.AsQueryable<OdaEkle>().ToList();

            foreach (var item in gosterOda11)
            {
                string[] array = { item.Ad.ToString(), item.Soyad.ToString() };
                btnOda11.Text = item.Ad.ToString();
            }

            if (btnOda11.Text != "Oda 11")
            {
                btnOda1.Enabled = false;
                btnOda11.BackColor = Color.Red;
            }

            collectionOda = veritabani.Database.GetCollection<OdaEkle>("Oda12");

            var gosterOda12 = collectionOda.AsQueryable<OdaEkle>().ToList();

            foreach (var item in gosterOda12)
            {
                string[] array = { item.Ad.ToString(), item.Soyad.ToString() };
                btnOda12.Text = item.Ad.ToString();
            }

            if (btnOda12.Text != "Oda 12")
            {
                btnOda1.Enabled = false;
                btnOda12.BackColor = Color.Red;
            }

            collectionOda = veritabani.Database.GetCollection<OdaEkle>("Oda13");

            var gosterOda13 = collectionOda.AsQueryable<OdaEkle>().ToList();

            foreach (var item in gosterOda13)
            {
                string[] array = { item.Ad.ToString(), item.Soyad.ToString() };
                btnOda13.Text = item.Ad.ToString();
            }

            if (btnOda13.Text != "Oda 13")
            {
                btnOda1.Enabled = false;
                btnOda13.BackColor = Color.Red;
            }

            collectionOda = veritabani.Database.GetCollection<OdaEkle>("Oda14");

            var gosterOda14 = collectionOda.AsQueryable<OdaEkle>().ToList();

            foreach (var item in gosterOda14)
            {
                string[] array = { item.Ad.ToString(), item.Soyad.ToString() };
                btnOda14.Text = item.Ad.ToString();
            }

            if (btnOda14.Text != "Oda 14")
            {
                btnOda1.Enabled = false;
                btnOda14.BackColor = Color.Red;
            }

            collectionOda = veritabani.Database.GetCollection<OdaEkle>("Oda15");

            var gosterOda15 = collectionOda.AsQueryable<OdaEkle>().ToList();

            foreach (var item in gosterOda15)
            {
                string[] array = { item.Ad.ToString(), item.Soyad.ToString() };
                btnOda15.Text = item.Ad.ToString();
            }

            if (btnOda15.Text != "Oda 15")
            {
                btnOda1.Enabled = false;
                btnOda15.BackColor = Color.Red;
            }
        }

        [Obsolete]
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            collectionOda = veritabani.Database.GetCollection<OdaKayit>("OdaKayit");
            var OdaKayit = new OdaKayit { };

            OdaKayit.Ad = txtAd.Text;
            OdaKayit.Soyad = txtSoyad.Text;
            OdaKayit.Tc = txtTC.Text;
            OdaKayit.Telefon = txtTelefon.Text;
            OdaKayit.Mail = txtMail.Text;
            OdaKayit.GirisTarih = txtGirisTarih.Text;
            OdaKayit.CikisTarih = txtCikisTarih.Text;
            OdaKayit.Adres = txtAdres.Text;
            OdaKayit.OdaNo = txtOdaNumarasi.Text;
            OdaKayit.Fiyat = txtFiyat.Text;
            collectionOda.Insert(OdaKayit);

            DialogResult result = MessageBox.Show
                ("Müşteri Adı: " + txtAd.Text +
                " Müşteri Soyadı: " + txtSoyad.Text +
                " Ve Oda No :" + txtOdaNumarasi.Text);

            if (txtOdaNumarasi.Text == "")
            {
                MessageBox.Show("Oda Numarası Boş Olamaz.");
            }

            if (txtOdaNumarasi.Text == "1")
            {
                collectionOda = veritabani.Database.GetCollection<OdaEkle>("Oda1");
                var OdaKayit1 = new OdaEkle { };

                OdaKayit1.Ad = txtAd.Text;
                OdaKayit1.Soyad = txtSoyad.Text;
                collectionOda.Insert(OdaKayit1);
            }

            if (txtOdaNumarasi.Text == "2")
            {
                collectionOda = veritabani.Database.GetCollection<OdaEkle>("Oda2");
                var OdaKayit2 = new OdaEkle { };

                OdaKayit2.Ad = txtAd.Text;
                OdaKayit2.Soyad = txtSoyad.Text;
                collectionOda.Insert(OdaKayit2);
            }

            if (txtOdaNumarasi.Text == "3")
            {
                collectionOda = veritabani.Database.GetCollection<OdaEkle>("Oda3");
                var OdaKayit3 = new OdaEkle { };

                OdaKayit3.Ad = txtAd.Text;
                OdaKayit3.Soyad = txtSoyad.Text;
                collectionOda.Insert(OdaKayit3);
            }

            if (txtOdaNumarasi.Text == "4")
            {
                collectionOda = veritabani.Database.GetCollection<OdaEkle>("Oda4");
                var OdaKayit4 = new OdaEkle { };

                OdaKayit4.Ad = txtAd.Text;
                OdaKayit4.Soyad = txtSoyad.Text;
                collectionOda.Insert(OdaKayit4);
            }

            if (txtOdaNumarasi.Text == "5")
            {
                collectionOda = veritabani.Database.GetCollection<OdaEkle>("Oda5");
                var OdaKayit5 = new OdaEkle { };

                OdaKayit5.Ad = txtAd.Text;
                OdaKayit5.Soyad = txtSoyad.Text;
                collectionOda.Insert(OdaKayit5);
            }

            if (txtOdaNumarasi.Text == "6")
            {
                collectionOda = veritabani.Database.GetCollection<OdaEkle>("Oda6");
                var OdaKayit6 = new OdaEkle { };

                OdaKayit6.Ad = txtAd.Text;
                OdaKayit6.Soyad = txtSoyad.Text;
                collectionOda.Insert(OdaKayit6);
            }

            if (txtOdaNumarasi.Text == "7")
            {
                collectionOda = veritabani.Database.GetCollection<OdaEkle>("Oda7");
                var OdaKayit7 = new OdaEkle { };

                OdaKayit7.Ad = txtAd.Text;
                OdaKayit7.Soyad = txtSoyad.Text;
                collectionOda.Insert(OdaKayit7);
            }

            if (txtOdaNumarasi.Text == "8")
            {
                collectionOda = veritabani.Database.GetCollection<OdaEkle>("Oda8");
                var OdaKayit8 = new OdaEkle { };

                OdaKayit8.Ad = txtAd.Text;
                OdaKayit8.Soyad = txtSoyad.Text;
                collectionOda.Insert(OdaKayit8);
            }

            if (txtOdaNumarasi.Text == "9")
            {
                collectionOda = veritabani.Database.GetCollection<OdaEkle>("Oda9");
                var OdaKayit9 = new OdaEkle { };

                OdaKayit9.Ad = txtAd.Text;
                OdaKayit9.Soyad = txtSoyad.Text;
                collectionOda.Insert(OdaKayit9);
            }

            if (txtOdaNumarasi.Text == "10")
            {
                collectionOda = veritabani.Database.GetCollection<OdaEkle>("Oda10");
                var OdaKayit10 = new OdaEkle { };

                OdaKayit10.Ad = txtAd.Text;
                OdaKayit10.Soyad = txtSoyad.Text;
                collectionOda.Insert(OdaKayit10);
            }

            if (txtOdaNumarasi.Text == "11")
            {
                collectionOda = veritabani.Database.GetCollection<OdaEkle>("Oda11");
                var OdaKayit11 = new OdaEkle { };

                OdaKayit11.Ad = txtAd.Text;
                OdaKayit11.Soyad = txtSoyad.Text;
                collectionOda.Insert(OdaKayit11);
            }

            if (txtOdaNumarasi.Text == "12")
            {
                collectionOda = veritabani.Database.GetCollection<OdaEkle>("Oda12");
                var OdaKayit12 = new OdaEkle { };

                OdaKayit12.Ad = txtAd.Text;
                OdaKayit12.Soyad = txtSoyad.Text;
                collectionOda.Insert(OdaKayit12);
            }

            if (txtOdaNumarasi.Text == "13")
            {
                collectionOda = veritabani.Database.GetCollection<OdaEkle>("Oda13");
                var OdaKayit13 = new OdaEkle { };

                OdaKayit13.Ad = txtAd.Text;
                OdaKayit13.Soyad = txtSoyad.Text;
                collectionOda.Insert(OdaKayit13);
            }

            if (txtOdaNumarasi.Text == "14")
            {
                collectionOda = veritabani.Database.GetCollection<OdaEkle>("Oda14");
                var OdaKayit14 = new OdaEkle { };

                OdaKayit14.Ad = txtAd.Text;
                OdaKayit14.Soyad = txtSoyad.Text;
                collectionOda.Insert(OdaKayit14);
            }

            if (txtOdaNumarasi.Text == "15")
            {
                collectionOda = veritabani.Database.GetCollection<OdaEkle>("Oda15");
                var OdaKayit15 = new OdaEkle { };

                OdaKayit15.Ad = txtAd.Text;
                OdaKayit15.Soyad = txtSoyad.Text;
                collectionOda.Insert(OdaKayit15);
            }
            OdaKarti fr1 = new OdaKarti();
            fr1.Show();
            this.Hide();
        }

        private void btnOda1_Click(object sender, EventArgs e)
        {
            txtOdaNumarasi.Text = "1";
        }

        private void btnOda2_Click(object sender, EventArgs e)
        {
            txtOdaNumarasi.Text = "2";
        }

        private void btnOda3_Click(object sender, EventArgs e)
        {
            txtOdaNumarasi.Text = "3";
        }

        private void btnOda4_Click(object sender, EventArgs e)
        {
            txtOdaNumarasi.Text = "4";
        }

        private void btnOda5_Click(object sender, EventArgs e)
        {
            txtOdaNumarasi.Text = "5";
        }

        private void btnOda6_Click(object sender, EventArgs e)
        {
            txtOdaNumarasi.Text = "6";
        }

        private void btnOda7_Click(object sender, EventArgs e)
        {
            txtOdaNumarasi.Text = "7";
        }

        private void btnOda8_Click(object sender, EventArgs e)
        {
            txtOdaNumarasi.Text = "10";
        }

        private void btnOda9_Click(object sender, EventArgs e)
        {
            txtOdaNumarasi.Text = "9";
        }

        private void btnOda10_Click(object sender, EventArgs e)
        {
            txtOdaNumarasi.Text = "10";
        }

        private void btnOda11_Click(object sender, EventArgs e)
        {
            txtOdaNumarasi.Text = "11";
        }

        private void btnOda12_Click(object sender, EventArgs e)
        {
            txtOdaNumarasi.Text = "12";
        }

        private void btnOda13_Click(object sender, EventArgs e)
        {
            txtOdaNumarasi.Text = "13";
        }

        private void btnOda14_Click(object sender, EventArgs e)
        {
            txtOdaNumarasi.Text = "14";
        }

        private void btnOda15_Click(object sender, EventArgs e)
        {
            txtOdaNumarasi.Text = "15";
        }
    }
    
}