using System.Windows;
using System.Windows.Controls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System;

namespace conexionGestionPedidos
{
    /// <summary>
    /// Lógica de interacción para Actualiza.xaml
    /// </summary>
    public partial class Actualiza : Window
    {


        SqlConnection miConexionSql;

        private int z; 
        public Actualiza(int elId)
        {
            InitializeComponent();

            z = elId;

            string miConexion = ConfigurationManager.ConnectionStrings["conexionGestionPedidos.Properties.Settings.GestionPedidosConnectionString"].ConnectionString;

            miConexionSql = new SqlConnection(miConexion);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string consulta = "UPDATE CLIENTE SET nombre=@nombre WHERE Id=" +z;

            SqlCommand misqlComand = new SqlCommand(consulta, miConexionSql);

            miConexionSql.Open();

            misqlComand.Parameters.AddWithValue("@nombre", cuadroActualizar.Text);

            misqlComand.ExecuteNonQuery();

            miConexionSql.Close();

            this.Close();

        }
    }
}
