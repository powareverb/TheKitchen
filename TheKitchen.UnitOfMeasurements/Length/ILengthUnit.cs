namespace TheKitchen.UnitOfMeasurements
{
    public interface ILengthUnit : IUnit<double>
    {
    }

    public class Centimeters : DoubleUnitBase, ILengthUnit
    {
        public override double BaseUnitRatio
        {
            get { return 100; }
        }
    }

    public class Meters : DoubleUnitBase, ILengthUnit
    {
        public override double BaseUnitRatio
        {
            get { return 1; }
        }
    }

    public class Kilometers : DoubleUnitBase, ILengthUnit
    {
        public override double BaseUnitRatio
        {
            get { return 1D / 1000D; }
        }
    }
}