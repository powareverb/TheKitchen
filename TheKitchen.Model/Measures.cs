namespace TheKitchen.Model.Models
{
    public class Measures
    {
        public Measures()
        { }

        public Measures(UnitOfMeasurements.Weight weight)
        {
            Qty = weight.BaseValue;
        }

        public Measures(UnitOfMeasurements.Quantity quantity)
        {
            Qty = quantity.BaseValue;
        }

        public double Qty { get; set; }
    }
}