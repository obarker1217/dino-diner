/* TyrannoteaTest.cs
 * Author: Owen Barker
 */
using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Drinks;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    /// <summary>
    /// 
    /// </summary>
    public class TyrannoteaTest
    {
        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<double>(0.99, tea.Price);
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            tea.Size = Size.Small;
            Assert.Equal<double>(0.99, tea.Price);
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Small;
            tea.Size = Size.Medium;
            Assert.Equal<double>(1.49, tea.Price);
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            tea.Size = Size.Large;
            Assert.Equal<double>(1.99, tea.Price);
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.True(tea.Ice);
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<uint>(8, tea.Calories);
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            tea.Size = Size.Small;
            Assert.Equal<uint>(8, tea.Calories);
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Small;
            tea.Size = Size.Medium;
            Assert.Equal<uint>(16, tea.Calories);
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            tea.Size = Size.Large;
            Assert.Equal<uint>(32, tea.Calories);
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void HoldIceResultsInIcePropertyBeingFalse()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.HoldIce();
            Assert.False(tea.Ice);
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void AddLemonResultsInLemonPropertyBeingTrue()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddLemon();
            Assert.True(tea.Lemon);
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Contains("Water", tea.Ingredients);
            Assert.Contains("Tea", tea.Ingredients);
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void SettingSweetShouldDoubleCalories()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddSweetener();
            if(tea.Size == Size.Small)
            {
                Assert.Equal<uint>(16, tea.Calories);
            }
            else if (tea.Size == Size.Medium)
            {
                Assert.Equal<uint>(32, tea.Calories);
            }
            else if (tea.Size == Size.Large)
            {
                Assert.Equal<uint>(64, tea.Calories);
            }
            Assert.True(tea.Sweet);
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void RemovingSweetShouldSetCaloriesToDefault()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddSweetener();
            tea.RemoveSweetener();
            if (tea.Size == Size.Small)
            {
                Assert.Equal<uint>(8, tea.Calories);
            }
            else if (tea.Size == Size.Medium)
            {
                Assert.Equal<uint>(16, tea.Calories);
            }
            else if (tea.Size == Size.Large)
            {
                Assert.Equal<uint>(32, tea.Calories);
            }
        }
    }
}
