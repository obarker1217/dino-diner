﻿/* Sodasaurus.cs
 * Author: Owen Barker
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// This class creates the Sodasarus drink and allows the user to choose flavor, if they want ice, and what size they want,
    /// which affects calorie count and price.
    /// </summary>
    public class Sodasaurus : Drink, IMenuItem
    {
        /// <summary>
        /// This is the desired Sodasaurus flavor taken from the SodasaurusFLavor enum.
        /// </summary>
        private SodasaurusFlavor flavor;
        
        /// <summary>
        /// This is the actual public property for the flavor that uses the private property to choose the correct
        /// flavor of Sodasaurus.
        /// </summary>
        public SodasaurusFlavor Flavor
        {
            get
            {
                return flavor;
            }
            set
            {
                flavor = value;
                NotifyOfPropertyChanged("Description");
            }
        }

        /// <summary>
        /// This method translates the flavor into a string.
        /// </summary>
        private string FlavorString
        {
            get
            {
                return Flavor.ToString();
            }
            set
            {
                FlavorString = value;
            }
        }

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
                        Price = 1.50;
                        Calories = 112;
                        NotifyOfPropertyChanged("Price");
                        NotifyOfPropertyChanged("Description");
                        break;

                    case Size.Medium:
                        Price = 2.00;
                        Calories = 156;
                        NotifyOfPropertyChanged("Price");
                        NotifyOfPropertyChanged("Description");
                        break;

                    case Size.Large:
                        Price = 2.50;
                        Calories = 208;
                        NotifyOfPropertyChanged("Price");
                        NotifyOfPropertyChanged("Description");
                        break;
                }
            }
            get
            {
                return size;
            }
        }

        /// <summary>
        /// This list contains all the ingredients in the form of a string.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Natural Flavors", "Water", "Cane Sugar" };

                return ingredients;
            }
        }

        /// <summary>
        /// This string sets the ToString() override output.
        /// </summary>
        /// <returns>
        /// A string message is returned.
        /// </returns>
        public override string ToString()
        {
            return SizeString + " " + FlavorString + " Sodasaurus";
        }

        /// <summary>
        /// This constructor sets the default values of a new Sodasaurus object.
        /// </summary>
        public Sodasaurus()
        {
            Price = 1.50;
            Calories = 112;
            Ice = true;
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
                if (!Ice)
                {
                    special.Add("Hold Ice");
                }
                return special.ToArray();
            }
        }
    }
}
