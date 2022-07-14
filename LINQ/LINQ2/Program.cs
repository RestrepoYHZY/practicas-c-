using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ControlEmpresasEmpleados ce= new ControlEmpresasEmpleados();

            /*ce.getCeo();
            Console.WriteLine(" ");
            ce.getSalario();
            Console.WriteLine(" ");
            ce.getEmpleadosOrdenados();
            Console.WriteLine("");*/

            string entrada = Console.ReadLine();
            try
            {
                int entradaId = Convert.ToInt32(entrada);

                ce.getEmpleadosEmpresa(entradaId);
            }
            catch (Exception)
            {
                  Console.WriteLine("Has introducido un Id erróneo");
            }
        }
    }

    class ControlEmpresasEmpleados
    {
        public ControlEmpresasEmpleados()
        {
            listaEmpresas = new List<Empresa>();
            listaEmpleados = new List<Empleado>();

            listaEmpresas.Add(new Empresa { Id = 1, Nombre = "Google" });
            listaEmpresas.Add(new Empresa { Id = 2, Nombre = "Pildoras Informaticas" });

            listaEmpleados.Add(new Empleado { Id = 1, Nombre = "Yhaizley RV", Cargo = "Ceo", Salario = 150000, EmpresaId = 1 });
            listaEmpleados.Add(new Empleado { Id = 2, Nombre = "Juan David", Cargo = "Ceo", Salario = 180000, EmpresaId = 2 });
            listaEmpleados.Add(new Empleado { Id = 3, Nombre = "Margot", Cargo = "Co-Ceo", Salario = 1100, EmpresaId = 1 });
           

        
        }

        public void getCeo()
        {
            IEnumerable<Empleado> ceos = from empleado in listaEmpleados where empleado.Cargo == "Ceo" select empleado;

            foreach (Empleado empleado1 in ceos)
            {
                empleado1.getDatosEmpleado();
                
            }
        
        }



        public void getSalario()
        {
            IEnumerable<Empleado> salario = from elSalario in listaEmpleados where elSalario.Salario < 100000 select elSalario; 

            foreach(Empleado salario1 in salario)
            {
                salario1.getDatosEmpleado();
            }
        }

        public void getEmpleadosOrdenados()
        {
            IEnumerable<Empleado> empleados = from empleado in listaEmpleados orderby empleado.Nombre select empleado;

            foreach (Empleado empleado1 in empleados)
            {
                empleado1.getDatosEmpleado();

            }
        }

        public void getEmpleadosEmpresa(int Id)
        {
            IEnumerable<Empleado> empleadosPil = from empleado in listaEmpleados join empresa in listaEmpleados
                                              on empleado.EmpresaId equals empresa.Id
                                              where empresa.Id==Id
                                              select empleado;



            foreach (Empleado empleado1 in empleadosPil)
            {
                empleado1.getDatosEmpleado();

            }
        }




        public List<Empresa> listaEmpresas;
        public List<Empleado> listaEmpleados;
    }


    class Empresa
    {
        public int Id { get; set; }

        public string Nombre{ get; set; }

        public void getDatosEmpresa()
        {
            Console.WriteLine("Empresa {0} con Id {1}", Nombre, Id);
        }

    }


    class Empleado
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Cargo { get; set; }

        public double Salario { get; set; }

        //Clave Foranea
        public int EmpresaId { get; set; }

        public void getDatosEmpleado()
        {
            Console.WriteLine("Empleado {0} con Id {1}, cargo {2} con salario {3}  pertenece a la empresa {4}", Nombre, Id, Cargo, Salario, EmpresaId);

        }

    }
}


