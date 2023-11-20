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
    /// Lógica de interacción para MenuInfo.xaml
    /// </summary>
    public partial class MenuInfo : Window
    {
        public MenuInfo()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MenuHamburguesaClick(null, null);
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

        private void Hyperlink_RequestNavigate(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
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

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            if (sender is Button button)
            {
                ScaleTransform scaleTransform = new ScaleTransform(1.1, 1.1); // Ajusta el factor de escala según tus necesidades
                button.RenderTransform = scaleTransform;

                if (button.Content is StackPanel stackPanel)
                {
                    if (stackPanel.Children[0] is Image image)
                    {
                        // Ajusta el tamaño de la imagen cuando el cursor está encima
                        image.Width *= 1.1;
                        image.Height *= 1.1;
                    }
                }
            }
        }

        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            if (sender is Button button)
            {
                button.RenderTransform = null; // Elimina la transformación al salir del botón

                if (button.Content is StackPanel stackPanel)
                {
                    if (stackPanel.Children[0] is Image image)
                    {
                        // Restaura el tamaño original de la imagen al salir del botón
                        image.Width /= 1.1;
                        image.Height /= 1.1;
                    }
                }
            }
        }

        private void IrAFavoritos(object sender, RoutedEventArgs e)
        {
            //FavoritosWindow favoritosWindow = new FavoritosWindow();
            //favoritosWindow.Show();
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
            //ParadasWindow paradasWindow = new ParadasWindow();
            //paradasWindow.Show();
            this.Close();
        }

        private void IrAMapa(object sender, RoutedEventArgs e)
        {
            // MapaWindow mapaWindow = new MapaWindow();
            //mapaWindow.Show();
            this.Close();
        }
    }
}
