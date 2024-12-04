using System;
using System.Collections.Generic;
using System.Formats.Tar;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dolgozat_OOP
{
    internal class Penztarca
    {
        public int penz;
        public int pluszPenz;
        public int pluszPenztarca;
        public Penztarca( int penz)
        {
            this.penz = penz;
        }

        public static Penztarca operator -(Penztarca a, Penztarca b)
        {
            return new Penztarca(a.penz - b.penz);
        }


        public static Penztarca operator -(Penztarca a, int b)
        {
            return new Penztarca(a.penz - b);
        }

        public Penztarca(int pluszPenz, int pluszPenztarca)
        {
            this.pluszPenz = pluszPenz;
            this.pluszPenztarca = pluszPenztarca;
        }

        public static Penztarca operator +(Penztarca a, Penztarca b)
        {
            return new Penztarca(a.penz + a.pluszPenz, b.penz + b.pluszPenztarca);
        }
        public override string ToString()
        {
            return $"{penz} Euro";
        }
    }
}
