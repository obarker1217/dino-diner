/* Tyrannotea.cs
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
    public class Tyrannotea : Drink
    {
        public bool sweet = false;

        public bool lemon = false;
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
                        Calories = 8;
                        if(sweet)
                        {
                            Calories = 16;
                        }
                        break;

                    case Size.Medium:
                        Price = 1.49;
                        Calories = 16;
                        if (sweet)
                        {
                            Calories = 32;
                        }
                        break;

                    case Size.Large:
                        Price = 1.99;
                        Calories = 32;
                        if (sweet)
                        {
                            Calories = 64;
                        }
                        break;
                }
            }
            get
            {
                return size;
            }
        }

        public void AddLemon()
        {
            this.lemon = true;
        }

        public Tyrannotea()
        {
            Price = 1.50;
            Calories = 112;
            Ingredients.Add("Water");
            Ingredients.Add("Tea");
            //Ingredients.Add("Cane Sugar");
        }
    }
}
