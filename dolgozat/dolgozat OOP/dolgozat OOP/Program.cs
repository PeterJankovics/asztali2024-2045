using dolgozat_OOP;
using System.Reflection.Metadata.Ecma335;

Penztarca ferj = new Penztarca(30000);
Penztarca feleseg = new Penztarca(42);

Penztarca pluszp = new Penztarca(300);
Penztarca penztarca = new Penztarca(3000);


Console.WriteLine(ferj - feleseg);
Console.WriteLine(ferj - 200);

Console.WriteLine(ferj + pluszp);
Console.WriteLine(ferj + penztarca);

