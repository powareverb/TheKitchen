namespace TheKitchen.Model.Models
{
    public class Preparation
    {
        public string PreparationInstructions { get; set; }

        public string Name { get; set; }

        public Preparation(string name, string preparationInstructions = "")
        {
            this.Name = name;
            this.PreparationInstructions = preparationInstructions;
        }
    }
}