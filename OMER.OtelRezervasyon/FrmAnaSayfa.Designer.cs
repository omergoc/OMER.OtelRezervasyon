
namespace OMER.OtelRezervasyon
{
    partial class FrmAnaSayfa
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
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnMusteriKarti = new DevExpress.XtraBars.BarButtonItem();
            this.btnMusteriListesi = new DevExpress.XtraBars.BarButtonItem();
            this.btnMusteriMesajlari = new DevExpress.XtraBars.BarButtonItem();
            this.btnOdaKayit = new DevExpress.XtraBars.BarButtonItem();
            this.btnOdaListesi = new DevExpress.XtraBars.BarButtonItem();
            this.btnOdaBosalt = new DevExpress.XtraBars.BarButtonItem();
            this.btnOdaKayitlari = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnPersonelEkle = new DevExpress.XtraBars.BarButtonItem();
            this.btnPersonelSil = new DevExpress.XtraBars.BarButtonItem();
            this.btnPersonelListesi = new DevExpress.XtraBars.BarButtonItem();
            this.s = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.Odalar = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarMusteriKarti = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarMusteriListesi = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarMusteriMesajlari = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarOdaKayit = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarOdaListe = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarOdaBosalt = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarOdaKayitlari = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarOdalar = new DevExpress.XtraNavBar.NavBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnMusteriKarti,
            this.btnMusteriListesi,
            this.btnMusteriMesajlari,
            this.btnOdaKayit,
            this.btnOdaListesi,
            this.btnOdaBosalt,
            this.btnOdaKayitlari,
            this.barButtonItem1,
            this.btnPersonelEkle,
            this.btnPersonelSil,
            this.btnPersonelListesi});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 12;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 371;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.s,
            this.Odalar,
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(900, 199);
            // 
            // btnMusteriKarti
            // 
            this.btnMusteriKarti.Caption = "Müşteri Kartı";
            this.btnMusteriKarti.Id = 1;
            this.btnMusteriKarti.ImageOptions.Image = global::OMER.OtelRezervasyon.Properties.Resources.customer_32x32;
            this.btnMusteriKarti.Name = "btnMusteriKarti";
            this.btnMusteriKarti.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnMusteriKarti.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMusteriKarti_ItemClick);
            // 
            // btnMusteriListesi
            // 
            this.btnMusteriListesi.Caption = "Müşteri Listesi";
            this.btnMusteriListesi.Id = 2;
            this.btnMusteriListesi.ImageOptions.Image = global::OMER.OtelRezervasyon.Properties.Resources.chartsshowlegend_32x32;
            this.btnMusteriListesi.Name = "btnMusteriListesi";
            this.btnMusteriListesi.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnMusteriListesi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMusteriListesi_ItemClick);
            // 
            // btnMusteriMesajlari
            // 
            this.btnMusteriMesajlari.Caption = "Müşteri  Mesajları";
            this.btnMusteriMesajlari.Id = 3;
            this.btnMusteriMesajlari.ImageOptions.Image = global::OMER.OtelRezervasyon.Properties.Resources.new_32x32;
            this.btnMusteriMesajlari.ImageOptions.LargeImage = global::OMER.OtelRezervasyon.Properties.Resources.new_32x32;
            this.btnMusteriMesajlari.Name = "btnMusteriMesajlari";
            this.btnMusteriMesajlari.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnMusteriMesajlari.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMusteriMesajlari_ItemClick);
            // 
            // btnOdaKayit
            // 
            this.btnOdaKayit.Caption = "Oda Kayıt";
            this.btnOdaKayit.Id = 4;
            this.btnOdaKayit.ImageOptions.Image = global::OMER.OtelRezervasyon.Properties.Resources.report_16x16;
            this.btnOdaKayit.ImageOptions.LargeImage = global::OMER.OtelRezervasyon.Properties.Resources.report_32x32;
            this.btnOdaKayit.Name = "btnOdaKayit";
            this.btnOdaKayit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnOdaKayit_ItemClick);
            // 
            // btnOdaListesi
            // 
            this.btnOdaListesi.Caption = "Oda Listesi";
            this.btnOdaListesi.Id = 5;
            this.btnOdaListesi.ImageOptions.Image = global::OMER.OtelRezervasyon.Properties.Resources.chartsshowlegend_32x32;
            this.btnOdaListesi.Name = "btnOdaListesi";
            this.btnOdaListesi.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnOdaListesi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnOdaListesi_ItemClick);
            // 
            // btnOdaBosalt
            // 
            this.btnOdaBosalt.Caption = "Oda Boşalt";
            this.btnOdaBosalt.Id = 6;
            this.btnOdaBosalt.ImageOptions.Image = global::OMER.OtelRezervasyon.Properties.Resources.deletelist2_16x16;
            this.btnOdaBosalt.ImageOptions.LargeImage = global::OMER.OtelRezervasyon.Properties.Resources.deletelist2_32x32;
            this.btnOdaBosalt.Name = "btnOdaBosalt";
            this.btnOdaBosalt.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnOdaBosalt_ItemClick);
            // 
            // btnOdaKayitlari
            // 
            this.btnOdaKayitlari.Caption = "Bütün Oda Kayıtları";
            this.btnOdaKayitlari.Id = 7;
            this.btnOdaKayitlari.ImageOptions.Image = global::OMER.OtelRezervasyon.Properties.Resources.article_16x16;
            this.btnOdaKayitlari.ImageOptions.LargeImage = global::OMER.OtelRezervasyon.Properties.Resources.article_32x32;
            this.btnOdaKayitlari.Name = "btnOdaKayitlari";
            this.btnOdaKayitlari.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnOdaKayitlari_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 8;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnPersonelEkle
            // 
            this.btnPersonelEkle.Caption = "Personel Ekle";
            this.btnPersonelEkle.Id = 9;
            this.btnPersonelEkle.ImageOptions.Image = global::OMER.OtelRezervasyon.Properties.Resources.newcontact_16x16;
            this.btnPersonelEkle.ImageOptions.LargeImage = global::OMER.OtelRezervasyon.Properties.Resources.newcontact_32x32;
            this.btnPersonelEkle.Name = "btnPersonelEkle";
            // 
            // btnPersonelSil
            // 
            this.btnPersonelSil.Caption = "Personel Sil";
            this.btnPersonelSil.Id = 10;
            this.btnPersonelSil.ImageOptions.Image = global::OMER.OtelRezervasyon.Properties.Resources.cancel_16x16;
            this.btnPersonelSil.ImageOptions.LargeImage = global::OMER.OtelRezervasyon.Properties.Resources.cancel_32x32;
            this.btnPersonelSil.Name = "btnPersonelSil";
            // 
            // btnPersonelListesi
            // 
            this.btnPersonelListesi.Caption = "Personel Listesi";
            this.btnPersonelListesi.Id = 11;
            this.btnPersonelListesi.ImageOptions.Image = global::OMER.OtelRezervasyon.Properties.Resources.hideproduct_16x16;
            this.btnPersonelListesi.ImageOptions.LargeImage = global::OMER.OtelRezervasyon.Properties.Resources.hideproduct_32x32;
            this.btnPersonelListesi.Name = "btnPersonelListesi";
            // 
            // s
            // 
            this.s.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.s.ImageOptions.Image = global::OMER.OtelRezervasyon.Properties.Resources.usergroup_32x32;
            this.s.Name = "s";
            this.s.Text = "Müşteriler";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnMusteriKarti);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnMusteriListesi);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnMusteriMesajlari);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Müşteriler Penceresi";
            // 
            // Odalar
            // 
            this.Odalar.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.Odalar.ImageOptions.Image = global::OMER.OtelRezervasyon.Properties.Resources.bringtofront_32x32;
            this.Odalar.Name = "Odalar";
            this.Odalar.Text = "Odalar";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnOdaKayit);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnOdaListesi);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnOdaBosalt);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnOdaKayitlari);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Odalar Penceresi";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage1.ImageOptions.Image = global::OMER.OtelRezervasyon.Properties.Resources.employee_32x321;
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Personeller";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnPersonelEkle);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnPersonelSil);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnPersonelListesi);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Personeller";
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarMusteriKarti,
            this.navBarMusteriListesi,
            this.navBarMusteriMesajlari,
            this.navBarOdaKayit,
            this.navBarOdaListe,
            this.navBarOdaBosalt,
            this.navBarOdaKayitlari});
            this.navBarControl1.Location = new System.Drawing.Point(0, 199);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 206;
            this.navBarControl1.Size = new System.Drawing.Size(206, 398);
            this.navBarControl1.TabIndex = 1;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.navBarGroup1.Appearance.Options.UseBorderColor = true;
            this.navBarGroup1.Caption = "Müşteriler";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.ImageOptions.SmallImage = global::OMER.OtelRezervasyon.Properties.Resources.usergroup_32x32;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarMusteriKarti),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarMusteriListesi),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarMusteriMesajlari)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // navBarMusteriKarti
            // 
            this.navBarMusteriKarti.Caption = "Müşteri Kartı";
            this.navBarMusteriKarti.ImageOptions.LargeImage = global::OMER.OtelRezervasyon.Properties.Resources.contact_32x32;
            this.navBarMusteriKarti.ImageOptions.SmallImage = global::OMER.OtelRezervasyon.Properties.Resources.contact_16x16;
            this.navBarMusteriKarti.Name = "navBarMusteriKarti";
            this.navBarMusteriKarti.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarMusteriKarti_LinkClicked);
            // 
            // navBarMusteriListesi
            // 
            this.navBarMusteriListesi.Caption = "Müşteri Listesi";
            this.navBarMusteriListesi.ImageOptions.LargeImage = global::OMER.OtelRezervasyon.Properties.Resources.list_32x32;
            this.navBarMusteriListesi.ImageOptions.SmallImage = global::OMER.OtelRezervasyon.Properties.Resources.list_16x16;
            this.navBarMusteriListesi.Name = "navBarMusteriListesi";
            this.navBarMusteriListesi.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarMusteriListesi_LinkClicked);
            // 
            // navBarMusteriMesajlari
            // 
            this.navBarMusteriMesajlari.Caption = "Müşteri Mesajları";
            this.navBarMusteriMesajlari.ImageOptions.LargeImage = global::OMER.OtelRezervasyon.Properties.Resources.merge_32x32;
            this.navBarMusteriMesajlari.ImageOptions.SmallImage = global::OMER.OtelRezervasyon.Properties.Resources.merge_16x16;
            this.navBarMusteriMesajlari.Name = "navBarMusteriMesajlari";
            this.navBarMusteriMesajlari.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarMusteriMesajlari_LinkClicked);
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "Odalar";
            this.navBarGroup2.Expanded = true;
            this.navBarGroup2.ImageOptions.SmallImage = global::OMER.OtelRezervasyon.Properties.Resources.bringtofront_32x32;
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarOdaKayit),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarOdaListe),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarOdaBosalt),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarOdaKayitlari)});
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // navBarOdaKayit
            // 
            this.navBarOdaKayit.Caption = "Oda Kayıt";
            this.navBarOdaKayit.ImageOptions.LargeImage = global::OMER.OtelRezervasyon.Properties.Resources.addgroupfooter_32x32;
            this.navBarOdaKayit.ImageOptions.SmallImage = global::OMER.OtelRezervasyon.Properties.Resources.addgroupfooter_16x16;
            this.navBarOdaKayit.Name = "navBarOdaKayit";
            this.navBarOdaKayit.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarOdaKayit_LinkClicked);
            // 
            // navBarOdaListe
            // 
            this.navBarOdaListe.Caption = "Odalar";
            this.navBarOdaListe.ImageOptions.LargeImage = global::OMER.OtelRezervasyon.Properties.Resources.showproduct_32x32;
            this.navBarOdaListe.ImageOptions.SmallImage = global::OMER.OtelRezervasyon.Properties.Resources.showproduct_16x16;
            this.navBarOdaListe.Name = "navBarOdaListe";
            this.navBarOdaListe.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarOdaListe_LinkClicked);
            // 
            // navBarOdaBosalt
            // 
            this.navBarOdaBosalt.Caption = "Oda Boşaltma";
            this.navBarOdaBosalt.ImageOptions.LargeImage = global::OMER.OtelRezervasyon.Properties.Resources.sortbyorderdate_32x32;
            this.navBarOdaBosalt.ImageOptions.SmallImage = global::OMER.OtelRezervasyon.Properties.Resources.sortbyorderdate_16x16;
            this.navBarOdaBosalt.Name = "navBarOdaBosalt";
            this.navBarOdaBosalt.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarOdaBosalt_LinkClicked);
            // 
            // navBarOdaKayitlari
            // 
            this.navBarOdaKayitlari.Caption = "Bütün Oda Kayıtları";
            this.navBarOdaKayitlari.ImageOptions.SmallImage = global::OMER.OtelRezervasyon.Properties.Resources.producttopsalesperson_16x16;
            this.navBarOdaKayitlari.Name = "navBarOdaKayitlari";
            this.navBarOdaKayitlari.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarOdaKayitlari_LinkClicked);
            // 
            // navBarOdalar
            // 
            this.navBarOdalar.Caption = "Odalar";
            this.navBarOdalar.ImageOptions.LargeImage = global::OMER.OtelRezervasyon.Properties.Resources.insert_32x32;
            this.navBarOdalar.ImageOptions.SmallImage = global::OMER.OtelRezervasyon.Properties.Resources.insert_16x16;
            this.navBarOdalar.Name = "navBarOdalar";
            // 
            // FrmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 597);
            this.Controls.Add(this.navBarControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage s;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnMusteriKarti;
        private DevExpress.XtraBars.BarButtonItem btnMusteriListesi;
        private DevExpress.XtraBars.BarButtonItem btnMusteriMesajlari;
        private DevExpress.XtraBars.Ribbon.RibbonPage Odalar;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnOdaKayit;
        private DevExpress.XtraBars.BarButtonItem btnOdaListesi;
        private DevExpress.XtraBars.BarButtonItem btnOdaBosalt;
        private DevExpress.XtraBars.BarButtonItem btnOdaKayitlari;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarItem navBarMusteriKarti;
        private DevExpress.XtraNavBar.NavBarItem navBarMusteriListesi;
        private DevExpress.XtraNavBar.NavBarItem navBarMusteriMesajlari;
        private DevExpress.XtraNavBar.NavBarItem navBarOdaKayit;
        private DevExpress.XtraNavBar.NavBarItem navBarOdaListe;
        private DevExpress.XtraNavBar.NavBarItem navBarOdalar;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraNavBar.NavBarItem navBarOdaBosalt;
        private DevExpress.XtraNavBar.NavBarItem navBarOdaKayitlari;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnPersonelEkle;
        private DevExpress.XtraBars.BarButtonItem btnPersonelSil;
        private DevExpress.XtraBars.BarButtonItem btnPersonelListesi;
    }
}

