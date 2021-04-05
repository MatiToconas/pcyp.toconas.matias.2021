using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Clase1.Ejercicio2.Vial
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lineas = File.ReadAllLines("C:/Users/Toconás Matías/Documents/GitHub/pcyp.toconas.matias.2021/PCyP.Ejercicios/Clase1.Ejercicio2.Vial/vial.csv");

            ArchivoVialCSV filas = new ArchivoVialCSV();
            int contador = 0;

            foreach (var linea in lineas)
            {
               var valor = linea.Split(',');

                filas = new ArchivoVialCSV(int.Parse(valor[0]), valor[1], int.Parse(valor[2]), valor[3], int.Parse(valor[4]));
                filas.imprimirLinea();
                contador++;   
             }
            Console.WriteLine("\nRegistro de valores: " + contador);
            Console.ReadLine();
        }
    }
}
