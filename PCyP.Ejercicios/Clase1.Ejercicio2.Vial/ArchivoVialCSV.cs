using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1.Ejercicio2.Vial
{
    class ArchivoVialCSV
    {
        private int numHoja;
        private int idTramo;
        private int longitud;
        private string tipObj;
        private string tipCamino;

        public ArchivoVialCSV()
        {
            numHoja = 0;
            idTramo = 0;
            longitud = 0;
            tipObj = null;
            tipCamino = null;
        }

        public ArchivoVialCSV(int numeroHoja, string tipoObje, int idTram, string tipoCamino, int lon)
        {
            numHoja = numeroHoja;
            tipObj = tipoObje;
            idTramo = idTram;
            tipCamino = tipoCamino;
            longitud = lon;
        }

        public void imprimirLinea()
        {
            Console.WriteLine("Número de hoja: {0}\t Tipo de objeto: {1}\t Identificador de tramo: {2}\t Tipo de camino: {3}\t Longitud: {4}", numHoja, tipObj, idTramo, tipCamino, longitud);
        }
    }
}
