﻿/* CustomizeBrontowurst.xaml.cs
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
        private Brontowurst bw = new Brontowurst();

        public CustomizeBrontowurst(Brontowurst bw)
        {
            InitializeComponent();
            this.bw = bw;
        }

        private void OnHoldBun(object sender, RoutedEventArgs e)
        {
            this.bw.HoldBun();
        }

        private void OnHoldPeppers(object sender, RoutedEventArgs e)
        {
            this.bw.HoldPeppers();
        }

        private void OnHoldOnions(object sender, RoutedEventArgs e)
        {
            this.bw.HoldOnion();
        }

        private void OnDone(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
