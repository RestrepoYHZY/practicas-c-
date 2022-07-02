using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Avion avion1 = new Avion("James");

            Vehiculo vehiculo1 = new Vehiculo("Juan");

            Coche coche1 = new Coche("Pedro");

            //Trabajar con el metodo virtual
            Transporte[] almacenarTransportes = new Transporte[3];

            almacenarTransportes[0] = avion1;
            almacenarTransportes[1] = vehiculo1;
            almacenarTransportes[2] = coche1;

            for (int i= 0; i<3; i++)
            {
                almacenarTransportes[i].conducir();
            }

            /* llamar nombre conductores 
            avion1.getConductor();
            vehiculo1.getConductor();
            coche1.getConductor();*/
        }

        class Transporte
        {
            public Transporte(String nombre)//constructor
            {
                conductor = nombre;
            }

            public void arrancarMotor()
            {
                Console.WriteLine("El motor esta encendido");
            }

            public void pararMotor() 
                {
                    Console.WriteLine("El motor esta apagado");
                } 

            public virtual void conducir()
            {
                Console.WriteLine("Comienzo a conducir");
            }

            public void getConductor()
            {
                Console.WriteLine("El nombre del conductor es: " + conductor);
            }

            private String conductor;
            
        }

        class Avion : Transporte
        {
            public Avion(String conductorAvion):base (conductorAvion)
            {

            }

            public override void conducir()
            {
                Console.WriteLine("Conduzco por los Aires");
            }
        }

        class Vehiculo : Transporte
        {
            public Vehiculo(String conductorVehiculo):base (conductorVehiculo)
            {

            }

            public override void conducir()
            {
                Console.WriteLine("Conduzco el vehiculo por Tierra");
            }

        }

        class Coche : Transporte
        {
            public Coche(String conductorCoche):base(conductorCoche)
            {

            }

            public override void conducir()
            {
                Console.WriteLine("Conduzco el coche por Tierra");
            }
        }
       
    }
}
