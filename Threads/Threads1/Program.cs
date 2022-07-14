using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Threads1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(MetodoSaludo);
            t.Start();
            t.Join();

            Thread t2 = new Thread(MetodoSaludo);
            t2.Start();
            t2.Join();

            Console.WriteLine("Hello from thread 1");
            Thread.Sleep(500);
            Console.WriteLine("Hello from thread 1");
            Thread.Sleep(500);
            Console.WriteLine("Hello from thread 1");
            Thread.Sleep(500);
            Console.WriteLine("Hello from thread 1");
            Thread.Sleep(500);
            Console.WriteLine("Hello from thread 1");
            

        }
         
        static void MetodoSaludo()
        {
            Console.WriteLine("Hello from thread 2");
            Thread.Sleep(500);
            Console.WriteLine("Hello from thread 2");
            Thread.Sleep(500);
            Console.WriteLine("Hello from thread 2");
            Thread.Sleep(500);
            Console.WriteLine("Hello from thread 2");
            Thread.Sleep(500);
            Console.WriteLine("Hello from thread 2");
        }
    }
}
