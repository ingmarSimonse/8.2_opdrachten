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

namespace _5._14
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            btnConvert.Click += BtnConvert_Click;
        }

        private void BtnConvert_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(txbNumber.Text, out int number))
            {
                MessageBox.Show(ConvertNumberToBinary(number));
            } else
            {
                MessageBox.Show("not a number");
            }
        }

        private string ConvertNumberToBinary(int number)
        {
            int[] binaryArray = { 256, 128, 64, 32, 16, 8, 4, 2, 1 };
            string binaryOutput = "";
            if (number <= 255 && number >= 0)
            {
                bool firstOne = false;
                foreach (var item in binaryArray)
                {
                    if (item <= number)
                    {
                        binaryOutput += "1";
                        number -= item;
                        firstOne = true;
                    }
                    else
                    {
                        if (firstOne)
                        {
                            binaryOutput += "0";
                        }
                    }
                }
            }
            return binaryOutput;
        }
    }
}
