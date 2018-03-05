using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraExport;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.ReportGeneration;
using DevExpress.XtraReports.UI;
using Software_Testing_LastProject.Controller;
using Software_Testing_LastProject.Views.Personeller;
using Software_Testing_LastProject.Views.Rooms;
using DevExpress.XtraSpreadsheet;
using Binding = System.Windows.Forms.Binding;

namespace Software_Testing_LastProject.Views.Fixtures
{
    public partial class OdaZimmetleriGetirForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private int _odaId;
        public OdaZimmetleriGetirForm(int odaId)
        {
            if (odaId == 0) return;
            this._odaId = odaId;
            InitializeComponent();
        }

        private void OdaZimmetleriGetirForm_Load(object sender, EventArgs e)
        {
            var odaAdi=OdaController.OdaDetayiGetir(_odaId);
            var kisiAdi = DemirbasOdaKisiController.OdaSorumlulariListele().FirstOrDefault(x => x.Oda.OdaId == _odaId);
            lbl_OdaAdi.Text = "Oda Adı: " + odaAdi.Oda.OdaAdi;
            lbl_Sorumlu.Text = "Oda Sorumlusu: " + kisiAdi.Kisi.Ad + " " + kisiAdi.Kisi.Soyad;
            GetValue();
        }

        private void GetValue()
        {
            
            var result= OdaController.OdaDemirbaslariList(_odaId);
            grid_OdaDemirbaslari.DataSource = result;
            
            gridView_OdaDemirbaslari.Columns["DemirbasOdaId"].Visible = false;
            gridView_OdaDemirbaslari.IndicatorWidth = 30;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DokumAl("pdf");
           
        }

        private void DokumAl(string belgeTip)
        {
            /**Gelen Oda Zimmetlerini PDF veya Excel formatında dökümünün alınmasını sağlayan kod*/
            string[] sorumluAdi = lbl_Sorumlu.Text.Split(':');
            string[] odaBilgi = lbl_OdaAdi.Text.Split(':');
            DataTable dtZimmet = new DataTable();
            dtZimmet.Columns.Add("SiraNo", typeof(int));
            dtZimmet.Columns.Add("DemirbasKodu", typeof(string));
            dtZimmet.Columns.Add("DemirbasAdi", typeof(string));
            dtZimmet.Columns.Add("Adet", typeof(int));
            dtZimmet.Columns.Add("ZimmetSahibi", typeof(string));
            GridControl grid = new GridControl();
            GridView view = new GridView();

            grid.ViewCollection.Add(view);
            grid.MainView = view;
            view.GridControl = grid;
            GridColumn siraNo = view.Columns.Add();
            GridColumn demirbasKod = view.Columns.Add();
            GridColumn demirbasAdi = view.Columns.Add();
            GridColumn demirbasAdet = view.Columns.Add();
            GridColumn sorumlu = view.Columns.Add();
            int siraSayac = 1;
            for (int i = 0; i < gridView_OdaDemirbaslari.DataRowCount; i++)
            {

                dtZimmet.Rows.Add(siraSayac++,
                    gridView_OdaDemirbaslari.GetRowCellValue(i, "DemirbasKodu")
                        .ToString(),
                    gridView_OdaDemirbaslari.GetRowCellValue(i, "DemirbasAdi")
                        .ToString(),
                    gridView_OdaDemirbaslari.GetRowCellValue(i, "Adet")
                        .ToString(), sorumluAdi[1]);
            }

            sorumlu.Caption = "ZimmetSahibi";
            sorumlu.FieldName = "ZimmetSahibi";
            sorumlu.VisibleIndex = 0;
            sorumlu.Visible = true;

            demirbasAdet.Caption = "Adet";
            demirbasAdet.FieldName = "Adet";
            demirbasAdet.VisibleIndex = 0;
            demirbasAdet.Visible = true;

            demirbasAdi.Caption = "DemirbasAdi";
            demirbasAdi.FieldName = "DemirbasAdi";
            demirbasAdi.VisibleIndex = 0;
            demirbasAdi.Visible = true;

            demirbasKod.Caption = "DemirbasKodu";
            demirbasKod.FieldName = "DemirbasKodu";
            demirbasKod.VisibleIndex = 0;
            demirbasKod.Visible = true;

            siraNo.Caption = "SiraNo";
            siraNo.FieldName = "SiraNo";
            siraNo.VisibleIndex = 0;
            siraNo.Visible = true;

            grid.BindingContext = this.BindingContext;
            grid.DataSource = dtZimmet;
            if (belgeTip=="pdf")
            {
                grid.ExportToPdf("D:\\" + odaBilgi[1] + "." + belgeTip);
            }
            else
            {
                grid.ExportToXlsx("D:\\" + odaBilgi[1] + "." + belgeTip);
            }
            MessageBox.Show("Yerel Disk D üzerine Oda Zimmet Raporu Oluşturuldu !", "Uyarı !", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void gridView_OdaDemirbaslari_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int demirbasOdaNo = Convert.ToInt32(gridView_OdaDemirbaslari.GetRowCellValue(gridView_OdaDemirbaslari.FocusedRowHandle, "DemirbasOdaId").ToString());
            string  demirbasAdi = gridView_OdaDemirbaslari.GetRowCellValue(gridView_OdaDemirbaslari.FocusedRowHandle, "DemirbasAdi").ToString();
            DialogResult sonuc = MessageBox.Show(demirbasAdi+" Demirbaşı Silinsin Mi?", "Uyarı !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes)
            {
                DemirbasOdaKisiController.OdaDemirbasSil(demirbasOdaNo);
                GetValue();
            }
        }

        private void gridView_OdaDemirbaslari_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.RowHandle >= 0)
                e.Info.DisplayText = e.RowHandle.ToString();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DokumAl("xlsx");
        }

    }
}