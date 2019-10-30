/* OrderList.xaml.cs
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
    /// Interaction logic for OrderList.xaml
    /// </summary>
    public partial class OrderList : UserControl
    {
        /// <summary>
        /// This is an empty constructor for a new order.
        /// </summary>
        public OrderList()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This allows the user to move between pages with buttons.
        /// </summary>
        public NavigationService navigationService { get; set; }

        /// <summary>
        /// This removes an item from the order list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void RemoveItem(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                if(sender is FrameworkElement element)
                {
                    if(element.DataContext is IOrderItem orderItem)
                    {
                        order.Remove(orderItem);
                    }
                }
            }
        }

        /*
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectionChanged(object sender, SelectedCellsChangedEventArgs args)
        {
            if(DataContext is Order order)
            {
                if(sender is ListBox element)
                {
                    if(element.SelectedItem is Drink drink)
                    {
                        navigationService.Navigate(new DrinkSelection(drink));
                    }
                    if (element.SelectedItem is Side side)
                    {
                        navigationService.Navigate(new SideSelection(side));
                    }
                    if (element.SelectedItem is Entree entree)
                    {
                        navigationService.Navigate(new EntreeSelection(entree));
                    }
                }
            }
        }
        */
    }    
}
