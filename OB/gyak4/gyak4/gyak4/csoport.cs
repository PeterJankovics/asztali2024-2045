using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//class tenyesz allatokrol, az allatnak legyen neve es sulya, meg ara.
//Legyen egy masik osztaly ami a farmon nevre hallgat amiben tobb allat vehet reszt
//Legyen olyan fuggvenye ami kiszamolja azt ossz erteket es az ossz sulyat.
//Es ennek az osztalynak meg kell csinalnu a + es- operatorokat ,
//ugy hogy ha egy masik csordat afdunk hozza akko a kettot egyesitse,
//ha egy allatot akkor azt az egyet adja hozzza a listahoz.
//Kivonaskor ha van az az allat akkor vonja csak ki,
//ha csordat vonunk akkor az osszes elemet vonja k

namespace gyak4
{
    internal class csoport
    {
        string[] allatok;
        List<allatok> tagok = new List<allatok>();
        public csoport() { }
        public csoport(allatok allat)
        {
            tagok.Add(allat);
        }
        public allatok(allatok allat)
        {
            this.tagok.AddRange(csoport.tagok);
        }
    }
}


