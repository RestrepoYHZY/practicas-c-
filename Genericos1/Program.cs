using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericos1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AlmacenObjetos<String> archivos = new AlmacenObjetos<String>(4);
            archivos.agregar("Juan");
            archivos.agregar("Maria");
            archivos.agregar("Pedro");
            archivos.agregar("Tomas");

            /*archivos.agregar(new Empleado(1500));
            archivos.agregar(new Empleado(1200));
            archivos.agregar(new Empleado(2500));
            archivos.agregar(new Empleado(3000));*/


            String nombrePersona = archivos.getElemento(2);
            Console.WriteLine(nombrePersona);
        }
    }

    class AlmacenObjetos <T>
    {
        public AlmacenObjetos(int z)
        {
            datosElemento = new T[z];

        }
        public void agregar(T obj){

            datosElemento[i] = obj;
            i++;
        }

        public T getElemento(int i)
        {
            return datosElemento[i];
        }

        private T[] datosElemento;
        private int i=0;
    }

    class Empleado
    {
        private double salario; 

        public Empleado(double salario)
        {
            this.salario = salario;
        }

        public double getSalario()
        {
            return salario; 
        }
    }
}
