namespace TheKitchen.Model.Models
{
    public class Recipe
    {
        public RecipeIngredientList IngredientsRequired { get; set; }

        public Recipe()
        {
            IngredientsRequired = new RecipeIngredientList();
        }
    }
}