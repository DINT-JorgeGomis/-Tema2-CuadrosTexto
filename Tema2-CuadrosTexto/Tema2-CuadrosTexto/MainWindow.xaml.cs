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

namespace Tema2_CuadrosTexto
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

        private void nombreKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1)
            {
                var label = (sender as TextBox).Equals(nombreTextBox) ? nombreLabel : apellidoLabel;
                label.Visibility = label.Visibility == Visibility.Visible ? Visibility.Hidden : Visibility.Visible;
            }
        }

        private void edadKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F2)
            {
                edadLabel.Visibility = !int.TryParse(edadTextBox.Text, out int result) ? Visibility.Visible : Visibility.Hidden;
            }
        }
    }
}
