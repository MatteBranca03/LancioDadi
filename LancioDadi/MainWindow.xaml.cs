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

namespace LancioDadi
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

        private void txtNumero_Click(object sender, RoutedEventArgs e)
        {
            double a = double.Parse(txtNumero.Text);
            double crediti = double.Parse(txtCrediti.Text);
            double puntata = double.Parse(txtPuntata.Text);
            if (a > 6 || a < 1)
            {
                MessageBox.Show("NON PUOI INSERIRE 0", "ERRORE", MessageBoxButton.OK, MessageBoxImage.Error);
                txtNumero.Clear();
            }
            else
            {
                Random r = new Random();
                int b = r.Next(1, 7);
                txtRandom.Text = ($"{b}");
                if (a == b)
                {
                    txtRisultato.Content = "COMPLIMENTI HAI VINTO";
                    crediti = (puntata * 2) + crediti;
                    txtCrediti.Text = ($"{crediti}");
                }
                else
                {
                    txtRisultato.Content = "MI DISPIACE HAI PERSO";
                    crediti = crediti - puntata;
                    txtCrediti.Text = ($"{crediti}");
                    a = 0;
                    b = 0;
                }
                if (crediti == 0)
                {
                    MessageBox.Show("MI DISPIACE HAI FINITO I CREDITI", "ERRORE", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                }
            }
        }
    }
}
