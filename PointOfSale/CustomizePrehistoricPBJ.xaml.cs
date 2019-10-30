/* CustomizePrehistoricPBJ.xaml.cs
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
    /// Interaction logic for CustomizePrehistoricPBJ.xaml
    /// </summary>
    public partial class CustomizePrehistoricPBJ : Page
    {
        /// <summary>
        /// This is the used object.
        /// </summary>
        private PrehistoricPBJ pbj;

        /// <summary>
        /// This constructor creates a non-empty instance.
        /// </summary>
        /// <param name="vw"></param>
        public CustomizePrehistoricPBJ(PrehistoricPBJ pbj)
        {
            InitializeComponent();
            this.pbj = pbj;
        }

        /// <summary>
        /// This button holds the peanut butter.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldPeanutButter(object sender, RoutedEventArgs e)
        {
            this.pbj.HoldPeanutButter();
        }

        /// <summary>
        /// This button holds the jelly.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldJelly(object sender, RoutedEventArgs e)
        {
            this.pbj.HoldJelly();
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
