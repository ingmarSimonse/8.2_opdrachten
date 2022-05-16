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

namespace _5._13
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            btnIncrement.Click += BtnIncrement_Click;
        }

        private void BtnIncrement_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(txbNumber.Text, out int number))
            {
                MessageBox.Show(Increment(number).ToString());
            } else
            {
                MessageBox.Show("not a number");
            }
        }

        private int Increment(int n)
        {
            return n += 1;
        }
    }
}
