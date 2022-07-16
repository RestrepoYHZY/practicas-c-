using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            realizarAllTareas();

            Console.ReadLine();

        }

        static void realizarAllTareas()
        {
           var tarea1= Task.Run(() =>
            {

                EjecutarTarea();
            });


            tarea1.Wait(); 


            var tarea2 = Task.Run(() =>
            {

                EjecutarTarea2();
            });

            var tarea3 = Task.Run(() =>
            {

                EjecutarTarea3();
            });

            //Task.WaitAll(tarea1, tarea2); 

        }

        static void EjecutarTarea()
        {

            for (int i = 0; i < 10; i++)
            {
                var miThread = Thread.CurrentThread.ManagedThreadId;

                Thread.Sleep(1000);

                Console.WriteLine("Esta vuelta del bluce corresponde a la tarea 1");
            }

        }

        static void EjecutarTarea2()
        {

            for (int i = 0; i < 10; i++)
            {
                var miThread = Thread.CurrentThread.ManagedThreadId;

                Thread.Sleep(500);

                Console.WriteLine("Esta vuelta del bluce corresponde a la tarea 2");
            }

        }

        static void EjecutarTarea3()
        {

            for (int i = 0; i < 10; i++)
            {
                var miThread = Thread.CurrentThread.ManagedThreadId;

                Thread.Sleep(500);

                Console.WriteLine("Esta vuelta del bluce corresponde a la tarea 3");

        }

    }
}
