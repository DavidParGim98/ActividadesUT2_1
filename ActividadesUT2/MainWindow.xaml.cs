using DocumentFormat.OpenXml.Drawing;
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

namespace ActividadesUT2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static Random random = new Random();
        int numeroGanador = random.Next(1 ,100);

        public MainWindow()
        {
            InitializeComponent();
            
        }

        void miBoton_Comprobar(object sender, RoutedEventArgs e)
        {
            if (TextoComprobar.Text.Length==0)
            {
                Pista.Text = "Introduce un numero";
            }
            else if (numeroGanador == int.Parse(TextoComprobar.Text))
            {
                Pista.Text="Lo has acertado";
            }
            else if(numeroGanador < int.Parse(TextoComprobar.Text))
            {
                Pista.Text = "Prueba un número mas pequeño";
            }
            else if (numeroGanador > int.Parse(TextoComprobar.Text))
            {
                Pista.Text = "Prueba un número mas grande";
            }
            else
            {
                Pista.Text = "Has acertado el número";
            }

        }

        void miBoton_Reiniciar(object sender, RoutedEventArgs e)
        {
            numeroGanador = random.Next(1, 100);
            Pista.Text = "";
            TextoComprobar.Clear();
        }

    }
}
