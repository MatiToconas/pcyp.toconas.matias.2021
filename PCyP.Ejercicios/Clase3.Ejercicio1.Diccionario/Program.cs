using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.Ejercicio1.Diccionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> values = new Dictionary<string, string>();
            values.Add("Juan", "55423412");
            values.Add("Ernesto", "56985623");
            values.Add("Mariana", "54787451");

            //a)
           if (values.ContainsKey("Juan"))
           {
                Console.WriteLine(values["Juan"]); 
                Console.ReadKey();
            }

            //b)
            string nombre;

            if (values.TryGetValue("Pedro", out nombre))
            {
                Console.WriteLine(nombre);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No contiene la llave");
                Console.ReadKey();
            }

            //c)
            
            foreach (KeyValuePair<string, string> entrada in values)
            {
                Console.WriteLine("{0}, {1}", entrada.Key, entrada.Value);
            }
            Console.ReadKey();

            //d)
           
            values["Mariana"] = "58251425";
            Console.WriteLine("Nuevo teléfono de Mariana: {0}", values["Mariana"]);
            Console.ReadKey();

        }
    }
}
