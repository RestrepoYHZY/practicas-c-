using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado1 = new Empleado(1200, 250);
            empleado1.cambiarSalario(empleado1, 100);
            Console.WriteLine(empleado1);

        }

        public struct Empleado
        {
            public double salarioBase, comision; 
            public Empleado(double salarioBase, int comision)
            {
                this.salarioBase = salarioBase;
                this.comision = comision;
            }

            public override string ToString()
            {
                return String.Format("Salario y comision del empleado ({0},{1})",this.salarioBase,this.comision);
            }

            public void cambiarSalario(Empleado emp, double incremento)
            {
                emp.salarioBase += incremento;
                emp.comision += incremento;
            }
        }
    }



}
