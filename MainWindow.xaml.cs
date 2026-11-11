using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Adicionales.Items.Clear();

            String producto = "";
            double precioProducto = 0;
            double precioAdicionales = 0;
            if (ComboProductos.SelectedIndex == 0)
            {
                producto = "Café Americano";
                precioProducto = 6.00;
            }
            else if (ComboProductos.SelectedIndex == 1)
            {
                producto = "Capuccino";
                precioProducto = 8.00;
            }
            else if (ComboProductos.SelectedIndex == 2)
            {
                producto = "Latte";
                precioProducto = 9.00;
            }

            else if (ComboProductos.SelectedIndex == 3)
            {
                producto = "Chocolate Caliente";
                precioProducto = 8.50;
            }
            else if (ComboProductos.SelectedIndex == 4) {
                producto = "Mocaccino";
                precioProducto = 10.00;
            }

            ProductoSeleccionado.Content = producto;
            Precio_Base.Content = precioProducto.ToString("F2");


            if (rdBtnPequenio.IsChecked == true)
            {
                Tamanio.Content = "Pequeño";
            }
            else if (rdBtnMediano.IsChecked == true)
            {
                Tamanio.Content = "Mediano";
            } else if (rdBtnGrande.IsChecked == true)
            {
                Tamanio.Content = "Grande";
            }


            

            if (checkLeche.IsChecked == true) {
                Adicionales.Items.Add("Leche");
                precioAdicionales += 1.50;
            }

            if (checkChantilly.IsChecked == true) {
                Adicionales.Items.Add("Crema Chantilly");
                precioAdicionales += 2.00;
            }

            if (checkCafe.IsChecked == true)
            {
                Adicionales.Items.Add("Shot de cafe");
                precioAdicionales += 2.50;
            }

            double total = precioProducto + precioAdicionales;

            Total.Content = total.ToString("F2");




        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ComboProductos.SelectedIndex = -1;

            rdBtnPequenio.IsChecked = false;
            rdBtnMediano.IsChecked = false;
            rdBtnGrande.IsChecked = false;

            checkLeche.IsChecked = false;
            checkChantilly.IsChecked = false;
            checkCafe.IsChecked = false;

            ProductoSeleccionado.Content = "";
            Precio_Base.Content = "";
            Tamanio.Content = "";
            Adicionales.Items.Clear();
            Total.Content = "";

        }
    }
}