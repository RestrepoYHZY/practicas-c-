using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coleccionQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue <int> numeros = new Queue<int>();

            //Agregando elementos en la cola 

            foreach(int numero in new int[5] { 1, 2, 3, 4, 5 })
            {
                numeros.Enqueue(numero);
            }

            //Recorriendo la cola

            Console.WriteLine("Recorriendo el QUEUE");

            foreach(int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            //Eliminando elementos del queue
            Console.WriteLine();
            Console.WriteLine("Eliminado elementos");

            numeros.Dequeue();

            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

        }
    }
}
