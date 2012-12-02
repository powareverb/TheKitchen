namespace TheKitchen.UnitOfMeasurements
{
    public interface IQuantityUnit : IUnit<double>
    {
    }

    public class Units : DoubleUnitBase, IQuantityUnit, IDescribableUnit
    {
        public static string Description = "Units";
        public static string Suffix = "units";

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

    public class Dozen : DoubleUnitBase, IQuantityUnit, IDescribableUnit
    {
        public static string Description = "Dozen";
        public static string Suffix = "doz";

        public override double BaseUnitRatio
        {
            get { return 1D/12D; }
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

    public class BakersDozen : DoubleUnitBase, IQuantityUnit, IDescribableUnit
    {
        public static string Description = "Bakers Dozen";
        public static string Suffix = "bdoz"; // Not likely to be parsed

        public override double BaseUnitRatio
        {
            get { return 1D/13D; }
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