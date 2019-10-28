/* EntreeSelection.xaml.cs
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
    /// Interaction logic for EntreeSelection.xaml
    /// </summary>
    public partial class EntreeSelection : Page
    {
        /// <summary>
        /// This initializes the page that allows the user to choose an entree.
        /// </summary>
        public EntreeSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This gives functionality to the Brontowurst button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BrontowurstButton(object sender, RoutedEventArgs e)
        {
            
        }

        /// <summary>
        /// This gives functionality to the Dino Nuggets button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DinoNuggetsButton(object sender, RoutedEventArgs e)
        {
            
        }

        /// <summary>
        /// This gives functionality to the Prehistoric PBJ button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrehistoricPBJButton(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order order)
            {
                PrehistoricPBJ pbj = new PrehistoricPBJ();
                order.Add(pbj);
                NavigationService.Navigate(new CustomizePrehistoricPBJ(pbj));
            }
        }

        /// <summary>
        /// This gives functionality to the Pterodactyl Wings button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PterodactylWingsButton(object sender, RoutedEventArgs e)
        {
            
        }

        /// <summary>
        /// This gives functionality to the Steakosaurus Burger button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SteakosarusButton(object sender, RoutedEventArgs e)
        {
            
        }

        /// <summary>
        /// This gives functionality to the TRex King Burger button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TRexKingButton(object sender, RoutedEventArgs e)
        {
            
        }

        /// <summary>
        /// This gives functionality to the Veloci-Wrap button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VelociwrapButton(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
