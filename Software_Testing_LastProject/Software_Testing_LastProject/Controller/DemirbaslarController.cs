using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Software_Testing_LastProject.Model;

namespace Software_Testing_LastProject.Controller
{
    public static class DemirbaslarController
    {
        public static void DemirbasEkle(DemirbasViewModel demirbas)
        {
            using (var context=new DatabaseContext())
            {
                context.sp_DemirbasEkle(demirbas.Fakulte.FakulteId, demirbas.Bolum.BolumId, demirbas.Kategori.KategoriId, demirbas.Urun.UrunId, demirbas.Demirbas.DemirbasAdedi, demirbas.Demirbas.DemirbasAciklama);
                context.SaveChanges();
            }
        }
        public static Demirbaslar DemirbasGetir(int demirbasNo)
        {
            using (var context=new DatabaseContext())
            {
                var result = context.Demirbaslars.FirstOrDefault(x => x.DemirbasNo == demirbasNo);
                return result;
            }
        }
        public static void DemirbasSil(int demirbasNo)
        {
            using (var context = new DatabaseContext())
            {
                var result = context.Demirbaslars.FirstOrDefault(x => x.DemirbasNo == demirbasNo);
                context.Entry(result).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
        public static void DemirbasGuncelle(int demirbasNo ,int fakutleId, int bolumId ,int kategoriId, int demirbasAdedi ,string demirbasAciklama)
        {
            using (var context=new DatabaseContext())
            {
                context.sp_DemirbasDuzenle(demirbasNo, fakutleId, bolumId, kategoriId, demirbasAdedi, demirbasAciklama);
            }
        }
        public static List<Demirbaslar> DemirbaslariListele()
        {
            using (var context = new DatabaseContext())
            {
                var result = context.Demirbaslars.ToList();
                return result;
            }
        }

        
    }
}
