namespace TheKitchen.UnitOfMeasurements
{
    public interface IQuantityUnit : IUnit<double>
    {
    }

    public class Units : DoubleUnitBase, IQuantityUnit
    {
        public override double BaseUnitRatio
        {
            get { return 1; }
        }
    }

    public class Dozen : DoubleUnitBase, IQuantityUnit
    {
        public override double BaseUnitRatio
        {
            get { return 12; }
        }
    }

    public class BakersDozen : DoubleUnitBase, IQuantityUnit
    {
        public override double BaseUnitRatio
        {
            get { return 13; }
        }
    }
}