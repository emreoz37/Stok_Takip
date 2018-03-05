using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Software_Testing_LastProject.Model;

namespace Software_Testing_LastProject.Controller
{
    public static class DemirbasOdaKisiController
    {
        public static void OdaDemirbasEkle(int demirbasId, int odaId,int adet)
        {
            using (var context=new DatabaseContext())
            {
                context.sp_OdayaDemirbasEkle(demirbasId, odaId,adet);
            }
        }

        public static void OdayaDemirbasEkle(int demirbasId, int odaId, int adet)
        {
            using (var context = new DatabaseContext())
            {
                context.sp_OdayaDemirbasEkle(demirbasId, odaId, adet);
                
            }
        }
        public static void OdaDemirbasSil(int demirbasOdaId)
        {
            using (var context=new DatabaseContext())
            {
                var result = context.Demirbas_Oda.FirstOrDefault(x => x.DemirbasOdaId == demirbasOdaId);
                context.Entry(result).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
        public static List<OdaKisiViewModel> OdaSorumlulariListele()
        {
            using (var context = new DatabaseContext())
            {
                var result = from k in context.Kisilers
                    join z in context.Zimmetlers on k.KisiId equals z.KisiId
                    join o in context.Odalars on z.OdaId equals o.OdaId
                    select new OdaKisiViewModel
                    {
                        Kisi = k,
                        Oda = o,
                        Zimmet = z
                    };
                return result.ToList();
            }
        }
    }
}
