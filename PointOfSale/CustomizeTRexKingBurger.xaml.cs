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
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeTRexKingBurger.xaml
    /// </summary>
    public partial class CustomizeTRexKingBurger : Page
    {
        private TRexKingBurger trex = new TRexKingBurger();

        public CustomizeTRexKingBurger(TRexKingBurger trex)
        {
            InitializeComponent();
            this.trex = trex;
        }

        private void OnHoldBun(object sender, RoutedEventArgs e)
        {
            this.trex.HoldBun();
        }

        private void OnHoldLettuce(object sender, RoutedEventArgs e)
        {
            this.trex.HoldLettuce();
        }

        private void OnHoldTomato(object sender, RoutedEventArgs e)
        {
            this.trex.HoldTomato();
        }

        private void OnHoldOnion(object sender, RoutedEventArgs e)
        {
            this.trex.HoldOnion();
        }

        private void OnHoldPickle(object sender, RoutedEventArgs e)
        {
            this.trex.HoldPickle();
        }

        private void OnHoldKetchup(object sender, RoutedEventArgs e)
        {
            this.trex.HoldKetchup();
        }

        private void OnHoldMustard(object sender, RoutedEventArgs e)
        {
            this.trex.HoldMustard();
        }

        private void OnHoldMayo(object sender, RoutedEventArgs e)
        {
            this.trex.HoldMayo();
        }

        private void OnDone(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
