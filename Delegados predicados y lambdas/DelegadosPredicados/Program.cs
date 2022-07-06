
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegadosPredicados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listaNumeros = new List<int>();
            listaNumeros.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });

            //Deleramos delegado predicado

            Predicate<int> predicate1 = new Predicate<int>(muestraPares);

            List<int> numPares = listaNumeros.FindAll(predicate1);

            foreach(int num in numPares)
            {
                Console.WriteLine(num);
            }

        }

        static bool muestraPares (int num)
        {
            if (num % 2 == 0) return true;
            else return false; 
        }
    }
}
