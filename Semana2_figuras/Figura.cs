using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2_figuras
{
    internal class Figura
    {
         
        public void Start()
        {
            figuras();
        }

        bool continueflag = true;
        public void figuras()
        {
            while (continueflag)
            {
                Console.WriteLine("Que figura deseas operar?");
                Console.WriteLine("RECTANGULO");
                Console.WriteLine("TRIANGULO");
                Console.WriteLine("CIRCULO");

                String options = Console.ReadLine();

                switch (options)
                {
                    case "RECTANGULO":

                        float alturaR, largoR;

                        Console.WriteLine("Ingrese la primera variable");
                        alturaR = float.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la segunda variable");
                        largoR = float.Parse(Console.ReadLine());
                        Rectangulo rectangulo = new Rectangulo(alturaR, largoR);
                        Console.WriteLine($"El area es {rectangulo.CalcularArea()}");
                        break;

                    case "TRIANGULO":
                        break;

                    case "CIRCULO":
                        break;

                }
                    
            }

        }

        public virtual float CalcularArea()
        {
            return 0;
        }
    }
}
