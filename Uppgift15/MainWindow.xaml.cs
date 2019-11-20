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

namespace Uppgift15
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

        private void btnConvert_Click(object sender, RoutedEventArgs e)
        {
            string yourMessage = txtMessage.Text;
            int numberOfVowels = NumberOfVowels(yourMessage);
            string jibberish = Jibberish(yourMessage);

            lblNumberOfVowels.Content = numberOfVowels;
            lblJibberish.Content = jibberish;
        }

        public bool IsVowel(char isVowel)
        {

            char[] vowelsArray = new char[] { 'a', 'e', 'i', 'o', 'u', 'y', 'å', 'ä', 'ö', 'A', 'E', 'I', 'O', 'U', 'Y', 'Å', 'Ä', 'Ö' };
            //mitt facit till vokaler
            bool vowel = false; //initierar till false för att ha ett utgångsläge

            foreach (char c in vowelsArray)
            {
                if ((c) == isVowel)
                {
                    vowel = true;
                }
            }

            return vowel;
        }

        public int NumberOfVowels(string input) 
        {
            int count = 0;

            foreach (char c in input)
            {
                if (IsVowel(c))
                {
                    count++;
                }
            }
            return count;
        }


        public string Jibberish(string input)
        {
            string edited = ""; 

            foreach (char c in input)
            {
                if (IsVowel(c))
                {
                    edited += "ö";
                }

                else
                {
                    edited += c;
                }
            }
            return edited;
        }

    }

}
