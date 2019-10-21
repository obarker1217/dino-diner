/* Order.cs
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
    /// 
    /// </summary>
    public class Order
    {
        /// <summary>
        /// 
        /// </summary>
        public ObservableCollection<IOrderItem> Items
        {
            get
            {
                ObservableCollection<IOrderItem> orderItem = 
                    new ObservableCollection<IOrderItem>();

                return orderItem;
            }
            set
            {
                //value = 
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public double SubtotalCost { get; }

        /// <summary>
        /// 
        /// </summary>
        public double SalesTaxRate { get; protected set; }

        /// <summary>
        /// 
        /// </summary>
        double SalesTaxCost { get; }

        /// <summary>
        /// 
        /// </summary>
        double TotalCost { get; }
    }
}
