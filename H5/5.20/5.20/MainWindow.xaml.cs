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

namespace _5._20
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            MessageBox.Show(GetTimeInSeconds(10, 2, 10).ToString());
            MessageBox.Show(GetTimeInSeconds(2, 10).ToString());
        }

        private int GetTimeInSeconds(int h, int m, int s)
        {
            int sec = h * 3600 + m * 60 + s;
            return sec;
        }

        private int GetTimeInSeconds(int m, int s)
        {
            int sec = m * 60 + s;
            return sec;
        }
    }
}
