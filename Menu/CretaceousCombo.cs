/* CretaceousCombo.cs
 * Author: Owen Barker
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class CretaceousCombo : IMenuItem, INotifyPropertyChanged
    {
        private Entree entree;

        /// <summary>
        /// 
        /// </summary>
        public Entree Entree
        {
            get
            {
                return entree;
            }
            protected set
            {
                entree = value;
                entree.PropertyChanged += (object sender, PropertyChangedEventArgs args) =>
                {
                    NotifyOfPropertyChanged(args.PropertyName);
                };
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public Side Side { get; set; } = new Fryceritops();

        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private Drink drink = new Sodasaurus();
        /// <summary>
        /// 
        /// </summary>
        public Drink Drink
        {
            get { return drink; }
            set
            {
                drink = value;
                
            }
        }

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

                NotifyOfPropertyChanged("Size");
                NotifyOfPropertyChanged("Special");
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("Description");
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

        
        /// <summary>
        /// This method overrides the standard ToString() method to show the item.
        /// </summary>
        /// <returns>
        /// A string containing the named menu item is returned.
        /// </returns>
        public override string ToString()
        {
            return Entree.ToString() + " Combo";
        }
        

        public string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                special.AddRange(Entree.Special);
                special.Add(Side.Description);
                special.AddRange(Side.Special);
                special.Add(Drink.Description);
                special.AddRange(Drink.Special);
                return special.ToArray();
            }
        }

        public string Description
        {
            get
            {
                return this.ToString();
            }
        }
    }
}
