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
            CboCustomer.ItemsSource = customerList;
            CboCustomer.SelectedIndex = 0;
        }
        List<Customer> customerList { get; set; } = new List<Customer>();
        //CheckingAccount checkingAccount;
        //SavingsAccount savingsAccount;
        //RetirementAccount retirementAccount;
        Customer activeCustomer;
        

        public void AddCustomer()
        {
            Customer newCustomer = new Customer(TxtFirstname.Text, TxtLastname.Text, TxtPhone.Text);
            customerList.Add(newCustomer);

            string customerName = TxtFirstname.Text;
            MessageBox.Show($"{customerName} har lagts till som kund.");
        }

        private void UpdateCustomerList()
        {
            CboCustomer.ItemsSource = null;
            CboCustomer.ItemsSource = customerList;
            CboCustomer.SelectedIndex = 0;
            activeCustomer = CboCustomer.SelectedItem as Customer;
        }

        private void UpdateAccounts()
        {
            CboSelectAccount.ItemsSource = null;
            CboSelectAccount.ItemsSource = activeCustomer.bankAccounts;
        }

        public void AddAccount()
        {
            if (OptChecking.IsChecked == true)
            {
                BankAccount Checking = new CheckingAccount(decimal.Parse(TxtCredit.Text));
                activeCustomer.AddBankAccount(Checking);
                MessageBox.Show("Du har skapat ett lönekonto.");
                return;
            }

            else if (OptSavings.IsChecked == true)
            {
                BankAccount Savings = new SavingsAccount();
                activeCustomer.AddBankAccount(Savings);
                MessageBox.Show("Du har skapat ett sparkonto.");
                return;
            }

            else if (OptRetirement.IsChecked == true)
            {
                BankAccount Retirement = new RetirementAccount();
                activeCustomer.AddBankAccount(Retirement);
                MessageBox.Show("Du har skapat ett pensionskonto.");
                return;
            }

       
    }
        private void BtnNewCustomer_Click(object sender, RoutedEventArgs e)
        {
            AddCustomer();
            UpdateCustomerList();
            TxtFirstname.Clear();
            TxtLastname.Clear();
            TxtPhone.Clear();
        }

        private void CboCustomer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            activeCustomer = (Customer)CboCustomer.SelectedItem;
        }

        private void BtnSelectCustomer_Click(object sender, RoutedEventArgs e)
        {
            activeCustomer = CboCustomer.SelectedItem as Customer;
            CboSelectAccount.ItemsSource = activeCustomer.bankAccounts;
        }

        
        private void BtnSelectAccount_Click(object sender, RoutedEventArgs e)
        {
            
        }

       
        private void BtnSaveTransaction_Click(object sender, RoutedEventArgs e)
        {

        }

        

        
        private void BtnNewAccount_Click(object sender, RoutedEventArgs e)
        {
            AddAccount();
            UpdateAccounts();
            TxtCredit.Clear();
        }
    }















    //private void Button_Click(object sender, RoutedEventArgs e)
    //{
    //    Customer Evelina = new Customer("0739070223", "Evelina", "Nilsson");
    //    //Skapar en kund

    //    SavingsAccount savings = new SavingsAccount();
    //    RetirementAccount retirement = new RetirementAccount();
    //    CheckingAccount checking = new CheckingAccount();
    //    //skapat variabler för de olika kontotyperna

    //    Evelina.BankAccounts.Add(savings);
    //    Evelina.BankAccounts.Add(retirement);
    //    Evelina.BankAccounts.Add(checking);
    //    //Evelina har fått tre olika konton

    //    checking.Deposit(500);

    //    checking.Withdrawal(1500);

    //    MessageBox.Show(Evelina.BankAccounts[2].GetBalance().ToString());
    //}
}

