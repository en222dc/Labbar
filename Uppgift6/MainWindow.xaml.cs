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

namespace Uppgift6
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


        private void btnAddition_Click(object sender, RoutedEventArgs e)
        {
            double tal1;
            double tal2;
            double sum;

            tal1 = double.Parse(txtTal1.Text);
            tal2 = double.Parse(txtTal2.Text);
            sum = (tal1 + tal2);

            txtResult.Text = Math.Round(sum, 2).ToString();
            lblResult.Content = $"Summa";
        }

        private void btnSubtraction_Click(object sender, RoutedEventArgs e)
        {
            double tal1;
            double tal2;
            double dif;

            tal1 = double.Parse(txtTal1.Text);
            tal2 = double.Parse(txtTal2.Text);
            dif = (tal1 - tal2);

            txtResult.Text = Math.Round(dif, 2).ToString();
            lblResult.Content = $"Differens";
        }

        private void btnMultiplication_Click(object sender, RoutedEventArgs e)
        {
            double tal1;
            double tal2;
            double prod;

            tal1 = double.Parse(txtTal1.Text);
            tal2 = double.Parse(txtTal2.Text);
            prod = (tal1 * tal2);

            txtResult.Text = Math.Round(prod, 2).ToString();
            lblResult.Content = $"Produkt";
        }

        private void btnDivision_Click(object sender, RoutedEventArgs e)
        {
            double tal1;
            double tal2;
            double kvot;

            tal1 = double.Parse(txtTal1.Text);
            tal2 = double.Parse(txtTal2.Text);
            kvot = (tal1 / tal2);

           
            txtResult.Text = Math.Round(kvot, 2).ToString();
            lblResult.Content = $"Kvot";
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtTal1.Clear();
            txtTal2.Clear();
            txtResult.Clear();          
        }
    }
}
