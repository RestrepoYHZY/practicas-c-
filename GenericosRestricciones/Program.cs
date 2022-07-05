using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericosRestricciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AlmacenEmpleados<Director> empleados = new AlmacenEmpleados<Director>(2);

            empleados.agregar(new Director(1200));
            empleados.agregar(new Director(2200));
        }
    }

    class AlmacenEmpleados<T> where T: IParaEmpleados
    {
        public AlmacenEmpleados(int z)
        {
            datosEmpleados = new T[z]; 
        }

        public void agregar(T obj)
        {
            datosEmpleados[i]=obj;
            i++;
        }

        public T getEmpleado(int i)
        {
            return datosEmpleados[i];
        } 

        private int i = 0;
        private T[] datosEmpleados;
    }



    class Director:IParaEmpleados
    {
        public Director (double salario)
        {
            this.salario = salario;
        }

        private double salario; 
        public double getSalario()
        {
            return salario;
        }
    }

    class Secretaria:IParaEmpleados
    {
        public Secretaria(double salario)
        {
            this.salario = salario;
        }

        private double salario;
        public double getSalario()
        {
            return salario;
        }

    }

    class Electricista: IParaEmpleados
    {
        public Electricista(double salario)
        {
            this.salario = salario;
        }

        private double salario;
        public double getSalario()
        {
            return salario;
        }
    }

    interface IParaEmpleados
    {
        double getSalario();
    }
}
