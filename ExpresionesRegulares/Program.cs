using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExpresionesRegulares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frase = "Mi nombre es Juan y mi n° de tgno es (+34)123-45-67, (+57)323-355-6777  y mi codigo postal es 25655";

           string patron = "[J]";
           //String patron =@"\+34|\+57"; //Dos busquedas de coincidencia

            Regex miRegex = new Regex(patron);

            MatchCollection elMath = miRegex.Matches(frase);

            if (elMath.Count > 0) Console.WriteLine("Se ha encontrado una J");
            else Console.WriteLine("No se ha encontrado J");
        
        }
    }
}
