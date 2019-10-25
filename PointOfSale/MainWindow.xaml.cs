/* MainWindow.xaml.cs
 * Athor: Owen Barker
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// This initializes tge structure for the main window of the whole project.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            OrderUI.Navigate(new MenuCategorySelection());
            OrderConrol.NavigationService = OrderUI.NavigationService();
        }

        private void PassDataContentToPage()
        {
            if(OrderUI.Content is Page page)
            {
                page.DataContext = OrderUI.DataContext;
            }
        }

        private void OrderUI_LoadCompleted(object sender, NavigationEventArgs args)
        {
            PassDataContentToPage();
        } 

        private void OrderUI_DataContextChanged(object sender, DependencyPropertyChangedEventArgs args)
        {
            PassDataContentToPage();
        }

        private void Frame_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
