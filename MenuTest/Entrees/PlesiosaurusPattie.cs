/* PlesiosaurusPattie.cs
 * Author: Owen Barker
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// 
    /// </summary>
    public class PlesiosaurusPattie: Entree, IMenuItem
    {
        /// <summary>
        /// 
        /// </summary>
        private bool mayo = true;

        /// <summary>
        /// 
        /// </summary>
        private bool bun = true;

        //private List<string> ingredients;

        /// <summary>
        /// 
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                ingredients.Add("Fish Patty");
                ingredients.Add("Whole Wheat Bun");
                ingredients.Add("Mayonnaise");
                return ingredients;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public PlesiosaurusPattie()
        {
            mayo = true;
            bun = true;
            this.Price = 5.50;
            this.Calories = 487;
        }

        /// <summary>
        /// 
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
            Ingredients.Remove("Whole Wheat Bun");
        }

        /// <summary>
        /// 
        /// </summary>
        public void HoldMayo()
        {
            this.mayo = false;
            Ingredients.Remove("Mayonnaise");
        }
    }
}
