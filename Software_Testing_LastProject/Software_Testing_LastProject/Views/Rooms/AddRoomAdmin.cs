using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using Software_Testing_LastProject.Controller;

namespace Software_Testing_LastProject.Views.Rooms
{
    public partial class AddRoomAdmin : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public AddRoomAdmin()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private int kisiId, odaId;
        private void btn_Yetkilendir_Click(object sender, EventArgs e)
        {

            try
            {
                if (kisiId==0 || odaId == 0)
                {
                    throw new Exception("Kişi veya Oda Seçmediniz Lütfen Kontrol Edin !");
                }
                OdaController.OdaYetkilendir(kisiId,odaId);
                MessageBox.Show("Yetkilendirme Başarılı !", "Bilgi !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Meydana Geldi !", MessageBoxButtons.OK, MessageBoxIcon.Information); 
               
            }

        }

        private void AddRoomAdmin_Load(object sender, EventArgs e)
        {
            var odalarListesi = OdaController.TumOdalariGetir();
            DataTable dtBitenStokList = new DataTable("odalarListesi");
            dtBitenStokList.Columns.Add("OdaId", typeof(int));
            dtBitenStokList.Columns.Add("OdaAdi", typeof(string));
            dtBitenStokList.Columns.Add("BolumAdi", typeof(string));
            dtBitenStokList.Columns.Add("FakulteAdi", typeof(string));
            foreach (var item in odalarListesi)
            {
                dtBitenStokList.Rows.Add(item.Oda.OdaId, item.Oda.OdaAdi, item.Bolum.BolumAdi, item.Fakulte.FakulteAdi);
            }
            grid_OdaListesi.DataSource = dtBitenStokList;
            gridView_OdaListesi.Columns["OdaId"].Visible = false;

            var kullanicilariListele = PersonellerController.KullanicilariListele();
            DataTable dtKullancilar = new DataTable("personller");
            dtKullancilar.Columns.Add("Ad", typeof(string));
            dtKullancilar.Columns.Add("Soyad", typeof(string));
            dtKullancilar.Columns.Add("KisiId", typeof(int));
            foreach (var item in kullanicilariListele)
            {
                dtKullancilar.Rows.Add(item.Ad, item.Soyad, item.KisiId);
            }
            grid_personelListesi.DataSource = dtKullancilar;
           

        }

        private void gridView_personelListesi_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            string personelAdi = gridView_personelListesi.GetRowCellValue(gridView_personelListesi.FocusedRowHandle, "Ad")+" "+ gridView_personelListesi.GetRowCellValue(gridView_personelListesi.FocusedRowHandle, "Soyad").ToString();
            lbl_PersonelBilgi.Text = personelAdi;
            kisiId = Convert.ToInt32(gridView_personelListesi.GetRowCellValue(gridView_personelListesi.FocusedRowHandle, "KisiId"));
        }

        private void gridView_OdaListesi_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            string odaAdi = gridView_OdaListesi.GetRowCellValue(gridView_OdaListesi.FocusedRowHandle, "OdaAdi").ToString();
            lbl_OdaAdi.Text = odaAdi;
            odaId = Convert.ToInt32(gridView_OdaListesi.GetRowCellValue(gridView_OdaListesi.FocusedRowHandle, "OdaId"));
        }
    }
}