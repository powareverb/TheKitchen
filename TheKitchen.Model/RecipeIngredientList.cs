using System.Collections.Generic;
using TheKitchen.UnitOfMeasurements;
using Phoenix.Core.String;

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

        public override string ToString()
        {
            string ret = "";
            foreach (var item in this.ToArray())
            {
                ret = ret + "{Measure} {Ingredient} ({Preparation})".Inject(
                    new
                    {
                        Measure = item.IngredientMeasure.Measure.ToString(),
                        Ingredient = item.Ingredient.ToString(),
                        Preparation = item.Preparation
                    });
            }
            return ret;
        }
    }
}