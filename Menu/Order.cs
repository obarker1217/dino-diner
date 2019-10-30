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
    /// This class creates the user's running order and calculates the subtotal, 
    /// tax, and final total.
    /// </summary>
    public class Order : INotifyPropertyChanged
    {
        /// <summary>
        /// This ObservableCollections contains the items on the order.
        /// </summary>
        private List<IOrderItem> items;

        public IOrderItem [] Items
        {
            get
            {
                return items.ToArray();
            }
        }

        /// <summary>
        /// This is the oweb subtotal. It cannot be negative.
        /// </summary>
        public double SubtotalCost
        {
            get
            {
                double subtotal = 0;
                for(int i = 0; i < items.Count; i++)
                {
                    if(items[i].Price > 0)
                    {
                        subtotal += items[i].Price;
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

        public Order()
        {
            items = new List<IOrderItem>();
        }

        public void Add(IOrderItem item)
        {
            item.PropertyChanged += OnCollectionChanged;
            items.Add(item);
            OnCollectionChanged(this, new EventArgs());
        }

        public void Remove(IOrderItem item)
        {
            items.Remove(item);
            OnCollectionChanged(this, new EventArgs());
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnCollectionChanged(object sender, EventArgs args)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
        }
    }
}
