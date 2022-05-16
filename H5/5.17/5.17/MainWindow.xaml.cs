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

namespace _5._17
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
            GetInput6(out int h1, out int m1, out int s1, out int h2, out int m2, out int s2);
            MessageBox.Show(CalculateTimeDifferenceInSeconds(h1, m1, s1, h2, m2, s2).ToString());
        }

        private int CalculateTimeDifferenceInSeconds(int h1, int m1, int s1, int h2, int m2, int s2)
        {
            int diff = Math.Abs(GetTimeInSeconds(h1, m1, s1) - GetTimeInSeconds(h2, m2, s2));
            return diff;
        }

        private void GetInput6(out int a1, out int b1, out int c1, out int a2, out int b2, out int c2)
        {
            a1 = b1 = c1 = a2 = b2 = c2 = 0;
            if (int.TryParse(txbA1.Text, out int txtA1) &&
                int.TryParse(txbB1.Text, out int txtB1) &&
                int.TryParse(txbC1.Text, out int txtC1) &&
                int.TryParse(txbA2.Text, out int txtA2) &&
                int.TryParse(txbB2.Text, out int txtB2) &&
                int.TryParse(txbC2.Text, out int txtC2))
            {
                a1 = txtA1;
                b1 = txtB1;
                c1 = txtC1;
                a2 = txtA2;
                b2 = txtB2;
                c2 = txtC2;
            }
        }

        private int GetTimeInSeconds(int h, int m, int s)
        {
            int sec = h * 3600 + m * 60 + s;
            return sec;
        }
    }
}
