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

namespace _5._3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            btnCalculateSalary.Click += BtnCalculateSalary_Click;
        }

        private void BtnCalculateSalary_Click(object sender, RoutedEventArgs e)
        {
            int yearlySalary;
            int years;
            if (int.TryParse(txbYearlySalary.Text, out yearlySalary) && int.TryParse(txbYears.Text, out years))
            {
                ShowSalary(yearlySalary, years);
            } else
            {
                MessageBox.Show("not a number");
            }
        }

        private void ShowSalary(int yearlySalary, int years)
        {
            int totalSalary = yearlySalary * years;
            MessageBox.Show(totalSalary.ToString());
        }
    }
}
