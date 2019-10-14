/* DrinkSelection.xaml.cs
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
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        /// <summary>
        /// This constructor initializes the page.
        /// </summary>
        public DrinkSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This gives functionality to the Tyrannotea button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TyrannoteaButton(object sender, RoutedEventArgs e)
        {
            //SweetButton.IsChecked = true;
        }

        /// <summary>
        /// This gives functionality to the JurassicJava button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void JurassicJavaButton(object sender, RoutedEventArgs e)
        {
            //DecafButton.IsChecked = true;
        }

        /// <summary>
        /// This gives functionality to the SodaSaurus button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SodasaurusButton(object sender, RoutedEventArgs e)
        {
            //FlavorButton.IsChecked = true;
        }

        /// <summary>
        /// This gives functionality to the Water button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WaterButton(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// This gives functionality to the Add Lemon button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddLemonButton(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// This gives functionality to the Hold Ice button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldIceButton(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// This gives functionality to the Small button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SmallRadioButton(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// This gives functionality to the Medium button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MediumRadioButton(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// This gives functionality to the Large button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LargeRadioButton(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// This gives functionality to the Sweet button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SweetButton(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// This gives functionality to the Decaf button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DecafButton(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// This gives functionality to the Flavor button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FlavorButton(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new FlavorSelection());
        }
    }
}
