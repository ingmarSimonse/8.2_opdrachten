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

namespace _10._3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BankAccount bankAccount;

        public MainWindow()
        {
            InitializeComponent();

            bankAccount = new BankAccount(9999.12);
            lblSaldo.Content = bankAccount.CurrentValue.ToString();

            btnTransaction.Click += BtnTransaction_Click;
        }

        private void BtnTransaction_Click(object sender, RoutedEventArgs e)
        {
            bankAccount.Transaction(Convert.ToDouble(txbValue.Text));
            lblSaldo.Content = bankAccount.CurrentValue.ToString();
        }
    }
}
