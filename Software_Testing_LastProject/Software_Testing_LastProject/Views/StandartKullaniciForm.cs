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
using Software_Testing_LastProject.Views.Fixtures;
using Software_Testing_LastProject.Views.Persons;
using Software_Testing_LastProject.Views.Product;
using Software_Testing_LastProject.Views.Rooms;

namespace Software_Testing_LastProject.Views
{
    public partial class StandartKullaniciForm : DevExpress.XtraEditors.XtraForm
    {
        public StandartKullaniciForm()
        {
            InitializeComponent();
        }

        private void btn_DemirbasListele_ItemClick(object sender, TileItemEventArgs e)
        {
            FixturesListsForm flForm=new FixturesListsForm();
            flForm.ShowDialog();
        }

        private void btn_OdaTanimla_ItemClick(object sender, TileItemEventArgs e)
        {
            AddRoomAdmin adaForm=new AddRoomAdmin();
            adaForm.ShowDialog();
        }

        private void btn_OdaListele_ItemClick(object sender, TileItemEventArgs e)
        {
            RoomsListForm rlForm=new RoomsListForm();
            rlForm.ShowDialog();
        }

        private void btn_OdaSorumluListele_ItemClick(object sender, TileItemEventArgs e)
        {
            ListRoomAdmin lfaForm = new ListRoomAdmin();
            lfaForm.ShowDialog();
        }

        private void btn_PersonelIslem_ItemClick(object sender, TileItemEventArgs e)
        {
            PersonListsForm plForm = new PersonListsForm();
            plForm.ShowDialog();
        }

        private void btn_StokListele_ItemClick(object sender, TileItemEventArgs e)
        {
            ProductStockListForm pslForm=new ProductStockListForm();
            pslForm.ShowDialog();
        }

        private void tileItem16_ItemClick(object sender, TileItemEventArgs e)
        {
            Application.Exit();
        }
    }
}