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
    /// Lógica de interacción para MENU.xaml
    /// </summary>
    public partial class MENU : Window
    /// <summary>
    /// Constructor del formulario que recibe nombre y cargo del usuario para mostrarlo en pantalla.
    /// </summary>
    /// <param name="nombreUsuario">Nombre del usuario que inició sesión.</param>
    /// <param name="rol">Cargo del usuario (Gerente).</param>
    {
        public MENU(string nombreUsuario, string rol)
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Mostrar el formulario de login nuevamente
            Login login = new Login();
            login.Show();

            // Cerrar el formulario actual
            this.Close();
        }
    }
}
