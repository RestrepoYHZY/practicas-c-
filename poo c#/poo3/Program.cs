using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace poo3
{
    internal class Program
    {
        static void Main(string[] arg)
        {
            //realizarTarea();

            var miVariable = new { Nombre = "Juan", Edad = 18 };

            Console.WriteLine(miVariable.Nombre + " "+ miVariable.Edad);
        }

        static void realizarTarea()
        {
            Punto origen = new Punto();
            Punto destino = new Punto(128, 80);

            

            double distancia = origen.DistanciaHasta(destino);

            Console.WriteLine($"La distancia entro los puentos es: {distancia}");

            Console.WriteLine($"Numero de objetos creados: {Punto.ContadorDeObjetos()}");
        }
    }
}
