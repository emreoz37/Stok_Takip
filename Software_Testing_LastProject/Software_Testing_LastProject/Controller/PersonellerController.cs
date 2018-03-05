using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Software_Testing_LastProject.Model;

namespace Software_Testing_LastProject.Controller
{
    public static class PersonellerController
    {
        public static List<Kisiler> KullanicilariListele()
        {
            using (var context=new DatabaseContext())
            {
                var result = context.Kisilers;
                return result.ToList();
            }
        }
        public static KisiKullaniciViewModel KisiGetir(int kisiId)
        {
            if (kisiId==0)
            {
                throw new TargetParameterCountException("Kullanici Getirilemedi !");
            }
            using (var context = new DatabaseContext())
            {
                var result = from kisi in context.Kisilers
                    join kullanici in context.Kullanicilars on kisi.KisiId equals kullanici.KullaniciId
                    join kullaniciRol in context.Kullanici_Role on kullanici.KullaniciId equals kullaniciRol.KullaniciId
                    join rol in context.Rollers on kullaniciRol.RoleId equals rol.RoleId
                    select new KisiKullaniciViewModel
                    {
                        Kisi = kisi,
                        Kullanici = kullanici,
                        Rol = rol
                    };
                return result.FirstOrDefault(x => x.Kisi.KisiId == kisiId);
            }
        }

        public static List<OdaKisiViewModel> KullaniciZimmetleri(int kisiId)
        {
            using (var context = new DatabaseContext())
            {
                var result = from oda in context.Odalars
                    join zim in context.Zimmetlers on oda.OdaId equals zim.OdaId
                    join demirbasOda in context.Demirbas_Oda on zim.ZimmetId equals demirbasOda.ZimmetId
                    join db in context.Demirbaslars on demirbasOda.DemirbasId equals db.DemirbasNo
                    join k in context.Kisilers on zim.KisiId equals k.KisiId select new OdaKisiViewModel
                    {
                        Kisi = k,
                        Oda = oda,
                        Zimmet = zim,
                        Demirbas = db
                    };
                return result.Where(x => x.Kisi.KisiId==kisiId).ToList();
            }
        }

        public static List<OdaKisiViewModel> KullaniciSorumluOdalar(int kisiId)
        {
            using (var context = new DatabaseContext())
            {
                var result = from oda in context.Odalars
                    join zim in context.Zimmetlers on oda.OdaId equals zim.OdaId
                    join k in context.Kisilers on zim.KisiId equals k.KisiId
                     select new OdaKisiViewModel
                    {
                        Kisi = k,
                        Oda = oda,
                        Zimmet = zim,
                        
                    };
                return result.Where(x => x.Kisi.KisiId == kisiId).ToList();
            }
        }

    }
}
