using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs_y_Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado1 = new Empleado(Bonus.extra, 1900.50);


           Console.WriteLine( "El salario del empleado es: "+empleado1.getSalario());
        }
    }

    class Empleado
    {
        private double salario,bonus;

        public Empleado(Bonus bonusEmpleado, double salario)
        {
            bonus = (double)bonusEmpleado;

            this.salario = salario;

        }

        public double getSalario()
        {
            return salario + bonus;
        }
    }

  enum Bonus { bajo=500, normal=1000, bueno=1500, extra=3000};

}
