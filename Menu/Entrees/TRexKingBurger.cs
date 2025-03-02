﻿/* TRexKingBurger.cs
 * Author: Owen Barker
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// This class creates the TRexKingBurger object and its menu specifications, including its 
    /// calories, price, and ingredients. It also lists which ingredients can be changed.
    /// </summary>
    public class TRexKingBurger : Entree, IMenuItem
    {
        /// <summary>
        /// This bool determines if the item contains a bun.
        /// </summary>
        private bool bun = true;
        /// <summary>
        /// This bool determines if the item contains lettuce.
        /// </summary>
        private bool lettuce = true;
        /// <summary>
        /// This bool determines if the item contains tomato.
        /// </summary>
        private bool tomato = true;
        /// <summary>
        /// This bool determines if the item contains onion.
        /// </summary>
        private bool onion = true;
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
        /// This bool determines if the item contains mayonnaise.
        /// </summary>
        private bool mayo = true;

        /// <summary>
        /// This list contains all the ingredients of the burger and allows the bun, lettuce, tomato,
        /// onions, pickles, ketchup, mustard and mayo to be removed.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>()
                { "Steakburger Pattie", "Steakburger Pattie", "Steakburger Pattie" };
                if (bun)
                {
                    ingredients.Add("Whole Wheat Bun");
                }
                if (lettuce)
                {
                    ingredients.Add("Lettuce");
                }
                if (tomato)
                {
                    ingredients.Add("Tomato");
                }
                if (onion)
                {
                    ingredients.Add("Onion");
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
                if(mayo)
                {
                    ingredients.Add("Mayo");
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
            return "T-Rex King Burger";
        }

        /// <summary>
        /// This method sets the default price and calorie count for the menu item.
        /// </summary>
        public TRexKingBurger()
        {
            this.Price = 8.45;
            this.Calories = 728;
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
        /// This method allows the user to remove the lettuce.
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// This method allows the user to remove the tomato.
        /// </summary>
        public void HoldTomato()
        {
            this.tomato = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// This method allows the user to remove the onion.
        /// </summary>
        public void HoldOnion()
        {
            this.onion = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// This method allows the user to remove the pickles.
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// This method allows the user to remove the ketchup.
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// This method allows the user to remove the mustard.
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// This method allows the user to remove the mayonnaise.
        /// </summary>
        public void HoldMayo()
        {
            this.mayo = false;
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
                if (!lettuce)
                {
                    special.Add("Hold Lettuce");
                }
                if (!tomato)
                {
                    special.Add("Hold Tomato");
                }
                if (!onion)
                {
                    special.Add("Hold Onions");
                }
                if (!pickle)
                {
                    special.Add("Hold Pickles");
                }
                if (!ketchup)
                {
                    special.Add("Hold Ketchup");
                }
                if (!mustard)
                {
                    special.Add("Hold Mustard");
                }
                if(!mayo)
                {
                    special.Add("Hold Mayo");
                }
                return special.ToArray();
            }
        }
    }
}
