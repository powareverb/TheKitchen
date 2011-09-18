namespace TheKitchen.Model.Models
{
    public class RecipeIngredient
    {
        private UnitOfMeasurements.IMeasurementValue value;
        private Ingredient ingredient;

        public IngredientMeasure IngredientMeasure { get; set; }

        public Preparation Preparation { get; set; }

        public RecipeIngredient(UnitOfMeasurements.IMeasurementValue value, string ingredient, string preparation)
        {
            IngredientMeasure = new Models.IngredientMeasure()
            {
                Ingredient = new Ingredient(ingredient),
                Measure = value
            };
            this.Preparation = new Preparation(preparation);
        }

        public RecipeIngredient(UnitOfMeasurements.IMeasurementValue value, Ingredient ingredient)
        {
            IngredientMeasure = new Models.IngredientMeasure()
            {
                Ingredient = new Ingredient(ingredient),
                Measure = value
            };
            this.Preparation = ingredient.SelectedPreparation;
        }
    }
}