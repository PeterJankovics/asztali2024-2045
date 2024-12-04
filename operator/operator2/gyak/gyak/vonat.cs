using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics;
using System.Text;
using System.Threading.Tasks;

// objektum egy vonatrol, aminel az operatorok amiket felul kell irni a plusz es minudz legyen,
// hogy ossze tudunk edni vonat szerelvenyeket,
// es szemelyeket, a vonatkocsinak egy tulajdonsaga legyen kocsi vagy ember.

namespace gyak
{
    internal class vonat
    {
        public int kocsikSzama;

        public vonat(int kocsikSzama)
        {
            this.kocsikSzama = kocsikSzama;
        }
        public static vonat operator +(vonat v1, vonat v2)
        {
            return new vonat(v1.kocsikSzama + v2.kocsikSzama);
        }


        public static vonat operator -(vonat v1, vonat v2)
        {
            return new vonat(v1.kocsikSzama - v2.kocsikSzama);
        }



        public override string ToString()
        {
            return "kocsi1: " + kocsikSzama;
        }
    }
}
