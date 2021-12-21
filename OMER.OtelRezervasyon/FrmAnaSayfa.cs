using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OMER.OtelRezervasyon.Musteriler;
using OMER.OtelRezervasyon.Odalar.Forms;

namespace OMER.OtelRezervasyon
{
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }

        private void btnMusteriKarti_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MusteriKarti frm = new MusteriKarti();
            frm.Show();
        }

        private void navBarMusteriKarti_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            MusteriKarti frm = new MusteriKarti();
            frm.Show();
        }

        private void btnMusteriMesajlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MusteriMesajlari frm = new MusteriMesajlari();
            frm.Show();
        }

        private void navBarMusteriMesajlari_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            MusteriMesajlari frm = new MusteriMesajlari();
            frm.Show();
        }

        private void btnMusteriListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MusteriListesi frm = new MusteriListesi();
            frm.Show();
        }

        private void navBarMusteriListesi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            MusteriListesi frm = new MusteriListesi();
            frm.Show();
        }

        private void btnOdaKayit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OdaKarti frm = new OdaKarti();
            frm.Show();
        }

        private void navBarOdaKayit_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            OdaKarti frm = new OdaKarti();
            frm.Show();
        }

        private void btnOdaListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OdaDurum frm = new OdaDurum();
            frm.Show();
        }

        private void btnOdaBosalt_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OdaBosalt frm = new OdaBosalt();
            frm.Show();
        }

        private void btnOdaKayitlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OdaKayitlari frm = new OdaKayitlari();
            frm.Show();
        }

        private void navBarOdaListe_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            OdaDurum frm = new OdaDurum();
            frm.Show();
        }

        private void navBarOdaBosalt_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            OdaBosalt frm = new OdaBosalt();
            frm.Show();
        }

        private void navBarOdaKayitlari_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            OdaKayitlari frm = new OdaKayitlari();
            frm.Show();
        }
    }
}
