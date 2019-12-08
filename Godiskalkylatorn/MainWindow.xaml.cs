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

namespace Godiskalkylatorn
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CandyCalculator candyCalculator = new CandyCalculator();

        public MainWindow()
        {
            InitializeComponent();
            candyCalculator.GetPeople();
            UpdateList(0);
        }

        public void UpdateList(int numberOfCandies)
        {
            lstSortCandy.ItemsSource = null;
            lstSortCandy.ItemsSource = candyCalculator.DivideCandy(numberOfCandies);
        }

        public void UpdateListByAge(int numberOfCandies)
        {
            lstSortCandy.ItemsSource = null;
            lstSortCandy.ItemsSource = candyCalculator.DivideCandyByAge(numberOfCandies);
        }

        public void UpdateListByName(int numberOfCandies)
        {
            lstSortCandy.ItemsSource = null;
            lstSortCandy.ItemsSource = candyCalculator.DivideCandyByName(numberOfCandies);
        }

        private void btnAddPerson_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(txtAge.Text, out int age))
                candyCalculator.AddPerson(age, txtName.Text);
            else
                MessageBox.Show("Var vänlig och ange ålder med heltal samt namn.");
            UpdateList(0);
            txtName.Clear();
            txtAge.Clear();
            txtName.Focus();
        }

        private void btnDivideCandy_Click(object sender, RoutedEventArgs e)
        {
            candyCalculator.ClearCandy();

            if (int.TryParse(txtNumberOfCandies.Text, out int numberOfCandies))
            {
                if (optOriginal.IsChecked == true)
                    UpdateList(numberOfCandies);
                else if (optAge.IsChecked == true)
                    UpdateListByAge(numberOfCandies);
                else if (optName.IsChecked == true)
                    UpdateListByName(numberOfCandies);
            }
            else
                MessageBox.Show("Var vänlig fyll i antalet godisar som ska fördelas, samt välj önskad sorteringsmetod.");
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            candyCalculator.SaveToFile();
            MessageBox.Show("Din lista har sparats.");
        }
    }
}
