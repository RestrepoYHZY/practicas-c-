using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeccionDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
               
            Dictionary<string, int> edades = new Dictionary<string, int>();

            //LLenar el Dictionary

            edades.Add("Juan", 18);
            edades.Add("Luz", 19);

            //Otra forma de llenar
            edades["Maria"] = 25;
            edades["Antonio"] = 30;


            //Recorrer el Dictionary

            foreach (KeyValuePair<string, int> persona in edades)
            {
                //Console.WriteLine("Nombre: " + persona.Key + " Edad: " + persona.Value);
                Console.WriteLine("Nombre: {0} Edad: {1}",persona.Key,persona.Value);
            }
        }
    }
}
