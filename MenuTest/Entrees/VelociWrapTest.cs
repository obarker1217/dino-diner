﻿using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Entrees
{
    public class VelociWrapUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            VelociWrap vw = new VelociWrap();
            Assert.Equal(6.86, vw.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            VelociWrap vw = new VelociWrap();
            Assert.Equal<uint>(356, vw.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            VelociWrap vw = new VelociWrap();
            List<string> ingredients = vw.Ingredients;
            Assert.Contains<string>("Flour Tortilla", ingredients);
            Assert.Contains<string>("Chicken Breast", ingredients);
            Assert.Contains<string>("Romaine Lettuce", ingredients);
            Assert.Contains<string>("Ceasar Dressing", ingredients);
            Assert.Contains<string>("Parmesan Cheese", ingredients);
            Assert.Equal<int>(5, ingredients.Count);
        }

        [Fact]
        public void HoldDressingShouldRemoveDressing()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldDressing();
            Assert.DoesNotContain<string>("Dressing", vw.Ingredients);
        }

        [Fact]
        public void HoldLettuceShouldRemoveLettuce()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldLettuce();
            Assert.DoesNotContain<string>("Lettuce", vw.Ingredients);
        }

        [Fact]
        public void HoldCheeseShouldRemoveCheese()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldCheese();
            Assert.DoesNotContain<string>("Parmesan Cheese", vw.Ingredients);
        }

        // These tests check Descriptions and Special.

        [Fact]
        public void DescriptionShouldBeCorrect()
        {
            VelociWrap vw = new VelociWrap();
            Assert.Equal("Veloci-Wrap", vw.Description);
        }

        [Fact]
        public void SpecialShouldBeEmptyByDefault()
        {
            VelociWrap vw = new VelociWrap();
            Assert.Empty(vw.Special);
        }

        [Fact]
        public void HoldDressingShouldAddToSpecial()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldDressing();
            Assert.Collection<string>(vw.Special,
                item =>
                {
                    Assert.Equal("Hold Ceasar Dressing", item);
                });
        }

        [Fact]
        public void HoldLettuceShouldAddToSpecial()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldLettuce();
            Assert.Collection<string>(vw.Special,
                item =>
                {
                    Assert.Equal("Hold Romaine Lettuce", item);
                });
        }

        [Fact]
        public void HoldCheeseShouldAddToSpecial()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldCheese();
            Assert.Collection<string>(vw.Special,
                item =>
                {
                    Assert.Equal("Hold Parmesan Cheese", item);
                });
        }

        [Fact]
        public void HoldBunAndPicklesAndKetchupAndMustardShouldAddToSpecial()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldDressing();
            vw.HoldLettuce();
            vw.HoldCheese();
            Assert.Collection<string>(vw.Special,
                item =>
                {
                    Assert.Equal("Hold Ceasar Dressing", item);
                },
                item =>
                {
                    Assert.Equal("Hold Romaine Lettuce", item);
                },
                item =>
                {
                    Assert.Equal("Hold Parmesan Cheese", item);
                });
        }


        //The following tests check event handling.

        [Fact]
        public void HoldingDressingShouldNotifySpecialChange()
        {
            VelociWrap vw = new VelociWrap();
            Assert.PropertyChanged(vw, "Special", () =>
            {
                vw.HoldDressing();
            });
        }

        [Fact]
        public void HoldingLettuceShouldNotifySpecialChange()
        {
            VelociWrap vw = new VelociWrap();
            Assert.PropertyChanged(vw, "Special", () =>
            {
                vw.HoldLettuce();
            });
        }

        [Fact]
        public void HoldingCheeseShouldNotifySpecialChange()
        {
            VelociWrap vw = new VelociWrap();
            Assert.PropertyChanged(vw, "Special", () =>
            {
                vw.HoldCheese();
            });
        }

        [Fact]
        public void HoldingDressingShouldNotifyIngredientsChange()
        {
            VelociWrap vw = new VelociWrap();
            Assert.PropertyChanged(vw, "Ingredients", () =>
            {
                vw.HoldDressing();
            });
        }

        [Fact]
        public void HoldingLettuceShouldNotifyIngredientsChange()
        {
            VelociWrap vw = new VelociWrap();
            Assert.PropertyChanged(vw, "Ingredients", () =>
            {
                vw.HoldLettuce();
            });
        }

        [Fact]
        public void HoldingCheeseShouldNotifyIngredientsChange()
        {
            VelociWrap vw = new VelociWrap();
            Assert.PropertyChanged(vw, "Ingredients", () =>
            {
                vw.HoldCheese();
            });
        }
    }
}
