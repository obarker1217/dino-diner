/* Drink.cs
 * Author: Owen Barker
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// 
    /// </summary>
    public enum SodasaurusFlavor
    {
        Cola,
        Orange,
        Lime,
        Cherry,
        Vanilla,
        RootBeer,
        //Grape,
        Chocolate//,
        //Cream
    }

    /// <summary>
    /// 
    /// </summary>
    public abstract class Drink
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
        public bool Ice { get; set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                return ingredients;
            }
        }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public void HoldIce()
        {
            this.Ice = false;
        }
    }
}
