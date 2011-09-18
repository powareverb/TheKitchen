using System.Collections.Generic;

namespace TheKitchen.Model.Models
{
    internal class PreparationList : List<Preparation>
    {
        internal Preparation FindOrAdd(string preparationName)
        {
            var prep = this.Find(p => p.Name == preparationName);
            if (prep != null)
                return prep;
            else
            {
                this.Add(new Preparation(preparationName));
                return this.Find(p => p.Name == preparationName);
            }
        }
    }
}