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

namespace Uppgift14
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

        public bool IsLetter()
        {
            string yourBirthYear = txtBirthYear.Text;

            foreach (char c in yourBirthYear)
            {
                if (Char.IsLetter(c))
                {
                    MessageBox.Show("Du får enbart mata in siffror!");

                    return true;
                }

            }

            return false;
        }

        private void btnCalcAge_Click(object sender, RoutedEventArgs e)
        {
            bool result = IsLetter();

            if (result == false)
            {
            int birthYear = int.Parse(txtBirthYear.Text);
            int yourAge = DateTime.Now.Year - birthYear;

            MessageBox.Show($"Du är {yourAge} år gammal.");
            }

        }
    }
}
