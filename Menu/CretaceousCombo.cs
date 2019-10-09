/* CretaceousCombo.cs
 * Author: Owen Barker
 */

using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Entrees;
using DinoDiner.Menu.Sides;
using DinoDiner.Menu.Drinks;

namespace DinoDiner.Menu
{
    public class CretaceousCombo : IMenuItem
    {
        /// <summary>
        /// 
        /// </summary>
        public Entree Entree { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Side Side { get; set; } = new Fryceritops();

        /// <summary>
        /// 
        /// </summary>
        public Drink Drink { get; set; } = new Sodasaurus();

        /// <summary>
        /// 
        /// </summary>
        public double Price
        {
            get
            {
                return Entree.Price + Drink.Price + Side.Price - 0.25;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public uint Calories
        {
            get
            {
                return Entree.Calories + Drink.Calories + Side.Calories;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private Size size = Size.Small;

        /// <summary>
        /// 
        /// </summary>
        public Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                Drink.Size = value;
                Side.Size = value;    
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.AddRange(Entree.Ingredients);
                ingredients.AddRange(Drink.Ingredients);
                ingredients.AddRange(Side.Ingredients);
                return ingredients;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public CretaceousCombo(Entree entree)
        {
            Entree = entree;
        }

        /*
        /// <summary>
        /// This method overrides the standard ToString() method to show the item.
        /// </summary>
        /// <returns>
        /// A string containing the named menu item is returned.
        /// </returns>
        public override string ToString()
        {
            return Size.ToString() + " " + Entree.ToString() + " Combo";
        }
        */
    }
}
