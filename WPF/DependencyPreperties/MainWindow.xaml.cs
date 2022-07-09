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

namespace DependencyPreperties
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        //Crear la propiar property

        public int MiProperty
        {
            get { return (int)GetValue(miDependency); }

            set { SetValue(miDependency, value);           
        }

        //Registrar la Property

        public static readonly DependencyProperty miDependency =
        DependencyProperty.Register("MiProperty", typeof(int), typeof(MainWindow, new PropertyMetadata(0));
        public MainWindow()
        {
            InitializeComponent();

        }  
    }
}
