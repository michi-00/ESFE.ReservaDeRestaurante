using ESFE.Restaurante.BL;
using ESFE.Restaurante.EN;
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
using System.Windows.Shapes;

namespace ESFE.Restaurante.UI
{
    /// <summary>
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        private bool isPasswordVisible = false;
        private string textoReal = "";
        public Login()
        {
            InitializeComponent();
        }
        UsuarioEN pusuarioEN = new UsuarioEN();
        UsuarioBL pusuarioBL = new UsuarioBL();
        List<UsuarioEN> lisc = new List<UsuarioEN>();
        EmpleadoEN empleadoEN = new EmpleadoEN();
        EmpleadoBL empleadoBL = new EmpleadoBL();


        private void btnAcceder_Click(object sender, RoutedEventArgs e)
        {
            if (txtNombre.Text != "" && txtClave.Password != "" && cbRol.Text != "")
            {
                pusuarioEN.Nombre = txtNombre.Text;
                pusuarioEN.Clave = txtClave.Password;
                pusuarioEN.Rol = cbRol.Text;
                var eNs = pusuarioBL.VerificarUsuario(pusuarioEN);
                if (eNs == 1)
                {
                    if (pusuarioEN.Rol == "Empleado")
                    {
                        InicioEmpleado inicioE = new InicioEmpleado();
                        inicioE.Show();
                        this.Hide();
                    }
                    else if (pusuarioEN.Rol == "Administrador")
                    {
                        lisc = pusuarioBL.MostrarUsuario(pusuarioEN);
                        MENU inicioC = new MENU(pusuarioEN.Nombre, pusuarioEN.Rol);
                        inicioC.Show();
                        this.Hide();

                    }
                }
                else
                {
                    MessageBox.Show("Las credenciales son incorrectas", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                }

            }
            else
            {
                MessageBox.Show("Los datos están vacíos, inténtelo de nuevo");
            }

        }
        private void pbPassword_Click(object sender, MouseButtonEventArgs e)
        {

            
            if (isPasswordVisible)
            {
                textoReal = txtClave.Password;
                txtClave.Visibility = Visibility.Collapsed;
                txtClave.Password = textoReal;
                txtClave.Visibility = Visibility.Visible;
                pbPassword.Source = new BitmapImage(new Uri("ojo.png", UriKind.Relative));
            }
            else
            {
                textoReal = txtClave.Password;
                txtClave.Visibility = Visibility.Collapsed;
                txtClave.Visibility = Visibility.Visible;
                pbPassword.Source = new BitmapImage(new Uri("ojo (1).png", UriKind.Relative));

            }
            isPasswordVisible = !
                isPasswordVisible;
            
            
            
        }

        private void btnCerrar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
