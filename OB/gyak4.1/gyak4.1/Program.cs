//class tenyesz allatokrol, az allatnak legyen neve es sulya, meg ara.
//Legyen egy masik osztaly ami a farmon nevre hallgat amiben tobb allat vehet reszt
//Legyen olyan fuggvenye ami kiszamolja azt ossz erteket es az ossz sulyat.
//Es ennek az osztalynak meg kell csinalnu a + es- operatorokat ,
//ugy hogy ha egy masik csordat afdunk hozza akko a kettot egyesitse,
//ha egy allatot akkor azt az egyet adja hozzza a listahoz.
//Kivonaskor ha van az az allat akkor vonja csak ki,
//ha csordat vonunk akkor az osszes elemet vonja ki.

using gyak4._1;

allatok a1 = new allatok("Bimboo", 300, 200000);
Console.WriteLine(a1);

csoport cs1 = new csoport();
csoport cs2 = new csoport(a1);
csoport cs3 = new csoport(cs2);
Console.WriteLine(cs3.tagok.Count);
