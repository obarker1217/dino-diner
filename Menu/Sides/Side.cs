/* Side.cs
 * Author: Owen Barker
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// This abstract base class creates all the properties for the sides classes.
    /// </summary>
    public abstract class Side : IMenuItem
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
        /// Gets or sets the size
        /// </summary>
        public virtual Size Size { get; set; }

    }
}
