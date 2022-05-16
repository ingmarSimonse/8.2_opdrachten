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

namespace _5._11
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
            if (int.TryParse(txbHours.Text, out int hours) &&
                int.TryParse(txbMinutes.Text, out int minutes) &&
                int.TryParse(txbSeconds.Text, out int seconds))
            {
                MessageBox.Show(GetTimeInSeconds(hours, minutes, seconds).ToString());
            } else
            {
                MessageBox.Show("not a number");
            }
        }

        private int GetTimeInSeconds(int h, int m, int s)
        {
            int sec = h * 3600 + m * 60 + s;
            return sec;
        }
    }
}
