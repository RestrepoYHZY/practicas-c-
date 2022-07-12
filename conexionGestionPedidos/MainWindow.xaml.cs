using System.Windows;
using System.Windows.Controls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System;

namespace conexionGestionPedidos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            string miConexion = ConfigurationManager.ConnectionStrings["conexionGestionPedidos.Properties.Settings.GestionPedidosConnectionString"].ConnectionString;

            miConexionSql = new SqlConnection(miConexion);

            MuestraClientes();
            MuestraTodosPedidos();
        }

        private void MuestraClientes()
        {
            try
            {
                string consulta = "SElECT * FROM cliente"; //consulta sql

                SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(consulta, miConexionSql);

                using (miAdaptadorSql)
                {
                    DataTable clientesTbla = new DataTable();

                    miAdaptadorSql.Fill(clientesTbla);

                    listaClientes.DisplayMemberPath = "nombre"; //expecificaciones de lo que se busca
                    listaClientes.SelectedValuePath = "Id";
                    listaClientes.ItemsSource = clientesTbla.DefaultView;
                }
            }catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }


       



        private void MuestraPedidos()
        {
            try {
                string consulta = "SElECT * FROM pedido P INNER JOIN cliente C ON C.ID=P.cCliente" +
                    " WHERE C.ID=@ClienteId"; //consulta sql

                SqlCommand sqlComando = new SqlCommand(consulta, miConexionSql);

                SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(sqlComando);

                using (miAdaptadorSql) 
                { 

                    sqlComando.Parameters.AddWithValue("@ClienteId", listaClientes.SelectedValue);
            
                    DataTable pedidosTabla = new DataTable();

                    miAdaptadorSql.Fill(pedidosTabla);

                    listaPedidos.DisplayMemberPath = "fechaPedido"; //expecificaciones de lo que se busca
                    listaPedidos.SelectedValuePath = "Id";
                    listaPedidos.ItemsSource = pedidosTabla.DefaultView;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }



        private void MuestraTodosPedidos()
        {
            try {
                string consulta = "SElECT *, CONCAT (cCliente, ' ', fechaPedido, ' ',formaPago) AS INFOPEDIDOS FROM PEDIDO"; //consulta sql

                SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(consulta, miConexionSql);

                using (miAdaptadorSql)
                {
                    DataTable pedidosTbla = new DataTable();

                    miAdaptadorSql.Fill(pedidosTbla);

                    todosPedidos.DisplayMemberPath = "INFOPEDIDOS"; //expecificaciones de lo que se busca
                    todosPedidos.SelectedValuePath = "Id";
                    todosPedidos.ItemsSource = pedidosTbla.DefaultView;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }


        SqlConnection miConexionSql;



       /* private void listaClientes_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            //MessageBox.Show("has hecho click en un cliente");
            MuestraPedidos();
        }*/

        private void Button_Click(object sender, RoutedEventArgs e)
        {
                // MessageBox.Show(todosPedidos.SelectedValue.ToString());

                string consulta = "DELETE FROM PEDIDO WHERE ID=@PEDIDOID";

                SqlCommand misqlComand = new SqlCommand(consulta, miConexionSql);

                miConexionSql.Open();

                misqlComand.Parameters.AddWithValue("@PEDIDOID", todosPedidos.SelectedValue);

                misqlComand.ExecuteNonQuery();

                miConexionSql.Close();

                MuestraTodosPedidos();
            }




        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string consulta = "INSERT INTO CLIENTE (nombre) VALUES (@nombre)";

            SqlCommand misqlComand = new SqlCommand(consulta, miConexionSql);

            miConexionSql.Open();

            misqlComand.Parameters.AddWithValue("@nombre", insertarCliente.Text);

            misqlComand.ExecuteNonQuery();

            miConexionSql.Close();

            MuestraClientes();

            insertarCliente.Text = "";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string consulta = "DELETE FROM CLIENTE WHERE ID=@CLIENTEID";

            SqlCommand misqlComand = new SqlCommand(consulta, miConexionSql);

            miConexionSql.Open();

            misqlComand.Parameters.AddWithValue("@CLIENTEID",listaClientes.SelectedValue);

            misqlComand.ExecuteNonQuery();

            miConexionSql.Close();

            MuestraClientes();
        }

       

        private void listaClientes_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            MuestraPedidos();
        }


        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Actualiza ventanaActualizar = new Actualiza((int)listaClientes.SelectedValue);


            try
            {
                string consulta = "SElECT nombre FROM cliente where Id=@CLID"; //consulta sql

                SqlCommand sqlCommand = new SqlCommand(consulta, miConexionSql);

                SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(sqlCommand);

                using (miAdaptadorSql)
                {
                    sqlCommand.Parameters.AddWithValue("@CLID", listaClientes.SelectedValue);

                    DataTable clientesTabla = new DataTable();

                    miAdaptadorSql.Fill(clientesTabla);

                    ventanaActualizar.cuadroActualizar.Text = clientesTabla.Rows[0]["nombre"].ToString();

                }
            }
            catch (Exception e2)
            {
                MessageBox.Show(e.ToString());
            }


            ventanaActualizar.ShowDialog();

            MuestraClientes();


        }
    }
 }

