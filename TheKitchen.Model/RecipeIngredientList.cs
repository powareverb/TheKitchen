using System.Collections.Generic;
using TheKitchen.UnitOfMeasurements;

namespace TheKitchen.Model.Models
{
    public class RecipeIngredientList : List<RecipeIngredient>
    {
        public void Add(IMeasurementValue value, string ingredient, string preparation = "")
        {
            this.Add(new RecipeIngredient(value, ingredient, preparation));
        }

        public void Add(IMeasurementValue value, Ingredient ingredient)
        {
            this.Add(new RecipeIngredient(value, ingredient));
        }
    }
}