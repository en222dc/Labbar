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

namespace Uppgift9
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

        private void btnCont_Click(object sender, RoutedEventArgs e)
        {
            //Programmet ska jämföra åldern med de gränser som SF har
            //15, 11, 7 och barntillåten är gränserna att förhålla sig till
            //En hälsning med namnet och resultatet ska komma upp i textblocket

            int yourage = int.Parse(txtAge.Text);
            string yourname = (txtName.Text);

            
            if (yourage >= 15)
            {
                txtBlockResult.Text = $"Hej {yourname}! Du är {yourage} år gammal och får se alla filmer.";
            }
        
            else if (yourage < 7 && rdoAlone.IsChecked == true)
            {
                txtBlockResult.Text = $"Hej {yourname}! Du är {yourage} år gammal och får se barntillåtna filmer.";
            }
            else if (yourage < 7 && rdoAdult.IsChecked == true)
            {
                txtBlockResult.Text = $"Hej {yourname}! Du är {yourage} år gammal och får se filmer med åldersgräns upp till 7 år med vuxen.";
            }


            else if (yourage >= 7 && yourage < 11 && rdoAlone.IsChecked == true)
            {
                txtBlockResult.Text = $"Hej {yourname}! Du är {yourage} år gammal och får se filmer med åldersgräns upp till 7 år.";
            }
            else if (yourage >= 7 && yourage < 11 && rdoAdult.IsChecked == true)
            {
                txtBlockResult.Text = $"Hej {yourname}! Du är {yourage} år gammal och får se filmer med åldersgräns upp till 11 år med vuxen.";
            }
           
            
            else if (yourage >= 11 && yourage < 15 && rdoAlone.IsChecked == true)
            {
                txtBlockResult.Text = $"Hej {yourname}! Du är {yourage} år gammal och får se filmer med åldersgräns upp till 11 år.";
            }
            else if (yourage >= 11 && yourage < 15 && rdoAdult.IsChecked == true)
            {
                txtBlockResult.Text = $"Hej {yourname}! Du är {yourage} år gammal och får se filmer med åldersgräns upp till 11 år, oavsett om du har en vuxen med dig eller inte.";
            }


        }
    }
}
