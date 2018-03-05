using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Testing_LastProject.Model
{
    public static class KategorilerModel
    {
        public static List<Kategoriler> KategorileriListele()
        {
            using (var context=new DatabaseContext())
            {
                return context.Kategorilers.ToList();
            }
        }
    }
}
