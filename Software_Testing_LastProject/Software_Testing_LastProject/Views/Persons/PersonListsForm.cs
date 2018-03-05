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
using Software_Testing_LastProject.Views.Personeller;

namespace Software_Testing_LastProject.Views.Persons
{
    public partial class PersonListsForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public PersonListsForm()
        {
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

        private void PersonListsForm_Load(object sender, EventArgs e)
        {
            var result = PersonellerController.KullanicilariListele();
            DataTable dtKullancilar=new DataTable("personller");
            dtKullancilar.Columns.Add("Ad", typeof(string));
            dtKullancilar.Columns.Add("Soyad", typeof(string));
            dtKullancilar.Columns.Add("KisiId", typeof(int));
            foreach (var item in result)
            {
                dtKullancilar.Rows.Add(item.Ad, item.Soyad, item.KisiId);
            }
            grid_Personel.DataSource = dtKullancilar;
            gridView_Personel.Columns["KisiId"].Visible = false;
        }

        private void gridView_Personel_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int kisiId = Convert.ToInt32(gridView_Personel.GetRowCellValue(gridView_Personel.FocusedRowHandle, "KisiId"));
            string kisiAdi = gridView_Personel.GetRowCellValue(gridView_Personel.FocusedRowHandle, "Ad")+" "+ gridView_Personel.GetRowCellValue(gridView_Personel.FocusedRowHandle, "Soyad");
            DialogResult sonuc = MessageBox.Show(kisiAdi + " Detaylarına Bakmak İster Misiniz?", "Öneri ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes)
            {
                PersonelDetayForm pdForm = new PersonelDetayForm(kisiId);
                this.Close();
                pdForm.Show();
            }
        }
    }
}