using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Circulo circulo1 = new Circulo();

            //Console.WriteLine(circulo1.CalculoArea(5)); 

            conversorEuroDola obj = new conversorEuroDola();

            obj.cambioEuro(1.45);

            Console.WriteLine(obj.Convierte(50)); 
        }
    }

    class Circulo
    {
        private const double pi = 3.1416; //propiedad de la clase circulo.Campo de clase
        
        public double CalculoArea(int radio)//Metodo de la clases
        {
            return pi * radio * radio; 
        }

    }

    class conversorEuroDola
    {
        private double euro = 1.253;

        public double   Convierte (double cantidad)
        {
            return cantidad * euro;
        }

        public void cambioEuro (double nuevoEuro)
        {
            if (nuevoEuro < 0) euro = 1.253;
           
            else
            euro = nuevoEuro;
        }
    }
}
