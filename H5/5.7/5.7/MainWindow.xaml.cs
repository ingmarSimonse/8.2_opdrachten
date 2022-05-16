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

namespace _5._7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            btnDrawStreet.Click += BtnDrawStreet_Click;
        }

        private void BtnDrawStreet_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txbPositionX.Text, out double posX) &&
                double.TryParse(txbPositionY.Text, out double posY) &&
                double.TryParse(txbSize.Text, out double size))
            {
                SolidColorBrush brush = new SolidColorBrush(Colors.Black);
                DrawStreet(cvsDrawStreet, brush, size, posX, posY);
            }
            else
            {
                MessageBox.Show("not a number");
            }
        }

        private void DrawStreet(Canvas drawingArea, SolidColorBrush brush,
            double size, double positionX, double positionY)
        {
            double size2 = size / 100 * 80;
            double size3 = size2 / 100 * 80;
            double size4 = size3 / 100 * 80;
            DrawHouse(drawingArea, brush, positionX, positionY, size);
            DrawHouse(drawingArea, brush, positionX + size * 3, positionY, size2);
            DrawHouse(drawingArea, brush, positionX, positionY + size * 3, size3);
            DrawHouse(drawingArea, brush, positionX + size * 3, positionY + size * 3, size4);
        }

        private void DrawHouse(Canvas drawingArea, SolidColorBrush brush,
               double topLeftX, double topLeftY, double size)
        {
            DrawPolygon(drawingArea, brush, topLeftX + (size / 2), topLeftY, size, size);
            DrawRectangle(drawingArea, brush, topLeftX, topLeftY + size, size, size);
        }

        private void DrawRectangle(Canvas drawingArea, SolidColorBrush brush,
            double topLeftX, double topLeftY, double width, double height)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Width = width;
            rectangle.Height = height;
            rectangle.Margin = new Thickness(topLeftX, topLeftY, 0, 0);
            rectangle.Stroke = brush;
            drawingArea.Children.Add(rectangle);
        }

        private void DrawPolygon(Canvas drawingArea, SolidColorBrush brush,
            double topX, double topY, double width, double height)
        {
            Polygon myPolygon = new Polygon();
            myPolygon.Stroke = brush;
            myPolygon.HorizontalAlignment = HorizontalAlignment.Left;
            myPolygon.VerticalAlignment = VerticalAlignment.Center;
            System.Windows.Point Point1 = new System.Windows.Point(topX, topY);
            System.Windows.Point Point2 = new System.Windows.Point(topX - (width / 2), topY + height);
            System.Windows.Point Point3 = new System.Windows.Point(topX + (width / 2), topY + height);
            PointCollection myPointCollection = new PointCollection();
            myPointCollection.Add(Point1);
            myPointCollection.Add(Point2);
            myPointCollection.Add(Point3);
            myPolygon.Points = myPointCollection;
            drawingArea.Children.Add(myPolygon);
        }
    }
}
