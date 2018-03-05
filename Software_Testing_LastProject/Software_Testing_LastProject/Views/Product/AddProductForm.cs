using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
    public partial class AddProductForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public AddProductForm()
        {
            InitializeComponent();
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {
           Tools.ComboBoxKategorileriGetir(cmb_UrunKategori);
        }

        private void JustNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            Tools.SadeceSayi(sender,e);
        }

        private void btn_UrunEkle_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime selectedDate = Convert.ToDateTime(calendarControl1.SelectionStart.ToShortDateString());
                if (string.IsNullOrEmpty(txt_UrunAdi.Text) || string.IsNullOrEmpty(txt_UrunBirimFiyat.Text) || string.IsNullOrEmpty(txt_urunAdet.Text))
                {
                    throw new ValidationException("Ürün Bilgileri Boş Geçilemez !");
                }
                if (int.Parse(txt_urunAdet.Text)<=0)
                {
                    throw new ValidationException("Stok Değeri Sıfır veya Daha Düşük Değerler Olamaz !");
                }
                if (selectedDate > DateTime.Now)
                {
                    throw new ValidationException("Satın alma tarihi bugünden daha sonraki bir tarih olamaz!");
                }

                Urunler urun = new Urunler();
                urun.UrunAdi = txt_UrunAdi.Text;
                urun.UrunBirimFiyati = decimal.Parse(txt_UrunBirimFiyat.Text);
                urun.SatinAlinmaTarihi = selectedDate;
                urun.KategoriId = Convert.ToInt32(cmb_UrunKategori.SelectedValue);
                UrunController.UrunEkle(urun,int.Parse(txt_urunAdet.Text));
                MessageBox.Show("Ürün Başarıyla Stok'a Eklendi !","İşlem Başarılı !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Meydana Geldi !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }
    }
}