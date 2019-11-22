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

            int yourAge = int.Parse(txtAge.Text);
            string yourName = (txtName.Text);
            bool isAlone = (bool)rdoAlone.IsChecked;
            bool withAdult = (bool)rdoAdult.IsChecked;
            
            if (yourAge >= 15)
            {
                txtBlockResult.Text = $"Hej {yourName}! Du är {yourAge} år gammal och får se alla filmer.";
            }
        
            else if (yourAge < 7 && isAlone)
            {
                txtBlockResult.Text = $"Hej {yourName}! Du är {yourAge} år gammal och får se barntillåtna filmer.";
            }
            else if (yourAge < 7 && withAdult)
            {
                txtBlockResult.Text = $"Hej {yourName}! Du är {yourAge} år gammal och får se filmer med åldersgräns upp till 7 år med vuxen.";
            }

            else if (yourAge >= 7 && yourAge < 11 && isAlone)
            {
                txtBlockResult.Text = $"Hej {yourName}! Du är {yourAge} år gammal och får se filmer med åldersgräns upp till 7 år.";
            }
            else if (yourAge >= 7 && yourAge < 11 && withAdult)
            {
                txtBlockResult.Text = $"Hej {yourName}! Du är {yourAge} år gammal och får se filmer med åldersgräns upp till 11 år med vuxen.";
            }
           
            else if (yourAge >= 11 && yourAge < 15 && isAlone)
            {
                txtBlockResult.Text = $"Hej {yourName}! Du är {yourAge} år gammal och får se filmer med åldersgräns upp till 11 år.";
            }
            else if (yourAge >= 11 && yourAge < 15 && withAdult)
            {
                txtBlockResult.Text = $"Hej {yourName}! Du är {yourAge} år gammal och får se filmer med åldersgräns upp till 11 år, oavsett om du har en vuxen med dig eller inte.";
            }
        }
    }
}
