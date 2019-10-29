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
    /// Interaction logic for CustomizeSteakosaurusBurger.xaml
    /// </summary>
    public partial class CustomizeSteakosaurusBurger : Page
    {
        private SteakosaurusBurger sb = new SteakosaurusBurger();

        public CustomizeSteakosaurusBurger(SteakosaurusBurger sb)
        {
            InitializeComponent();
            this.sb = sb;
        }

        private void OnHoldBun(object sender, RoutedEventArgs e)
        {
            this.sb.HoldBun();
        }

        private void OnHoldPickle(object sender, RoutedEventArgs e)
        {
            this.sb.HoldPickle();
        }

        private void OnHoldKetchup(object sender, RoutedEventArgs e)
        {
            this.sb.HoldKetchup();
        }

        private void OnHoldMustard(object sender, RoutedEventArgs e)
        {
            this.sb.HoldMustard();
        }

        private void OnDone(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
