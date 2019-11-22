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
            prgBarLuck.Value = 50; //Gör så att baren står på mitten i början
        }

        Random Random = new Random(); //Gör en slumpgenerator
        int rndGen;
        int tries;
        int rightWay = 0;
        int wrongWay = 0;

        private void btnSandwich_Click(object sender, RoutedEventArgs e)
        {          
            tries = int.Parse(txtNmbOfTries.Text);
            rightWay = 0; //nollställer vid varje knapptryck
            wrongWay = 0; //nollställer vid varje knapptryck

            for (int i = 0; i < tries; i++)
            {
                rndGen = Random.Next(1, 101); //kör från 1-101 för att få en mer jämn fördelning
                
                if (rndGen > prgBarLuck.Value)//bara > istället för >= för att bara ladda ett värde
                {
                    rightWay++;
                }

                else
                {
                    wrongWay++;
                }

            }
            lblRightWay.Content = rightWay; //bättre att de är utanför loopen så ifon inte behöver skrivas över hela tiden
            lblWrongWay.Content = wrongWay;
        }

        private void btnBadLuck_Click(object sender, RoutedEventArgs e)
        {
            prgBarLuck.Value += 5;
            lblProcent.Content = $"{prgBarLuck.Value}%";
        }

        private void btnLuck_Click(object sender, RoutedEventArgs e)
        {
            prgBarLuck.Value -= 5;
            lblProcent.Content = $"{prgBarLuck.Value}%";
        }
    }

}