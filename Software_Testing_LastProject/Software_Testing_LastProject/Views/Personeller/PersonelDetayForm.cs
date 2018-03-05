using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Software_Testing_LastProject.Controller;
using Software_Testing_LastProject.Views.Fixtures;

namespace Software_Testing_LastProject.Views.Personeller
{
    public partial class PersonelDetayForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private int kisiId;
        public PersonelDetayForm(int kisiId)
        {
            if (kisiId == 0) return;
            this.kisiId = kisiId;
            InitializeComponent();
        }
        void navBarControl_ActiveGroupChanged(object sender, DevExpress.XtraNavBar.NavBarGroupEventArgs e)
        {
            navigationFrame.SelectedPageIndex = navBarControl.Groups.IndexOf(e.Group);
        }
        void barButtonNavigation_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int barItemIndex = barSubItemNavigation.ItemLinks.IndexOf(e.Link);
            navBarControl.ActiveGroup = navBarControl.Groups[barItemIndex];
        }

        private void ribbonControl_Click(object sender, EventArgs e)
        {

        }

        private void PersonelDetayForm_Load(object sender, EventArgs e)
        {
            var result = PersonellerController.KisiGetir(kisiId);
            lbl_AdSoyad.Text ="Ad Soyad: " +result.Kisi.Ad + " " + result.Kisi.Soyad;
            lbl_KullaniciAdi.Text = "Kullanıcı Adı: " + result.Kullanici.KullaniciAdi;
            lbl_Rol.Text = "Kullanıcı Türü: " + result.Rol.RolAdi;


            var result2 = PersonellerController.KullaniciSorumluOdalar(kisiId);
            DataTable dt=new DataTable();
            dt.Columns.Add("OdaId", typeof(int));
            dt.Columns.Add("OdaAdi", typeof(string));
            dt.Columns.Add("AdSoyad", typeof(string));
            foreach (var item in result2)
            {
                dt.Rows.Add(item.Oda.OdaId,item.Oda.OdaAdi,item.Kisi.Ad+" "+item.Kisi.Soyad);
            }
            grid_PersonelOda.DataSource = dt;
            gridView_personelOda.Columns["OdaId"].Visible = false;

            var result1 = PersonellerController.KullaniciZimmetleri(kisiId);
            DataTable dtDemirbas = new DataTable();
            dtDemirbas.Columns.Add("DemirbasKodu", typeof(string));
            dtDemirbas.Columns.Add("DemirbasAdi", typeof(string));
            foreach (var item in result1)
            {
                dtDemirbas.Rows.Add(item.Demirbas.DemirbasKodu,item.Demirbas.DemirbasAdi);
            }
            grid_personeldemirbas.DataSource = dtDemirbas;

        }

        private void gridView_personelDemirbas_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

        }

        public static string OdaAdi { get; set; }
        public static string SorumluAdi { get; set; }
        private void gridView_personelOda_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            OdaAdi = gridView_personelOda.GetRowCellValue(gridView_personelOda.FocusedRowHandle, "OdaAdi").ToString();
            SorumluAdi = gridView_personelOda.GetRowCellValue(gridView_personelOda.FocusedRowHandle, "AdSoyad").ToString();
            int odaId = Convert.ToInt32(gridView_personelOda.GetRowCellValue(gridView_personelOda.FocusedRowHandle, "OdaId"));
            OdaZimmetleriGetirForm ozgForm=new OdaZimmetleriGetirForm(odaId);
            ozgForm.ShowDialog();
        }
    }
}