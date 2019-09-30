﻿/* Tyrannotea.cs
 * Author: Owen Barker
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// This class creates the Tyrranotea drink and allows the user to choose if they want ice and what size they want,
    /// which affects calorie count and price.
    /// </summary>
    public class Tyrannotea : Drink
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
                        Calories = 8;
                        break;

                    case Size.Medium:
                        Price = 1.49;
                        Calories = 16;
                        break;

                    case Size.Large:
                        Price = 1.99;
                        Calories = 32;
                        break;
                }
            }
            get
            {
                return size;
            }
        }

        /// <summary>
        /// This boolean decides if the tea has sugar added. 
        /// </summary>
        public bool Sweet { get; set; } = false;

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
        /// This method sets the sweet property to true and doubles the calories.
        /// </summary>
        public void AddSweetener()
        {
            this.Sweet = true;
            this.Calories = this.Calories * 2;
            Ingredients.Add("Cane Sugar");
        }

        /// <summary>
        /// This method sets the sweet property to false and sets the calories to false.
        /// </summary>
        public void RemoveSweetener()
        {
            this.Sweet = false;
            this.Calories = this.Calories / 2;
            Ingredients.Remove("Cane Sugar");
        }

        /// <summary>
        /// This constructor sets the default values of a new Tyrannotea object.
        /// </summary>
        public Tyrannotea()
        {
            Price = 0.99;
            Calories = 8;
            Ice = true;
            Ingredients.Add("Water");
            Ingredients.Add("Tea");
        }
    }
}
