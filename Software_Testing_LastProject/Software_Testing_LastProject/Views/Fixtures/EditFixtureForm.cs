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

namespace Software_Testing_LastProject.Views.Fixtures
{
    public partial class EditFixtureForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public EditFixtureForm(int demirbasNo)
        {
            if(demirbasNo==0)return;
            this.demirbasNo = demirbasNo;
            InitializeComponent();
        }

        public int demirbasNo;
        private void EditFixtureForm_Load(object sender, EventArgs e)
        {
            Tools.ComboBoxKategorileriGetir(cmb_Categories);
            Tools.ComboBoxFakulteGetir(cmb_Faculties);

            DemirbasGetir();
        }

        private void DemirbasGetir()
        {
            var result = DemirbaslarController.DemirbasGetir(demirbasNo);
            lbl_SeciliUrun.Text =lbl_DemirbasAciklama.Text = lbl_DemirbasAdet.Text = lbl_DemirbasKod.Text = string.Empty;
            lbl_DemirbasAdet.Text ="Demirbaş Adeti: "; lbl_DemirbasAdet.Text += txt_Adet.Text = result.DemirbasAdedi.ToString();
            lbl_DemirbasAciklama.Text = "Demirbaş Açıklama"; lbl_DemirbasAciklama.Text += txt_Aciklama.Text= result.DemirbasAciklama;
            lbl_DemirbasKod.Text = "Demirbaş Kod: "; lbl_DemirbasKod.Text+= result.DemirbasKodu;
        }

        private void cmb_Faculties_SelectedIndexChanged(object sender, EventArgs e)
        {
            int fakulteId = int.Parse(cmb_Faculties.SelectedValue.ToString());
            Tools.ComboBoxBolumGetir(cmb_Departments,fakulteId);
            
        }

        private void btn_DemirbasEkle_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (string.IsNullOrEmpty(cmb_Faculties.SelectedValue.ToString()))
                {
                    throw new Exception("Lütfen Fakülte ve Departman Bilgilerini Kontrol Ediniz !");

                }

                if (string.IsNullOrEmpty(txt_Adet.Text) || short.Parse(txt_Adet.Text) < 0)
                {
                    throw new Exception("Lütfen Adet Bilgisini Kontrol Ediniz !");
                }
                
                DemirbaslarController.DemirbasGuncelle(demirbasNo,Convert.ToInt32(cmb_Faculties.SelectedValue.ToString()), Convert.ToInt32(cmb_Departments.SelectedValue.ToString()), Convert.ToInt32(cmb_Categories.SelectedValue.ToString()),Convert.ToInt32(txt_Adet.Text),txt_Aciklama.Text);
                MessageBox.Show("İşlem Başarılı !", "Başarılı !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DemirbasGetir();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Dikkat !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void txt_Adet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cmb_Faculties_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }
    }
}