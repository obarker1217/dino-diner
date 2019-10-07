/* IMenuItem.cs
 * Author: Owen Barker
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// This interface creates getter properties that are shared amongst all items on the menu.
    /// </summary>
    public interface IMenuItem
    {
        /// <summary>
        /// This property gets the price as a double.
        /// </summary>
        double Price { get; }

        /// <summary>
        /// This property gets the calorie count as a uint.
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// This property gets the ingredients as a list of strings.
        /// </summary>
        List<string> Ingredients { get; }
    }
}
