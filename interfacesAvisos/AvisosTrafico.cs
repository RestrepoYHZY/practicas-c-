using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacesAvisos
{
   

    class AvisosTrafico : IAvisos
    {
        public AvisosTrafico()
        {
            remitente = "DGT";

            mensaje = "Sancion Cometida. Pague antes de 3 dias y obtendra beneficios";
            
            fecha = "";

        }

        public AvisosTrafico(String remitente, string mensaje, string fecha)
        {
            this.remitente = remitente;
            this.mensaje = mensaje;
            this.fecha = fecha;
        }


        public string getFecha()
        {
            return fecha;
        }

        public void mostrarAviso()
        {
            Console.WriteLine("Mensaje: {0} ha sido enviado por {1} el dia {2}",mensaje, remitente, fecha);
        }

        private string remitente;
        private string mensaje;
        private string fecha;
    }
}
