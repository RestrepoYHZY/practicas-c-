using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace LINQ1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] valoresNumericos = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Numeros pares: ");

            /*List<int> numerosPares = new List<int>();

            foreach (int i in valoresNumericos)
            {
                if(i %2 == 0)
                {
                    numerosPares.Add(i);
                }
            }*/

            IEnumerable<int> numerosPares = from numero in valoresNumericos where numero %2==0 select numero;

            foreach(int i in numerosPares)
            {
                Console.WriteLine(i);
            }
        }
    }
}
