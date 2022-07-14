using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Threads2Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CuentaBancaria CuentaFamiliar = new CuentaBancaria(2000);

            Thread[] hlosPersonas = new Thread[15];

            for(int  i = 0; i < 15; i++)
            {
                Thread t = new Thread(CuentaFamiliar.VamosARetirar);
                t.Name=1.ToString(); 
                hlosPersonas[i]= t;
            }

            for (int i = 0; i < 15; i++) hlosPersonas[i].Start();

            
        }
    }

    class CuentaBancaria
    {

        private Object bloqueaSaldoPositivo = new object();
        double saldo { set; get; }

        public CuentaBancaria (double saldo)
        {
            this.saldo = saldo;
        }

        public double RetirarEfectivo(double cantidad)
        {
            if ((saldo - cantidad) < 0)
            {
                Console.WriteLine($"Lo siento queda {saldo} en la cuenta. Hilo: {Thread.CurrentThread.Name}");

                return saldo;

            }

            lock(bloqueaSaldoPositivo){
                if (saldo <= cantidad)
                {
                    Console.WriteLine("Retirado {0} y queda {1} en la cuenta {2}", cantidad, (saldo - cantidad), Thread.CurrentThread.Name);
                    saldo -= cantidad;

                }
                return saldo;
            }
        }

        public void VamosARetirar()
        {
            Console.WriteLine("Esta sacando dinero el hilo: {0}", Thread.CurrentThread.Name);
            for( int i =0; i<4; i++) RetirarEfectivo(500);
        }
    }
}
