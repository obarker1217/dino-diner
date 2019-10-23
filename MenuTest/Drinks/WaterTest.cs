/* WaterTest.cs
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
    /// This test class checks to make sure the Water class works as intended.
    /// </summary>
    public class WaterTest
    {
        /// <summary>
        /// This test makes sure the price is set correctly when a new instance is created.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Water water = new Water();
            Assert.Equal<double>(0.10, water.Price);
        }

        /// <summary>
        /// This test makes sure the price is correct when the drink is set to small.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSmall()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            water.Size = Size.Small;
            Assert.Equal<double>(0.10, water.Price);
        }

        /// <summary>
        /// This test makes sure the price is correct when the drink is set to medium.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingMedium()
        {
            Water water = new Water();
            water.Size = Size.Small;
            water.Size = Size.Medium;
            Assert.Equal<double>(0.10, water.Price);
        }

        /// <summary>
        /// This test makes sure the price is correct when the drink is set to large.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingLarge()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            water.Size = Size.Large;
            Assert.Equal<double>(0.10, water.Price);
        }

        /// <summary>
        /// This test checks to make sure ice is defaulted to true.
        /// </summary>
        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Water water = new Water();
            Assert.True(water.Ice);
        }

        /// <summary>
        /// This test makes sure the calorie count is set correctly when a new instance is created.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Water water = new Water();
            Assert.Equal<uint>(0, water.Calories);
        }

        /// <summary>
        /// This test makes sure the calorie count is correct when the drink is set to small.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSmall()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            water.Size = Size.Small;
            Assert.Equal<uint>(0, water.Calories);
        }

        /// <summary>
        /// This test makes sure the calorie count is correct when the drink is set to medium.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingMedium()
        {
            Water water = new Water();
            water.Size = Size.Small;
            water.Size = Size.Medium;
            Assert.Equal<uint>(0, water.Calories);
        }

        /// <summary>
        /// This test makes sure the calorie count is correct when the drink is set to large.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingLarge()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            water.Size = Size.Large;
            Assert.Equal<uint>(0, water.Calories);
        }

        /// <summary>
        /// This test makes sure HoldIce() makes the Ice property false.
        /// </summary>
        [Fact]
        public void HoldIceResultsInIcePropertyBeingFalse()
        {
            Water water = new Water();
            water.HoldIce();
            Assert.False(water.Ice);
        }

        /// <summary>
        /// This test makes sure AddLemon() makes the Lemon property true.
        /// </summary>
        [Fact]
        public void AddLemonResultsInLemonPropertyBeingTrue()
        {
            Water water = new Water();
            water.AddLemon();
            Assert.True(water.Lemon);
        }

        /// <summary>
        /// This test checks to make sure the drink has the correct default ingredients.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            Water water = new Water();
            Assert.Contains("Water", water.Ingredients);
        }

        // These tests check Descriptions and Special.

        [Fact]
        public void DefaultDescriptionShouldBeCorrect()
        {
            Water water = new Water();
            Assert.Equal("Small Water", water.Description);
        }

        [Fact]
        public void SmallDescriptionShouldBeCorrect()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            water.Size = Size.Small;
            Assert.Equal("Small Water", water.Description);
        }

        [Fact]
        public void MediumDescriptionShouldBeCorrect()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            Assert.Equal("Medium Water", water.Description);
        }

        [Fact]
        public void LargeDescriptionShouldBeCorrect()
        {
            Water water = new Water();
            water.Size = Size.Large;
            Assert.Equal("Large Water", water.Description);
        }

        [Fact]
        public void SpecialShouldBeEmptyByDefault()
        {
            Water water = new Water();
            Assert.Empty(water.Special);
        }

        [Fact]
        public void HoldIceShouldAddToSpecial()
        {
            Water water = new Water();
            water.HoldIce();
            Assert.Collection<string>(water.Special,
                item =>
                {
                    Assert.Equal("Hold Ice", item);
                });
        }

        [Fact]
        public void AddLemonShouldAddToSpecial()
        {
            Water water = new Water();
            water.AddLemon();
            Assert.Collection<string>(water.Special,
                item =>
                {
                    Assert.Equal("Add Lemon", item);
                });
        }

        [Fact]
        public void AddIceAndSpaceForCreamShouldAddToSpecial()
        {
            Water water = new Water();
            water.HoldIce();
            water.AddLemon();
            Assert.Collection<string>(water.Special,
                item =>
                {
                    Assert.Equal("Hold Ice", item);
                },
                item =>
                {
                    Assert.Equal("Add Lemon", item);
                });
        }

        // The follwing tests handle change notification.

        [Fact]
        public void ChangingSizeToMediumShouldNotifyDescriptionChange()
        {
            Water water = new Water();
            Assert.PropertyChanged(water, "Description", () =>
            {
                water.Size = Size.Medium;
            });
        }

        [Fact]
        public void ChangingSizeToSmallShouldNotifyDescriptionChange()
        {
            Water water = new Water();
            Assert.PropertyChanged(water, "Description", () =>
            {
                water.Size = Size.Medium;
                water.Size = Size.Small;
            });
        }

        [Fact]
        public void ChangingSizeToLargeShouldNotifyDescriptionChange()
        {
            Water water = new Water();
            Assert.PropertyChanged(water, "Description", () =>
            {
                water.Size = Size.Large;
            });
        }

        [Fact]
        public void AddLemonShouldNotifySpecialChange()
        {
            Water water = new Water();
            Assert.PropertyChanged(water, "Special", () =>
            {
                water.AddLemon();
            });
        }

        [Fact]
        public void HoldIceShouldNotifySpecialChange()
        {
            Water water = new Water();
            Assert.PropertyChanged(water, "Special", () =>
            {
                water.HoldIce();
            });
        }
    }
}
