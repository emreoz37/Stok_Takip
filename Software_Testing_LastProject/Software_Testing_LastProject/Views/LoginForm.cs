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
using Software_Testing_LastProject.Views.Users;

namespace Software_Testing_LastProject.Views
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        public static string _session { get; set; }
        public static int _userIdSession { get; set; }
        private void btn_AdminGiris_ItemClick(object sender, TileItemEventArgs e)
        {
            AdminLoginForm ALF = new AdminLoginForm();
            ALF.Show();
            this.Hide();
        }

        private void tileItem2_ItemClick(object sender, TileItemEventArgs e)
        {
            StandartLoginForm slForm=new StandartLoginForm();
            slForm.Show();
            this.Hide();
        }
    }
}