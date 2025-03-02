﻿/* DinoNuggets.cs
 * Author: Owen Barker
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// This class creates the PBrontowurst object and its menu specifications, including its 
    /// calories, price, and ingredients. It also allows the user to change how many nuggets
    /// are included in an order and changes the price and calorie count to fit.
    /// </summary>
    public class DinoNuggets : Entree, IMenuItem
    {
        /// <summary>
        /// This uint keeps track of how many dino nuggets are on a given order.
        /// </summary>
        public uint nuggetCount = 6;

        /// <summary>
        /// This double has a getter and a setter to decide the price of the menu item.
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// This unsigned integer gives the calorie count for this menu item. It has a getter and 
        /// a setter.
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// This list contains all the ingredients of the nuggets and allows the user to add nuggets.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                for(int i = 1; i <= nuggetCount; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }
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
            return "Dino-Nuggets";
        }

        /// <summary>
        /// This method sets the default price and calorie count for the menu item. It also
        /// allows those fields to be changed.
        /// </summary>
        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 354;
        }
        
        /// <summary>
        /// This method allows the number of nuggets to change.
        /// </summary>
        public void AddNugget()
        {
            this.nuggetCount++;
            this.Price += 0.25;
            this.Calories += 59;
            NotifyOfPropertyChanged("Description");
            NotifyOfPropertyChanged("Special");
            NotifyOfPropertyChanged("Price");
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
                uint i = nuggetCount - 6;
                if(nuggetCount > 6)
                {
                    special.Add(i + " Extra Nuggets");
                }
                return special.ToArray();
            }
           
        } 
    }
}
