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
using Software_Testing_LastProject.Model;

namespace Software_Testing_LastProject.Views.Fixtures
{
    public partial class FixtureProductAddForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FixtureProductAddForm()
        {
            InitializeComponent();
        }

        private void FixtureProductAddForm_Load(object sender, EventArgs e)
        {
            GetStocks();
            Tools.ComboBoxFakulteGetir(cmb_Faculties);
            Tools.ComboBoxKategorileriGetir(cmb_Categories);
            

        }

        private void GetStocks()
        {
            Tools.StoklariGrideDoldur(grid_Urunler,gridView_Urun);
            
        }

        private bool drm = false;
        private int _productBuyId;
        private string _productName;
        private int _selectedQuantity;
        private void btn_DemirbasListe_ItemClick(object sender, ItemClickEventArgs e)
        {
            FixturesListsForm x = new FixturesListsForm();
            x.ShowDialog();
        }

        private void btn_DemirbasEkle_Click_1(object sender, EventArgs e)
        {
           
            try
            {

                if (string.IsNullOrEmpty(cmb_Faculties.SelectedValue.ToString()))
                {
                    throw new Exception("Lütfen Fakülte ve Departman Bilgilerini Kontrol Ediniz !");

                }
                if (string.IsNullOrEmpty(_productName) || _productBuyId == 0)
                {
                    throw new Exception("Lütfen Demirbaş Olacak Ürünü Seçiniz !");
                }
                if (string.IsNullOrEmpty(txt_Adet.Text) || short.Parse(txt_Adet.Text) == 0 || short.Parse(txt_Adet.Text) < 0)
                {
                    throw new Exception("Lütfen Adet Bilgisini Kontrol Ediniz !");
                }
                if (short.Parse(txt_Adet.Text)>_selectedQuantity)
                {
                    throw new Exception("Stok Miktarındakinden Fazla Ürün Demirbaşa Eklenemez ! !");
                }

               
                DemirbasViewModel model = new DemirbasViewModel
                {
                    Fakulte = { FakulteId = Convert.ToInt32(cmb_Faculties.SelectedValue) },
                    Bolum = { BolumId = Convert.ToInt32(cmb_Departments.SelectedValue) },
                    Kategori = { KategoriId = Convert.ToInt32(cmb_Categories.SelectedValue) },
                    Demirbas =
                    {
                        DemirbasAciklama = txt_Aciklama.Text,
                        DemirbasAdedi = Convert.ToInt32(txt_Adet.Text)
                    },
                    Urun = { UrunId = _productBuyId }
                };
                DemirbaslarController.DemirbasEkle(model);
                MessageBox.Show("Demirbaş Başarıyla Eklendi !", "Demirbaş Eklendi !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetStocks();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Dikkat !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmb_Faculties_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmb_Faculties.SelectedIndex == -1) return;
            int fakulteId = int.Parse(cmb_Faculties.SelectedValue.ToString());
            Tools.ComboBoxBolumGetir(cmb_Departments,fakulteId);
        }

        private void gridView_Urun_RowClick_1(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                _productName = gridView_Urun.GetRowCellValue(gridView_Urun.FocusedRowHandle, "UrunAdi").ToString();
                _productBuyId = int.Parse(gridView_Urun.GetRowCellValue(gridView_Urun.FocusedRowHandle, "UrunId").ToString());
                _selectedQuantity = int.Parse(gridView_Urun.GetRowCellValue(gridView_Urun.FocusedRowHandle, "Adet").ToString());
                if (_selectedQuantity == 0)
                {
                    btn_DemirbasEkle.Enabled = false;
                    throw new Exception("Ürün Stoklarda Bulunmadığı Üzerinde İçin İşlem Yapılamaz !");
                }
                else
                {
                    btn_DemirbasEkle.Enabled = true;
                }
                lbl_UrunAdi.Text = _productName;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Dikkat !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void txt_Adet_KeyPress(object sender, KeyPressEventArgs e)
        {
            Tools.SadeceSayi(sender,e);
        }

        private void cmb_Faculties_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void btn_OdaDemirbasAta_ItemClick(object sender, ItemClickEventArgs e)
        {
            DemirbasOdaTanimlaForm dotForm = new DemirbasOdaTanimlaForm();
            this.Close();
            dotForm.Show();
            
        }
    }
}