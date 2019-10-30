/* CustomizeSteakosaurusBurger.xaml.cs
 * Author: Owen Barker
 */

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
        /// <summary>
        /// This is the used object.
        /// </summary>
        private SteakosaurusBurger sb = new SteakosaurusBurger();

        /// <summary>
        /// This constructor creates a non-empty instance.
        /// </summary>
        /// <param name="vw"></param>
        public CustomizeSteakosaurusBurger(SteakosaurusBurger sb)
        {
            InitializeComponent();
            this.sb = sb;
        }

        /// <summary>
        /// This button holds the bun.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldBun(object sender, RoutedEventArgs e)
        {
            this.sb.HoldBun();
        }

        /// <summary>
        /// This button holds the pickles.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldPickle(object sender, RoutedEventArgs e)
        {
            this.sb.HoldPickle();
        }

        /// <summary>
        /// This button holds the ketchup.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldKetchup(object sender, RoutedEventArgs e)
        {
            this.sb.HoldKetchup();
        }

        /// <summary>
        /// This button holds the mustard.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldMustard(object sender, RoutedEventArgs e)
        {
            this.sb.HoldMustard();
        }

        /// <summary>
        /// This method sends the user back a page when they click the done button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnDone(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
