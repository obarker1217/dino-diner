/* Water.cs
 * Author: Owen Barker
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// This class creates the Water drink and allows the user to choose if they want ice and what size they want,
    /// which does not affect calorie count or price.
    /// </summary>
    public class Water : Drink, IMenuItem
    {
        /// <summary>
        /// This private property allows the switch case to function based on a change of order size.
        /// </summary>
        private Size size;

        /// <summary>
        /// This overridden method allows the calories and price of the menu item to change based on order size.
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        Price = 0.10;
                        Calories = 0;
                        break;

                    case Size.Medium:
                        Price = 0.10;
                        Calories = 0;
                        break;

                    case Size.Large:
                        Price = 0.10;
                        Calories = 0;
                        break;
                }
            }
            get
            {
                return size;
            }
        }

        /// <summary>
        /// This list contains all the ingredients of the wings and allows for no ingredients to be
        /// changed.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string> { "Water" };
                return ingredients;
            }
        }

        /// <summary>
        /// This method overrides the standard ToString() method to show the item.
        /// </summary>
        /// <returns>
        /// A string containing the named menu item is returned.
        /// </returns>
        public override string ToString()
        {
            return SizeString + " Water";
        }

        /// <summary>
        /// This property represents a slice of lemon being added to a drink. It defaults to false.
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// This method allows the user to add a lemon to their drink.
        /// </summary>
        public void AddLemon()
        {
            this.Lemon = true;
            Ingredients.Add("Lemon");
        }

        /// <summary>
        /// This constructor sets the default values of a new Water object.
        /// </summary>
        public Water()
        {
            Price = 0.10;
            Calories = 0;
            Ice = true;
        }
    }
}
