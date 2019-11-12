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

namespace Uppgift7
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
            int tal1 = int.Parse(txtTal1.Text); //initierat Tal 1
            int tal2 = int.Parse(txtTal2.Text); //initierat Tal 2
            int resultInt = (tal1 / tal2); //initierat Heltal
            int resultRem = (tal1 % tal2); //initiera Rest

            //Nu måste jag räkna ut heltalen när knappen btnCalc klickas på

            txtResultInt.Text = resultInt.ToString();

            //Nu måste jag få in resten i txtRest också

            txtResultRem.Text = resultRem.ToString();

            //MADE IT!!!

        }
    }
}
