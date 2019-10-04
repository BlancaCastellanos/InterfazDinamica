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

namespace InterfazDinamica2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            BGuardar.Visibility = Visibility.Hidden;
            BCancelar.Visibility = Visibility.Hidden;
        }

        private void Boton1_Click(object sender, RoutedEventArgs e)
        {
            grdParametrosUsuarios.Children.Add(new ParametroAlumno());
        }

        private void cbDato_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            grdParametrosUsuarios.Children.Clear();
        }

        private void BAgregarC(object sender, RoutedEventArgs e)
        {
            switch (cbDato.SelectedIndex)
            {
                case 0:  //Alumno
                    grdParametrosUsuarios.Children.Add(new ParametroAlumno());
                    BGuardar.Visibility = Visibility.Visible;
                    BCancelar.Visibility = Visibility.Visible;
                    break;

                case 1:  //Maestro
                    grdParametrosUsuarios.Children.Add(new ParametroMaestro());
                    BGuardar.Visibility = Visibility.Visible;
                    BCancelar.Visibility = Visibility.Visible;
                    break;
            }
        }

        private void BCancelarC(object sender, RoutedEventArgs e)
        {
            grdParametrosUsuarios.Children.Clear();
            BGuardar.Visibility = Visibility.Hidden;
            BCancelar.Visibility = Visibility.Hidden;
        }

        private void BGuardarC(object sender, RoutedEventArgs e)
        {
            grdParametrosUsuarios.Children.Clear();
            BGuardar.Visibility = Visibility.Hidden;
            BCancelar.Visibility = Visibility.Hidden;
        }
    }
}


