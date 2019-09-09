﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    class Brontowurst
    {
        private bool bun = true;
        private bool peppers = true;
        private bool onions = true;

        public double price { get; set; }
        public uint calories { get; set; }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string> {"Brautwurst"};
                if(bun)
                {
                    ingredients.Add("Whole-Wheat Bun");
                }
                if(peppers)
                {
                    ingredients.Add("Peppers");
                }
                if(onions)
                {
                    ingredients.Add("Onions");
                }
                return ingredients;
            }
        }

        public Brontowurst()
        {
            this.price = 5.36;
            this.calories = 498;
        }

        public void HoldBun()
        {
            this.bun = false;
        }
        public void HoldPeppers()
        {
            this.peppers = false;
        }
        public void HoldOnions()
        {
            this.onions = false;
        }
    }
}
