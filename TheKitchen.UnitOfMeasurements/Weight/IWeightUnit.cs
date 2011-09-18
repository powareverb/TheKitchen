namespace TheKitchen.UnitOfMeasurements
{
    public interface IWeightUnit : IUnit<double>
    {
    }

    public class Grams : DoubleUnitBase, IWeightUnit
    {
        public override double BaseUnitRatio
        {
            get { return 1000; }
        }
    }

    public class Kilograms : DoubleUnitBase, IWeightUnit
    {
        public override double BaseUnitRatio
        {
            get { return 1; }
        }
    }

    public class Pounds : DoubleUnitBase, IWeightUnit
    {
        public override double BaseUnitRatio
        {
            get { return 2.20462262185; }
        }
    }
}