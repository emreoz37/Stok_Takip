using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using Software_Testing_LastProject.Controller;
using Software_Testing_LastProject.Model;

namespace Software_Testing_LastProject.Views.Rooms
{
    public partial class EditRoomForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private int _odaId;
        public EditRoomForm(int odaId)
        {
            if (odaId == 0) return;
            this._odaId = odaId;
            InitializeComponent();
        }

        private void btn_OdaListele_ItemClick(object sender, ItemClickEventArgs e)
        {
            RoomsListForm rlForm=new RoomsListForm();
            this.Close();
            rlForm.Show();
        }

        private void btn_Ekle_ItemClick(object sender, ItemClickEventArgs e)
        {
            //AddRoomForm arForm=new AddRoomForm();
            //this.Close();
            //arForm.Show();
        }

        private void EditRoomForm_Load(object sender, EventArgs e)
        {
            if (LoginForm._session==ERoles.Standart.ToString())
            {
                btn_Ekle.Enabled = false;
                btn_OdaSil.Enabled = false;
            }
            Tools.ComboBoxFakulteGetir(cmb_Fakulte);
            var result = OdaController.OdaDetayiGetir(_odaId);
            cmb_Fakulte.SelectedValue = result.Bolum.FakulteId;
            cmb_Departman.SelectedValue = result.Bolum.BolumId;
            txt_OdaAdi.Text = result.Oda.OdaAdi;

            var kullanicilariListele = PersonellerController.KullanicilariListele();
            DataTable dtKullancilar = new DataTable("personller");
            dtKullancilar.Columns.Add("Ad", typeof(string));
            dtKullancilar.Columns.Add("Soyad", typeof(string));
            dtKullancilar.Columns.Add("KisiId", typeof(int));
            foreach (var item in kullanicilariListele)
            {
                dtKullancilar.Rows.Add(item.Ad, item.Soyad, item.KisiId);
            }
            grid_Kisiler.DataSource = dtKullancilar;
        }

        private void cmb_Fakulte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Fakulte.SelectedIndex == -1) return;
            int fakulteId = int.Parse(cmb_Fakulte.SelectedValue.ToString());
            Tools.ComboBoxBolumGetir(cmb_Departman, fakulteId);
        }

        private int kisiId;
        private void btn_OdaDuzenle_Click(object sender, EventArgs e)
        {
            try
            {
                if (kisiId==0)
                {
                    throw new Exception("Kişi Seçmediniz !");

                }
                if (string.IsNullOrEmpty(txt_OdaAdi.Text))
                {
                    throw  new Exception("Oda Adı Boş Geçilemez !");
                }
                OdaController.OdaGuncelle(this._odaId, txt_OdaAdi.Text, Convert.ToInt32(cmb_Departman.SelectedValue), kisiId);
                MessageBox.Show("Güncelleme Başarılı !", "Bilgi !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Bilgi !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btn_OdaSil_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                DialogResult sonuc = MessageBox.Show("Oda Silinecektir !", "Uyarı !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (sonuc == DialogResult.Yes)
                {
                    OdaController.OdaSil(_odaId);
                    MessageBox.Show("Oda Silindi !\nOdalar Listesine Yönlendiriliyorsunuz !", "Bilgi !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Thread.Sleep(500);
                    RoomsListForm rlForm = new RoomsListForm();
                    this.Close();
                    rlForm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Odaya Bağlı Zimmetler Vardır Oda Silinemez  !", "Bilgi !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void gridView_Kisiler_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            kisiId = Convert.ToInt32(gridView_Kisiler.GetRowCellValue(gridView_Kisiler.FocusedRowHandle, "KisiId"));
        }
    }
}