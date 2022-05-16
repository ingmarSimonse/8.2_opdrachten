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

namespace _5._2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            btnShowName.Click += BtnShowName_Click;
        }

        private void BtnShowName_Click(object sender, RoutedEventArgs e)
        {
            ShowNames(txbFirstName.Text, txbLastName.Text);
        }

        private void ShowNames(string firstName, string lastName)
        {
            MessageBox.Show(firstName);
            MessageBox.Show(lastName);
        }
    }
}
