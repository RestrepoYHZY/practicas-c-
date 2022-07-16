using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace cancelacionTask
{
    internal class Program
    {
        static int acumulador = 0;
        static void Main(string[] args)
        {
            CancellationTokenSource miToken = new CancellationTokenSource();
            CancellationToken cancelaToken = miToken.Token;


            Task tara = Task.Run(() => RealizarTarea(cancelaToken));

            for(int i=0; i<100; i++)
            {
                acumulador += 30;

                Thread.Sleep(1000);

                if (acumulador > 100)
                {

                    miToken.Cancel();
                    break;
                } 
            }

            Thread.Sleep(1000);
            Console.WriteLine("VALOR DEL ACUMULADOR: "+acumulador);
            Console.ReadLine();
            
        }
        
        static void RealizarTarea(CancellationToken token)
        {
            for (int i=0; i<100; i++)
            {
                acumulador++;

                var miThread = Thread.CurrentThread.ManagedThreadId;
                Thread.Sleep(1000);
                Console.WriteLine("Ejecutando tarea el thread: "+miThread);
                Console.WriteLine(acumulador);

                if (token.IsCancellationRequested)
                {
                    acumulador = 0;
                    return; 
                }
            }


        }
    }

}
