using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Testing_LastProject.Model
{
    public class DemirbasViewModel
    {
        public DemirbasViewModel()
        {
            Fakulte=new Fakulteler();
            Bolum=new Bolumler();
            Kategori=new Kategoriler();
            Demirbas=new Demirbaslar();
            Urun=new Urunler();
        }
        public Fakulteler Fakulte { get; set; }
        public Bolumler Bolum { get; set; }
        public Urunler Urun { get; set; }
        public Demirbaslar Demirbas { get; set; }
        public Kategoriler Kategori { get; set; }
        
    }
}
