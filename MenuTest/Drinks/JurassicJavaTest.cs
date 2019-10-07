/* JurrasicJavaTest.cs
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
    /// This test class checks to make sure the JurrasicJava class works as intended.
    /// </summary>
    public class JurassicJavaTest
    {
        /// <summary>
        /// This test makes sure the price is set correctly when a new instance is created.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            JurassicJava coffee = new JurassicJava();
            Assert.Equal<double>(0.59, coffee.Price);
        }

        /// <summary>
        /// This test makes sure the price is correct when the drink is set to small.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSmall()
        {
            JurassicJava coffee = new JurassicJava();
            coffee.Size = Size.Medium;
            coffee.Size = Size.Small;
            Assert.Equal<double>(0.59, coffee.Price);
        }

        /// <summary>
        /// This test makes sure the price is correct when the drink is set to medium.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingMedium()
        {
            JurassicJava coffee = new JurassicJava();
            coffee.Size = Size.Small;
            coffee.Size = Size.Medium;
            Assert.Equal<double>(0.99, coffee.Price);
        }

        /// <summary>
        /// This test makes sure the price is correct when the drink is set to large.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingLarge()
        {
            JurassicJava coffee = new JurassicJava();
            coffee.Size = Size.Medium;
            coffee.Size = Size.Large;
            Assert.Equal<double>(1.49, coffee.Price);
        }

        /// <summary>
        /// This test checks to make sure ice is defaulted to false.
        /// </summary>
        [Fact]
        public void ShouldNotHaveDefaultIce()
        {
            JurassicJava coffee = new JurassicJava();
            Assert.False(coffee.Ice);
        }

        /// <summary>
        /// This test makes sure the calorie count is set correctly when a new instance is created.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            JurassicJava coffee = new JurassicJava();
            Assert.Equal<uint>(2, coffee.Calories);
        }

        /// <summary>
        /// This test makes sure the calorie count is correct when the drink is set to small.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSmall()
        {
            JurassicJava coffee = new JurassicJava();
            coffee.Size = Size.Medium;
            coffee.Size = Size.Small;
            Assert.Equal<uint>(2, coffee.Calories);
        }

        /// <summary>
        /// This test makes sure the calorie count is correct when the drink is set to medium.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingMedium()
        {
            JurassicJava coffee = new JurassicJava();
            coffee.Size = Size.Small;
            coffee.Size = Size.Medium;
            Assert.Equal<uint>(4, coffee.Calories);
        }

        /// <summary>
        /// This test makes sure the calorie count is correct when the drink is set to large.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingLarge()
        {
            JurassicJava coffee = new JurassicJava();
            coffee.Size = Size.Medium;
            coffee.Size = Size.Large;
            Assert.Equal<uint>(8, coffee.Calories);
        }

        /// <summary>
        /// This test makes sure AddIce() makes the Ice property true.
        /// </summary>
        [Fact]
        public void AddIceResultsInIcePropertyBeingTrue()
        {
            JurassicJava coffee = new JurassicJava();
            coffee.AddIce();
            Assert.True(coffee.Ice);
        }

        /// <summary>
        /// This test makes sure IsDecaf() makes the Decaf property true.
        /// </summary>
        [Fact]
        public void IsDecafSetsTheDecafPropertyToTrue()
        {
            JurassicJava coffee = new JurassicJava();
            coffee.IsDecaf();
            Assert.True(coffee.Decaf);
        }

        /// <summary>
        /// This test makes sure LeaveSpaceForCream() makes the SpaceForCream property true.
        /// </summary>
        [Fact]
        public void LeaveSpaceForCreamSetsSpaceForCreamPropertyToTrue()
        {
            JurassicJava coffee = new JurassicJava();
            coffee.LeaveSpaceForCream();
            Assert.True(coffee.SpaceForCream);
        }

        /// <summary>
        /// This test checks to make sure the drink has the correct default ingredients.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            JurassicJava coffee = new JurassicJava();
            List<string> ingredients = coffee.Ingredients;
            Assert.Contains<string>("Water", ingredients);
            Assert.Contains<string>("Coffee", ingredients);
            Assert.Equal<int>(2, ingredients.Count);
        }
    }
}
