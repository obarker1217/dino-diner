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
using DinoDiner.Menu;
using Size = DinoDiner.Menu.Size;
using System.ComponentModel;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page, INotifyPropertyChanged
    {
        /// <summary>
        /// This method sends a message to the program when a men u item property is changed.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// This method creates a new instance of the event argument when a property is changed.
        /// </summary>
        /// <param name="propertyName"></param>
        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// 
        /// </summary>
        private Drink drink;

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
            if (DataContext is Order order)
            {
                drink = new Tyrannotea();
                order.Add(new Tyrannotea());
            }
        }

        /// <summary>
        /// This gives functionality to the JurassicJava button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void JurassicJavaButton(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                drink = new JurassicJava();
                order.Add(new JurassicJava());
            }
        }

        /// <summary>
        /// This gives functionality to the SodaSaurus button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SodasaurusButton(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                drink = new Sodasaurus();
                order.Add(new Sodasaurus());
            }
        }

        /// <summary>
        /// This gives functionality to the Water button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WaterButton(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                drink = new Water();
                order.Add(new Water());
            }
        }

        /// <summary>
        /// This gives functionality to the Add Lemon button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddLemonButton(object sender, RoutedEventArgs e)
        {
            if(DataContext is Water || DataContext is Tyrannotea)
            {
                //this.drink.AddLemon();
            }
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
            this.drink.Size = Size.Small;
            /*
            NotifyOfPropertyChanged("Size");
            NotifyOfPropertyChanged("Price");
            NotifyOfPropertyChanged("Description");
            */
        }

        /// <summary>
        /// This gives functionality to the Medium button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MediumRadioButton(object sender, RoutedEventArgs e)
        {
            
            this.drink.Size = Size.Medium;
            /*
            NotifyOfPropertyChanged("Size");
            NotifyOfPropertyChanged("Price");
            NotifyOfPropertyChanged("Description");
            */
        }

        /// <summary>
        /// This gives functionality to the Large button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LargeRadioButton(object sender, RoutedEventArgs e)
        {
            this.drink.Size = Size.Large;
            /*
            NotifyOfPropertyChanged("Size");
            NotifyOfPropertyChanged("Price");
            NotifyOfPropertyChanged("Description");
            */
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
            NavigationService.Navigate(new FlavorSelection((Sodasaurus)drink));
        }
    }
}
