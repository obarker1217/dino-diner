/* Sodasaurus.cs
 * Author: Owen Barker
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// This class creates the Sodasarus drink and allows the user to choose flavor, if they want ice, and what size they want,
    /// which affects calorie count and price.
    /// </summary>
    public class Sodasaurus : Drink
    {
        /// <summary>
        /// This is the desired Sodasaurus flavor taken from the SodasaurusFLavor enum.
        /// </summary>
        private SodasaurusFlavor flavor;
        
        /// <summary>
        /// This is the actual public property for the flavor that uses the private property to choose the correct
        /// flavor of Sodasaurus.
        /// </summary>
        public SodasaurusFlavor Flavor
        {
            get
            {
                return flavor;
            }
            set
            {
                flavor = value;
            }
        }

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

        /// <summary>
        /// This constructor sets the default values of a new Sodasaurus object.
        /// </summary>
        public Sodasaurus()
        {
            Price = 1.50;
            Calories = 112;
            Ice = true;
            Ingredients.Add("Water");
            Ingredients.Add("Natural Flavors");
            Ingredients.Add("Cane Sugar");
        }
    }
}
