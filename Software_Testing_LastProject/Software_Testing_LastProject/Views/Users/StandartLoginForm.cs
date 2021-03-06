﻿using System;
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

namespace Software_Testing_LastProject.Views.Users
{
    public partial class StandartLoginForm : DevExpress.XtraEditors.XtraForm
    {
        public StandartLoginForm()
        {
            InitializeComponent();
        }

        private void btn_Giris_Click(object sender, EventArgs e)
        {
            try
            {
                Kullanicilar user = new Kullanicilar();
                user.KullaniciAdi = txt_KullaniciAdi.Text;
                user.Sifre = txt_Sifre.Text;
                string md5 =Tools.CreateMD5(user.Sifre);
               
                if (string.IsNullOrEmpty(user.KullaniciAdi) || string.IsNullOrEmpty(md5))
                {
                    throw new ValidationException("Kullanıcı Adı ve Şifre Boş Geçilemez !");
                }
                user.Sifre = md5;
                var result = UsersController.UserStandartLogin(user);
                LoginForm._session = ERoles.Standart.ToString();
                LoginForm._userIdSession = result.KullaniciId;
                StandartKullaniciForm skForm = new StandartKullaniciForm();
                skForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Meydana Geldi !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void StandartLoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm lf=new LoginForm();
            lf.Show();
        }

    }
}