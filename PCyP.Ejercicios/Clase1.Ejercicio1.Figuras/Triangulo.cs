using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1.Ejercicio1.Figuras
{
    class Triangulo : Figura
    {
        private double basetrian, altura, lado;

        public Triangulo()
        {
            basetrian=0;
            altura=0;
            lado = 0;
        }

        public double getLado()
        {
            return lado;
        }

        public void setLado(double lad)
        {
            lado = lad;
        }

        public double getBase()
        {
            return basetrian;
        }

        public void setBase(double bas)
        {
            basetrian=bas;
        }

        public double getAltura()
        {
            return altura;
        }

        public void setAltura(double alt)
        {
            altura=alt;
        }

        public double calcularArea()
        {
            return (basetrian*altura)/2;
        }

        public double calcularPerimetro()
        {
            return (lado * 2) + basetrian;
        }
    }
}
