﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1.Ejercicio1.Figuras
{
    class Triangulo : Figura
    {
        private double ladoBase, altura;

        public Triangulo()
        {
            ladoBase=0;
            altura=0;
        }

        public double getBase()
        {
            return ladoBase;
        }

        public void setBase(double lado)
        {
            ladoBase=lado;
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
            return (ladoBase*altura)/2;
        }

        public double calcularPerimetro()
        {
            return ladoBase*3;
        }
    }
}
