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
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for CalculatorWindow.xaml
    /// </summary>
    public partial class CalculatorWindow : Window
    {
        public CalculatorWindow()
        {
            InitializeComponent();
        }

        private void StartText_TextChanged(object sender, TextChangedEventArgs e) // tekstboks til starttidspunkt
        {

        }

        private void UnitText_TextChanged(object sender, TextChangedEventArgs e) // tekstboks til antal genstande indtaget
        {

        }

        private void CalcButton_Click(object sender, RoutedEventArgs e) // knap til beregning af promille
        {

        }

        private void PromilleText_TextChanged(object sender, TextChangedEventArgs e) // tekstboks til brugerens promille
        {

        }

        private void AllowedText_TextChanged(object sender, TextChangedEventArgs e) // tekts til "må du køre?"
        {

        }

        private void logoutButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}
