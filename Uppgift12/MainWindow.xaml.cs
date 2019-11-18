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

namespace Uppgift12
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

        //Börja med att föra in ett tal från txtNumber till lstNumbers

        int index;
        double[] number = new double[5];
               
        private void btnNumberToList_Click(object sender, RoutedEventArgs e)
        {
            double sum;
            double yourNum = double.Parse(txtNumber.Text); // Initierad en variabel av typen int. Talen skall in i textBoxTal.
            double average;

            number[index] = yourNum++;
            index++;

            txtNumber.Clear();
            txtNumber.Focus();

            lstNumbers.ItemsSource = null; //  Värdet på 0 för att den ska ”börja om” när värdet knyts till kontrollen. För att allt ska visas.
            lstNumbers.ItemsSource = number; // Berättar för Listboxen att en array har skapats. 

            if (index == 5)
            {
                btnNumberToList.IsEnabled = false;

                sum = number.Sum();
                average = sum / 5;
                txtAverage.Text = $"{average}";                
            }

        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtNumber.Clear();
            txtAverage.Clear();
            txtNumber.Focus();
            lstNumbers.ItemsSource = null; //  Värdet på 0 för att den ska ”börja om” när värdet knyts till kontrollen. För att allt ska visas.

            btnNumberToList.IsEnabled = true;
        }
    }
}
