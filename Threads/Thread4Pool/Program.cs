using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Thread4Pool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                /* Thread t = new Thread(EjecutarTarea);
                 t.Start();*/

                ThreadPool.QueueUserWorkItem(EjecutarTarea, i);
            }

            Console.WriteLine();
            
        }


        static void EjecutarTarea(Object o)
        {

            int nTarea = (int)o;

            Console.WriteLine($"Thread n°: {Thread.CurrentThread.ManagedThreadId} ha comenzado la tarea n° "+nTarea);

            Thread.Sleep(1000);

            Console.WriteLine($"Thread n°: {Thread.CurrentThread.ManagedThreadId} ha terminado la tarea n° " + nTarea);


        
        }
    }
}
