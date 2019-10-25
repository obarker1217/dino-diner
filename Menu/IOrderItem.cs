/* IOrderItem.cs
 * Author: Owen Barker
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// 
    /// </summary>
    public interface IOrderItem : INotifyPropertyChanged
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
