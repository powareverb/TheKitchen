using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheKitchen.Converters.CoreConverters;
using TheKitchen.Model.Models;

namespace TheKitchen.Tests
{
    [TestClass]
    public class ConversionTests
    {
        [TestMethod]
        public void RecipeMLLoad()
        {
            string ml = TestResources.RecipeML1;

            IRecipeConverter rml = new RecipeMLConverter();
            rml.Load(ml);

            Recipe r = rml.ToRecipe();

            Assert.IsNotNull(r);

            string blah = r.IngredientsRequired.ToString();

        }
    }
}
