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

namespace AplicacionAutobuses
{
    /// <summary>
    /// Lógica de interacción para MenuIncidencias.xaml
    /// </summary>
    public partial class MenuIncidencias : Window
    {
        public MenuIncidencias()
        {
            InitializeComponent();
        }

        private void IrAMenuInfo(object sender, RoutedEventArgs e)
        {
            MenuInfo menuInfo = new MenuInfo();
            menuInfo.Show();

            this.Close();
        }

        private void enviar(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("La incidencia ha sido enviada con éxito", "Éxito", MessageBoxButton.OK, MessageBoxImage.Information);

            // Borra el contenido de todos los TextBox
            LimpiarTextBoxes(this);
        }
        private void LimpiarTextBoxes(DependencyObject parent)
        {
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(parent); i++)
            {
                DependencyObject child = VisualTreeHelper.GetChild(parent, i);

                if (child is TextBox)
                {
                    TextBox textBox = (TextBox)child;
                    textBox.Clear();
                }

                // Llama recursivamente al método para los elementos secundarios del contenedor actual
                LimpiarTextBoxes(child);
            }
        }
    }
}
