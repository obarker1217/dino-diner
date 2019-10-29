﻿using System;
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
    /// Interaction logic for CustomizeVelociWrap.xaml
    /// </summary>
    public partial class CustomizeVelociWrap : Page
    {
        private VelociWrap vw = new VelociWrap();

        public CustomizeVelociWrap(VelociWrap vw)
        {
            InitializeComponent();
            this.vw = vw;
        }

        private void OnHoldDressing(object sender, RoutedEventArgs e)
        {
            this.vw.HoldDressing();
        }

        private void OnHoldLettuce(object sender, RoutedEventArgs e)
        {
            this.vw.HoldLettuce();
        }

        private void OnHoldCheese(object sender, RoutedEventArgs e)
        {
            this.vw.HoldCheese();
        }

        private void OnDone(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
