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

namespace _6._3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<int> numbers = new List<int>();

        public MainWindow()
        {
            InitializeComponent();

            btnGenerate.Click += BtnGenerate_Click;
        }

        private void BtnGenerate_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            int rndNumber = rnd.Next(200, 400);
            lblNumber.Content = rndNumber.ToString();
            numbers.Add(rndNumber);
            int average = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                average += numbers[i];
            }
            average = average / numbers.Count;
            lblAverage.Content = average.ToString();
        }
    }
}
