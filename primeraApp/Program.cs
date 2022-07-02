//Sinxtaxis Basica

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace primeraApp
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {

//            const double PI = 3.1416;

//            Console.WriteLine("Introduzca la medida del radio");

//            double radio = double.Parse(Console.ReadLine());

//            double area = radio * radio * PI;

//            Console.WriteLine($"El area del circulo es: {area}");

//        }
//    }
//}


//Metodos

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace primeraApp
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            mensajeEnPantalla();

//            Console.WriteLine("MensajeMain");
//        }

//        static void mensajeEnPantalla()
//        {
//            Console.WriteLine("Mensaje Hello My name is evel");
//        }
//    }
//}



////Condicional if

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace primeraApp
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string carnet="no"; 

//            Console.WriteLine("Vamos a evaluar si puedes conducir un vehiculo");
//            Console.WriteLine("Introduce tu edad,por favor");

//            int edad = Int32.Parse(Console.ReadLine());

//            if (edad >= 18)
//            {

//                Console.WriteLine("¿Tines carnet?");
//                carnet = Console.ReadLine();

//            }

//            else if(edad>=18 && carnet == "si")
//            {
//                Console.WriteLine("Puedes conducir");
//            }
//            else
//            {
//                Console.WriteLine("NO puedes conducir ");
//            }
//        }


//    }
//}



////Condicional switch

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace primeraApp
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Elige medio de transporte(coche, tren, avion)");
//            string medioTransporte = Console.ReadLine();

//            switch(medioTransporte){

//                case "coche":
//                    Console.WriteLine("Velocidad media:100km/h");
//                    break;
//                case "tren":
//                    Console.WriteLine("Velocidad media:200km/h");
//                    break;
//                case "avion":
//                    Console.WriteLine("Velocidad media:800km/h");
//                    break;
//                default: Console.WriteLine("No aplica ese medio de transporte");
//                    break; 

//            }
//        }


//    }
//}



////bucle while

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace primeraApp
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {

//            Random numero = new Random();
//            int numeroAleatorio = numero.Next(0, 100);

//            int intentos = 0;
//            int miNumero = 101;


//                Console.WriteLine("Bienvenido al juego del bucle númerico");
//                Console.WriteLine();

//                Console.WriteLine($"Introduce un número entre el 1 y el 100");

//                while (numeroAleatorio != miNumero)
//                {
//                    miNumero = int.Parse(Console.ReadLine());

//                    if (miNumero < numeroAleatorio) Console.WriteLine("Debes ingresar un número mayor");

//                    if (miNumero > numeroAleatorio) Console.WriteLine("Debes ingresar un número menor");

//                    intentos++;
//                }
//                Console.WriteLine("Felicitaciónes adivinaste el número del bucle");
//                Console.WriteLine();
//                Console.WriteLine($"Tu número de intentos es {intentos} intentos");
//                Console.WriteLine();               

//        }


//    }
//}


//Excepciones

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeraApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce numero del mes");
            int numMes = int.Parse(Console.ReadLine());

            try
            {
                Console.WriteLine(NombreMes(numMes));
            }catch(Exception e)
            {
                Console.WriteLine("Mensaje de excepcion: "+e.Message);
            }

           

            Console.WriteLine( "Continua el resto del programa");
             
        }

        public static string NombreMes(int mes)
        {
            switch (mes)
            {
                case 1:
                    return "enero";
                case 2:
                    return "febrero";
                case 3:
                    return "marzo";
                case 4:
                    return "abril";
                case 5:
                    return "mayo";
                case 6:
                    return "junio";
                case 7:
                    return "julio";
                case 8:
                    return "agosto";
                case 9:
                    return "septiembre";
                case 10:
                    return "octubre";
                case 11:
                    return "noviembre";
                case 12:
                    return "diciembre";

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }


    }
}

