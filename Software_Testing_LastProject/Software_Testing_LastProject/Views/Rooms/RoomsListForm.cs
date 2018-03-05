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
using Software_Testing_LastProject.Views.Fixtures;
using Software_Testing_LastProject.Views.Reports;


namespace Software_Testing_LastProject.Views.Rooms
{
    public partial class RoomsListForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public RoomsListForm()
        {
            InitializeComponent();
        }

        private int odaId;
        private void RoomsListForm_Load(object sender, EventArgs e)
        {
            if (LoginForm._session==ERoles.Standart.ToString())
            {
                btn_OdaTanimla.Enabled = false;
            }
            var result = OdaController.TumOdalariGetir();
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
        }

        private void btn_OdaTanimla_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OdaEkle adForm = new OdaEkle();
            this.Close();
            adForm.Show();
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }
        private void gridView_OdaListesi_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            string odaAdi = gridView_OdaListesi.GetRowCellValue(gridView_OdaListesi.FocusedRowHandle, "OdaAdi").ToString();
            odaId = Convert.ToInt32(gridView_OdaListesi.GetRowCellValue(gridView_OdaListesi.FocusedRowHandle, "OdaId"));
            DialogResult sonuc = MessageBox.Show(odaAdi + " İsimli Oda Detaylarına Bakmak İçin Evet \n Oda Demirbaş Listesini Görmek İçin Hayır'ı Seçin !", "Öneri ?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (sonuc==DialogResult.Yes)
            {
                EditRoomForm erForm = new EditRoomForm(odaId);
                this.Close();
                erForm.Show();
            }
            else if (sonuc == DialogResult.No)
            {
                OdaZimmetleriGetirForm ozGetirForm=new OdaZimmetleriGetirForm(odaId);
                this.Close();
                ozGetirForm.Show();
            }
        }
    }
}