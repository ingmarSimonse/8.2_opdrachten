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

namespace _5._15
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
            if (int.TryParse(txbSeconds.Text, out int seconds))
            {
                ConvertSecondsToHoursMinutesSeconds(seconds, out int h, out int m, out int s);
                MessageBox.Show("H: " + h + " M: " + m + " S: " + s);
            } else
            {
                MessageBox.Show("not a number");
            }
        }

        private void ConvertSecondsToHoursMinutesSeconds(int sec, out int h, out int m, out int s)
        {
            h = 0;
            while (sec / 3600 >= 1)
            {
                h += 1;
                sec -= 3600;
            }

            m = 0;
            while (sec / 60 >= 1)
            {
                m += 1;
                sec -= 60;
            }

            s = sec;
        }
    }
}
