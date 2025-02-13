using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace park
{
    internal class adatok
    {
        public int kezd;
        public int veg;
        public string szin;

        public adatok (string sor)
        {
            string[] vag = sor.Split (' ');
            kezd = int.Parse(vag[0]);
            veg = int.Parse(vag[1]);
            szin = vag[2];

        }
        public bool kapubentvan
        {
            get { return kezd > veg; }
        }

        public bool bennevanez(int sorszam)
        {
            return (kezd <= sorszam && sorszam <= veg)
                || (kapubentvan && (kezd <= sorszam || sorszam <= veg));
        }


    }
}
