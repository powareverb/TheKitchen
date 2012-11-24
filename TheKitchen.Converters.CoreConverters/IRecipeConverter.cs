using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheKitchen.Model.Models;

namespace TheKitchen.Converters.CoreConverters
{
    public interface IRecipeConverter
    {
        Recipe ToRecipe();

        void Load(string recipeML);
    }
}
