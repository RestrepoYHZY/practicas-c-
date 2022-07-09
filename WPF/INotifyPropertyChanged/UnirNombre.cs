using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace INotifyPropertyChanged
{

    public class UnirNombre : INotifyPropertyChanged

    {
      

        private string nombre, apellido, nombreCompleto;
 
         public event PropertyChangedEventHandler PropertyChanged;
    
        private void OnPropertyChanged(String property)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        public string Nombre
        {
            get { return nombre;}
            set { nombre = value;
                OnPropertyChanged("nombreCompleto");
            }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value;
                OnPropertyChanged("nombreCompleto");
            }
        }

        public string NombreCompleto
        {
            get {
            nombreCompleto = Nombre + " " + Apellido;
                return nombreCompleto;
            }
            set { }
        }
    }
}
