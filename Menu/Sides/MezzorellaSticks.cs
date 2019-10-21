/* MezzorellaSticks.cs
 * Author: Owen Barker
 */

using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;

namespace DinoDiner.Menu
{
    /// <summary>
    /// This class inherits from the Side class and contains three sizes, each with changing price and calories 
    /// and a list of ingredients that cannot be changed.
    /// </summary>
    public class MezzorellaSticks : Side, IMenuItem
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
                        Price = 0.99;
                        Calories = 540;
                        NotifyOfPropertyChanged("Size");
                        NotifyOfPropertyChanged("Price");
                        break;

                    case Size.Medium:
                        Price = 1.45;
                        Calories = 610;
                        NotifyOfPropertyChanged("Size");
                        NotifyOfPropertyChanged("Price");
                        break;

                    case Size.Large:
                        Price = 1.95;
                        Calories = 720;
                        NotifyOfPropertyChanged("Size");
                        NotifyOfPropertyChanged("Price");
                        break;
                }
            }
            get
            {
                return size;
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
            return SizeString + " Mezzorella Sticks";
        }

        /// <summary>
        /// This list contains all the ingredients of the wings and allows for no ingredients to be
        /// changed.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string> { "Cheese Product", "Breading", "Vegetable Oil" };
                return ingredients;
            }
        }

        /// <summary>
        /// This class creates the actual MezzorellaSticks with the default price and calories of a small size order
        /// and all the ingredients.
        /// </summary>
        public MezzorellaSticks()
        {
            Price = 0.99;
            Calories = 540;
        }

        /// <summary>
        /// This method creates a ToString function for the special changes to the 
        /// given menu item.
        /// </summary>
        public string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                return special.ToArray();
            }
        }
    }
}
