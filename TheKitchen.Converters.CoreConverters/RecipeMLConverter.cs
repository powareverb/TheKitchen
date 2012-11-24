using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheKitchen.Converters.CoreConverters
{
    public class RecipeMLConverter : IRecipeConverter
    {
        public Model.Models.Recipe ToRecipe()
        {
            throw new NotImplementedException();
        }

        public void Load(string recipeML)
        {
            RecipeML.RecipeML r = new RecipeML.RecipeML();
        }
    }
}
