using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheKitchen.Converters.CoreConverters;
using TheKitchen.Model.Models;

namespace TheKitchen.UnitOfMeasurements.Tests
{
    [TestClass]
    public class RecipeTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string recipeML = TestResources.RecipeML1;
            IRecipeConverter recipeConverter = new RecipeMLConverter();
            recipeConverter.Load(recipeML);
            Recipe r = recipeConverter.ToRecipe();
        }
    }
}
