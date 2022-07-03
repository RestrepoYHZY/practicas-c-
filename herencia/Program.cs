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
            //Caballo Babieca = new Caballo("Babieca");
            //ISaltar ImiBabieca = Babieca;

            //Humano Juan = new Humano("Juan");

            //Gorila Copito = new Gorila("Copito");

            //Mamiferos[] almacenAnimales = new Mamiferos[3];

            //almacenAnimales[0] = Babieca;

            //almacenAnimales[1] = Juan;

            //almacenAnimales[2] = Copito;

            //for (int i = 0; i < 3; i++)
            //{
            //    almacenAnimales[i].pensar();

            //}

            ////Juan.getNombre();
            ////Babieca.getNombre();
            ////Copito.getNombre();


            //Ballena miWally = new Ballena("Wally");

            //miWally.nadar();

            //Console.WriteLine("Patas utilizadas para el salto de Babieca " + ImiBabieca.numeroPatas());


            Lagartija Juanita = new Lagartija("Juanita");
            Juanita.respirar();
            Juanita.getNombre();

            Console.WriteLine();

            Humano Juan = new Humano("Juan");
            Juan.respirar();
            Juan.getNombre();
        }
    }

    interface IManiferosTerrestres
    {
        int numeroPatas();
    }

    interface IAnimalesYDeportes
    {
        String tipoDeporte();

        Boolean esOlimpico();
    }

    interface ISaltar
    {
        int numeroPatas();
    }


    abstract class Animales
    {
       public void respirar()
        {
           Console.WriteLine("Soy capaz de respirar");
        }

        public abstract void getNombre();

    }

    class Lagartija : Animales
    {
        public Lagartija(String nombre)
        {
            nombreReptil = nombre; 
        }

        public override void getNombre()
        {
            Console.WriteLine("El nombre de la lagartija es: " + nombreReptil);
        }
    
        private String nombreReptil;
    }


    class Mamiferos:Animales
    {
        public Mamiferos(String nombre)
        {
            nombreSerVivo = nombre;
        }

        public virtual void pensar()
        {
            Console.WriteLine("Pensamiento Básico");
        }

        public void cuidarCrias()
        {
            Console.WriteLine("Cuido de mis crias");
        }

        public override void getNombre()
        {
            Console.WriteLine("El nombre del mamifero es: "+nombreSerVivo);
        }

        private String nombreSerVivo;

    }

    class Ballena : Mamiferos
    {
        public Ballena(String nombreBallena) : base(nombreBallena)
        {
          
        }

        public void nadar()
        {
            Console.WriteLine("I able to swim");
        }
    }

    class Caballo : Mamiferos, IManiferosTerrestres,IAnimalesYDeportes,ISaltar
    {
        public Caballo(String nombreCaballo) : base(nombreCaballo)
        {
           
        }
        
        public void galopar()
        {
            Console.WriteLine("Me encanta galopar");
        }

        int ISaltar.numeroPatas()
        {
            return 2; 
        }
        int IManiferosTerrestres.numeroPatas()
        {
            return 4;
        }

        public String tipoDeporte()
        {
            return "Hípica";
        }
        public Boolean esOlimpico()
        {
            return true; 
        }
    }

    class Humano : Mamiferos, IManiferosTerrestres
    {

        public Humano(String nombreHuman) : base(nombreHuman)
        {

        }
        public  override void pensar()
        {
            Console.WriteLine("Soy habil pensando");
        }

        public int numeroPatas()
        {
            return 2; 
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
