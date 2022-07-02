using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Coche coche1 = new Coche();

            Console.WriteLine(coche1.getInfoCoche());

            Coche coche2 = new Coche(23.344, 3434.4);
            Console.WriteLine(coche2.getInfoCoche());

            coche2.setExtras(true, "cuero");
            Console.WriteLine(coche2.getExtras());

        }
    }

    class Coche
    {

        public Coche()
        {
            ruedas = 4;
            largo = 2330.5;
            ancho = 0.800;
            tapiceria = "tela";
        }

        public Coche (double largoCoche, double anchoCoche)
        {
            ruedas = 4;
            largo = largoCoche;
            ancho = anchoCoche;
            tapiceria = "tela";

        }

        public String getInfoCoche()
        {
            return "Informacion del coche: "+ ruedas + " "+largo + " " + ancho;
        }

        public void setExtras(bool Climatizador, String Tapiceria)
        {
            this.climatizador = Climatizador;
            this.tapiceria = Tapiceria;

        }
        public String getExtras()
        {
            return "Extras del coche: \n" + "tapiceria: " + tapiceria + " climatizador: " + climatizador;
            
        }


        private int ruedas;
        private double largo;
        private double ancho;
        private bool climatizador;
        private String tapiceria;


    }
}
