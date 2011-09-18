using TheKitchen.UnitOfMeasurements;

namespace TheKitchen.Model.Models
{
    public class IngredientMeasure
    {
        public IMeasurementValue Measure { get; set; }

        public Ingredient Ingredient { get; set; }
    }
}