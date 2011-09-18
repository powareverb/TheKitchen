namespace TheKitchen.UnitOfMeasurements
{
    public interface IAreaUnit : IUnit<double>
    {
    }

    public class SquareCentimeters : DoubleUnitBase, IAreaUnit
    {
        public override double BaseUnitRatio
        {
            get { return 10000; }
        }
    }

    public class SquareMeters : DoubleUnitBase, IAreaUnit
    {
        public override double BaseUnitRatio
        {
            get { return 1; }
        }
    }

    public class SquareKilometers : DoubleUnitBase, IAreaUnit
    {
        public override double BaseUnitRatio
        {
            get { return 1D / 1000000D; }
        }
    }
}