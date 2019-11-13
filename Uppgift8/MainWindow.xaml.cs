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

namespace Uppgift8
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

        private void btnCalc_Click(object sender, RoutedEventArgs e)
        {
            double tal1 = double.Parse(txtTal1.Text); //initierat Tal 1
            double tal2 = double.Parse(txtTal2.Text); //initierat Tal 2
            
            if(rdoAdd.IsChecked == true)
            {
                double result = (tal1 + tal2);

                txtResult.Text = result.ToString();
            }

            else if(rdoSub.IsChecked == true)
            {
                double result = (tal1 - tal2);

                txtResult.Text = result.ToString();
            }

            else if(rdoMul.IsChecked == true)
            {
                double result = (tal1 * tal2);

                txtResult.Text = result.ToString();
            }

            else if(rdoDiv.IsChecked == true)
            {
                double result = (tal1 / tal2);

                txtResult.Text = Math.Round(result, 2).ToString();
            }
        }

       
    }
}
