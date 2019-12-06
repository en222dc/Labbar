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
            //CboCustomer.SelectedIndex = 0;
        }

        List<Customer> customerList { get; set; } = new List<Customer>();
        Customer activeCustomer;
        BankAccount selectedAccount;

        decimal chosenAmount;


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
            CboSelectAccount.SelectedIndex = 0;
        }


        public void AddAccount()
        {
            if (OptChecking.IsChecked == true)
            {
                //if (inget är ifyllt i TxtCredit)
                //{
                //    MessageBox.Show("Var vänlig fyll i önskad kredit.");
                //}

                //else
                //{
                BankAccount Checking = new CheckingAccount(decimal.Parse(TxtCredit.Text));
                activeCustomer.AddBankAccount(Checking);
                MessageBox.Show("Du har skapat ett lönekonto.");
                return;
                //}
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
            selectedAccount = CboSelectAccount.SelectedItem as BankAccount;
        }

       
        private void BtnSaveTransaction_Click(object sender, RoutedEventArgs e)
        {
            chosenAmount = decimal.Parse(TxtAmount.Text);

            if (OptWithdrawal.IsChecked == true)
            {
                if (selectedAccount.Withdrawal(chosenAmount))
                {
                    return;
                }
                UpdateAccounts();

                if (!selectedAccount.Withdrawal(chosenAmount))
                {
                    MessageBox.Show("Tyvärr, du saknar täckning på kontot.");
                }
                UpdateAccounts();
            }

            else if (OptDeposit.IsChecked == true)
            {
                selectedAccount.Deposit(chosenAmount);
                UpdateAccounts();
            }
            TxtAmount.Clear();
        }
        

        private void BtnNewAccount_Click(object sender, RoutedEventArgs e)
        {
            AddAccount();
            UpdateAccounts();
            TxtCredit.Clear();
        }
    }

}

