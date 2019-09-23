/* Sodasaurus.cs
 * Author: Owen Barker
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// 
    /// </summary>
    public class Sodasaurus : Drink
    {
        /// <summary>
        /// 
        /// </summary>
        public SodasaurusFlavor Flavor { get; set; }

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
                        Price = 1.50;
                        Calories = 112;
                        break;

                    case Size.Medium:
                        Price = 2.00;
                        Calories = 156;
                        break;

                    case Size.Large:
                        Price = 2.50;
                        Calories = 208;
                        break;
                }
            }
            get
            {
                return size;
            }
        }


        public Sodasaurus()
        {
            Price = 1.50;
            Calories = 112;
            Ingredients.Add("Water");
            Ingredients.Add("Natural Flavors");
            Ingredients.Add("Cane Sugar");
        }
    }
}
