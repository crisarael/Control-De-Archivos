using Control_Archivo.Paginas;
using System;
using System.Collections.Generic;
using System.DirectoryServices;
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

using System.Net;
using System.Net.NetworkInformation;

namespace Control_Archivo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //variables de acceso al activi directory
        string ldapAddress = "LDAP://192.168.100.9";
        string username = "alimones";
        string password = "Asael05";

        //usuario actual
        public string usuario = "alimones";
        public string NombreUsuario = Environment.UserName;
        public string NombrePc = Environment.MachineName;

        public MainWindow()
        {
            InitializeComponent();
            frameNavegacion.Navigate(new Expedientes());

            DirectoryEntry de = new DirectoryEntry(ldapAddress, username, password);

            DirectorySearcher ds = new DirectorySearcher(de);

            ds.Filter = "(&((&(objectCategory=Person)(objectClass=User)))(samaccountname=" + usuario + "))";

            ds.SearchScope = SearchScope.Subtree;

            SearchResult rs = ds.FindOne();

            IPHostEntry host;
            string localIP = "";
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    localIP = ip.ToString();
                }
            }

            if (rs.GetDirectoryEntry().Properties["displayName"].Value != null)
               lblNombreUsuario.Text = NombreUsuario;
               lblNombreCompleto.Text = rs.GetDirectoryEntry().Properties["displayName"].Value.ToString();
               lblNombrePC.Text = NombrePc;
               lblNombreIP.Text = localIP;
        }

        private void RdSalir_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void RdExpedientes_Click(object sender, RoutedEventArgs e)
        {
            frameNavegacion.Navigate(new Expedientes());
        }

        private void Solicitar_Click(object sender, RoutedEventArgs e)
        {
            frameNavegacion.Navigate(new Solicitar());
        }

        private void Rdsolicitudes_Click(object sender, RoutedEventArgs e)
        {
            frameNavegacion.Navigate(new MisSolicitudes());
        }
  
    }
}
