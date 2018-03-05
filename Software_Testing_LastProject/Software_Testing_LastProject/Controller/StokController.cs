using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Data.ODataLinq.Helpers;
using Software_Testing_LastProject.Model;

namespace Software_Testing_LastProject.Controller
{
    public static class StokController
    {
        public static List<StokUrunViewModel> StoklarıGetir()
        {
            using (var context=new DatabaseContext())
            {
                var result = from urun in context.Urunlers
                    join stok in context.Urun_Stok
                        on urun.UrunId equals stok.UrunId
                    select new StokUrunViewModel
                    {
                        UrunStok = stok,
                        Urun = urun
                    };
                bool silinmedi = Convert.ToBoolean(EDeleted.silinmedi);
                return result.Where(x=>x.UrunStok.Stok>0 && x.Urun.Silindi==silinmedi).ToList();
            }
        }
        public static List<StokUrunViewModel> StoktaBitenleriGetir()
        {
            using (var context = new DatabaseContext())
            {
                var result = from urun in context.Urunlers
                    join stok in context.Urun_Stok
                        on urun.UrunId equals stok.UrunId
                    select new StokUrunViewModel
                    {
                        UrunStok = stok,
                        Urun = urun
                    };
                bool silinmedi = Convert.ToBoolean(EDeleted.silinmedi);
                return result.Where(x => x.UrunStok.Stok == 0 && x.Urun.Silindi ==silinmedi).ToList();
            }
        }
        


    }
}
