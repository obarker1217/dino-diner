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

        public List<IMenuItem> menuList;

        [BindProperty]
        public string search { get; set; }

        [BindProperty]
        public int? minPrice { get; set; }

        [BindProperty]
        public int? maxPrice { get; set; }

        [BindProperty]
        public List<string> menuCategory { get; set; } = new List<string>();

        public void OnGet()
        {
            menuList = Menu.AvailableMenuItems;
        }

        public void OnPost()
        {
            menuList = Menu.AvailableMenuItems;

            if(menuCategory != null)
            {
                menuList = FilterByMenuCategory(menuList, menuCategory);
            }

            if (minPrice != null)
            {
                menuList = FilterByMinPrice(menuList, (int)minPrice);
            }

            if (minPrice != null)
            {
                menuList = FilterByMaxPrice(menuList, (int)maxPrice);
            }
        }

        public List<IMenuItem> Search(List<IMenuItem> menuItem, string searchString)
        {
            List<IMenuItem> result = new List<IMenuItem>();

            foreach(IMenuItem item in Menu.AvailableMenuItems)
            {
                if(item.ToString().Contains(searchString, StringComparison.OrdinalIgnoreCase))
                {
                    result.Add(item);
                }
            }

            return result;
        }

        public List<IMenuItem> FilterByMenuCategory(List<IMenuItem> menuItem, List<string> menuCategory)
        {
            List<IMenuItem> result = new List<IMenuItem>();

            foreach (IMenuItem item in Menu.AvailableMenuItems)
            {
                if (item is CretaceousCombo && menuCategory.Contains("Combo"))
                {
                    result.Add(item);
                }
                if (item is Entree && menuCategory.Contains("Entree"))
                {
                    result.Add(item);
                }
                if (item is Side && menuCategory.Contains("Side"))
                {
                    result.Add(item);
                }
                if (item is Drink && menuCategory.Contains("Drink"))
                {
                    result.Add(item);
                }
            }

            return result;
        }

        public List<IMenuItem> FilterByMinPrice(List<IMenuItem> menuItem, float minPrice)
        {
            List<IMenuItem> result = new List<IMenuItem>();

            foreach (IMenuItem item in Menu.AvailableMenuItems)
            {
                if (item.Price >= minPrice)
                {
                    result.Add(item);
                }
            }

            return result;
        }

        public List<IMenuItem> FilterByMaxPrice(List<IMenuItem> menuItem, float maxPrice)
        {
            List<IMenuItem> result = new List<IMenuItem>();

            foreach (IMenuItem item in Menu.AvailableMenuItems)
            {
                if (item.Price <= maxPrice)
                {
                    result.Add(item);
                }
            }

            return result;
        }
    }
}