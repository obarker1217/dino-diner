/* SteakosaurusBurger.cs
 * Author: Owen Barker
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// This class creates the SteakosaurusBurger object and its menu specifications, including its 
    /// calories, price, and ingredients. It also lists which ingredients can be changed.
    /// </summary>
    public class SteakosaurusBurger : Entree, IMenuItem
    {
        /// <summary>
        /// This bool determines if the item contains a bun.
        /// </summary>
        private bool bun = true;
        /// <summary>
        /// This bool determines if the item contains pickles.
        /// </summary>
        private bool pickle = true;
        /// <summary>
        /// This bool determines if the item contains ketchup.
        /// </summary>
        private bool ketchup = true;
        /// <summary>
        /// This bool determines if the item contains mustard.
        /// </summary>
        private bool mustard = true;

        /// <summary>
        /// This list contains all the ingredients of the burger and allows the bun, pickles, ketchup,
        /// and mustard to be removed.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie" };
                if (bun)
                {
                    ingredients.Add("Whole Wheat Bun");
                }
                if (pickle)
                {
                    ingredients.Add("Pickle");
                }
                if (ketchup)
                {
                    ingredients.Add("Ketchup");
                }
                if (mustard)
                {
                    ingredients.Add("Mustard");
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
            return "Steakosaurus Burger";
        }

        /// <summary>
        /// This method sets the default price and calorie count for the menu item.
        /// </summary>
        public SteakosaurusBurger()
        {
            this.Price = 5.15;
            this.Calories = 621;
        }

        /// <summary>
        /// This method allows the user to remove the bun.
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
        }
        /// <summary>
        /// This method allows the user to remove the pickles.
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
        }
        /// <summary>
        /// This method allows the user to remove the ketchup.
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
        }
        /// <summary>
        /// This method allows the user to remove the mustard.
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
        }
    }
}
