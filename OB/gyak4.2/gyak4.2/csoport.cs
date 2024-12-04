using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyak4._2
{
    internal class Csorda
    {
        public List<Allat> tagok = new List<Allat>();
        public Csorda() { }

        public Csorda(Allat allat)
        {
            tagok.Add(allat);
        }
        public Csorda(Csorda csorda)
        {
            this.tagok.AddRange(csorda.tagok);
        }
        public static Csorda operator +(Csorda cs1, Allat a1)
        {
            List<Allat> temp = new List<Allat>(cs1.tagok);
            
            if (!cs1.tagok.Contains(a1))
            {
                temp.Add(a1);
                
            }
            Csorda tempcs = new Csorda();
            tempcs.tagok = temp;
            return tempcs; 
        }

        public static Csorda operator -(Csorda cs1, Allat a1)
        {
            List<Allat> temp = new List<Allat>(cs1.tagok);
            temp.Remove(a1);
            Csorda tempcs = new Csorda();
            tempcs.tagok = temp;
            return tempcs;
        }

        public void Kiir()
        {
            for (int i = 0; i < tagok.Count; i++)
            {
                Console.WriteLine(tagok[i]);
            }
        }
    }
}
