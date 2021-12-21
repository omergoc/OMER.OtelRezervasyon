
namespace OMER.OtelRezervasyon.Musteriler
{
    partial class MusteriListesi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.Ad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Soyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tarih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Adres = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Resim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.MusteriAd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MusteriSoyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MusteriTC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MusteriTarih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MusteriMesaj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Ad,
            this.Soyad,
            this.TC,
            this.Telefon,
            this.Mail,
            this.Tarih,
            this.Adres,
            this.Resim});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1320, 362);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Ad
            // 
            this.Ad.Text = "Müşteri Adı";
            this.Ad.Width = 120;
            // 
            // Soyad
            // 
            this.Soyad.Text = "Müşteri Soyadı";
            this.Soyad.Width = 120;
            // 
            // TC
            // 
            this.TC.Text = "Müşteri TC";
            this.TC.Width = 120;
            // 
            // Telefon
            // 
            this.Telefon.Text = "Müşteri Telefon";
            this.Telefon.Width = 150;
            // 
            // Mail
            // 
            this.Mail.Text = "Müşteri Mail";
            this.Mail.Width = 150;
            // 
            // Tarih
            // 
            this.Tarih.Text = "Müşteri Tarih";
            this.Tarih.Width = 150;
            // 
            // Adres
            // 
            this.Adres.Text = "Müşteri Adres";
            this.Adres.Width = 200;
            // 
            // Resim
            // 
            this.Resim.Text = "Resim";
            this.Resim.Width = 260;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MusteriAd,
            this.MusteriSoyad,
            this.MusteriTC,
            this.MusteriTarih,
            this.MusteriMesaj});
            this.listView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(0, 362);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(1320, 334);
            this.listView2.TabIndex = 2;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // MusteriAd
            // 
            this.MusteriAd.Text = "Müşteri Ad";
            this.MusteriAd.Width = 150;
            // 
            // MusteriSoyad
            // 
            this.MusteriSoyad.Text = "Müşteri Soyad";
            this.MusteriSoyad.Width = 150;
            // 
            // MusteriTC
            // 
            this.MusteriTC.Text = "Müşteri TC";
            this.MusteriTC.Width = 150;
            // 
            // MusteriTarih
            // 
            this.MusteriTarih.Text = "Müşteri Tarih";
            this.MusteriTarih.Width = 150;
            // 
            // MusteriMesaj
            // 
            this.MusteriMesaj.Text = "Mesaj";
            this.MusteriMesaj.Width = 600;
            // 
            // MusteriListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 696);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MusteriListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri & Mesaj Listesi";
            this.Load += new System.EventHandler(this.MusteriListesi_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Ad;
        private System.Windows.Forms.ColumnHeader Soyad;
        private System.Windows.Forms.ColumnHeader TC;
        private System.Windows.Forms.ColumnHeader Telefon;
        private System.Windows.Forms.ColumnHeader Mail;
        private System.Windows.Forms.ColumnHeader Tarih;
        private System.Windows.Forms.ColumnHeader Adres;
        private System.Windows.Forms.ColumnHeader Resim;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader MusteriAd;
        private System.Windows.Forms.ColumnHeader MusteriSoyad;
        private System.Windows.Forms.ColumnHeader MusteriTC;
        private System.Windows.Forms.ColumnHeader MusteriTarih;
        private System.Windows.Forms.ColumnHeader MusteriMesaj;
    }
}