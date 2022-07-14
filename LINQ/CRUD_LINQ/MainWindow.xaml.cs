using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;

namespace CRUD_LINQ
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataClasses1DataContext dataContext;

        public MainWindow()
        {
            InitializeComponent();

            string miConexion = ConfigurationManager.ConnectionStrings["CRUD_LINQ.Properties.Settings.CruedLinqSql"].ConnectionString;

            dataContext = new DataClasses1DataContext(miConexion);

            //InsertarEmpresas();
            //InsertarEmpleados();
            //InsertarCargos();
            //InsertaEmpleadoCargo();
            // ActualizaEmpleado();
            EliminaEmpleado();



        }

        public void InsertarEmpresas()
        {
           // dataContext.ExecuteCommand("delete from Empresa"); //Eliminar

            empresa pildorasInformaticas = new empresa();

            pildorasInformaticas.Nombre = "Pildoras Informaticas";
            dataContext.empresa.InsertOnSubmit(pildorasInformaticas);

            empresa empresaGoogle = new empresa();

            empresaGoogle.Nombre = "Google";
            dataContext.empresa.InsertOnSubmit(empresaGoogle);


            dataContext.SubmitChanges();

            Principal.ItemsSource = dataContext.empresa;


        }


        public void InsertarEmpleados()
        {
            empresa pildorasInformaticas = dataContext.empresa.First(em => em.Nombre.Equals("Pildoras Informaticas"));
            empresa empresaGoogle = dataContext.empresa.First(em => em.Nombre.Equals("Google"));

            List<empleado> listaEmpleados = new List<empleado>();

            listaEmpleados.Add(new empleado { Nombre = "Juan", Apellido = "Beltran", EmpresaId = pildorasInformaticas.Id });
            listaEmpleados.Add(new empleado { Nombre = "Jose", Apellido = "Ramirez", EmpresaId = pildorasInformaticas.Id });
            listaEmpleados.Add(new empleado { Nombre = "Anna", Apellido = "Perez", EmpresaId = empresaGoogle.Id });
            listaEmpleados.Add(new empleado { Nombre = "Maria", Apellido = "Altez", EmpresaId = empresaGoogle.Id });
        
            dataContext.empleado.InsertAllOnSubmit(listaEmpleados);

            dataContext.SubmitChanges();

            Principal.ItemsSource = dataContext.empleado;


        }


        public void InsertarCargos()
        {
            dataContext.cargo.InsertOnSubmit(new cargo { NombreCargo = "Ddirector/a" });
            dataContext.cargo.InsertOnSubmit(new cargo { NombreCargo = "Administrativo/a" });

            dataContext.SubmitChanges();

            Principal.ItemsSource = dataContext.cargo;

        }

        public void InsertaEmpleadoCargo()
        {
            empleado Juan = dataContext.empleado.First(em => em.Nombre.Equals("Juan"));
            empleado Jose = dataContext.empleado.First(em => em.Nombre.Equals("Anna"));
            empleado Anna = dataContext.empleado.First(em => em.Nombre.Equals("Anna"));
            empleado Maria= dataContext.empleado.First(em => em.Nombre.Equals("Anna"));


            cargo cDirector = dataContext.cargo.First(cg => cg.NombreCargo.Equals("Ddirector/a"));
            cargo cAdtvo = dataContext.cargo.First(cg => cg.NombreCargo.Equals("Administrativo/a"));

           /* cargoEmpleado cargoJuan = new cargoEmpleado();

            cargoJuan.empleado = Juan;
            cargoJuan.CargoId = cDirector.Id;*/


            List<cargoEmpleado> listaCargosEmpleados = new List<cargoEmpleado>();

            listaCargosEmpleados.Add(new cargoEmpleado { empleado = Juan, cargo = cDirector });
            listaCargosEmpleados.Add(new cargoEmpleado { empleado = Jose, cargo = cAdtvo });
            listaCargosEmpleados.Add(new cargoEmpleado { empleado = Anna, cargo = cDirector });
            listaCargosEmpleados.Add(new cargoEmpleado { empleado = Maria, cargo = cAdtvo});


            dataContext.cargoEmpleado.InsertAllOnSubmit(listaCargosEmpleados);

            dataContext.SubmitChanges();
            Principal.ItemsSource = dataContext.cargoEmpleado;

            
        }


        public void ActualizaEmpleado()
        {
            empleado Maria = dataContext.empleado.First(em => em.Nombre.Equals("Maria"));

            Maria.Nombre = "Maria Angeles";

            dataContext.SubmitChanges();
            Principal.ItemsSource = dataContext.empleado;


        }

        public void EliminaEmpleado()
        {
            empleado Juan = dataContext.empleado.First(em => em.Nombre.Equals("Juan"));
       
            dataContext.empleado.DeleteOnSubmit(Juan);

            dataContext.SubmitChanges();
            Principal.ItemsSource = dataContext.empleado;

        }
    }
}
