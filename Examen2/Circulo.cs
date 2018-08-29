using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2
{
    class Circulo :FigurasG
    {
        public Circulo()
        {
            this.Radio = 0;
        }
        public Circulo(double R)
        {
            this.Radio = R;
        }

        public override double Area()
        {
            return (3.1416 * this.Radio * this.Radio);
        }
    }
}
