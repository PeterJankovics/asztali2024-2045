using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyak3
{
    internal class gyumolcsok
    {
        public string nev;
        public int tomeg;

        public gyumolcsok(string nev, int tomeg)
        {
            this.nev = nev;
            this.tomeg = tomeg;
        }
        public static gyumolcsok operator +(gyumolcsok nev, gyumolcsok tomeg)
        {
            return nev.nev + nev.nev;

        }
    }
}
