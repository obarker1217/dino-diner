/* CmoboSelection.xaml.cs
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : Page
    {
        /// <summary>
        /// This constructor initializes the page.
        /// </summary>
        public ComboSelection()
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
            NavigationService.Navigate(new CustomizeCombo());
        }

        /// <summary>
        /// This gives functionality to the Dino Nuggets button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DinoNuggetsButton(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeCombo());
        }

        /// <summary>
        /// This gives functionality to the Prehistoric PBJ button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrehistoricPBJButton(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeCombo());
        }

        /// <summary>
        /// This gives functionality to the Pterodactyl Wings button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PterodactylWingsButton (object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeCombo());
        }

        /// <summary>
        /// This gives functionality to the Steakosaurus Burger button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SteakosarusButton(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeCombo());
        }

        /// <summary>
        /// This gives functionality to the TRex King Burger button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TRexKingButton(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeCombo());
        }

        /// <summary>
        /// This gives functionality to the Veloci-Wrap button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VelociwrapButton(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeCombo());
        }
    }
}
