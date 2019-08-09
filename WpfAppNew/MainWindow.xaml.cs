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
using WpfAppNew.Data;

namespace WpfAppNew
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
        public BibliotecaDBContent context;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            context = new BibliotecaDBContent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(context.Usuarios.FirstOrDefault(x => x.Id > 0).Nome);

            var runList = context.Usuarios.OrderBy(x => x.Nome).ToList<Usuario>();

            gridView1.ItemsSource = runList;
        }
    }
}
