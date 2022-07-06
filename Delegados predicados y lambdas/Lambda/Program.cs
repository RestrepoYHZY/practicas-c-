using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //uso delegate
            OperacionesMath operacion = new OperacionesMath((num1, num2)=> num1+num2);
            Console.WriteLine(  operacion(4,7));
        }

        public delegate int OperacionesMath(int numero1, int numero2);

        /*public static int Cuadrado(int num)
        {
            return num * num;
        }*/

        /*public static int suma (int num1, int num2)
        {
            return num1 + num2;
        }*/
    }

    class Personas
    {
        private string nombre;
        private int edad;

        public string Nombre { get => nombre; set=> nombre = value; }
        public int Edad { get => edad; set => edad = value; }
    }
}
