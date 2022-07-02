using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Caballo Babieca = new Caballo("Babieca");

            Humano Juan = new Humano("Juan");

            Gorila Copito = new Gorila("Copito");

            Mamiferos[] almacenAnimales = new Mamiferos[3];

            almacenAnimales[0] = Babieca;

            almacenAnimales[1] = Juan;

            almacenAnimales[2] = Copito;

            for (int i = 0; i < 3; i++)
            {
                almacenAnimales[i].pensar();

            }

            //Juan.getNombre();
            //Babieca.getNombre();
            //Copito.getNombre();

        }
    }

    class Mamiferos
    {
        public Mamiferos(String nombre)
        {
            nombreSerVivo = nombre;
        }

        public void respirar()
        {
            Console.WriteLine("Soy capaz de caminar");
        }

        public virtual void pensar()
        {
            Console.WriteLine("Pensamiento Básico");
        }

        public void cuidarCrias()
        {
            Console.WriteLine("Cuido de mis crias");
        }

        public void getNombre()
        {
            Console.WriteLine("El nombre del ser vivo es: "+nombreSerVivo);
        }

        private String nombreSerVivo;

    }

    class Caballo : Mamiferos
    {
        public Caballo(String nombreCaballo) : base(nombreCaballo)
        {
           
        }
        
        public void galopar()
        {
            Console.WriteLine("Me encanta galopar");
        }
    }

    class Humano : Mamiferos
    {

        public Humano(String nombreHuman) : base(nombreHuman)
        {

        }
        public override void pensar()
        {
            Console.WriteLine("Soy habil pensando");
        }
    }

    class Gorila : Mamiferos
    {
        public Gorila(String nombreGorila) : base(nombreGorila)
        {
        }

        public override void pensar()
        {
            Console.WriteLine("Pensar, of course! me too");
        }
        public void trepar()
        {
            Console.WriteLine("Trepo por mis bananas");
        }
    }
}
