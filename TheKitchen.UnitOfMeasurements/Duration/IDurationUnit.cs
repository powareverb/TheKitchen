namespace TheKitchen.UnitOfMeasurements
{
    public interface IDurationUnit : IUnit<double>
    {
    }

    public class Seconds : DoubleUnitBase, IDurationUnit
    {
        public override double BaseUnitRatio
        {
            get { return 3600; }
        }
    }

    public class Minutes : DoubleUnitBase, IDurationUnit
    {
        public override double BaseUnitRatio
        {
            get { return 60; }
        }
    }

    public class Hours : DoubleUnitBase, IDurationUnit
    {
        public override double BaseUnitRatio
        {
            get { return 1; }
        }
    }

    public class Days : DoubleUnitBase, IDurationUnit
    {
        public override double BaseUnitRatio
        {
            get { return 1D / 24D; }
        }
    }
}