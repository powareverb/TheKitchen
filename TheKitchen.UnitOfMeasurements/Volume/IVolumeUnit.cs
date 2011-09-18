namespace TheKitchen.UnitOfMeasurements
{
    public interface IVolumeUnit : IUnit<double>
    {
    }

    public class Millilitres : DoubleUnitBase, IVolumeUnit
    {
        public override double BaseUnitRatio
        {
            get { return 1000; }
        }
    }

    public class Litres : DoubleUnitBase, IVolumeUnit
    {
        public static string Description = "Litres";

        public override double BaseUnitRatio
        {
            get { return 1; }
        }
    }

    public class Kilolitres : DoubleUnitBase, IVolumeUnit
    {
        public override double BaseUnitRatio
        {
            get { return 1D / 1000D; }
        }
    }

    public class Cups : DoubleUnitBase, IVolumeUnit
    {
        public override double BaseUnitRatio
        {
            get { return Volume.ToBaseUnitRatio(Measure.Volume<Millilitres>(250)); }
        }
    }

    public class Teaspoons : DoubleUnitBase, IVolumeUnit
    {
        public override double BaseUnitRatio
        {
            get { return Volume.ToBaseUnitRatio(Measure.Volume<Millilitres>(5)); }
        }
    }

    public class Tablespoons : DoubleUnitBase, IVolumeUnit
    {
        public override double BaseUnitRatio
        {
            get { return Volume.ToBaseUnitRatio(Measure.Volume<Millilitres>(15)); }
        }
    }

    public class AustralianTablespoons : DoubleUnitBase, IVolumeUnit
    {
        public override double BaseUnitRatio
        {
            get { return Volume.ToBaseUnitRatio(Measure.Volume<Millilitres>(20)); }
        }
    }

    public class Desertspoons : DoubleUnitBase, IVolumeUnit
    {
        public override double BaseUnitRatio
        {
            get { return Volume.ToBaseUnitRatio(Measure.Volume<Millilitres>(10)); }
        }
    }
}