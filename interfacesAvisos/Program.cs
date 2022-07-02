using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacesAvisos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AvisosTrafico aviso1 = new AvisosTrafico();
            aviso1.mostrarAviso();

            AvisosTrafico aviso2 = new AvisosTrafico("Jefatura Colombia", "Sancion de velocidad", "02/07/2022");
            Console.WriteLine(aviso2.getFecha()); 
            aviso2.mostrarAviso();
        }

    }
}
