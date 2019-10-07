/* VelociWrap.cs
 * Author: Owen Barker
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// This class creates the VelociWrap object and its menu specifications, including its 
    /// calories, price, and ingredients. It also lists which ingredients can be changed.
    /// </summary>
    public class VelociWrap : Entree, IMenuItem
    {
        /// <summary>
        /// This bool determines if the item contains Caesar dressing.
        /// </summary>
        private bool dressing = true;
        /// <summary>
        /// This bool determines if the item contains lettuce.
        /// </summary>
        private bool lettuce = true;
        /// <summary>
        /// This bool determines if the item contains cheese.
        /// </summary>
        private bool cheese = true;

        /// <summary>
        /// This list contains all the ingredients of the wrap and allows the dressing, lettuce,
        /// and cheese to be removed.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string> { "Flour Tortilla", "Chicken Breast"};
                if (dressing)
                {
                    ingredients.Add("Ceasar Dressing");
                }
                if (lettuce)
                {
                    ingredients.Add("Romaine Lettuce");
                }
                if (cheese)
                {
                    ingredients.Add("Parmesan Cheese");
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
            return "Veloci-Wrap";
        }

        /// <summary>
        /// This method sets the default price and calorie count for the menu item.
        /// </summary>
        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
        }

        /// <summary>
        /// This method allows the user to remove the dressing.
        /// </summary>
        public void HoldDressing()
        {
            this.dressing = false;
        }
        /// <summary>
        /// This method allows the user to remove the lettuce.
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
        }
        /// <summary>
        /// This method allows the user to remove the cheese.
        /// </summary>
        public void HoldCheese()
        {
            this.cheese = false;
        }
    }
}
