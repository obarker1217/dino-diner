/* Menu.cshtml
 * Author: Owen Barker
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Menu;

namespace Website.Pages
{
    /// <summary>
    /// This class simply creates a read-only instance of the Menu item.
    /// </summary>
    public class MenuModel : PageModel
    {
        /// <summary>
        /// This is used to create a menu that cannot be changed, only referenced.
        /// </summary>
        public Menu Menu { get; } = new Menu();

        public void OnGet()
        {
            
        }
    }
}