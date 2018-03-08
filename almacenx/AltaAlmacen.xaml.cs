<<<<<<< HEAD
﻿using System;
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

namespace almacenx
{
    /// <summary>
    /// Lógica de interacción para AltaAlmacen.xaml
    /// </summary>
    public partial class AltaAlmacen : Window
    {
        Window parent;
        public AltaAlmacen(Window parent)
        {
            InitializeComponent();
            this.parent = parent;
            Connection.fillArticles(cbArticulo);
            Connection.fillUsers(cbIdUser);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            new MainWindow().Show();
        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
=======
﻿using System;
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

namespace Almacen
{
    /// <summary>
    /// Lógica de interacción para AltaAlmacen.xaml
    /// </summary>
    public partial class AltaAlmacen : Window
    {
        public AltaAlmacen()
        {
            InitializeComponent();
        }
    }
}
>>>>>>> 7bda7cc265669c581e68227f94a7774ed14a1962
