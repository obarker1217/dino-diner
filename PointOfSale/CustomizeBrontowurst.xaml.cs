/* CustomizeBrontowurst.xaml.cs
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
    /// Interaction logic for CustomizeBrontowurst.xaml
    /// </summary>
    public partial class CustomizeBrontowurst : Page
    {
        /// <summary>
        /// This is the used object.
        /// </summary>
        private Brontowurst bw = new Brontowurst();

        /// <summary>
        /// This constructor creates a non-empty instance.
        /// </summary>
        /// <param name="vw"></param>
        public CustomizeBrontowurst(Brontowurst bw)
        {
            InitializeComponent();
            this.bw = bw;
        }

        /// <summary>
        /// This button holds the bun.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldBun(object sender, RoutedEventArgs e)
        {
            this.bw.HoldBun();
        }

        /// <summary>
        /// This button holds the peppers.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldPeppers(object sender, RoutedEventArgs e)
        {
            this.bw.HoldPeppers();
        }

        /// <summary>
        /// This button holds the onions.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldOnions(object sender, RoutedEventArgs e)
        {
            this.bw.HoldOnion();
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
