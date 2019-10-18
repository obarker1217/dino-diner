/* Entree.cs
 * Author: Owen Barker
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// This abstract base class creates the properties for the price, calorie count, and ingredients for all entree classes.
    /// </summary>
    public abstract class Entree: IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// This is the read-only list of ingredients.
        /// </summary>
        protected List<string> ingredients = new List<string>();
    
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Description
        {
            get { return this.ToString(); }
        }

        /// <summary>
        /// 
        /// </summary>
        public string[] Special { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="propertyName"></param>
        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public virtual List<string> Ingredients
        {
            get
            {
                return ingredients;
            }
        }
    }
}
