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

namespace _10._5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Dice dice;

        public MainWindow()
        {
            InitializeComponent();

            dice = new Dice();

            btnThrow.Click += BtnThrow_Click;
        }

        private void BtnThrow_Click(object sender, RoutedEventArgs e)
        {
            lblValue.Content = dice.Throw();
        }
    }
}
