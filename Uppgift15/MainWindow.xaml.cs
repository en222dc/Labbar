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
        }
        

        public bool IsVowel(char isVowel)
        {

            char[] vowelsArray = new char[] { 'a', 'e', 'i', 'o', 'u', 'y', 'å', 'ä', 'ö', 'A', 'E', 'I', 'O', 'U', 'Y', 'Å', 'Ä', 'Ö' };
            //mitt facit till vokaler
            bool vowel = false;

            foreach (char c in vowelsArray)
            {
                if ((c) == isVowel)
                {
                    vowel = true;
                }
            }

            return vowel;
        }

        public int NumberOfVowels(string numberOfVowels) //Varför har jag en sträng här???
        {
            int count = 0;

            foreach (char c in numberOfVowels)
            {
                if (IsVowel(c))
                {
                    count++;
                }
            }
            return count;
        }

        public string Jibberish(char convertTo)
        {
            foreach (char c in collection)
            {

            }
           
           
        }
        


        //public bool IsNumberOfVowels()  //räkna vokalerna
        //{
        //    int numberOfVowels = 0;

        //    foreach (char c in yourMessage)
        //    {
        //        bool isVowel = "aeiouyåäöAEIOUYÅÄÖ".IndexOf(c) >= 0; //kollar om vokaler (= a, e, i, o, u, y, å, ä, ö)

        //        if (true)
        //        {
        //            numberOfVowels++;
        //        }
        //    }
        //    return numberOfVowels;

    }

}
