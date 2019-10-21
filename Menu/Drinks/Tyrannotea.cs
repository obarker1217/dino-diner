/* Tyrannotea.cs
 * Author: Owen Barker
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// This class creates the Tyrranotea drink and allows the user to choose if they want ice and what size they want,
    /// which affects calorie count and price.
    /// </summary>
    public class Tyrannotea : Drink, IMenuItem
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
                        NotifyOfPropertyChanged("Size");
                        NotifyOfPropertyChanged("Price");
                        break;

                    case Size.Medium:
                        Price = 1.49;
                        Calories = 16;
                        NotifyOfPropertyChanged("Size");
                        NotifyOfPropertyChanged("Price");
                        break;

                    case Size.Large:
                        Price = 1.99;
                        Calories = 32;
                        NotifyOfPropertyChanged("Size");
                        NotifyOfPropertyChanged("Price");
                        break;
                }
            }
            get
            {
                return size;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (Sweet)
            {
                return SizeString + " Sweet Tyrannotea";
            }
            else
            {
                return SizeString + " Tyrannotea";
            }
        }

        /// <summary>
        /// This list contains all the ingredients of the wings and allows for no ingredients to be
        /// changed.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string> { "Water", "Tea" };
                if(Sweet)
                {
                    ingredients.Add("Cane Sugar");
                }
                return ingredients;
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
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// This method sets the sweet property to true and doubles the calories.
        /// </summary>
        public void AddSweetener()
        {
            this.Sweet = true;
            this.Calories = this.Calories * 2;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Description");
            //Ingredients.Add("Cane Sugar");
        }

        /// <summary>
        /// This method sets the sweet property to false and sets the calories to false.
        /// </summary>
        public void RemoveSweetener()
        {
            this.Sweet = false;
            this.Calories = this.Calories / 2;
            Ingredients.Remove("Cane Sugar");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Description");
        }

        /// <summary>
        /// This constructor sets the default values of a new Tyrannotea object.
        /// </summary>
        public Tyrannotea()
        {
            Price = 0.99;
            Calories = 8;
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
                if(Lemon)
                {
                    special.Add("Add Lemon");
                }
                return special.ToArray();
            }
        }
    }
}
