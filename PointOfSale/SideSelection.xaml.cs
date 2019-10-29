/* SideSelection.xaml.cs
 * Author: Owen Barker
 */

using System.Windows;
using System.Windows.Controls;
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page
    {
        /// <summary>
        /// 
        /// </summary>
        private Side side;
        
        /// <summary>
        /// This initializes the side selection page.
        /// </summary>
        public SideSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This initializes the side selection page.
        /// </summary>
        public SideSelection(Side side)
        {
            InitializeComponent();
            this.side = side;
        }

        /// <summary>
        /// This gives functionality to the Fryceritops button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FryceritopsButton(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                side = new Fryceritops();
                order.Add(new Fryceritops());
            }
        }

        /// <summary>
        /// This gives functionality to the Meteor Mac and Cheese button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MeteorMacAndCheeseButton(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                side = new MeteorMacAndCheese();
                order.Add(new MeteorMacAndCheese());
            }
        }

        /// <summary>
        /// This gives functionality to the Mezzorella Sticks button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MezzorellaSticksButton(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                side = new MezzorellaSticks();
                order.Add(new MezzorellaSticks());
            }
        }

        /// <summary>
        /// This gives functionality to the Trieritots button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TriceritotsButton(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                side = new Triceritots();
                order.Add(new Triceritots());
            }
        }

        /// <summary>
        /// This gives functionality to the Small button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SmallRadioButton(object sender, RoutedEventArgs e)
        {
            //SideSelection(DinoDiner.Menu.Size)
            NavigationService.GoBack();
        }

        /// <summary>
        /// This gives functionality to the Medium button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MediumRadioButton(object sender, RoutedEventArgs e)
        {

            NavigationService.GoBack();
        }

        /// <summary>
        /// This gives functionality to the Large button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LargeRadioButton(object sender, RoutedEventArgs e)
        {

            NavigationService.GoBack();
        }
    }
}
