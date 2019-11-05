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
using DinoDiner.Menu;
using Size = DinoDiner.Menu.Size;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : Page
    {
        /// <summary>
        /// This private backing variable sets the value for the combo.
        /// </summary>
        private CretaceousCombo combo;

        /// <summary>
        /// This constructor initializes the page.
        /// </summary>
        public ComboSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This event creates a non-empty combo.
        /// </summary>
        /// <param name="combo"></param>
        public ComboSelection(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
        }

        /// <summary>
        /// This event adds a Brontowurst and goes to its selection page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnSelectBrontowurst(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                Brontowurst bw = new Brontowurst();
                order.Add(bw);
                NavigationService.Navigate(new CustomizeBrontowurst(bw));
            }
        }

        /// <summary>
        /// This event adds a Dino Nugget and goes to its selection page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnSelectDinoNuggets(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                DinoNuggets dn = new DinoNuggets();
                order.Add(dn);
                NavigationService.Navigate(new CustomizeDinoNuggets(dn));
            }
        }

        /// <summary>
        /// This event adds a Prehistoric PB&J and goes to its selection page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnSelectPrehistoricPBJ(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                PrehistoricPBJ pbj = new PrehistoricPBJ();
                order.Add(pbj);
                NavigationService.Navigate(new CustomizePrehistoricPBJ(pbj));
            }
        }

        /// <summary>
        /// This event adds a Pterodactyl Wing and goes to its selection page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnSelectPterodactylWings(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                PterodactylWings pw = new PterodactylWings();
                order.Add(pw);
            }
        }

        /// <summary>
        /// This event adds a Steakosaurus Burger and goes to its selection page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnSelectSteakosaurusBurger(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                SteakosaurusBurger sb = new SteakosaurusBurger();
                order.Add(sb);
                NavigationService.Navigate(new CustomizeSteakosaurusBurger(sb));
            }
        }

        /// <summary>
        /// This event adds a T-Rex King Burger and goes to its selection page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnSelectTRexKingBurger(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                TRexKingBurger trex = new TRexKingBurger();
                order.Add(trex);
                NavigationService.Navigate(new CustomizeTRexKingBurger(trex));
            }
        }

        /// <summary>
        /// This event adds a Veloci-Wrap and goes to its selection page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnSelectVelociwrap(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                VelociWrap vw = new VelociWrap();
                order.Add(vw);
                NavigationService.Navigate(new CustomizeVelociWrap(vw));
            }
        }

        /// <summary>
        /// This event moves to the side selection page to add to the order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnSelectSide(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order order)
            {
                NavigationService.Navigate(new SideSelection());
            }
        }

        /// <summary>
        /// This event moves to the drink selection page to add to the order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnSelectDrink(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                NavigationService.Navigate(new DrinkSelection());
            }
        }

        /// <summary>
        /// This mehtod changes the combo to a small.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SmallRadioButton(object sender, RoutedEventArgs e)
        {
            this.combo.Size = Size.Small;
        }

        /// <summary>
        /// This mehtod changes the combo to a medium.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MediumRadioButton(object sender, RoutedEventArgs e)
        {
            this.combo.Size = Size.Medium;
        }

        /// <summary>
        /// This mehtod changes the combo to a large.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LargeRadioButton(object sender, RoutedEventArgs e)
        {
            this.combo.Size = Size.Large;
        }
    }
}
