using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operator1
{
    internal class Pont
    {
        public int x;
        public int y;

        public Pont(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public Pont(int x)
        {
            this.x = x;
            this.y = 0;
        }
        public Pont()
        {
            this.x = 0;
            this.y = 0;
        }
        public static Pont operator +(Pont a, Pont b){return new Pont(a.x+b.x+a.y+b.y);}
        public static Pont operator +(Pont a, int b){return new Pont(a.x + b, a.y + b);}
        public static Pont operator +(int b, Pont a){ return new Pont(a.x + b, a.y + b);}

        public static Pont operator -(Pont a, Pont b){ return new Pont(a.x - b.x - a.y - b.y);}
        public static Pont operator -(Pont a, int b){return new Pont(a.x - b, a.y - b);}
        public static Pont operator -(int b, Pont a){return new Pont(a.x - b, a.y - b);}

        public static Pont operator *(Pont a, Pont b) { return new Pont(a.x * b.x * a.y * b.y); }
        public static Pont operator *(Pont a, int b) { return new Pont(a.x * b, a.y * b); }
        public static Pont operator *(int b, Pont a) { return new Pont(a.x * b, a.y * b); }

        public static Pont operator /(Pont a, Pont b) { return new Pont(a.x / b.x / a.y / b.y); }
        public static Pont operator /(Pont a, int b) { return new Pont(a.x / b, a.y / b); }
        public static Pont operator /(int b, Pont a) { return new Pont(a.x / b, a.y / b); }

        public static Pont operator++(Pont a) { return new Pont(a.x + 1, a.y + 1); }

        public static Pont operator --(Pont a) { return new Pont(a.x - 1, a.y - 1); }



        public override bool Equals(object obj)
        {
            // ha nem volt parameter;
            if ( obj == null)
            {
                return false;
            }
            if (obj.GetType() != typeof(Pont))
            {
                return false;
            }
            // Ha nem volt pont tipusu parameter;
            Pont other = obj as Pont;
            if (other == null)
            {
                return false;
            }
           

            return x==other.x && y==other.y;
        }
        public static bool operator ==(Pont a, Pont b) { return a.Equals(b); }
        public static bool operator !=(Pont a, Pont b) { return !a.Equals(b); }

        public override string ToString()
        {
            return "X:" + x + ", Y:" + y;
        }


    }
}
