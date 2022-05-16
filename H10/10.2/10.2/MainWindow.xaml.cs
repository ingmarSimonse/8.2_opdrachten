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

namespace _10._2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Volume volume;

        public MainWindow()
        {
            InitializeComponent();

            volume = new Volume();
            volume.MaxValue = 100;
            txbMax.Text = volume.MaxValue.ToString();
            sldVolume.Maximum = volume.MaxValue;
            volume.MinValue = 0;
            txbMin.Text = volume.MinValue.ToString();
            sldVolume.Minimum = volume.MinValue;
            volume.CurrentValue = 0;
            txbVolume.Text = volume.CurrentValue.ToString();

            sldVolume.ValueChanged += SldVolume_ValueChanged;
            txbVolume.TextChanged += TxbVolume_TextChanged;
            txbMax.TextChanged += TxbMax_TextChanged;
            txbMin.TextChanged += TxbMin_TextChanged;
        }

        private void SldVolume_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            volume.CurrentValue = Convert.ToInt32(sldVolume.Value);
            txbVolume.Text = volume.CurrentValue.ToString();
        }

        private void TxbVolume_TextChanged(object sender, TextChangedEventArgs e)
        {
            volume.CurrentValue = Convert.ToInt32(txbVolume.Text);
            sldVolume.Value = Convert.ToDouble(volume.CurrentValue);
        }

        private void TxbMax_TextChanged(object sender, TextChangedEventArgs e)
        {
            volume.MaxValue = Convert.ToInt32(txbMax.Text);
            sldVolume.Maximum = volume.MaxValue;
        }

        private void TxbMin_TextChanged(object sender, TextChangedEventArgs e)
        {
            volume.MinValue = Convert.ToInt32(txbMin.Text);
            sldVolume.Minimum = volume.MinValue;
        }
    }
}
