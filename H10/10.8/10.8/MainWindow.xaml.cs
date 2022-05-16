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

namespace _10._8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AlarmClock alarmClock;

        public MainWindow()
        {
            InitializeComponent();

            alarmClock = new AlarmClock();

            lblCurrentTime.Content = alarmClock.getTime();

            btnCheckTime.Click += BtnCheckTime_Click;
        }

        private void BtnCheckTime_Click(object sender, RoutedEventArgs e)
        {
            lblCurrentTime.Content = alarmClock.getTime();
            int timeLeft = alarmClock.CheckDifference(txbAlarm.Text);
            if (timeLeft <= 0)
            {
                grdWindow.Background = Brushes.Red;
            } else
            {
                grdWindow.Background = Brushes.White;
            }
            lblDifference.Content = timeLeft.ToString();
        }
    }
}
