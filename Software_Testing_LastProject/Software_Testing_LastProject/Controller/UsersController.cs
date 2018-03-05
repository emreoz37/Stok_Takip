using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;
using Software_Testing_LastProject.Model;
namespace Software_Testing_LastProject.Controller
{
    public static class UsersController
    {
        public static Kullanicilar UserAdminLogin(Kullanicilar modelUser)
        {
            if (string.IsNullOrEmpty(modelUser.KullaniciAdi)&&string.IsNullOrEmpty(modelUser.Sifre))
            {
                throw new AuthenticationException("Kullanici Verileri Boş Geçilemez !");
            }
            using (var context=new DatabaseContext())
            {
                var result = context.Kullanicilars.FirstOrDefault(x =>x.KullaniciAdi == modelUser.KullaniciAdi && x.Sifre == modelUser.Sifre);
                
                if (result == null || result.Silindi==Convert.ToBoolean(EDeleted.silindi))
                {
                    throw new AuthenticationException("Kullanıcı Girişi Başarısız !");
                }
                var roleResult = context.Kullanici_Role.FirstOrDefault(x => x.KullaniciId == result.KullaniciId);
                if (roleResult.RoleId!=(int)ERoles.Admin)
                {
                    throw new AuthenticationException("Kullanıcı Bilgileriniz Bu Sayfayı Açmak İçin Yeterli Değil ! \n Lütfen Standart Kullanıcı Biriminden Giriş Yapınız !");
                }
                UserLoginDate(result);
               return result;
            }
        }
        public static Kullanicilar UserStandartLogin(Kullanicilar modelUser)
        {
            if (modelUser == null)
            {
                throw new ValidationException("Lütfen Kullanıcı Bilgilerinizi Lütfen Boş Geçmeyiniz !");
            }
            using (var context = new DatabaseContext())
            {
                var result = context.Kullanicilars.FirstOrDefault(x => x.KullaniciAdi == modelUser.KullaniciAdi && x.Sifre == modelUser.Sifre);
                if (result == null || result.Silindi == Convert.ToBoolean(EDeleted.silindi))
                {
                    throw new AuthenticationException("Kullanıcı Girişi Başarısız !");
                }
                var roleResult = context.Kullanici_Role.FirstOrDefault(x => x.KullaniciId == result.KullaniciId);
                if (roleResult.RoleId != (int)ERoles.Standart)
                {
                    throw new AuthenticationException("Yönetici Bilgileri İle Giriş Yapıyorsunuz !\nLütfen Yönetici Kullanıcı Biriminden Giriş Yapınız !");
                }
                UserLoginDate(result);
                return result;
            }
        }
        private static void UserLoginDate(Kullanicilar modelUser)
        {
            using (var context=new DatabaseContext())
            {
                var result  = context.Kullanicilars.FirstOrDefault(x=>x.KullaniciId==modelUser.KullaniciId);
                if (result!=null)
                {
                    result.SonGirisTarihi = DateTime.Now;
                    context.Entry(result).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                }
            }
        }
        
    }

}
