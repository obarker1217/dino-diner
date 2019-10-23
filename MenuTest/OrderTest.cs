/* OrderTest.cs
 * Author: Owen Barker
 */

using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class OrderTest
    {
        [Fact]
        public void SubtotalCannotGoNegative()
        {
            Order order = new Order();
            Sodasaurus soda = new Sodasaurus();
            order.Items.Add(soda);
            TRexKingBurger trex = new TRexKingBurger();
            order.Items.Add(trex);
            Fryceritops fry = new Fryceritops();
            order.Items.Add(fry);
            soda.Price = -100;
            Assert.Equal(order.SubtotalCost, -1);
        }
          
        [Fact]
        public void SubtotalCostShouldBeCorrect()
        {
            Order order = new Order();
            Sodasaurus soda = new Sodasaurus();
            order.Items.Add(soda);
            TRexKingBurger trex = new TRexKingBurger();
            order.Items.Add(trex);
            Fryceritops fry = new Fryceritops();
            order.Items.Add(fry);
            Assert.Equal(10.94, order.SubtotalCost);
        }

        [Fact]
        public void SalesTaxShouldBeCorrect()
        {
            Order order = new Order();
            Sodasaurus soda = new Sodasaurus();
            order.Items.Add(soda);
            TRexKingBurger trex = new TRexKingBurger();
            order.Items.Add(trex);
            Fryceritops fry = new Fryceritops();
            order.Items.Add(fry);
            Assert.Equal(1.094, order.SalesTaxCost);
        }

        [Fact]
        public void TotalCostShouldBeCorrect()
        {
            Order order = new Order();
            Sodasaurus soda = new Sodasaurus();
            order.Items.Add(soda);
            TRexKingBurger trex = new TRexKingBurger();
            order.Items.Add(trex);
            Fryceritops fry = new Fryceritops();
            order.Items.Add(fry);
            Assert.Equal(12.034, order.TotalCost);
        }
    }
}
