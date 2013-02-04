using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheKitchen.Model.Models
{
    public class RecipeBook : IEntity
    {
        public int ID { get; set; }
        public string Title { get; set; }

        // TODO: Implement
        public void Add(Recipe r)
        {
        }
    }
}
