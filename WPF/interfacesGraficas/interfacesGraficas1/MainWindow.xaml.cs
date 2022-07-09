using System;
using System.Windows;
using System.Windows.Input;

namespace interfacesGraficas1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Le has dado al boton 2");
        }

        /*private void Panel_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Le has dado al Panel");
        }*/

        private void Panel_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("Le has dado al Panel");
        }
    }
}
