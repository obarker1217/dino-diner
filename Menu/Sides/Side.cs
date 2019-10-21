﻿/* Side.cs
 * Author: Owen Barker
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// This abstract base class creates all the properties for the sides classes.
    /// </summary>
    public abstract class Side : IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// This is the read-only list of ingredients.
        /// </summary>
        protected List<string> ingredients = new List<string>();
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Description
        {
            get { return this.ToString(); }
        }

        /// <summary>
        /// 
        /// </summary>
        public string[] Special { get; set; }

        /// <summary>
        /// This method sends a message to the program when a men u item property is changed.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// This method creates a new instance of the event argument when a property is changed.
        /// </summary>
        /// <param name="propertyName"></param>
        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public virtual List<string> Ingredients
        {
            get
            {
                return ingredients;
            }
        }

        /// <summary>
        /// This string names a size for the ToString() override.
        /// </summary>
        public string SizeString
        {
            get
            {
                return Size.ToString();
            }
        }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public virtual Size Size { get; set; }

    }
}
