﻿/* Water.cs
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
    public class Water : Drink
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
            /*
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        Price = 0.59;
                        Calories = 2;
                        break;

                    case Size.Medium:
                        Price = 0.99;
                        Calories = 4;
                        break;

                    case Size.Large:
                        Price = 1.99;
                        Calories = 8;
                        break;
                }
            }
            */
            get
            {
                return size;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Lemon { get; set; } = false;

        public void AddLemon()
        {
            this.Lemon = true;
        }

        /// <summary>
        /// 
        /// </summary>
        public Water()
        {
            Price = 0.10;
            Calories = 0;
            Ingredients.Add("Water");
        }
    }
}
