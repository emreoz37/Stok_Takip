using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Security.Authentication;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Software_Testing_LastProject.Controller;
using Software_Testing_LastProject.Model;

namespace Software_Testing_LastProject.Test
{
    [TestClass]
    public class ProjectTest1
    {
       
        [TestMethod]
        [ExpectedException(typeof(AuthenticationException))]
        public void KullaniciGirisi()
        {
            var kullanici=new Kullanicilar();
            UsersController.UserAdminLogin(kullanici);

        }

        [TestMethod]
        [ExpectedException(typeof(ValidationException))]
        public void UrunEkle()
        {
            Urunler urun = null;
            int stok = 0;
            UrunController.UrunEkle(urun,stok);
        }

        [TestMethod]
        [ExpectedException(typeof(ValidationException))]
        public void OdaEkle()
        {
            OdaController.OdaDetayiGetir(0);
        }

    }
}
