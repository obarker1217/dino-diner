/* Entree.cs
 * Author: Owen Barker
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// This abstract base class creates the properties for the price, calorie count, and ingredients for all entree classes.
    /// </summary>
    public abstract class Entree
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
