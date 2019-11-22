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

namespace Uppgift4._1
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

        // satte tabindex i properties efter den ordning jag ville få mina knappar
        // Satte in en tom textbox och sa till den att visa text beroende på var man klickar
        // med hjälp av .Content.


        private void btnTue_Click(object sender, RoutedEventArgs e)
        {
            lblDayClick.Content = $"Du klickade på knappen {btnTue.Content}.";
        }
        private void btnMon_Click(object sender, RoutedEventArgs e)
        {
            lblDayClick.Content = $"Du klickade på knappen {btnMon.Content}.";
        }

        private void btnWed_Click(object sender, RoutedEventArgs e)
        {
            lblDayClick.Content = $"Du klickade på knappen {btnWed.Content}.";
        }

        private void btnThu_Click(object sender, RoutedEventArgs e)
        {
            lblDayClick.Content = $"Du klickade på knappen {btnThu.Content}.";
        }

        private void btnFri_Click(object sender, RoutedEventArgs e)
        {
            lblDayClick.Content = $"Du klickade på knappen {btnFri.Content}.";
        }

        private void btnSat_Click(object sender, RoutedEventArgs e)
        {
            lblDayClick.Content = $"Du klickade på knappen {btnSat.Content}.";
        }

        private void btnSun_Click(object sender, RoutedEventArgs e)
        {
            lblDayClick.Content = $"Du klickade på knappen {btnSun.Content}.";
        }
    }
}
