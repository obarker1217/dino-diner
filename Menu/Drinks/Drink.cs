/* Drink.cs
 * Author: Owen Barker
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// This class gives general properties to all drinks. It is abstract so it can be overridden if need be.
    /// </summary>
    public abstract class Drink : IMenuItem
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
        /// This boolean decides if a drink should have ice in it. All drinks but JurrasicJava default to true.
        /// </summary>
        public bool Ice { get; set; }

        /// <summary>
        /// This string names a size for the ToString() override.
        /// </summary>
        public string SizeString
        {
            get
            {
                return Size.ToString();
            }
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

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// This method removes the ice from a given drink.
        /// </summary>
        public void HoldIce()
        {
            this.Ice = false;
        }
    }
}
