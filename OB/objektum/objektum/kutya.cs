using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objektum
{
    internal class kutya
    {
        public string nev;
        public kutya(string nev) 
        {
            this.nev = nev;
            Console.WriteLine("kutya letrejott.");
        }
        public void ugat()
        {
            Console.WriteLine("Vau!!");
           
        }
        private float _suly;
        public float suly
        {
            get
            {
                return _suly;
            }
            set
            {
                _suly = Math.Abs(value);
            }
        }
        public override string ToString()
        {
            return "en vagyok pokember" + nev;
        }
        static string ezMiez()
        {
            return "ez egy kutya objektum.";
        }
    }
}

// egy olyan osztaly aminek egy kons egy propreti egy mezo kell lennie minimum.