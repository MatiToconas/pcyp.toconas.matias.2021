using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1.Ejercicio1.Figuras
{
    class Menu
    {
        public void MenuPrincipal()
        {
            int opcion = 0;

            do
            {

                Console.WriteLine("Area y Perimetro");

                Console.WriteLine("01-Cuadrado - Area y Perimetro");
                Console.WriteLine("02-Rectangulo - Area y Perimetro");
                Console.WriteLine("03-Triangulo - Area y Perimetro");
                Console.WriteLine("04-Exit");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:

                        Console.WriteLine("Ingrese lado");

                        int lado = int.Parse(Console.ReadLine());

                        Cuadrado cuad = new Cuadrado();

                        Console.WriteLine("El area del cuadrado es:{cuad.calcularArea()}");
                        Console.WriteLine("El perimetro del cuadrado es:{cuad.calcularPerimetro()}");

                        break;

                    case 2:

                        Console.WriteLine("Ingrese altura");
                        int altura = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese base");
                        int baseFigura = int.Parse(Console.ReadLine());

                        Rectangulo rect = new Rectangulo();

                        Console.WriteLine("El area del rectangulo es:{rect.calcularArea()}");
                        Console.WriteLine("El perimetro del rectangulo es:{rect.calcularPerimetro()}");
                        break;

                    case 3:

                        Console.WriteLine("Ingrese altura");
                        altura = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese base");
                        baseFigura = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese lado");
                        lado = int.Parse(Console.ReadLine());

                        Triangulo trian = new Triangulo();

                        Console.WriteLine("El area del rectangulo es:{trian.calcularArea()}");
                        Console.WriteLine("El perimetro del rectangulo es:{trian.calcularPerimetro()}");
                        break;

                    case 4:
                        Console.WriteLine("Exit");
                        break;
                }
            }
            while (opcion != 4);
        }
    }
}