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
    /// Lógica de interacción para MenuMapa.xaml
    /// </summary>
    public partial class MenuMapa : Window
    {
        public MenuMapa()
        {
            InitializeComponent();
            string url = "https://www.google.com/maps/place/Centro+Integrado+Mar%C3%ADa+Ana+Sanz/@42.8127834,-1.6518812,13.75z/data=!4m6!3m5!1s0xd50931c7c00bafb:0x375d338b0fc6631b!8m2!3d42.8256461!4d-1.631864!16s%2Fg%2F1tds7__k?authuser=0&entry=ttu";
            webBrowser.Navigate(new Uri(url));
        }





        //MENU HAMBURGUESA
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
