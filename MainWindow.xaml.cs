//Nathan Peereboom
//April 2, 2020
//Waterloo Problem J2: Epidemiology
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

namespace _312840Epidemiology
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int P;
        int N;
        int R;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnProcess_Click(object sender, RoutedEventArgs e)
        {
            lblOutput.Content = "";
            int.TryParse(txtTarget.Text, out P);
            int.TryParse(txtInfected.Text, out N);
            int.TryParse(txtSpread.Text, out R);
            int totalInfected = N;
            int newlyInfected = N;
            int day = 0;
            while (totalInfected <= P)
            {
                day++;
                newlyInfected *= R;
                totalInfected += newlyInfected;

                /*lblOutput.Content += "Day " + day.ToString() + Environment.NewLine;
                lblOutput.Content += newlyInfected.ToString() + " caught the virus today." + Environment.NewLine;
                lblOutput.Content += "A total of " + totalInfected + " people are now infected." + Environment.NewLine;*/
            }
            lblOutput.Content += "The target was reached on day " + day.ToString();
        }
    }
}
