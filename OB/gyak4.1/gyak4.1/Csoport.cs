using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyak4._1

{
    internal class Csoport
    {
        List<Allatok> tagok = new List<Allatok>();
        public Csoport() { }
        public csoport(Allatok allat)
        {
            tagok.Add(allat);
        }
        public allatok(Allatok allat)
        {
            this.tagok.AddRange(Csoport.tagok);
        }
        public static Csoport operator +(Csoport cs1, Allatok a1)
        {
            cs1.tagok.Add(a1);
            return new Csoport(cs1);
        }
    }
}
