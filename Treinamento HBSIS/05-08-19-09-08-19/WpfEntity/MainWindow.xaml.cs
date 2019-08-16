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

namespace WpfEntity
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

        private void UcLogin_sucess(object sender, EventArgs e)
        {
            MessageBox.Show(sender.ToString());

            ucLoginForm.Visibility = Visibility.Hidden;
            ucGrid.Visibility = Visibility.Visible;
        }

        private void UcLogin_fail(object sender, EventArgs e)
        {
            MessageBox.Show(sender.ToString());
        }
    }
}