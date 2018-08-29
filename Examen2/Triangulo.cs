using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2
{
    class Triangulo:FigurasG
    {
        public Triangulo()
        {
            this.Base = 0;
            this.Altura = 0;
        }

        public Triangulo(double b, double a)
        {
            this.Base = b;
            this.Altura = a;
        }

        public override double Area()
        {
            return (this.Base * this.Altura)/2;
        }
    }
}
