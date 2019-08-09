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
using WpfEntity.Data;

namespace WpfEntity.Views
{
    /// <summary>
    /// Interaction logic for frmEditarUsuario.xaml
    /// </summary>
    public partial class frmEditarUsuario : Window
    {
        public frmEditarUsuario()
        {
            InitializeComponent();
        }
        public Usuario user;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            user.Nome = tbxNome.Text;
            user.Login = tbxLogin.Text;
            user.Senha = tbxSenha.Text;

            this.DialogResult = true;
        }
    }
}
