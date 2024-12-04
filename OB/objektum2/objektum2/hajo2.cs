using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace objektum2
{
    internal interface hajo2
    {
        class hajo : hajo2
        {
            public void megy()
            {
                Console.WriteLine("shhhhhhh");
            }
            public void hangjelzes()
            {
                Console.WriteLine("tuutttuuuuuu");
            }
            public void sullyed()
            {
                Console.WriteLine("sullyedunk!!!!!");
            }
            public string nev;
            public string hossza;
            public int vizkiszoritas;

            public hajo(string nev, string hossza, int vizkiszoritas)
            { 
                this.nev = nev;
                this.hossza = hossza;
                this.vizkiszoritas = vizkiszoritas;
            }
     
        }

    }

}
