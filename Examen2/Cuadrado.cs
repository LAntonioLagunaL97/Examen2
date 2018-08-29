using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2
{
    class Cuadrado:FigurasG
    {
        public Cuadrado()
        {
            this.Lado = 0;
        }
        public Cuadrado(double R)
        {
            this.Lado = R;
        }

        public override double Area()
        {
            return this.Lado * this.Lado;
        }
    }
}
