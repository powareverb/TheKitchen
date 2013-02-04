using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StaticVoid.Core.Repository;
using TheKitchen.Model.Models;
using TheKitchen.Storage;

namespace TheKitchen.Services
{
    public class SimpleRecipeBookService : IRecipeBookService
    {
        private IRepository<RecipeBook> _repo;

        public SimpleRecipeBookService(IRepository<RecipeBook> repo)
        {
            _repo = repo;
        }

        public IQueryable<RecipeBook> GetAllRecipeBooks()
        {
            return _repo.GetAll();
        }

        public RecipeBook ById(int id)
        {
            return _repo.GetBy(p => p.ID == id);
        }
    }
}
