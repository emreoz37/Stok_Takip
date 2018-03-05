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
using Software_Testing_LastProject.Views.Fixtures;

namespace Software_Testing_LastProject.Views.Rooms
{
    public partial class ListRoomAdmin : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public ListRoomAdmin()
        {
            InitializeComponent();
        }

        private void ListRoomAdmin_Load(object sender, EventArgs e)
        {
            var result = DemirbasOdaKisiController.OdaSorumlulariListele();
            DataTable dt=new DataTable("odaSorumlulari");
            dt.Columns.Add("AdSoyad", typeof(string));
            dt.Columns.Add("KisiId", typeof(int));
            dt.Columns.Add("OdaAdi", typeof(string));
            dt.Columns.Add("OdaId", typeof(int));
            foreach (var item in result)
            {
                dt.Rows.Add(item.Kisi.Ad + " " + item.Kisi.Soyad ,item.Kisi.KisiId,item.Oda.OdaAdi,item.Oda.OdaId);
            }
            grid_OdaYetkilileri.DataSource = dt;
            gridView_OdaYetkilileri.Columns["OdaId"].Visible = false;
            gridView_OdaYetkilileri.Columns["KisiId"].Visible = false;
        }

        public static string odaAdi { get; set; }
        public static string odaSorumlusu { get; set; }
        private void gridView_OdaYetkilileri_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            odaAdi = gridView_OdaYetkilileri.GetRowCellValue(gridView_OdaYetkilileri.FocusedRowHandle, "OdaAdi")
                .ToString();
            odaSorumlusu = gridView_OdaYetkilileri.GetRowCellValue(gridView_OdaYetkilileri.FocusedRowHandle, "AdSoyad")
                .ToString();
            int odaId = Convert.ToInt32(gridView_OdaYetkilileri.GetRowCellValue(gridView_OdaYetkilileri.FocusedRowHandle, "OdaId").ToString());
            OdaZimmetleriGetirForm ozgForm=new OdaZimmetleriGetirForm(odaId);
            ozgForm.ShowDialog();
            
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }
    }
}