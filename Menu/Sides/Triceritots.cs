﻿/* Triceritots.cs
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
    public class Triceritots : Side, IMenuItem
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
                switch(size)
                {
                    case Size.Small:
                        Price = 0.99;
                        Calories = 352;
                        NotifyOfPropertyChanged("Description");
                        NotifyOfPropertyChanged("Price");
                        break;

                    case Size.Medium:
                        Price = 1.45;
                        Calories = 410;
                        NotifyOfPropertyChanged("Description");
                        NotifyOfPropertyChanged("Price");
                        break;

                    case Size.Large:
                        Price = 1.95;
                        Calories = 590;
                        NotifyOfPropertyChanged("Description");
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
        /// This list contains all the ingredients of the wings and allows for no ingredients to be
        /// changed.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string> { "Potato", "Salt", "Vegetable Oil" };
                return ingredients;
            }
        }

        /// <summary>
        /// This class creates the actual Triceratots with the default price and calories of a small size order
        /// and all the ingredients.
        /// </summary>
        public Triceritots()
        {
            Price = 0.99;
            Calories = 352;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return SizeString + " Triceritots";
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
