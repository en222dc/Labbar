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

namespace Uppgift13
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
                
        private void btnCount_Click(object sender, RoutedEventArgs e)
        {
            string text = txtInsertText.Text.ToLower(); //MÅSTE ha .Text med också, annars skiter det sig... .ToLower för att alla bokstäver ska tas med
            string letter = txtLetterSearch.Text.ToLower(); 
            int sum = 0;

            foreach (char test in text) //den inmatade texten söks igenom, bokstav för bokstav och kollar om det är den eftersökta bokstaven.
            {
                if(test == letter[0])
                {
                    sum++;
                    lblResult.Content = $"Hittade bokstaven {letter} {sum} gånger.";
                }

            }


        }
    }
}

//En massa ord hämtas in från txtInsertText.Text = sträng
//Sök efter bokstaven {txtLetterSearch} i txtInsertText.Text när btnCount klickas på
//varje bokstav ska kollas igenom - är det den sökta bokstaven - true/false?
//om true - räkna med bokstaven.
//loopen ska fortsätta tills alla bokstäver gåtts igenom.
