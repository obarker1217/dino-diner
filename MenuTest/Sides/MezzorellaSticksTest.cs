using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Sides
{
    public class MezzorellaSticksTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            MezzorellaSticks mmc = new MezzorellaSticks();
            Assert.Equal(0.99, mmc.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            MezzorellaSticks mmc = new MezzorellaSticks();
            Assert.Equal<uint>(540, mmc.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            MezzorellaSticks mmc = new MezzorellaSticks();
            Assert.Contains<string>("Breading", mmc.Ingredients);
            Assert.Contains<string>("Cheese Product", mmc.Ingredients);
            Assert.Contains<string>("Vegetable Oil", mmc.Ingredients);
            Assert.Equal<int>(3, mmc.Ingredients.Count);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            MezzorellaSticks mmc = new MezzorellaSticks();
            Assert.Equal<Size>(Size.Small, mmc.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForMedium()
        {
            MezzorellaSticks mmc = new MezzorellaSticks();
            mmc.Size = Size.Medium;
            Assert.Equal(1.45, mmc.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForMedium()
        {
            MezzorellaSticks mmc = new MezzorellaSticks();
            mmc.Size = Size.Medium;
            Assert.Equal<uint>(610, mmc.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToMedium()
        {
            MezzorellaSticks mmc = new MezzorellaSticks();
            mmc.Size = Size.Medium;
            Assert.Equal<Size>(Size.Medium, mmc.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForLarge()
        {
            MezzorellaSticks mmc = new MezzorellaSticks();
            mmc.Size = Size.Large;
            Assert.Equal(1.95, mmc.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForLarge()
        {
            MezzorellaSticks mmc = new MezzorellaSticks();
            mmc.Size = Size.Large;
            Assert.Equal<uint>(720, mmc.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToLarge()
        {
            MezzorellaSticks mmc = new MezzorellaSticks();
            mmc.Size = Size.Large;
            Assert.Equal<Size>(Size.Large, mmc.Size);
        }

        // These tests check Descriptions and Special.

        [Fact]
        public void DefaultDescriptionShouldBeCorrect()
        {
           MezzorellaSticks mmc = new MezzorellaSticks();
            Assert.Equal("Small Mezzorella Sticks", mmc.Description);
        }

        [Fact]
        public void SmallDescriptionShouldBeCorrect()
        {
           MezzorellaSticks mmc = new MezzorellaSticks();
            mmc.Size = Size.Medium;
            mmc.Size = Size.Small;
            Assert.Equal("Small Mezzorella Sticks", mmc.Description);
        }

        [Fact]
        public void MediumDescriptionShouldBeCorrect()
        {
           MezzorellaSticks mmc = new MezzorellaSticks();
            mmc.Size = Size.Medium;
            Assert.Equal("Medium Mezzorella Sticks", mmc.Description);
        }

        [Fact]
        public void LargeDescriptionShouldBeCorrect()
        {
           MezzorellaSticks mmc = new MezzorellaSticks();
            mmc.Size = Size.Large;
            Assert.Equal("Large Mezzorella Sticks", mmc.Description);
        }

        [Fact]
        public void SpecialShouldBeEmptyByDefault()
        {
           MezzorellaSticks mmc = new MezzorellaSticks();
            Assert.Empty(mmc.Special);
        }

        // The follwing tests handle change notification.

        [Fact]
        public void ChangingSizeToMediummchouldNotifyDescriptionChange()
        {
           MezzorellaSticks mmc = new MezzorellaSticks();
            Assert.PropertyChanged(mmc, "Description", () =>
            {
                mmc.Size = Size.Medium;
            });
        }

        [Fact]
        public void ChangingSizeToSmallShouldNotifyDescriptionChange()
        {
           MezzorellaSticks mmc = new MezzorellaSticks();
            Assert.PropertyChanged(mmc, "Description", () =>
            {
                mmc.Size = Size.Medium;
                mmc.Size = Size.Small;
            });
        }

        [Fact]
        public void ChangingSizeToLargeShouldNotifyDescriptionChange()
        {
           MezzorellaSticks mmc = new MezzorellaSticks();
            Assert.PropertyChanged(mmc, "Description", () =>
            {
                mmc.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingSizeToMediummchouldNotifyPriceChange()
        {
           MezzorellaSticks mmc = new MezzorellaSticks();
            Assert.PropertyChanged(mmc, "Description", () =>
            {
                mmc.Size = Size.Medium;
            });
        }

        [Fact]
        public void ChangingSizeToSmallShouldNotifyPriceChange()
        {
           MezzorellaSticks mmc = new MezzorellaSticks();
            Assert.PropertyChanged(mmc, "Description", () =>
            {
                mmc.Size = Size.Medium;
                mmc.Size = Size.Small;
            });
        }

        [Fact]
        public void ChangingSizeToLargeShouldNotifyPriceChange()
        {
           MezzorellaSticks mmc = new MezzorellaSticks();
            Assert.PropertyChanged(mmc, "Description", () =>
            {
                mmc.Size = Size.Large;
            });
        }
    }
}
