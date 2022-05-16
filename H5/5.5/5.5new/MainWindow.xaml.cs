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

namespace _5._5new
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            btnDrawPolygon.Click += BtnDrawPolygon_Click;
        }

        private void BtnDrawPolygon_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txbTopX.Text, out double topX) &&
                double.TryParse(txbTopY.Text, out double topY) &&
                double.TryParse(txbWidth.Text, out double width) &&
                double.TryParse(txbHeight.Text, out double height))
            {
                SolidColorBrush brush = new SolidColorBrush(Colors.Black);
                DrawPolygon(cvsDrawPolygon, brush, topX, topY, width, height);
            }
        }

        private void DrawPolygon(Canvas drawingArea, SolidColorBrush brush,
            double topX, double topY, double width, double height)
        {
            Polygon myPolygon = new Polygon();
            myPolygon.Stroke = brush;
            myPolygon.HorizontalAlignment = HorizontalAlignment.Left;
            myPolygon.VerticalAlignment = VerticalAlignment.Center;
            System.Windows.Point Point1 = new System.Windows.Point(topY, topX);
            System.Windows.Point Point2 = new System.Windows.Point(topY - (width / 2), topX + height);
            System.Windows.Point Point3 = new System.Windows.Point(topY + (width / 2), topX + height);
/*            System.Windows.Point Point1 = new System.Windows.Point(1, 50);
            System.Windows.Point Point2 = new System.Windows.Point(10, 80);
            System.Windows.Point Point3 = new System.Windows.Point(50, 50);*/
            PointCollection myPointCollection = new PointCollection();
            myPointCollection.Add(Point1);
            myPointCollection.Add(Point2);
            myPointCollection.Add(Point3);
            myPolygon.Points = myPointCollection;
            drawingArea.Children.Add(myPolygon);
        }
    }
}
