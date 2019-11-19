using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Menu;

namespace Website.Pages
{
    public class MenuModel : PageModel
    {
        public Menu Menu { get; } = new Menu();
        /*

        public IMenuItem MenuItem { get; }

        public CretaceousCombo Combo { get; }

        public Entree Entree { get; }

        public Side Side { get; }

        public Drink Drink { get; }
        */

        public void OnGet()
        {
            
        }
    }
}