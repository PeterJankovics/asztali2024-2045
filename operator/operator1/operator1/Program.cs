using operator1;
using System.Runtime.InteropServices.Marshalling;

Pont p1 = new Pont(1, 1);
Pont p2 = new Pont(2, 3);
Console.WriteLine(p1 + p2);
Console.WriteLine(p1 + 10);
Console.WriteLine(10 + p2);
Console.WriteLine(p1 - p2);
Console.WriteLine(p1 - 10);
Console.WriteLine(10 - p2);
Console.WriteLine(p1 * p2);
Console.WriteLine(p1 * 10);
Console.WriteLine(10 * p2);
Console.WriteLine(p1 / p2);
Console.WriteLine(10 / p2);
Console.WriteLine(p1 / 10);

Console.WriteLine(p2++);
Console.WriteLine(++p2);
Console.WriteLine(p2--);
Console.WriteLine(--p2);
Console.WriteLine(p1.Equals(1));
Console.WriteLine(p2.Equals(p1));
Console.WriteLine(p2.Equals(p2));
Console.WriteLine(p2.Equals(new Pont(1, 1)));


Console.WriteLine(p1 == new Pont(1, 1));

Console.WriteLine(p1 != p2);