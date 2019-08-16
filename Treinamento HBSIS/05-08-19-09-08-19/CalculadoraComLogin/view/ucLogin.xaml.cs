﻿using System;
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
    /// Interaction logic for ucLogin.xaml
    /// </summary>
    public partial class ucLogin : UserControl
    {
        public ucLogin()
        {
            InitializeComponent();
        }
        public event EventHandler loginCorret;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Logi(PassWoSenha.Password, tbxLogin.Text);
        }
        public void Logi(string login, string senha)
        {
            if (login == "admin" && senha == "admin")
            {
                this.Visibility = Visibility.Hidden;
                loginCorret(null, new EventArgs());
            }
            else
            {
                MessageBox.Show("Login Invalido");
            }
        }
    }
    
}