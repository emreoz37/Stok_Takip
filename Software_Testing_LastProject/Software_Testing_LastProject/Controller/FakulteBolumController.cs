using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Software_Testing_LastProject.Model;

namespace Software_Testing_LastProject.Controller
{
    public static class FakulteBolumController
    {
        public static List<Fakulteler> FakulteleriListele()
        {
            using (var context=new DatabaseContext())
            {
                var result = context.Fakultelers.ToList();
                return result.ToList();
            }
        }
        public static List<Bolumler> BolumleriListele(int fakulteId)
        {
            using (var context = new DatabaseContext())
            {
                var result = context.Bolumlers.Where(x => x.FakulteId == fakulteId);
                return result.ToList();
            }
        }
    }
}
