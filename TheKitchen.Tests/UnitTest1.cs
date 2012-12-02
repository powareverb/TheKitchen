using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheKitchen.Converters.CoreConverters;
using TheKitchen.Model.Models;
using System.Linq;

namespace TheKitchen.Model.Tests
{
    [TestClass]
    public class RecipeTest
    {
        [TestMethod]
        public void RecipeMLLoadTest()
        {
            string recipeML = TestResources.RecipeML1;
            IRecipeConverter recipeConverter = new RecipeMLConverter();
            recipeConverter.Load(recipeML);
            Recipe r = recipeConverter.ToRecipe();

            Assert.IsTrue(r.IngredientsRequired.Any(p => p.Ingredient.Name.Contains("butter")));
            Assert.IsTrue(r.IngredientsRequired.Any(p => p.Ingredient.Name.Contains("flower")));
            Assert.IsTrue(r.IngredientsRequired.Any(p => p.Ingredient.Name.Contains("salt")));
        }
    }
}
