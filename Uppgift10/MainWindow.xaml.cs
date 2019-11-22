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

namespace Uppgift10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        //Programmet ska slumpa fram ett heltal mellan 0-1000 
        //Användaren ska kunna gissa ett tal och försöka lista ut det slumpade talet

        //Programmet ska ge ledtrådar om det gissade talet är för litet/stort eller helt rätt
        //Om skillnaden mellan det slumpade och det gissade talet är >=100 ska det framgå att gissningen är alldeles för stor/liten
        //Om skillnaden är mindre ska det framgå

        public MainWindow()
        {
            InitializeComponent();
        }
        
        Random rndGenerator = new Random();
        int rndNumber; //deklarera variabeln för det nummer som ska slumpas fram
        int nmbOfTries = 0; //initiera antalet gissningar     
        
        private void btnRandom_Click(object sender, RoutedEventArgs e)
        {
            rndNumber = rndGenerator.Next(1001); //Slumpgenerator
            btnGuess.IsEnabled = true; //Gissaknappen blir tillgänglig först när slumpgeneratorn klickats på
        }

        private void btnGuess_Click(object sender, RoutedEventArgs e)
        {
            int myGuess = int.Parse(txtGuess.Text);
            int diff = (myGuess - rndNumber); //differens för att kunna få till det spann som behövs för att få till extremvärdena.
            nmbOfTries ++;   //antalet gissningar plussas på med en för varje klick på knappen                   

            //Helt perfekt!
            if (myGuess == rndNumber)
            {
                txtBlResult.Text = $"Woohoo, du gissade helt RÄTT! Fasen va bäst du är!! Du klarade det på {nmbOfTries} försök.";
            }

            //Extremvärden först.
         
            //Tokhögt
           else if (diff >= 100)
            {
                txtBlResult.Text = "Haha, inte ens i närheten! Du gissade alldeles för högt!";
            }

            //Toklågt
            else if (diff <= -100)
            {
                txtBlResult.Text = "Nope. Du får försöka igen, det här var på tok för lågt!";
            }

            //Lite lågt
            else if (diff > -100 && diff < 0)
            {
                txtBlResult.Text = "Tyvärr, nu gissade du lite för lågt.";
            }

            //Lite högt
            else if (diff < 100 && diff > 0)
            {
                txtBlResult.Text = "Nja... Nu gissade du lite för högt.";
            }
        }
    }
}
