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

namespace _5._12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            btnCalc.Click += BtnCalc_Click;
        }

        private void BtnCalc_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txbRadius.Text, out double radius) &&
                double.TryParse(txbHeight.Text, out double height))
            {
                MessageBox.Show(CalculateCilinderArea(radius, height).ToString());
            } else
            {
                MessageBox.Show("not a number");
            }
        }

        private double CalculateCilinderArea(double radius, double height)
        {
            double area = Math.Round(2 * Math.PI * Math.Pow(radius, 2) + Math.PI * (radius * 2) * height, 2);
            return area;
        }
    }
}
