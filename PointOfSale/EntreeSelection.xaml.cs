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
        /// This is the private backing variable for the non-empty constructor.
        /// </summary>
        private Entree entree;

        /// <summary>
        /// This initializes the page that allows the user to choose an entree.
        /// </summary>
        public EntreeSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This initializes the entree selection page.
        /// </summary>
        public EntreeSelection(Entree entree)
        {
            InitializeComponent();
            this.entree = entree;
        }

        /// <summary>
        /// This gives functionality to the Brontowurst button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BrontowurstButton(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                Brontowurst bw = new Brontowurst();
                order.Add(bw);
                NavigationService.Navigate(new CustomizeBrontowurst(bw));
            }
        }

        /// <summary>
        /// This gives functionality to the Dino Nuggets button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DinoNuggetsButton(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                DinoNuggets nugs = new DinoNuggets();
                order.Add(nugs);
                NavigationService.Navigate(new CustomizeDinoNuggets(nugs));
            }
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
            if (DataContext is Order order)
            {
                PterodactylWings wings = new PterodactylWings();
                order.Add(wings);
            }
        }

        /// <summary>
        /// This gives functionality to the Steakosaurus Burger button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SteakosarusButton(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                SteakosaurusBurger sb = new SteakosaurusBurger();
                order.Add(sb);
                NavigationService.Navigate(new CustomizeSteakosaurusBurger(sb));
            }
        }

        /// <summary>
        /// This gives functionality to the TRex King Burger button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TRexKingButton(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                TRexKingBurger trex = new TRexKingBurger();
                order.Add(trex);
                NavigationService.Navigate(new CustomizeTRexKingBurger(trex));
            }
        }

        /// <summary>
        /// This gives functionality to the Veloci-Wrap button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VelociwrapButton(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                VelociWrap vw = new VelociWrap();
                order.Add(vw);
                NavigationService.Navigate(new CustomizeVelociWrap(vw));
            }
        }
    }
}
