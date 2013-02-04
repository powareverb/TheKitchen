using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TheKitchen.Model.Models;

namespace TheKitchen.Services
{
    public interface IRecipeBookService
    {
        IQueryable<RecipeBook> GetAllRecipeBooks();

        RecipeBook ById(int id);
    }
}
