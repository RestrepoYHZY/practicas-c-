//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace array
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            //array implicito
//            var valores = new[] { 15, 23.98, 45, 65, 65.87, 65, 76, 76 };

//            Empleados Ana = new Empleados("ana", 27);
//            //array objetos

//            Empleados[] arayEmpleados = new Empleados[2];

//            arayEmpleados[0] = new Empleados("sara", 27);

//            arayEmpleados[1] = Ana;

//            //Array de tipo anonimo

//            var personas = new[]
//            {
//                new{Nombre="Juan",edad=18},

//                new{Nombre="Yhaz", edad=20},

//                new{Nombre="Angel", edad=30}
//            };

//           /*for (int i = 0; i < valores.Length; i++)
//            {
//                Console.WriteLine(valores[i]);
//            }*/


//           /* for (int i = 0; i < arayEmpleados.Length; i++)
//            {
//                Console.WriteLine(arayEmpleados[i].getInfo());
//            }*/

//            foreach (Empleados variable in arayEmpleados)
//            {
//                Console.WriteLine(variable.getInfo());
//            }

//            foreach (double variable in valores)
//            {
//                Console.WriteLine(variable);
//            }

//            foreach (var variable in personas)
//            {
//                Console.WriteLine(variable);
//            }


//        }

//        class Empleados
//        {
//            public Empleados (String nombre, int edad)
//            {
//                this.nombre = nombre;
//                this.edad = edad;
//            }

//            public string getInfo()
//            {
//                return "Nombre del empleado: " + nombre + " edad: " + edad;
//            }

//            private string nombre;
//            private int edad; 
//        }
//    }
//}




//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace array
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] numeros = new int[4];

//            numeros[0] = 7;
//            numeros[1] = 5;
//            numeros[2] = 13;
//            numeros[3] = 10;

//            ProcesaDatos(numeros);

//            foreach (int i in numeros)
//            {
//                Console.WriteLine(i);
//            }

//        }

//        static void  ProcesaDatos(int[] datos)
//        {
//            for(int i=0; i<4; i++)
//            {
//                datos[i] += 10;            }
//        }
//    }
//}




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayElementos = leerDatos();

            Console.WriteLine("Imprimiendo desde el main");

            foreach (int i in arrayElementos)
            {
                Console.WriteLine(i);
            }
        }

        static int[] leerDatos()
        {
            Console.WriteLine("Cuantos elementos iran en el array");

            string respuesta = Console.ReadLine();

            int numElementos= int.Parse(respuesta);

            int[] datos = new int[numElementos];


            for(int i=0; i<numElementos; i++)
            {
                Console.WriteLine($"Introduce el dato {i+1}");
                respuesta= Console.ReadLine();
                int datosElemento = int.Parse(respuesta);

                datos[i] = datosElemento;
            }
            return datos;   
        }
    }
}


