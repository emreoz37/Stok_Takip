using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Software_Testing_LastProject.Controller;

namespace Software_Testing_LastProject.Views.Rooms
{
    public partial class OdaEkle : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public OdaEkle()
        {
            InitializeComponent();
        }

        private void OdaEkle_Load(object sender, EventArgs e)
        {
            Tools.ComboBoxFakulteGetir(cmb_Fakulte);
        }

        private void cmb_Fakulte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Fakulte.SelectedIndex == -1) return;
            int fakulte = int.Parse(cmb_Fakulte.SelectedValue.ToString());
            Tools.ComboBoxBolumGetir(cmb_Departman,fakulte);
        }

        private void btn_OdaDuzenle_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_OdaAdi.Text))
                {
                    throw new ValidationException("Oda Adını Boş Geçemezsiniz !");
                }
                OdaController.OdaEkle(txt_OdaAdi.Text,Convert.ToInt32(cmb_Departman.SelectedValue));
                MessageBox.Show("Oda Başarıyla Eklendi !", "İşlem Başarılı !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AddRoomAdmin adForm=new AddRoomAdmin();
                adForm.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Meydana Geldi !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddRoomAdmin adForm = new AddRoomAdmin();
            adForm.Show();
            this.Close();
        }
    }
}
