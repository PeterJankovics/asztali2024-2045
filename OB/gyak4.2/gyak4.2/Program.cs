//class tenyesz allatokrol, az allatnak legyen neve es sulya, meg ara.
//Legyen egy masik osztaly ami a farmon nevre hallgat amiben tobb allat vehet reszt
//Legyen olyan fuggvenye ami kiszamolja azt ossz erteket es az ossz sulyat.
//Es ennek az osztalynak meg kell csinalnu a + es- operatorokat ,
//ugy hogy ha egy masik csordat afdunk hozza akko a kettot egyesitse,
//ha egy allatot akkor azt az egyet adja hozzza a listahoz.
//Kivonaskor ha van az az allat akkor vonja csak ki,
//ha csordat vonunk akkor az osszes elemet vonja ki.
using gyak4._2;

Allat a1 = new Allat("CARALÁBÉ", 100, 111111);
Console.WriteLine(a1);

Csorda cs1 = new Csorda();
Csorda cs2 = new Csorda(a1);
Csorda cs3 = new Csorda(cs2);

Console.WriteLine(cs3.tagok.Count);

Allat a2 = new Allat("zsomle", 300, 500000);
Allat a3 = new Allat("kifli", 3001, 500000);

Csorda cs4 = cs2 + a1;
cs4 = cs3 += a2;
cs4 = cs4 += a2; 
cs4 = cs4 += a3;
cs4.Kiir();
cs4 = cs3 -= a2;
cs4 = cs4 -= a2;
cs4 = cs4 -= a3;
cs4.Kiir();

Console.WriteLine(cs4.tagok.Count);
