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

namespace _5._8
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
            if (double.TryParse(txbDollar.Text, out double dollar))
            {
                MessageBox.Show(CalculateEuroEquivalent(dollar).ToString());
            }
        }

        private double CalculateEuroEquivalent(double dollar)
        {
            double euro = Math.Round(dollar / 100 * 95, 2);
            return euro;
        }
    }
}
