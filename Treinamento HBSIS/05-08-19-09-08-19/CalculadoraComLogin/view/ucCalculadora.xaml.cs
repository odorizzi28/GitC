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

namespace CalculadoraComLogin.view
{
    /// <summary>
    /// Interaction logic for Calculadora.xaml
    /// </summary>
    public partial class Calculadora : UserControl
    {
        public Calculadora()
        {
            InitializeComponent();
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            double numero1 = int.Parse(txValor1.Text);
            double numero2 = int.Parse(txValor2.Text);
            labelTotal.Content =(numero1+numero2).ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double numero1 = int.Parse(txValor1.Text);
            double numero2 = int.Parse(txValor2.Text);
            labelTotal.Content = (numero1 - numero2).ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double numero1 = int.Parse(txValor1.Text);
            double numero2 = int.Parse(txValor2.Text);
            labelTotal.Content = (numero1 / numero2).ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double numero1 = int.Parse(txValor1.Text);
            double numero2 = int.Parse(txValor2.Text);
            labelTotal.Content = (numero1 * numero2).ToString();
        }
    }
}
