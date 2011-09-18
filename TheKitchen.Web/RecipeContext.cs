using System.Data.Entity;
using TheKitchen.Model.Models;

namespace TheKitchen.Model
{
    public class RecipeContext : DbContext
    {
        public DbSet<Recipe> Recipes { get; set; }

        public DbSet<Ingredient> Ingredients { get; set; }
    }
}