using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1.Ejercicio1.Figuras
{
    class Menu
    {
        public Menu()
        {
            MenuPrincipal();
        }

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
                        Cuadrado cuad = new Cuadrado();
                        Console.WriteLine("Ingrese lado");
                        cuad.setLado(double.Parse(Console.ReadLine()));

                        Console.WriteLine("El area del cuadrado es:{0}",cuad.calcularArea());
                        Console.WriteLine("El perimetro del cuadrado es:{0}",cuad.calcularPerimetro());
                        break;

                    case 2:
                        Rectangulo rect = new Rectangulo();
                        Console.WriteLine("Ingrese base");
                        rect.setBase(double.Parse(Console.ReadLine()));
                        Console.WriteLine("Ingrese altura");
                        rect.setAltura(double.Parse(Console.ReadLine()));

                        Console.WriteLine("El area del rectangulo es:{0}",rect.calcularArea());
                        Console.WriteLine("El perimetro del rectangulo es:{0}",rect.calcularPerimetro());
                        break;

                    case 3:
                        Triangulo trian = new Triangulo();
                        Console.WriteLine("Ingrese altura");
                        trian.setAltura(double.Parse(Console.ReadLine()));
                        Console.WriteLine("Ingrese base");
                        trian.setBase(double.Parse(Console.ReadLine()));
                        Console.WriteLine("Ingrese lado");
                        trian.setLado(double.Parse(Console.ReadLine()));
                               
                        Console.WriteLine("El area del triangulo es:{0}",trian.calcularArea());
                        Console.WriteLine("El perimetro del triangulo es:{0}",trian.calcularPerimetro());
                        break;

                    case 4:
                        Console.WriteLine("Exit");
                        break;
                }
                Console.ReadLine();
            }
            while (opcion != 4);
        }
    }
}