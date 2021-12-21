
namespace OMER.OtelRezervasyon.Odalar.Forms
{
    partial class OdaKayitlari
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
            this.odaNumarasi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.musteriAd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.musteriSoyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.musteriTc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.musteriTelefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.musteriMail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.girisTarih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cikisTarih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.musteriAdres = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.musteriFiyat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.odaNumarasi,
            this.musteriAd,
            this.musteriSoyad,
            this.musteriTc,
            this.musteriTelefon,
            this.musteriMail,
            this.girisTarih,
            this.cikisTarih,
            this.musteriAdres,
            this.musteriFiyat});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1350, 450);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // odaNumarasi
            // 
            this.odaNumarasi.Text = "Oda Numarası";
            this.odaNumarasi.Width = 120;
            // 
            // musteriAd
            // 
            this.musteriAd.Text = "Müşteri Ad";
            this.musteriAd.Width = 150;
            // 
            // musteriSoyad
            // 
            this.musteriSoyad.Text = "Müşteri Soyad";
            this.musteriSoyad.Width = 150;
            // 
            // musteriTc
            // 
            this.musteriTc.Text = "Müşteri Tc";
            this.musteriTc.Width = 150;
            // 
            // musteriTelefon
            // 
            this.musteriTelefon.Text = "Müşteri Telefon";
            this.musteriTelefon.Width = 150;
            // 
            // musteriMail
            // 
            this.musteriMail.Text = "Müşteri Mail Adresi";
            this.musteriMail.Width = 150;
            // 
            // girisTarih
            // 
            this.girisTarih.Text = "Giriş Tarih";
            this.girisTarih.Width = 150;
            // 
            // cikisTarih
            // 
            this.cikisTarih.Text = "Çıkış Tarihi";
            this.cikisTarih.Width = 150;
            // 
            // musteriAdres
            // 
            this.musteriAdres.Text = "Müşteri Adres";
            this.musteriAdres.Width = 150;
            // 
            // musteriFiyat
            // 
            this.musteriFiyat.Text = "Ücret";
            this.musteriFiyat.Width = 100;
            // 
            // OdaKayitlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 450);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OdaKayitlari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oda Kayitlari";
            this.Load += new System.EventHandler(this.OdaKayitlari_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader odaNumarasi;
        private System.Windows.Forms.ColumnHeader musteriAd;
        private System.Windows.Forms.ColumnHeader musteriSoyad;
        private System.Windows.Forms.ColumnHeader musteriTc;
        private System.Windows.Forms.ColumnHeader musteriTelefon;
        private System.Windows.Forms.ColumnHeader musteriMail;
        private System.Windows.Forms.ColumnHeader girisTarih;
        private System.Windows.Forms.ColumnHeader cikisTarih;
        private System.Windows.Forms.ColumnHeader musteriAdres;
        private System.Windows.Forms.ColumnHeader musteriFiyat;
    }
}