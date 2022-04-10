using System;
using System.Collections.Generic;
using System.Data;
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
using Npgsql;

namespace Control_Archivo.Paginas
{
    /// <summary>
    /// Interaction logic for Expedientes.xaml
    /// </summary>
    public partial class Expedientes : Page
    {

        NpgsqlConnection conexion = new NpgsqlConnection("Server=192.168.100.14;Port=5432; User Id=postgres;Password=Indivi2022*.;Database=Archivo");
        string query = "Select id_expediente,clave,propietario,fraccionamiento,disponibilidad,observaciones from expedientes order by id_expediente asc";

      


        public Expedientes()
        {
            InitializeComponent();
            CargarExpedientes();
        }

        public void CargarExpedientes()
        {
            NpgsqlCommand comando = new NpgsqlCommand(query, conexion);


            NpgsqlDataAdapter data = new NpgsqlDataAdapter(comando);
            conexion.Open();

            data.SelectCommand = comando;
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            DGExpedientes.ItemsSource = tabla.DefaultView;
            conexion.Close();
        }

        

        private void DGExpedientes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataRowView row = DGExpedientes.SelectedItem as DataRowView;
            txtClave.Text = Convert.ToString(row["clave"]);
            txtPropietario.Text= Convert.ToString(row["propietario"]);
            txtFraccionamiento.Text = Convert.ToString(row["fraccionamiento"]);


        }
    }
    
}
