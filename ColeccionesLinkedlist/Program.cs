using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeccionesLinkedlist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> numeros = new LinkedList<int>();
            
            foreach (int numero in new int[] {1,2,3,4,5,})
            {
                //numeros.AddFirst(numero);
                numeros.AddLast(numero);
            }

            numeros.Remove(6);

            /*foreach(int numero in numeros)
            {
                Console.WriteLine(numero);
            }*/

            for(LinkedListNode<int> nodo=numeros.First; nodo!=null; nodo = nodo.Next)
            {
                int numero = nodo.Value;
                Console.WriteLine(numero);
            }

        }
    }
}
