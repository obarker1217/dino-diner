/* Menu.cs
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
    public class Menu  
    {
        /// <summary>
        /// 
        /// </summary>
        public List<IMenuItem> AvailableMenuItems
        {
            get
            {
                List<IMenuItem> menuItemList = new List<IMenuItem>();
                menuItemList.Add(new Brontowurst());
                menuItemList.Add(new DinoNuggets());
                menuItemList.Add(new PrehistoricPBJ());
                menuItemList.Add(new PterodactylWings());
                menuItemList.Add(new SteakosaurusBurger());
                menuItemList.Add(new TRexKingBurger());
                menuItemList.Add(new VelociWrap());
                menuItemList.Add(new Fryceritops());
                menuItemList.Add(new MeteorMacAndCheese());
                menuItemList.Add(new MezzorellaSticks());
                menuItemList.Add(new Triceritots());
                menuItemList.Add(new JurassicJava());
                menuItemList.Add(new Sodasaurus());
                menuItemList.Add(new Water());
                menuItemList.Add(new Tyrannotea());
                return menuItemList;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public List<Entree> AvailableEntrees
        {
            get
            {
                List<Entree> entreeList = new List<Entree>();
                foreach(Entree entree in AvailableMenuItems)
                {
                    entreeList.Add(entree);
                }
                return entreeList;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public List<Side> AvailableSide
        {
            get
            {
                List<Side> sideList = new List<Side>();
                foreach(IMenuItem menuItem in AvailableMenuItems)
                {
                    if(menuItem is Side)
                    {
                        sideList.Add((Side)menuItem);
                    }
                }
                return sideList;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public List<Drink> AvailableDrinks
        {
            get
            {
                List<Drink> drinkList = new List<Drink>();
                foreach (IMenuItem menuItem in AvailableMenuItems)
                {
                    if (menuItem is Drink)
                    {
                        drinkList.Add((Drink)menuItem);
                    }
                }
                return drinkList;
            }
        }

        /// <summary>
        ///
        /// </summary>
        public List<CretaceousCombo> AvailableCombos
        {
            get
            {
                List<CretaceousCombo> comboList = new List<CretaceousCombo>();
                foreach (IMenuItem menuItem in AvailableMenuItems)
                {
                    if (menuItem is Entree)
                    {
                        comboList.Add((CretaceousCombo)menuItem);
                    }
                }
                return comboList;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override string ToString()
        {
            string menuString = "";
            foreach(IMenuItem menuItem in AvailableMenuItems)
            {
                menuString += menuItem.ToString() + " \n";
            }
            return menuString;
        }
    }
}
