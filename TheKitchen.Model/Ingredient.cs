using Phoenix.Core.String;

namespace TheKitchen.Model.Models
{
    public class Ingredient
    {
        public Ingredient(string ingredient)
        {
            this.Name = ingredient;
        }

        public Ingredient(Ingredient ingredient)
        {
            this.Name = ingredient.Name;
            this.Description = ingredient.Description;
            this.SubType = ingredient.SubType;
        }

        /// <summary>
        /// Whether this ingredient is typically a packet, comes in a can, etc
        /// </summary>
        public string SubType { get; set; }

        /// <summary>
        /// What this ingredient is called
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// A more descriptive description :)
        /// </summary>
        public string Description { get; set; }

        internal PreparationList Preparations = new PreparationList();

        public Preparation SelectedPreparation { get; set; }

        /// <summary>
        /// How this ingredient should be prepared typically
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public Ingredient Prepare(string describePrepared)
        {
            Ingredient i = new Ingredient(this);
            i.SelectedPreparation = Preparations.FindOrAdd(describePrepared);
            return i;
        }

        public override string ToString()
        {
            return "{Name} ({Preparation})".Inject(new { 
                Name = this.Name,
                Preparation = this.SelectedPreparation.Name
            });
        }
    }
}