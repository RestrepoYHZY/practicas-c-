using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Thread3TaskComSo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tareaTerminada = new TaskCompletionSource<bool>();

            var hilo1 = new Thread(() =>
            {
                for ( int i=0; i< 5; i++)
                {
                    Console.WriteLine("Hilo 1");
                    Thread.Sleep(1000);
                }

                tareaTerminada.TrySetResult(true);
            });


           

            var hilo2 = new Thread(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Hilo 2");
                    Thread.Sleep(1000);
                }

                tareaTerminada.TrySetResult(true);
            });

            var hilo3 = new Thread(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Hilo 3");
                    Thread.Sleep(1000);
                }
            });


            hilo1.Start();

            hilo2.Start();

            var resultado = tareaTerminada.Task.Result; // saber si la tarea termina para iniciar la otra

            hilo3.Start();
        }
    }
}
