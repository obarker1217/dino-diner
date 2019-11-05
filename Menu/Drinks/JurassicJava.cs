/* JurrasicJava.cs
 * Author: Owen Barker
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// This class creates the JurrasicJava drink and allows the user to choose if they want ice and what size they want,
    /// which affects calorie count and price.
    /// </summary>
    public class JurassicJava : Drink
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
                        Price = 0.59;
                        Calories = 2;
                        NotifyOfPropertyChanged("Description");
                        NotifyOfPropertyChanged("Price");
                        break;

                    case Size.Medium:
                        Price = 0.99;
                        Calories = 4;
                        NotifyOfPropertyChanged("Description");
                        NotifyOfPropertyChanged("Price");
                        break;

                    case Size.Large:
                        Price = 1.49;
                        Calories = 8;
                        NotifyOfPropertyChanged("Description");
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
        /// This boolean property determines if the coffee is decaffienated.
        /// </summary>
        public bool Decaf { get; set; } = false;

        /// <summary>
        /// This bool decides whether or not room should be left in the coffee for the customer to add cream.
        /// </summary>
        public bool SpaceForCream { get; set; } = false;

        /// <summary>
        /// This method adds room to the coffee so the customer may add cream.
        /// </summary>
        public void LeaveRoomForCream()
        {
            this.SpaceForCream = true;
            NotifyOfPropertyChanged("Description");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// This method allows ice to be added in the coffee. In this drink's case, ice is defualted at false.
        /// </summary>
        public void AddIce()
        {
            this.Ice = true;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// This function sets the Decaf property to true.
        /// </summary>
        public void IsDecaf()
        {
            this.Decaf = true;
            NotifyOfPropertyChanged("Description");
        }

        /// <summary>
        /// This list contains all the ingredients of the wings and allows for no ingredients to be
        /// changed.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string> { "Coffee", "Water" };
                return ingredients;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if(Decaf)
            {
                return SizeString + " Decaf Jurassic Java";
            }
            else
            {
                return SizeString + " Jurassic Java";
            }
        }

        /// <summary>
        /// This constructor sets the default values of a new JurrasicJava object.
        /// </summary>
        public JurassicJava()
        {
            Price = 0.59;
            Calories = 2;
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
                if (Ice)
                {
                    special.Add("Add Ice");
                }
                if(SpaceForCream)
                {
                    special.Add("Add Space For Cream");
                }
                return special.ToArray();
            }
        }
    }
}
