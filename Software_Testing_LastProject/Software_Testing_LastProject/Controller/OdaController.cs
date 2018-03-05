using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Software_Testing_LastProject.Model;

namespace Software_Testing_LastProject.Controller
{
    public static class OdaController
    {
        public static void OdaEkle(string odaAdi,int bolumId)
        {
            if (string.IsNullOrEmpty(odaAdi)||bolumId==0)
            {
                throw new ValidationException("OdaAdi ve BolumId Boş Geçilemez !");
            }
            var result = TumOdalariGetir().FirstOrDefault(x => x.Oda.OdaAdi == odaAdi);
            if (result!=null)
            {
                throw new Exception("Bu isimdeki oda mevcuttur!");
            }
            using (var context = new DatabaseContext())
            {
                context.sp_OdaEkle(odaAdi, bolumId);
            }
            
        }
        public static void OdaGuncelle(int odaId,string odaAdi, int bolumId,int kisiId)
        {
            using (var context = new DatabaseContext())
            {
                context.sp_OdaGuncelle(odaId, odaAdi, bolumId,kisiId);
            }
        }
        public static void OdaSil(int odaId)
        {
            using (var context = new DatabaseContext())
            {
                var result = context.Odalars.FirstOrDefault(x => x.OdaId == odaId);
                context.Entry(result).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }
        public static OdaFakulteBolumViewModel OdaDetayiGetir(int odaId)
        {
            if (odaId==0)
            {
                throw new ValidationException("Oda Id Boş Geldi !");
            }
            var result = TumOdalariGetir().FirstOrDefault(x => x.Oda.OdaId == odaId);
            return result;
        }

        //Sorgu Stored Procedure Olduğu için IEnumarable<object> halinde dönmek zorunda çünkü complex type bir nesne geriye döndüğü için class hali mevcut değil.
        public static IEnumerable<object> OdaDemirbaslariList(int odaId)
        {
            using (var context = new DatabaseContext())
            {
                var result = context.sp_Odadaki_Demirbaslar02(odaId);
                return result.ToList();
            }
        }
        public static List<OdaFakulteBolumViewModel> TumOdalariGetir()
        {
            using (var context = new DatabaseContext())
            {
                var result = from odaFakulteBolum in context.OdaFakulteBolums
                    join oda in context.Odalars on odaFakulteBolum.OdaId equals oda.OdaId
                    join bolum in context.Bolumlers on odaFakulteBolum.BolumId equals bolum.BolumId
                    join fakulte in context.Fakultelers on bolum.FakulteId equals fakulte.FakulteId
                    select new OdaFakulteBolumViewModel
                    {
                        Bolum = bolum,
                        Fakulte = fakulte,
                        Oda = oda
                    };
                return result.ToList();
            }
        }

        public static void OdaYetkilendir(int kisiId, int OdaId)
        {
            using (var context = new DatabaseContext())
            {
                Zimmetler z = new Zimmetler();
                z.KisiId = kisiId;
                z.OdaId = OdaId;
                context.Zimmetlers.Add(z);
                context.SaveChanges();

            }
        }
    }
}
