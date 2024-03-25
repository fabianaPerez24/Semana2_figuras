using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2_figuras
{
    internal class Rectangulo : Figura
    {
        private float altura;
        private float largo;

        public Rectangulo(float altura, float largo)
        {
            this.largo = largo;
            this.altura = altura;
        }

        public override float CalcularArea()
        {
            return altura * largo;
        }
    }
}
