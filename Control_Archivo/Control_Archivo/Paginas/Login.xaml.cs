using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.DirectoryServices.ActiveDirectory;
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
using System.Windows.Shapes;

namespace Control_Archivo
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
            string usuario= Environment.UserName;
            txtUsuario.Text = usuario;
        }

        public string ObtenerUsuario()
        {
            string usuario = Environment.UserName;
            return usuario;
        }
       
      
        private bool AutenticarUsuario(string patch ,string user,string pass) //Metodo para validar credenciales
        {
  
             DirectoryEntry entrada = new DirectoryEntry(patch,user,pass,AuthenticationTypes.Secure);

            try
            {
                //inicia el cheque de credenciales con los datos recibidos, 
                //si devuelve algo es que se validaron las credenciales
                DirectorySearcher buscador = new DirectorySearcher(entrada);
                buscador.FindOne();
                return true;
            }

            catch
            {
                //si no devuleve nada es que no se pudo auntentificar las credenciales
                return false;
            }
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            string patch = @"LDAP://192.168.100.9";
            string dominio = @"inetttijuana";
            string usuario = txtUsuario.Text.Trim();// trim elimina los espacios presionados por el usuario
            string password = txtPassword.Password;
            string DominioUsuario = dominio + @"\" + usuario;

            bool permiso = AutenticarUsuario(patch, DominioUsuario, password);

            if (permiso==true)
            {
              var Main = new MainWindow();
              MessageBox.Show("Acceso Correcto");
              this.Close();
              Main.Show();
               
            }
            else
            {
                MessageBox.Show("Acceso Incorrecto");
            }

        }
    }
}
