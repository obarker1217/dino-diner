/* SodasaurusTest
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
    /// This test class checks to make sure the Sodasaurus class works as intended.
    /// </summary>
    public class SodasaurusTest
    {
        /// <summary>
        /// This test makes sure the SodasaurusFLavor can be set to Cherry.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetFlavorToCherry()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Cherry;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Cherry, soda.Flavor);
        }

        /// <summary>
        /// This test makes sure the SodasaurusFLavor can be set to Cola.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetFlavorToCola()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Cola;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Cola, soda.Flavor);
        }

        /// <summary>
        /// This test makes sure the SodasaurusFLavor can be set to Chocolate.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetFlavorToChocolate()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Chocolate;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Chocolate, soda.Flavor);
        }

        /// <summary>
        /// This test makes sure the SodasaurusFLavor can be set to Orange.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetFlavorToOrange()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Orange;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Orange, soda.Flavor);
        }

        /// <summary>
        /// This test makes sure the SodasaurusFLavor can be set to Lime.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetFlavorToLime()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Lime;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Lime, soda.Flavor);
        }

        /// <summary>
        /// This test makes sure the SodasaurusFLavor can be set to Vanilla.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetFlavorToVanilla()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Vanilla;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Vanilla, soda.Flavor);
        }

        /// <summary>
        /// This test makes sure the SodasaurusFLavor can be set to RootBeer.
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetFlavorToRootBeer()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.RootBeer;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.RootBeer, soda.Flavor);
        }

        /// <summary>
        /// This test makes sure the price is set correctly when a new instance is created.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal<double>(1.50, soda.Price);
        }

        /// <summary>
        /// This test makes sure the price is correct when the drink is set to small.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSmall()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            soda.Size = Size.Small;
            Assert.Equal<double>(1.50, soda.Price);
        }

        /// <summary>
        /// This test makes sure the price is correct when the drink is set to medium.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingMedium()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Small;
            soda.Size = Size.Medium;
            Assert.Equal<double>(2.00, soda.Price);
        }

        /// <summary>
        /// This test makes sure the price is correct when the drink is set to large.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingLarge()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            soda.Size = Size.Large;
            Assert.Equal<double>(2.50, soda.Price);
        }

        /// <summary>
        /// This test checks to make sure ice is defaulted to true.
        /// </summary>
        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.True(soda.Ice);
        }

        /// <summary>
        /// This test makes sure the calorie count is set correctly when a new instance is created.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal<uint>(112, soda.Calories);
        }

        /// <summary>
        /// This test makes sure the calorie count is correct when the drink is set to small.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSmall()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            soda.Size = Size.Small;
            Assert.Equal<uint>(112, soda.Calories);
        }

        /// <summary>
        /// This test makes sure the calorie count is correct when the drink is set to medium.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingMedium()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Small;
            soda.Size = Size.Medium;
            Assert.Equal<uint>(156, soda.Calories);
        }

        /// <summary>
        /// This test makes sure the calorie count is correct when the drink is set to large.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingLarge()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            soda.Size = Size.Large;
            Assert.Equal<uint>(208, soda.Calories);
        }

        /// <summary>
        /// This test makes sure HoldIce() makes the Ice property false.
        /// </summary>
        [Fact]
        public void HoldIceResultsInIcePropertyBeingFalse()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.HoldIce();
            Assert.False(soda.Ice);
        }

        /// <summary>
        /// This test checks to make sure the drink has the correct default ingredients.
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Contains("Water", soda.Ingredients);
            Assert.Contains("Natural Flavors", soda.Ingredients);
            Assert.Contains("Cane Sugar", soda.Ingredients);
        }

        // These tests check Descriptions and Special.

        [Fact]
        public void DefaultDescriptionShouldBeCorrect()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal("Small Cola Sodasaurus", soda.Description);
        }

        [Fact]
        public void SmallDescriptionShouldBeCorrect()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            soda.Size = Size.Small;
            Assert.Equal("Small Cola Sodasaurus", soda.Description);
        }

        [Fact]
        public void MediumDescriptionShouldBeCorrect()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            Assert.Equal("Medium Cola Sodasaurus", soda.Description);
        }

        [Fact]
        public void LargeDescriptionShouldBeCorrect()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Large;
            Assert.Equal("Large Cola Sodasaurus", soda.Description);
        }

        [Fact]
        public void SpecialShouldBeEmptyByDefault()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Empty(soda.Special);
        }

        [Fact]
        public void HoldIceShouldAddToSpecial()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.HoldIce();
            Assert.Collection<string>(soda.Special,
                item =>
                {
                    Assert.Equal("Hold Ice", item);
                });
        }

        // The follwing tests handle change notification.

        [Fact]
        public void HoldIceShouldNotifySpecialChange()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.PropertyChanged(soda, "Special", () =>
            {
                soda.HoldIce();
            });
        }

        [Fact]
        public void ChangingSizeToMediumShouldNotifyDescriptionChange()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.PropertyChanged(soda, "Description", () =>
            {
                soda.Size = Size.Medium;
            });
        }

        [Fact]
        public void ChangingSizeToSmallShouldNotifyDescriptionChange()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.PropertyChanged(soda, "Description", () =>
            {
                soda.Size = Size.Medium;
                soda.Size = Size.Small;
            });
        }

        [Fact]
        public void ChangingSizeToLargeShouldNotifyDescriptionChange()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.PropertyChanged(soda, "Description", () =>
            {
                soda.Size = Size.Large;
            });
        }
        [Fact]
        public void ChangingSizeToMediumShouldNotifyPriceChange()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.PropertyChanged(soda, "Price", () =>
            {
                soda.Size = Size.Medium;
            });
        }

        [Fact]
        public void ChangingSizeToSmallShouldNotifyPriceChange()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.PropertyChanged(soda, "Price", () =>
            {
                soda.Size = Size.Medium;
                soda.Size = Size.Small;
            });
        }

        [Fact]
        public void ChangingSizeToLargeShouldNotifyPriceChange()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.PropertyChanged(soda, "Description", () =>
            {
                soda.Size = Size.Large;
            });
        }
    }
}
