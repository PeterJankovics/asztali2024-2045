using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace belepteto
{
    internal class Class1
    {
        public string kod;
        public string ido;
        public int esemeny;

        public int ora;
        public int perc;

        public Class1(string sor)
        {
            string[] vag = sor.Split(" ");
            kod = vag[0];
            ido = vag[1];
            esemeny = Convert.ToInt32(vag[2]);


            vag = ido.Split(":");
            ora = Convert.ToInt32(vag[0]);
            perc = Convert.ToInt32(vag[1]);
        }


    }
}
