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
using System.Text;
using System.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using carro_prueba_3.Clase;

namespace carro_prueba_3
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Carro carron;
        public MainWindow()
        {
            carron = new Carro("BMW", 2022, "ROJO", 250);
            InitializeComponent();
        }

        private void buttonencender_Click(object sender, RoutedEventArgs e)
        {
            labelencender.Content = carron.EncenderMotor();
        }

        private void buttonacelerar_Click(object sender, RoutedEventArgs e)
        {
            labelacelerar.Content = carron.acelerar();
        }

        private void buttonfrenar_Click(object sender, RoutedEventArgs e)
        {
            labelfrenar.Content = carron.Frenado();
        }

        private void buttonbocina_Click(object sender, RoutedEventArgs e)
        {
            labelbocina.Content = carron.Bocina();
        }

        private void ButtonBajarVelocidad_Click(object sender, RoutedEventArgs e)
        {
            LabelBajarVelocidad.Content = carron.disminuir();
        }

        private void butttonApagar_Click(object sender, RoutedEventArgs e)
        {
            labelApagar.Content = carron.apagado();
        }

        private void buttonradio_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer Player = new SoundPlayer();
            Player.SoundLocation = "C:/Users/Jairo Fernando/Downloads/TIME1.wav";
            Player.Play();
        }
    }
}
