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

namespace _5._16
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            btnGetInput.Click += BtnGetInput_Click;
        }

        private void BtnGetInput_Click(object sender, RoutedEventArgs e)
        {
            GetInput3(out int a, out int b, out int c);
            MessageBox.Show("a: " + a + " b: " + b + " c: " + c);
        }

        private void GetInput3(out int a, out int b, out int c)
        {
            a = b = c = 0;
            if (int.TryParse(txbA.Text, out int txtA) &&
                int.TryParse(txbB.Text, out int txtB) &&
                int.TryParse(txbC.Text, out int txtC))
            {
                a = txtA;
                b = txtB;
                c = txtC;
            } else
            {
                MessageBox.Show("not a number");
            }
        }
    }
}
