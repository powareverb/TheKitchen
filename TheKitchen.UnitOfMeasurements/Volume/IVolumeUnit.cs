namespace TheKitchen.UnitOfMeasurements
{
    public interface IVolumeUnit : IUnit<double>
    {
    }

    public class Millilitres : DoubleUnitBase, IVolumeUnit, IDescribableUnit
    {
        public static string Description = "Millilitre";
        public static string Suffix = "ml";

        public override double BaseUnitRatio
        {
            get { return 1000; }
        }

        public string GetUnitDescription()
        {
            return Description;
        }

        public string GetUnitSuffix()
        {
            return Suffix;
        }

        public bool ParseType(string baseUnitString)
        {
            return base.ParseType(baseUnitString, Description, Suffix);
        }
    }

    public class Litres : DoubleUnitBase, IVolumeUnit, IDescribableUnit
    {
        public static string Description = "Litre";
        public static string Suffix = "l";

        public override double BaseUnitRatio
        {
            get { return 1; }
        }

        public string GetUnitDescription()
        {
            return Description;
        }

        public string GetUnitSuffix()
        {
            return Suffix;
        }

        public bool ParseType(string baseUnitString)
        {
            return base.ParseType(baseUnitString, Description, Suffix);
        }
    }

    public class Kilolitres : DoubleUnitBase, IVolumeUnit, IDescribableUnit
    {
        public static string Description = "Kilolitre";
        public static string Suffix = "kl";

        public override double BaseUnitRatio
        {
            get { return 1D / 1000D; }
        }

        public string GetUnitDescription()
        {
            return Description;
        }

        public string GetUnitSuffix()
        {
            return Suffix;
        }

        public bool ParseType(string baseUnitString)
        {
            return base.ParseType(baseUnitString, Description, Suffix);
        }
    }

    public class Cups : DoubleUnitBase, IVolumeUnit, IDescribableUnit
    {
        public static string Description = "Cup";
        public static string Suffix = "c";

        public override double BaseUnitRatio
        {
            get { return Volume.ToBaseUnitRatio(Measure.Volume<Millilitres>(250)); }
        }

        public string GetUnitDescription()
        {
            return Description;
        }

        public string GetUnitSuffix()
        {
            return Suffix;
        }

        public bool ParseType(string baseUnitString)
        {
            return base.ParseType(baseUnitString, Description, Suffix);
        }
    }

    public class Teaspoons : DoubleUnitBase, IVolumeUnit, IDescribableUnit
    {
        public static string Description = "Teaspoon";
        public static string Suffix = "tsp";

        public override double BaseUnitRatio
        {
            get { return Volume.ToBaseUnitRatio(Measure.Volume<Millilitres>(5)); }
        }

        public string GetUnitDescription()
        {
            return Description;
        }

        public string GetUnitSuffix()
        {
            return Suffix;
        }

        public bool ParseType(string baseUnitString)
        {
            return base.ParseType(baseUnitString, Description, Suffix);
        }
    }

    public class Tablespoons : DoubleUnitBase, IVolumeUnit, IDescribableUnit
    {
        public static string Description = "Tablespoon";
        public static string Suffix = "tbsp";

        public override double BaseUnitRatio
        {
            get { return Volume.ToBaseUnitRatio(Measure.Volume<Millilitres>(15)); }
        }

        public string GetUnitDescription()
        {
            return Description;
        }

        public string GetUnitSuffix()
        {
            return Suffix;
        }

        public bool ParseType(string baseUnitString)
        {
            return base.ParseType(baseUnitString, Description, Suffix);
        }
    }

    public class AustralianTablespoons : DoubleUnitBase, IVolumeUnit, IDescribableUnit
    {
        public static string Description = "Australian Tablespoon";
        public static string Suffix = "Australian tbsp";    // Will likely never be parsed

        public override double BaseUnitRatio
        {
            get { return Volume.ToBaseUnitRatio(Measure.Volume<Millilitres>(20)); }
        }

        public string GetUnitDescription()
        {
            return Description;
        }

        public string GetUnitSuffix()
        {
            return Suffix;
        }

        public bool ParseType(string baseUnitString)
        {
            return base.ParseType(baseUnitString, Description, Suffix);
        }
    }

    public class Desertspoons : DoubleUnitBase, IVolumeUnit, IDescribableUnit
    {
        public static string Description = "Desertspoon";
        public static string Suffix = "dsp";

        public override double BaseUnitRatio
        {
            get { return Volume.ToBaseUnitRatio(Measure.Volume<Millilitres>(10)); }
        }

        public string GetUnitDescription()
        {
            return Description;
        }

        public string GetUnitSuffix()
        {
            return Suffix;
        }

        public bool ParseType(string baseUnitString)
        {
            return base.ParseType(baseUnitString, Description, Suffix);
        }
    }
}