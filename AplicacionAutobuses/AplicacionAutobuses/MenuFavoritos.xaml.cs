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
    /// Lógica de interacción para MenuParadas.xaml
    /// </summary>
    public partial class MenuFavoritos : Window
    {
        public MenuFavoritos()
        {
            InitializeComponent();
        }
        private void MenuHamburguesaClick(object sender, RoutedEventArgs e)
        {
            if (MenuCanvas.Visibility == Visibility.Collapsed)
            {
                MenuCanvas.Visibility = Visibility.Visible;
                BotonHamburguesa.Visibility = Visibility.Collapsed; // Oculta el botón de la hamburguesa
            }
            else
            {
                MenuCanvas.Visibility = Visibility.Collapsed;
                BotonHamburguesa.Visibility = Visibility.Visible; // Muestra el botón de la hamburguesa
            }
        }

        private void botonInfoClick(object sender, RoutedEventArgs e)
        {

            MenuInfo menuInfo = new MenuInfo();
            menuInfo.Show();

            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void IrAFavoritos(object sender, RoutedEventArgs e)
        {
            MenuFavoritos favoritosWindow = new MenuFavoritos();
            favoritosWindow.Show();
            this.Close();
        }

        private void IrAInfo(object sender, RoutedEventArgs e)
        {
            MenuInfo infoWindow = new MenuInfo();
            infoWindow.Show();
            this.Close();
        }

        private void IrAInicio(object sender, RoutedEventArgs e)
        {
            MainWindow inicioWindow = new MainWindow();
            inicioWindow.Show();
            this.Close();
        }

        private void IrAParadas(object sender, RoutedEventArgs e)
        {
            MenuParadas paradasWindow = new MenuParadas();
            paradasWindow.Show();
            this.Close();
        }

        private void IrAMapa(object sender, RoutedEventArgs e)
        {
            // MapaWindow mapaWindow = new MapaWindow();
            //mapaWindow.Show();
            this.Close();
        }
        private void ButtonMenu_MouseEnter(object sender, MouseEventArgs e)
        {
            // Cambia el tamaño de la fuente cuando el ratón pasa sobre el botón
            if (sender is Button button)
            {
                if (button.Content is StackPanel stackPanel && stackPanel.Children.Count > 0 && stackPanel.Children[0] is TextBlock textBlock)
                {
                    textBlock.FontSize = 100;
                }
            }
        }

        private void ButtonMenu_MouseLeave(object sender, MouseEventArgs e)
        {
            // Restaura el tamaño original de la fuente cuando el ratón se quita del botón
            if (sender is Button button)
            {
                if (button.Content is StackPanel stackPanel && stackPanel.Children.Count > 0 && stackPanel.Children[0] is TextBlock textBlock)
                {
                    textBlock.FontSize = 70;
                }
            }
        }
    }
}
