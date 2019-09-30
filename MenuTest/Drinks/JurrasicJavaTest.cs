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
    public class JurrasicJavaTest
    {
        /// <summary>
        /// This test makes sure the price is set correctly when a new instance is created.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            JurrasicJava coffee = new JurrasicJava();
            Assert.Equal<double>(0.59, coffee.Price);
        }

        /// <summary>
        /// This test makes sure the price is correct when the drink is set to small.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSmall()
        {
            JurrasicJava coffee = new JurrasicJava();
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
            JurrasicJava coffee = new JurrasicJava();
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
            JurrasicJava coffee = new JurrasicJava();
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
            JurrasicJava coffee = new JurrasicJava();
            Assert.False(coffee.Ice);
        }

        /// <summary>
        /// This test makes sure the calorie count is set correctly when a new instance is created.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            JurrasicJava coffee = new JurrasicJava();
            Assert.Equal<uint>(2, coffee.Calories);
        }

        /// <summary>
        /// This test makes sure the calorie count is correct when the drink is set to small.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSmall()
        {
            JurrasicJava coffee = new JurrasicJava();
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
            JurrasicJava coffee = new JurrasicJava();
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
            JurrasicJava coffee = new JurrasicJava();
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
            JurrasicJava coffee = new JurrasicJava();
            coffee.AddIce();
            Assert.True(coffee.Ice);
        }

        /// <summary>
        /// This test makes sure IsDecaf() makes the Decaf property true.
        /// </summary>
        [Fact]
        public void IsDecafSetsTheDecafPropertyToTrue()
        {
            JurrasicJava coffee = new JurrasicJava();
            coffee.IsDecaf();
            Assert.True(coffee.Decaf);
        }

        /// <summary>
        /// This test makes sure LeaveSpaceForCream() makes the SpaceForCream property true.
        /// </summary>
        [Fact]
        public void LeaveSpaceForCreamSetsSpaceForCreamPropertyToTrue()
        {
            JurrasicJava coffee = new JurrasicJava();
            coffee.LeaveSpaceForCream();
            Assert.True(coffee.SpaceForCream);
        }

        /// <summary>
        /// This test checks to make sure the drink has the correct default ingredients.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            JurrasicJava coffee = new JurrasicJava();
            Assert.Contains("Water", coffee.Ingredients);
            Assert.Contains("Coffee", coffee.Ingredients);
        }
    }
}
