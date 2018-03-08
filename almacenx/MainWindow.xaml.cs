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

namespace almacenx
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
<<<<<<< HEAD

        private void Button_Click(object sender, RoutedEventArgs e)
        {

=======
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Usuario u = new Usuario(txUsuario.Text, txPassword.Text);
            u.iniciar();
>>>>>>> 7bda7cc265669c581e68227f94a7774ed14a1962
        }
    }
}
