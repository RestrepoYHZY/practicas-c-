using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Task tarea = new Task(EjecutarTarea);

            tarea.Start();*/

            Task tarea = Task.Run(()=> EjecutarTarea());
            Task tarea2 = tarea.ContinueWith(EjecutarOtraTarea);

            /*Task tarea2 = new Task(() =>
            {
                for ( int j=0; j < 100; j++)
                {

                    var miThread = Thread.CurrentThread.ManagedThreadId;

                    Thread.Sleep(1000);

                    Console.WriteLine("Tarea correspondiente al hilo: "+miThread + " ejecuntadose desde el main");
                }
            });
            tarea2.Start(); */


            Console.ReadLine();

        }

        static void EjecutarTarea()
        {

            for (int i= 0; i<10; i++)
            {
                var miThread = Thread.CurrentThread.ManagedThreadId;

                Thread.Sleep(1000);

                Console.WriteLine("Esta vuelta del bluce corresponde al Thread: "+miThread);
            }
           
        }



        static void EjecutarOtraTarea(Task obj)
        {

            for (int i = 0; i < 10; i++)
            {
                var miThread = Thread.CurrentThread.ManagedThreadId;

                Thread.Sleep(1000);

                Console.WriteLine("Esto es otra tarea y esta vuelta del bluce corresponde al Thread: " + miThread);
            }

        }
    }
}
 