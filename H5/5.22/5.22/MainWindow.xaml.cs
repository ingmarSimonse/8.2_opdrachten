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

namespace _5._22
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            int a = 4;
            Increment(ref a);
            MessageBox.Show(a.ToString());

            string b = " ";
            Increment(ref b);
            MessageBox.Show(b);

            double c = 4;
            Increment(ref c);
            MessageBox.Show(c.ToString());
        }

        private void Increment(ref int v)
        {
            v += 1;
        }

        private void Increment(ref string v)
        {
            v += " ";
        }

        private void Increment(ref double v)
        {
            v += 1;
        }
    }
}
