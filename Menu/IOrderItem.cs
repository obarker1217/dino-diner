/* IOrderItem.cs
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
    public interface IOrderItem
    {
        /// <summary>
        /// 
        /// </summary>
        double Price { get; set; }

        /// <summary>
        /// 
        /// </summary>
        string Description { get; }

        /// <summary>
        /// 
        /// </summary>
        string[] Special { get; set; }
    }
}
