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

namespace Software_Testing_LastProject.Views.Fixtures
{
    public partial class DemirbasOdaTanimlaForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public DemirbasOdaTanimlaForm()
        {
            InitializeComponent();
        }

        private void DemirbasOdaTanimlaForm_Load(object sender, EventArgs e)
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
            grid_Oda.DataSource = dtBitenStokList;
            gridView_Oda.Columns["OdaId"].Visible = false;


            Tools.DemirbaslariGrideDoldur(grid_Demirbas,gridView_Demirbas);
        }

        private int odaId, demirbasId,secilenAdet;

  

        private void gridView_Oda_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            odaId = int.Parse(gridView_Oda.GetRowCellValue(gridView_Oda.FocusedRowHandle, "OdaId").ToString());
            lbl_oda.Text = string.Empty;
            lbl_oda.Text += "Seçilen Oda: "+gridView_Oda.GetRowCellValue(gridView_Oda.FocusedRowHandle, "OdaAdi");
        }

        private void gridView_Demirbas_RowClick_1(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            demirbasId = int.Parse(gridView_Demirbas.GetRowCellValue(gridView_Demirbas.FocusedRowHandle, "DemirbasNo").ToString());
            secilenAdet = int.Parse(gridView_Demirbas.GetRowCellValue(gridView_Demirbas.FocusedRowHandle, "DemirbasAdedi").ToString());
            lbl_demirbas.Text = string.Empty;
            lbl_demirbas.Text += "Seçilen Demirbaş: "+gridView_Demirbas.GetRowCellValue(gridView_Demirbas.FocusedRowHandle, "DemirbasAdi");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Tools.SadeceSayi(sender,e);
        }

        

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_Adet.Text) || int.Parse(txt_Adet.Text)<=0)
                {
                    throw new Exception("Lütfen Demirbaş Adedini Kontrol Ediniz !");
                }
                if (odaId==0 || demirbasId==0)
                {
                    throw new Exception("Lütfen Oda Ve Demirbaş Seçimlerinizi Kontrol Ediniz Bu Değerler Boş Geçilemez !");
                }
                int adet = int.Parse(txt_Adet.Text);
                if (adet>secilenAdet)
                {
                    throw new Exception("Adet Bilgisi Var Olan Adetten Sayısından Büyük Girilemez!");
                }
                DemirbasOdaKisiController.OdayaDemirbasEkle(demirbasId,odaId,adet);
                MessageBox.Show("İşlem Başarılı !", "Başarılı !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("Eklendi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Dikkat !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}