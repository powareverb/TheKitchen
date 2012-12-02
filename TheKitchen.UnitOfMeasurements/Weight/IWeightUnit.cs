namespace TheKitchen.UnitOfMeasurements
{
    public interface IWeightUnit : IUnit<double>
    {
    }

    public class Grams : DoubleUnitBase, IWeightUnit, IDescribableUnit
    {
        public static string Description = "Gram";
        public static string Suffix = "g";

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

    public class Kilograms : DoubleUnitBase, IWeightUnit, IDescribableUnit
    {
        public static string Description = "Kilogram";
        public static string Suffix = "kg";

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

    public class Pounds : DoubleUnitBase, IWeightUnit, IDescribableUnit
    {
        public static string Description = "Pound";
        public static string Suffix = "lb";

        public override double BaseUnitRatio
        {
            get { return 2.20462262185; }
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

    public class Ounces : DoubleUnitBase, IWeightUnit, IDescribableUnit
    {
        public static string Description = "Ounce";
        public static string Suffix = "oz";

        public override double BaseUnitRatio
        {
            get { return 35.274; }
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