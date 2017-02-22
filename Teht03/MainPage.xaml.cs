using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Teht03
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void textBlock6_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void textBlock7_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void CalculateButtonClick(object sender, RoutedEventArgs e)
        {
            double leveys = double.Parse(IkkunanLeveys.Text);
            double korkeus = double.Parse(IkkunanKorkeus.Text);
            double karmi = double.Parse(KarminLeveys.Text);

            double dIkkunanPintaAla = leveys * korkeus;
            double dLasinPintaAla = dIkkunanPintaAla - ((leveys - (karmi * 2))*(korkeus - (karmi * 2)));
            double dKarminPiiri = leveys * 2 + korkeus * 2;

            string iPintaAla = dIkkunanPintaAla.ToString();
            string lPintaAla = dLasinPintaAla.ToString();
            string kPiiri = dKarminPiiri.ToString();

            IkkunanPintaAla.Text = iPintaAla;
            LasinPintaAla.Text = lPintaAla;
            KarminPiiri.Text = kPiiri;
               


        }
        
    }
}
