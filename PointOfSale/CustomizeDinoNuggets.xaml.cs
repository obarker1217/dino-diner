/* CustomizeDinoNuggets.xaml.cs
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
    /// Interaction logic for CustomizeDinoNuggets.xaml
    /// </summary>
    public partial class CustomizeDinoNuggets : Page
    {
        /// <summary>
        /// This is the used object.
        /// </summary>
        private DinoNuggets nugs = new DinoNuggets();

        /// <summary>
        /// This constructor creates a non-empty instance.
        /// </summary>
        /// <param name="vw"></param>
        public CustomizeDinoNuggets(DinoNuggets nugs)
        {
            InitializeComponent();
            this.nugs = nugs;
        }

        /// <summary>
        /// This button adds nuggets.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddNugget(object sender, RoutedEventArgs e)
        {
            this.nugs.AddNugget();
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
