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
using Software_Testing_LastProject.Views.Reports;
using Software_Testing_LastProject.Views.Rooms;


namespace Software_Testing_LastProject.Views
{
    public partial class GeneralForm : DevExpress.XtraEditors.XtraForm
    {
        public GeneralForm()
        {
            InitializeComponent();
        }

        private void GeneralForm_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_StokGirisi_ItemClick(object sender, TileItemEventArgs e)
        {
            AddProductForm apf=new AddProductForm();
            apf.ShowDialog();

        }

        private void btn_StokListele_ItemClick(object sender, TileItemEventArgs e)
        {
            ProductStockListForm psListForm=new ProductStockListForm();
            psListForm.ShowDialog();
        }

        private void btn_DemirbasEkle_ItemClick(object sender, TileItemEventArgs e)
        {
            FixtureProductAddForm fpAddForm=new FixtureProductAddForm();
            fpAddForm.ShowDialog();
        }

        private void tileItem14_ItemClick(object sender, TileItemEventArgs e)
        {
            FixturesListsForm flForm=new FixturesListsForm();
            flForm.ShowDialog();
        }

        private void btn_RaporIslem_ItemClick(object sender, TileItemEventArgs e)
        {
            ReportsForm rpForm=new ReportsForm();
            rpForm.ShowDialog();
        }

        private void btn_OdaTanimla_ItemClick(object sender, TileItemEventArgs e)
        {
            OdaEkle roomsForm=new OdaEkle();
            roomsForm.ShowDialog();
        }

        private void btn_OdaListele_ItemClick(object sender, TileItemEventArgs e)
        {
            RoomsListForm roomsListForm = new RoomsListForm();
            roomsListForm.ShowDialog();
        }

        private void btn_PersonelIslem_ItemClick(object sender, TileItemEventArgs e)
        {
            PersonListsForm plForm=new PersonListsForm();
            plForm.ShowDialog();
        }

        private void btn_OdaSorumluListele_ItemClick(object sender, TileItemEventArgs e)
        {
            ListRoomAdmin lfaForm=new ListRoomAdmin();
            lfaForm.ShowDialog();
        }

        private void tileItem16_ItemClick(object sender, TileItemEventArgs e)
        {
            Application.Exit();
        }
    }
}