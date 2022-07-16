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

namespace calculadora
{

    public enum Operacion
    {
        noDefinida= 0,
        Suma =1,
        Resta=2,
        Division=3,
        Multiplicacion = 4,
        Modulo=5
    }
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        double valor1 = 0;
        double valor2 = 0;
        Operacion operador = Operacion.noDefinida;
        bool unNumeroLeido = false;

        public MainWindow()
        {
            InitializeComponent();


        }


        private void leerNumero(string numero) {

            unNumeroLeido = true;

            if (cajaResultado.Text == "0" && cajaResultado.Text != null)
            {
                cajaResultado.Text = numero;
            }
            else
            {
                cajaResultado.Text += numero;
            }
        }

        private double EjecutarOperacion ()
        {
            double resultado = 0;
            switch (operador)
            {

                case Operacion.Suma:
                    resultado = valor1 + valor2;
                    break;
                case Operacion.Resta:
                    resultado = valor1 - valor2;
                    break;
                case Operacion.Division:
                    if(valor2 ==0)
                    {
                        // MessageBox.Show("No se puede dividir entre 0");
                        lblHistorial.Text = "No se puede dividir entre 0";
                        resultado = 0;
                    }
                    else
                    {
                        resultado = valor1 / valor2;
                    }
                  
                    break;
                case Operacion.Multiplicacion:
                    resultado = valor1 * valor2;
                    break;
                case Operacion.Modulo:
                    resultado = valor1 % valor2;
                    break;
            }
            return resultado;
        }


        private void btnCero_Click(object sender, RoutedEventArgs e)
        {
            unNumeroLeido = true; 
            if (cajaResultado.Text == "0")
            {
                return;
            }
            else
            {
                cajaResultado.Text += "0";
            }

        }

        private void btnUno_Click(object sender, RoutedEventArgs e)
        {
            leerNumero("1");
        }

        private void btnDos_Click(object sender, RoutedEventArgs e)
        {
            leerNumero("2");
        }

        private void btnTres_Click(object sender, RoutedEventArgs e)
        {
            leerNumero("3");
        }

        private void btnCuatro_Click(object sender, RoutedEventArgs e)
        {
            leerNumero("4");
        }

        private void btnCinco_Click(object sender, RoutedEventArgs e)
        {
            leerNumero("5");
        }

        private void btnSeis_Click(object sender, RoutedEventArgs e)
        {
            leerNumero("6");
        }

        private void btnSiete_Click(object sender, RoutedEventArgs e)
        {
            leerNumero("7");
        }

        private void btnOcho_Click(object sender, RoutedEventArgs e)
        {
            leerNumero("8");
        }

        private void btnNueve_Click(object sender, RoutedEventArgs e)
        {
            leerNumero("9");
        }


        private void ObtenerValor(string operador)
        {
            valor1 = Convert.ToDouble(cajaResultado.Text);
            lblHistorial.Text = cajaResultado.Text + operador;
            cajaResultado.Text = "0";
        }


        private void btnSuma_Click(object sender, RoutedEventArgs e)
        {
            operador = Operacion.Suma;
            ObtenerValor("+");
          

        }

        private void btnIgual_Click(object sender, RoutedEventArgs e)
        {
            if (valor2 == 0 && unNumeroLeido)
            {
                valor2 = Convert.ToDouble(cajaResultado.Text);
                lblHistorial.Text += valor2 + "=";
                double resultado = EjecutarOperacion();
                valor1 = 0;
                valor2 = 0;
                unNumeroLeido = false;
                cajaResultado.Text = Convert.ToString(resultado);


            }

        }

        private void btnResta_Click(object sender, RoutedEventArgs e)
        {
            operador = Operacion.Resta;
            ObtenerValor("-");
        }

        private void btnMult_Click(object sender, RoutedEventArgs e)
        {

            operador = Operacion.Multiplicacion;
            ObtenerValor("x");
        }

        private void btnDivision_Click(object sender, RoutedEventArgs e)
        {

            operador = Operacion.Division;
            ObtenerValor("/");
        }

        private void btnMod_Click(object sender, RoutedEventArgs e)
        {

            operador = Operacion.Modulo;
            ObtenerValor("%");
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            cajaResultado.Text = "0";
            lblHistorial.Text="";

        }

        private void btnBorrar_Click(object sender, RoutedEventArgs e)
        {
            if (cajaResultado.Text.Length > 1)
            {
                string txtResultado = cajaResultado.Text;
                txtResultado = txtResultado.Substring(0, txtResultado.Length - 1);

                if (txtResultado.Length == 1 && txtResultado.Contains("-"))
                {
                    cajaResultado.Text = "0";
                }
                else
                {
                    cajaResultado.Text = txtResultado;
                }               
              
                
            }
            else
            {
                cajaResultado.Text = "0";
            }
        }

        private void btnPunto_Click(object sender, RoutedEventArgs e)
        {
            if (cajaResultado.Text.Contains("."))
            {
                return;

            }
            cajaResultado.Text += ".";
        }
    }
}
