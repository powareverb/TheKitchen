using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheKitchen.Model.Models;
using TheKitchen.UnitOfMeasurements;

namespace TheKitchen.Tests
{
    [TestClass]
    public class BasicTests
    {
        [TestMethod]
        public void Pantry()
        {
            Pantry s = new Pantry();
            Ingredient mince = s.Find("Prime Beef Mince").Ingredient;
            Ingredient onion = s.Find("Onion").Ingredient.Prepare("Chopped");
            Ingredient beans = s.Find("Mexican Beans", "Can").Ingredient;

            Recipe r = new Recipe();
            r.IngredientsRequired.Add(Measure.Weight<Grams>(500), mince);
            r.IngredientsRequired.Add(Measure.Quantity<Units>(0.5), onion);
            r.IngredientsRequired.Add(Measure.Quantity<Units>(1), beans);
        }

        [TestMethod]
        public void Ingredients()
        {
            Pantry s = new Pantry();
            Ingredient mince = s.Find("Prime Beef Mince").Ingredient;
            Ingredient onion = s.Find("Onion").Ingredient.Prepare("Chopped");
            Ingredient beans = s.Find("Mexican Beans", "Can").Ingredient;
        }

        [TestMethod]
        public void RecipeBook()
        {
            RecipeBook book = new RecipeBook();
            book.Title = "Bread Recipies";

            Recipe r = new Recipe();
            r.Title = "Nachos!";
            r.Author = "Gavin Jones";

            book.Add(r);

        }


        [TestMethod]
        public void Nachos()
        {
            Recipe r = new Recipe();
            r.Title = "Nachos!";
            r.Author = "Gavin Jones";

            r.IngredientsRequired.Add(Measure.Weight<Grams>(500), "Prime Beef Mince");
            r.IngredientsRequired.Add(Measure.Quantity<Units>(0.5), "Onion", "Chopped");
            r.IngredientsRequired.Add(Measure.Quantity<Units>(2), "Garlic Cloves", "Chopped");
            r.IngredientsRequired.Add(Measure.Quantity<Units>(1), "Large Carrot", "Grated");
            r.IngredientsRequired.Add(Measure.Volume<Teaspoons>(0.5), "Greggs Chilli (jar)");
            r.IngredientsRequired.Add(Measure.Quantity<Units>(1), "Chopped Peeled Tomatos (can)");
            r.IngredientsRequired.Add(Measure.Quantity<Units>(1), "Mexican Beans (can)");
            r.IngredientsRequired.Add(Measure.Quantity<Units>(1), "Maggi Burrito Mix (packet)");

            r.IngredientsRequired.Add(Measure.Quantity<Units>(1), "Black Pepper (taste)");
            r.IngredientsRequired.Add(Measure.Quantity<Units>(1), "Chilli Powder (taste)");

            r.IngredientsRequired.Add(Measure.Quantity<Units>(1), "Nacho Chips (packet)");
            r.IngredientsRequired.Add(Measure.Quantity<Units>(1), "Sour Cream");
            r.IngredientsRequired.Add(Measure.Quantity<Units>(1), "Cheese", "Grated");
        }
    }
}