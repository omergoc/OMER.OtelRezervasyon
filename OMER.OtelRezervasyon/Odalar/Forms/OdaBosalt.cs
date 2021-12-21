using DevExpress.XtraEditors;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using OMER.OtelRezervasyon.Odalar.Model;
using System;
using System.Drawing;
using System.Linq;

namespace OMER.OtelRezervasyon.Odalar.Forms
{
    public partial class OdaBosalt : XtraForm
    {
        public OdaBosalt()
        {
            InitializeComponent();
        }

        [Obsolete]
        Veritabani veritabani = new Veritabani();
        MongoCollection collectionOda;

        [Obsolete]
        private void OdaBosalt_Load(object sender, EventArgs e)
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
                btnOda15.BackColor = Color.Red;
            }
        }

        [Obsolete]
        private void btnOdayiBosalt_Click(object sender, EventArgs e)
        {
            if (label1.Text == "1")
            {
                collectionOda = veritabani.Database.GetCollection<OdaEkle>("Oda1");

                var sorgu = new QueryDocument();
                collectionOda.Remove(sorgu);

                OdaBosalt fr1 = new OdaBosalt();
                fr1.Show();
                this.Hide();
            }

            if (label1.Text == "2")
            {
                collectionOda = veritabani.Database.GetCollection<OdaEkle>("Oda2");

                var sorgu = new QueryDocument();
                collectionOda.Remove(sorgu);

                OdaBosalt fr1 = new OdaBosalt();
                fr1.Show();
                this.Hide();
            }

            if (label1.Text == "3")
            {
                collectionOda = veritabani.Database.GetCollection<OdaEkle>("Oda3");

                var sorgu = new QueryDocument();
                collectionOda.Remove(sorgu);

                OdaBosalt fr1 = new OdaBosalt();
                fr1.Show();
                this.Hide();
            }

            if (label1.Text == "4")
            {
                collectionOda = veritabani.Database.GetCollection<OdaEkle>("Oda4");

                var sorgu = new QueryDocument();
                collectionOda.Remove(sorgu);

                OdaBosalt fr1 = new OdaBosalt();
                fr1.Show();
                this.Hide();
            }

            if (label1.Text == "5")
            {
                collectionOda = veritabani.Database.GetCollection<OdaEkle>("Oda5");

                var sorgu = new QueryDocument();
                collectionOda.Remove(sorgu);

                OdaBosalt fr1 = new OdaBosalt();
                fr1.Show();
                this.Hide();
            }

            if (label1.Text == "6")
            {
                collectionOda = veritabani.Database.GetCollection<OdaEkle>("Oda6");

                var sorgu = new QueryDocument();
                collectionOda.Remove(sorgu);

                OdaBosalt fr1 = new OdaBosalt();
                fr1.Show();
                this.Hide();
            }

            if (label1.Text == "7")
            {
                collectionOda = veritabani.Database.GetCollection<OdaEkle>("Oda7");

                var sorgu = new QueryDocument();
                collectionOda.Remove(sorgu);

                OdaBosalt fr1 = new OdaBosalt();
                fr1.Show();
                this.Hide();
            }

            if (label1.Text == "8")
            {
                collectionOda = veritabani.Database.GetCollection<OdaEkle>("Oda8");

                var sorgu = new QueryDocument();
                collectionOda.Remove(sorgu);

                OdaBosalt fr1 = new OdaBosalt();
                fr1.Show();
                this.Hide();
            }

            if (label1.Text == "9")
            {
                collectionOda = veritabani.Database.GetCollection<OdaEkle>("Oda9");

                var sorgu = new QueryDocument();
                collectionOda.Remove(sorgu);

                OdaBosalt fr1 = new OdaBosalt();
                fr1.Show();
                this.Hide();
            }

            if (label1.Text == "10")
            {
                collectionOda = veritabani.Database.GetCollection<OdaEkle>("Oda10");

                var sorgu = new QueryDocument();
                collectionOda.Remove(sorgu);

                OdaBosalt fr1 = new OdaBosalt();
                fr1.Show();
                this.Hide();
            }

            if (label1.Text == "11")
            {
                collectionOda = veritabani.Database.GetCollection<OdaEkle>("Oda11");

                var sorgu = new QueryDocument();
                collectionOda.Remove(sorgu);

                OdaBosalt fr1 = new OdaBosalt();
                fr1.Show();
                this.Hide();
            }

            if (label1.Text == "12")
            {
                collectionOda = veritabani.Database.GetCollection<OdaEkle>("Oda12");

                var sorgu = new QueryDocument();
                collectionOda.Remove(sorgu);

                OdaBosalt fr1 = new OdaBosalt();
                fr1.Show();
                this.Hide();
            }

            if (label1.Text == "13")
            {
                collectionOda = veritabani.Database.GetCollection<OdaEkle>("Oda13");

                var sorgu = new QueryDocument();
                collectionOda.Remove(sorgu);


                OdaBosalt fr1 = new OdaBosalt();
                fr1.Show();
                this.Hide();
            }

            if (label1.Text == "14")
            {
                collectionOda = veritabani.Database.GetCollection<OdaEkle>("Oda14");

                var sorgu = new QueryDocument();
                collectionOda.Remove(sorgu);

                OdaBosalt fr1 = new OdaBosalt();
                fr1.Show();
                this.Hide();
            }

            if (label1.Text == "15")
            {
                collectionOda = veritabani.Database.GetCollection<OdaEkle>("Oda15");

                var sorgu = new QueryDocument();
                collectionOda.Remove(sorgu);

                OdaBosalt fr1 = new OdaBosalt();
                fr1.Show();
                this.Hide();
            }
        }

        private void btnOda1_Click_1(object sender, EventArgs e)
        {
            label1.Text = "1";
        }

        private void btnOda2_Click(object sender, EventArgs e)
        {
            label1.Text = "2";
        }

        private void btnOda3_Click(object sender, EventArgs e)
        {
            label1.Text = "3";
        }

        private void btnOda4_Click(object sender, EventArgs e)
        {
            label1.Text = "4";
        }

        private void btnOda5_Click(object sender, EventArgs e)
        {
            label1.Text = "5";
        }

        private void btnOda6_Click(object sender, EventArgs e)
        {
            label1.Text = "6";
        }

        private void btnOda7_Click(object sender, EventArgs e)
        {
            label1.Text = "7";
        }

        private void btnOda8_Click(object sender, EventArgs e)
        {
            label1.Text = "8";
        }

        private void btnOda9_Click(object sender, EventArgs e)
        {
            label1.Text = "9";
        }

        private void btnOda10_Click(object sender, EventArgs e)
        {
            label1.Text = "10";
        }

        private void btnOda11_Click(object sender, EventArgs e)
        {
            label1.Text = "11";
        }

        private void btnOda12_Click(object sender, EventArgs e)
        {
            label1.Text = "12";
        }

        private void btnOda13_Click(object sender, EventArgs e)
        {
            label1.Text = "13";
        }

        private void btnOda14_Click(object sender, EventArgs e)
        {
            label1.Text = "14";
        }

        private void btnOda15_Click(object sender, EventArgs e)
        {
            label1.Text = "15";
        }
    }
}