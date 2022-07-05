using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeccionesStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack <int> numeros = new Stack <int>();

            //Agregando el stack

            foreach (int numero in new int[5] { 1, 2, 3, 4, 5 })
            {
                numeros.Push(numero);
            }

            //Recorriendo el stack

            Console.WriteLine("Recorriendo el Stack");

            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            //Eliminando elementos del stack
            Console.WriteLine();
            Console.WriteLine("Eliminado elementos");

            numeros.Pop();

            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

        }
    }
}
