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

namespace Uppgift11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            prgBarLuck.Minimum = 0;
            prgBarLuck.Maximum = 100;
            prgBarLuck.Value = 50;
        }

        Random Random = new Random();
        int rndGen;
        int tries;
        int rightWay = 0;
        int wrongWay = 0;

        private void btnSandwich_Click(object sender, RoutedEventArgs e)
        {          

            tries = int.Parse(txtNmbOfTries.Text);

            for (int i = 0; i < tries; i++)
            {
                rndGen = Random.Next(101);

                if (rndGen <= prgBarLuck.Value)
                {
                    rightWay++;
                    lblRightWay.Content = rightWay;
                }

                else
                {
                    wrongWay++;
                    lblWrongWay.Content = wrongWay;
                }

            }
        }

        private void btnBadLuck_Click(object sender, RoutedEventArgs e)
        {
            prgBarLuck.Value -= 5;
            lblProcent.Content = $"{prgBarLuck.Value}%";
        }

        private void btnLuck_Click(object sender, RoutedEventArgs e)
        {
            prgBarLuck.Value += 5;
            lblProcent.Content = $"{prgBarLuck.Value}%";
        }

    }

}