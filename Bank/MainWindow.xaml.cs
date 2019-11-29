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

namespace Bank
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Customer Evelina = new Customer("0739070223", "Evelina", "Nilsson", "Ålfiskaregatan 43");
            //Skapar en kund

            SavingsAccount savings = new SavingsAccount();
            RetirementAccount retirement = new RetirementAccount();
            CheckingAccount checking = new CheckingAccount();
            //skapat variabler för de olika kontotyperna

            Evelina.BankAccounts.Add(savings);
            Evelina.BankAccounts.Add(retirement);
            Evelina.BankAccounts.Add(checking);
            //Evelina har fått tre olika konton

            checking.Deposit(500);
            checking.Withdrawal(1000);

            MessageBox.Show(Evelina.BankAccounts[2].AccountBalance().ToString());
        }
    }
}
