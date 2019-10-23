﻿/* Order.cs
 * Author: Owen Barker
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// This class creates the user's running order and calculates the subtotal, 
    /// tax, and final total.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// This ObservableCollections contains the items on the order.
        /// </summary>
        public ObservableCollection<IOrderItem> Items { get; set; }
            = new ObservableCollection<IOrderItem>();

        /// <summary>
        /// This is the oweb subtotal. It cannot be negative.
        /// </summary>
        public double SubtotalCost
        {
            get
            {
                double subtotal = 0;
                for(int i = 0; i < Items.Count; i++)
                {
                    if(Items[i].Price > 0)
                    {
                        subtotal += Items[i].Price;
                    }
                    else
                    {
                        return -1;
                    }
                }
                return subtotal;
            }
        }

        /// <summary>
        /// This is the set sales tax.
        /// </summary>
        public double SalesTaxRate { get; protected set; } = 0.10;

        /// <summary>
        /// This is how much the sales tax costs on any given order.
        /// </summary>
        public double SalesTaxCost
        {
            get
            {
                return SalesTaxRate * SubtotalCost;
            }
        }

        /// <summary>
        /// This is the entire cost owed.
        /// </summary>
        public double TotalCost
        {
            get
            {
                return SubtotalCost + SalesTaxCost;
            }
        }
    }
}
