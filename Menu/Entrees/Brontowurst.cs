﻿/* Brontowurst.cs
 * Author: Owen Barker
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// This class creates the Brontowurst object and its menu specifications, including its 
    /// calories, price, and ingredients. It also lists which ingredients can be changed.
    /// </summary>
    public class Brontowurst : Entree, IMenuItem
    {
        /// <summary>
        /// This bool determines if the item contains a bun.
        /// </summary>
        private bool bun = true;
        /// <summary>
        /// This bool determines if the item contains peppers.
        /// </summary>
        private bool peppers = true;
        /// <summary>
        /// This bool determines if the item contains onions.
        /// </summary>
        private bool onions = true;

        /// <summary>
        /// This list contains all the ingredients of the Brontowurst and allows the bun, peppers,
        /// and onions to be removed.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string> {"Brautwurst"};
                if(bun)
                {
                    ingredients.Add("Whole Wheat Bun");
                }
                if(peppers)
                {
                    ingredients.Add("Peppers");
                }
                if(onions)
                {
                    ingredients.Add("Onion");
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
            return "Brontowurst";
        }

        /// <summary>
        /// This method sets the default price and calorie count for the menu item.
        /// </summary>
        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }

        /// <summary>
        /// This method allows the user to remove the bun.
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// This method allows the user to remove the peppers.
        /// </summary>
        public void HoldPeppers()
        {
            this.peppers = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// This method allows the user to remove the onions.
        /// </summary>
        public void HoldOnion()
        {
            this.onions = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
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
                if (!bun)
                {
                    special.Add("Hold Whole Wheat Bun");
                }
                if (!peppers)
                {
                    special.Add("Hold Peppers");
                }
                if(!onions)
                {
                    special.Add("Hold Onions");
                }
                return special.ToArray();
            }
        }
    }
}
