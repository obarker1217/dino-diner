/* CustomizeTRexKingBurger.xaml.cs
 * Author: Owen barker
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
    /// Interaction logic for CustomizeTRexKingBurger.xaml
    /// </summary>
    public partial class CustomizeTRexKingBurger : Page
    {
        /// <summary>
        /// This is the used object.
        /// </summary>
        private TRexKingBurger trex = new TRexKingBurger();

        /// <summary>
        /// This constructor creates a non-empty instance.
        /// </summary>
        /// <param name="vw"></param>
        public CustomizeTRexKingBurger(TRexKingBurger trex)
        {
            InitializeComponent();
            this.trex = trex;
        }

        /// <summary>
        /// This button holds the bun.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldBun(object sender, RoutedEventArgs e)
        {
            this.trex.HoldBun();
        }

        /// <summary>
        /// This button holds the lettuce.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldLettuce(object sender, RoutedEventArgs e)
        {
            this.trex.HoldLettuce();
        }

        /// <summary>
        /// This button holds the tomatoes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldTomato(object sender, RoutedEventArgs e)
        {
            this.trex.HoldTomato();
        }

        /// <summary>
        /// This button holds the onions.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldOnion(object sender, RoutedEventArgs e)
        {
            this.trex.HoldOnion();
        }

        /// <summary>
        /// This button holds the pickles.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldPickle(object sender, RoutedEventArgs e)
        {
            this.trex.HoldPickle();
        }

        /// <summary>
        /// This button holds the ketchup.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldKetchup(object sender, RoutedEventArgs e)
        {
            this.trex.HoldKetchup();
        }

        /// <summary>
        /// This button holds the mustard.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldMustard(object sender, RoutedEventArgs e)
        {
            this.trex.HoldMustard();
        }

        /// <summary>
        /// This button holds the mayonnaise.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldMayo(object sender, RoutedEventArgs e)
        {
            this.trex.HoldMayo();
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
