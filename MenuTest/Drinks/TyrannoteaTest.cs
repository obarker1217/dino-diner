/* TyrannoteaTest.cs
 * Author: Owen Barker
 */

using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    /// <summary>
    /// This test class checks to make sure the Tyrannotea class works as intended.
    /// </summary>
    public class TyrannoteaTest
    {
        /// <summary>
        /// This test makes sure the price is set correctly when a new instance is created.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<double>(0.99, tea.Price);
        }

        /// <summary>
        /// This test makes sure the price is correct when the drink is set to small.
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
        /// This test makes sure the price is correct when the drink is set to medium.
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
        /// This test makes sure the price is correct when the drink is set to large.
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
        /// This test checks to make sure ice is defaulted to true.
        /// </summary>
        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.True(tea.Ice);
        }

        /// <summary>
        /// This test makes sure the calorie count is set correctly when a new instance is created.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<uint>(8, tea.Calories);
        }

        /// <summary>
        /// This test makes sure the calorie count is correct when the drink is set to small.
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
        /// This test makes sure the calorie count is correct when the drink is set to medium.
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
        /// This test makes sure the calorie count is correct when the drink is set to large.
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
        /// This test makes sure HoldIce() makes the Ice property false.
        /// </summary>
        [Fact]
        public void HoldIceResultsInIcePropertyBeingFalse()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.HoldIce();
            Assert.False(tea.Ice);
        }

        /// <summary>
        /// This test makes sure AddLemon() makes the Lemon property true.
        /// </summary>
        [Fact]
        public void AddLemonResultsInLemonPropertyBeingTrue()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddLemon();
            Assert.True(tea.Lemon);
        }

        /// <summary>
        /// This test checks to make sure the drink has the correct default ingredients.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Contains("Water", tea.Ingredients);
            Assert.Contains("Tea", tea.Ingredients);
        }

        /// <summary>
        /// This test makes sure that the AddSweetener() method doubles the calories regardless of size.
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
        /// This test makes sure that RemoveSweetener() sets all calories to default.
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
