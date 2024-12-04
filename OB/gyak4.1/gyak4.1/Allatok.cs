using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyak4._1
{
    internal class Allatok
    {
        public string nev;
        public int suly;
        public int ar;

        public Allatok(string nev, int suly, int ar)
        {
            this.nev = nev;
            this.suly = suly;
            this.ar = ar;
        }
        public override string ToString()
        {
            return nev;
        }
    }
}
