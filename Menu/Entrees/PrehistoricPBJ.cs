/* Brontowurst.cs
 * Author: Nathan Bean
 * Modified by: Owen Barker
 */

using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// This class creates the PrehistoricPBJ object and its menu specifications, including its 
    /// calories, price, and ingredients. It also lists which ingredients can be changed.
    /// </summary>
    public class PrehistoricPBJ : Entree, IMenuItem
    {
        /// <summary>
        /// This bool determines if the item contains peanut butter.
        /// </summary>
        private bool peanutButter = true;
        /// <summary>
        /// This bool determines if the item contains jelly.
        /// </summary>
        private bool jelly = true;
        
        /// <summary>
        /// This list contains all the ingredients of the PBJ and allows the peanut butter and jelly
        /// to be removed.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Bread" };
                if (peanutButter)
                {
                    ingredients.Add("Peanut Butter");
                }
                if (jelly)
                {
                    ingredients.Add("Jelly");
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
            return "Prehistoric PB&J";
        }

        /// <summary>
        /// This method sets the default price and calorie count for the menu item.
        /// </summary>
        public PrehistoricPBJ()
        {
            this.Price = 6.52;
            this.Calories = 483;
        }

        /// <summary>
        /// This method allows the user to remove the peanut butter.
        /// </summary>
        public void HoldPeanutButter()
        {
            this.peanutButter = false;
        }

        /// <summary>
        /// This method allows the user to remove the jelly.
        /// </summary>
        public void HoldJelly()
        {
            this.jelly = false;
        }
    }
}
