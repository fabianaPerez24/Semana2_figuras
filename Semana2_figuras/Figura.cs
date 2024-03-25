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

                        float alturaT, largoT;

                        Console.WriteLine("Ingrese la primera variable");
                        alturaT = float.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la segunda variable");
                        largoT = float.Parse(Console.ReadLine());
                        Triangulo triangulo = new Triangulo(alturaT, largoT);
                        Console.WriteLine($"El area es {triangulo.CalcularArea()}");
                        break;

                    case "CIRCULO":

                        float radio;

                        Console.WriteLine("Ingrese el radio");
                        radio = float.Parse(Console.ReadLine());

                        Circulo circulo = new Circulo(radio);
                        Console.WriteLine($"El area del circulo es {circulo.CalcularArea()}");
                        break;

                }

                Console.WriteLine("Desea continuar? Escriba SI o NO");
                if (Console.ReadLine() == "NO")
                {
                    continueflag = false;
                }

            }

        }

        public virtual float CalcularArea()
        {
            return 0;
        }
    }
}
