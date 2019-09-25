/* Sodasaurus.cs
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
    public class Sodasaurus : Drink
    {
        /// <summary>
        /// 
        /// </summary>
        private SodasaurusFlavor flavor;
        
        /// <summary>
        /// 
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
        /// 
        /// </summary>
        public bool Ice { get; set; } = true;

        /// <summary>
        /// 
        /// </summary>
        public double Price { get; set; } = 1.50;

        /// <summary>
        /// 
        /// </summary>
        public uint Calories { get; set; } = 122;

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
        /// 
        /// </summary>
        public void HoldIce()
        {
            this.Ice = false;
        }

        /// <summary>
        /// 
        /// </summary>
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
