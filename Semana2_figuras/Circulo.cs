using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2_figuras
{
    internal class Circulo : Figura
    {
        private float radio;
        private float pi = 3.14f;

        public Circulo(float radio)
        {
            this.radio = radio;
        }
        
        public override float CalcularArea()
        {
        return radio * radio * pi;
        }
    }
}

