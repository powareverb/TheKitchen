namespace TheKitchen.Model.Models
{
    public class RecipeIngredient
    {
        private UnitOfMeasurements.IMeasurementValue value;

        public IngredientMeasure IngredientMeasure { get; set; }

        public Preparation Preparation { get; set; }

        public Ingredient Ingredient { get; set; }

        public RecipeIngredient(UnitOfMeasurements.IMeasurementValue value, string ingredient, string preparation)
        {
            Ingredient = new Models.Ingredient(ingredient);
            IngredientMeasure = new Models.IngredientMeasure()
            {
                Ingredient = this.Ingredient,
                Measure = value
            };
            this.Preparation = new Preparation(preparation);
        }

        public RecipeIngredient(UnitOfMeasurements.IMeasurementValue value, Ingredient ingredient)
        {
            Ingredient = new Models.Ingredient(ingredient);
            IngredientMeasure = new Models.IngredientMeasure()
            {
                Ingredient = this.Ingredient,
                Measure = value
            };
            this.Preparation = ingredient.SelectedPreparation;
        }
    }
}