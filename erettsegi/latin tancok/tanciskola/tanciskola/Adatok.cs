using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace tanciskola
{
    internal class Adatok
    {
        public string tanc;
        public string lany;
        public string fiu;

        public Adatok(string tanc, string lany, string fiu)
        { 
            this.tanc = tanc;
            this.lany = lany;
            this.fiu = fiu;
            
        }

        public override string ToString() {
            return tanc;
            }
       
       

    }

}
