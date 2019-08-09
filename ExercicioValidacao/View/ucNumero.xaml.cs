using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace ExercicioValidacao.View
{
    /// <summary>
    /// Interaction logic for ucNumero.xaml
    /// </summary>
    public partial class ucNumero : UserControl
    {
        public ucNumero()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string fone = tbxFone.Text;

            Regex regexFone  = new Regex(@"^\(?\d{2}\(?\d{2}\)?[\s-]?[\s9]?\d{4}-?\d{4}$");

            if (regexFone.IsMatch(fone))
            {
                labelFone.Content = "Fone Valido!";
            }
            else
            {
                labelFone.Content = "Fone Inválido!";
            }

            string email = tbxEmail.Text;

            Regex regexEmail = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

            if (regexEmail.IsMatch(email))
            {
                labelEmail.Content = "Email Valido!";
            }
            else
            {
                labelEmail.Content = "Email Inválido!";
            }

        }
    }
}
