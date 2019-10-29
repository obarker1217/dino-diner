/* FlavorSelection.xaml.cs
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
    /// Interaction logic for FlavorSelection.xaml
    /// </summary>
    public partial class FlavorSelection : Page
    {
        private Sodasaurus soda = new Sodasaurus();

        /// <summary>
        /// This initializes the flavor selection page.
        /// </summary>
        public FlavorSelection(Sodasaurus soda)
        {
            this.soda = soda;
            InitializeComponent();
        }

        /// <summary>
        /// This gives functionality to the Cherry button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CherryButton(object sender, RoutedEventArgs e)
        {
            this.soda.Flavor = SodasaurusFlavor.Cherry;
            NavigationService.GoBack();
        }

        /// <summary>
        /// This gives functionality to the Chocolate button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChocolateButton(object sender, RoutedEventArgs e)
        {
            this.soda.Flavor = SodasaurusFlavor.Chocolate;
            NavigationService.GoBack();
        }

        /// <summary>
        /// This gives functionality to the Cola button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ColaButton(object sender, RoutedEventArgs e)
        {
            this.soda.Flavor = SodasaurusFlavor.Cola;
            NavigationService.GoBack();
        }

        /// <summary>
        /// This gives functionality to the Lime button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LimeButton(object sender, RoutedEventArgs e)
        {
            this.soda.Flavor = SodasaurusFlavor.Lime;
            NavigationService.GoBack();
        }

        /// <summary>
        /// This gives functionality to the Orange button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrangeButton(object sender, RoutedEventArgs e)
        {
            this.soda.Flavor = SodasaurusFlavor.Orange;
            NavigationService.GoBack();
        }

        /// <summary>
        /// This gives functionality to the Root Beer button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RootBeerButton(object sender, RoutedEventArgs e)
        {
            this.soda.Flavor = SodasaurusFlavor.RootBeer;
            NavigationService.GoBack();
        }

        /// <summary>
        /// This gives functionality to the Vanilla button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VanillaButton(object sender, RoutedEventArgs e)
        {
            this.soda.Flavor = SodasaurusFlavor.Vanilla;
            NavigationService.GoBack();
        }
    }
}
