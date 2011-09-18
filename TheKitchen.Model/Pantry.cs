using System.Collections.Generic;
using TheKitchen.UnitOfMeasurements;

namespace TheKitchen.Model.Models
{
    public class IngredientMeasureList : List<IngredientMeasure>
    {
        internal void Add(Ingredient ingredient)
        {
            this.Add(new IngredientMeasure() { Ingredient = ingredient, Measure = Measure.Quantity<Units>(0) });
        }
    }

    public class Pantry
    {
        IngredientMeasureList _ingredientsList = new IngredientMeasureList();

        public IngredientMeasure Find(string name)
        {
            var result = _ingredientsList.Find(p => p.Ingredient.Name == name);
            if (result != null)
                return result;

            _ingredientsList.Add(new Ingredient(name));
            return _ingredientsList.Find(p => p.Ingredient.Name == name);
        }

        public IngredientMeasure Find(string name, string type)
        {
            var result = _ingredientsList.Find(p => p.Ingredient.Name == name && p.Ingredient.SubType == type);
            if (result != null)
                return result;

            _ingredientsList.Add(new Ingredient(name) { SubType = type });
            return _ingredientsList.Find(p => p.Ingredient.Name == name && p.Ingredient.SubType == type);
        }
    }
}