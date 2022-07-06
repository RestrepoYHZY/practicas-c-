using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crearobjeto delegate-Apuntar delegate
            ObjetoDelegate delegate1 = new ObjetoDelegate(MensajeWelcome.SaludoWelcome);

            //llamar
            delegate1("Hello!Welcome to home");

            delegate1 = new ObjetoDelegate(MensajeGoodbye.SaludoGoodbye);
            delegate1("Bye bye, see you later!");
        }
        //Definicion del objeto delegado
        delegate void ObjetoDelegate(String msj);
    }

    class MensajeWelcome
    {
        public static void SaludoWelcome( string msj)
        {
            Console.WriteLine("Mensaje de Bienvenida: {0} ",msj);
        }
    }

    class MensajeGoodbye
    {
        public static void SaludoGoodbye(String msj)
        {
            Console.WriteLine("Mensaje despedida: {0} ",msj);
        }
    }
}
