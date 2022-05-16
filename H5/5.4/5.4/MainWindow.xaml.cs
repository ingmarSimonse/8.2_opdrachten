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

namespace _5._4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            btnDrawCircle.Click += BtnDrawCircle_Click;
        }

        private void BtnDrawCircle_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txbPositionX.Text, out double positionX) &&
                double.TryParse(txbPositionY.Text, out double positionY) &&
                double.TryParse(txbRadius.Text, out double radius))
            {
                SolidColorBrush brush = new SolidColorBrush(Colors.Black);
                DrawCircle(cvsDrawCircle, brush, positionX, positionY, radius);
            } else
            {
                MessageBox.Show("not a number");
            }
        }

        private void DrawCircle(Canvas cvsDrawArea, SolidColorBrush brush, double xCentre, double yCentre, double radius)
        {
            Ellipse circle = new Ellipse();
            circle.Width = radius * 2;
            circle.Height = radius * 2;
            circle.Margin = new Thickness(xCentre - radius, yCentre - radius, 0, 0);
            circle.Stroke = brush;
            cvsDrawArea.Children.Add(circle);
        }
    }
}
