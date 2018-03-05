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
using Software_Testing_LastProject.Model;

namespace Software_Testing_LastProject.Views.Product
{
    public partial class ProductStockListForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public ProductStockListForm()
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
      
        private void ProductStockListForm_Load(object sender, EventArgs e)
        {
            if (LoginForm._session==ERoles.Standart.ToString())
            {
                btn_StokEkleFormAc.Enabled = false;
            }
            /**Stoktaki Ürünlerin GridControl Üzerinde Gösterilmesini Sağlamaktadır.*/
            Tools.StoklariGrideDoldur(grid_Stoklar,gridView_Stoklar);

            /**Stokta Biten Ürünlerin GridControl Üzerinde Gösterilmesini Sağlamaktadır.*/
            List<StokUrunViewModel> stokBitenlerListesi = StokController.StoktaBitenleriGetir();
            DataTable dtBitenStokList = new DataTable("BitenStokListesi");
            dtBitenStokList.Columns.Add("UrunId", typeof(int));
            dtBitenStokList.Columns.Add("UrunAdi", typeof(string));
            dtBitenStokList.Columns.Add("SatinAlinmaTarihi", typeof(DateTime));
            dtBitenStokList.Columns.Add("Adet", typeof(int));
            foreach (var item in stokBitenlerListesi)
            {
                dtBitenStokList.Rows.Add(item.Urun.UrunId,item.Urun.UrunAdi, item.Urun.SatinAlinmaTarihi, item.UrunStok.Stok);
            }
            grid_StoktaBiten.DataSource = dtBitenStokList;
            gridView_StoktaBiten.Columns["UrunId"].Visible = false;
        }

        public static int UrunId { get; set; }
        private void gridView_StoktaBiten_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            string urunAdi = gridView_StoktaBiten.GetRowCellValue(gridView_StoktaBiten.FocusedRowHandle, "UrunAdi")
                .ToString();
            DialogResult sonuc =  MessageBox.Show(urunAdi+" İsimli Ürün Detaylarına Bakmak İster Misiniz?","Öneri ?",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            UrunId=Convert.ToInt32(gridView_StoktaBiten.GetRowCellValue(gridView_StoktaBiten.FocusedRowHandle, "UrunId"));
            if (sonuc == DialogResult.Yes)
            {
                ProductStockDetailForm psdForm = new ProductStockDetailForm(UrunId);
                this.Close();
                psdForm.Show();
            }
        }

        private void gridView_Stoklar_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            string urunAdi = gridView_Stoklar.GetRowCellValue(gridView_Stoklar.FocusedRowHandle, "UrunAdi")
                .ToString();
            DialogResult sonuc = MessageBox.Show(urunAdi + " İsimli Ürün Detaylarına Bakmak İster Misiniz?", "Öneri ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            UrunId = Convert.ToInt32(gridView_Stoklar.GetRowCellValue(gridView_Stoklar.FocusedRowHandle, "UrunId"));
            if (sonuc == DialogResult.Yes)
            {
                ProductStockDetailForm psdForm = new ProductStockDetailForm(UrunId);
                this.Close();
                psdForm.Show();
            }
        }

        private void btn_StokEkleFormAc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddProductForm apForm = new  AddProductForm();
            apForm.Show();
            this.Close();
        }
    }
}