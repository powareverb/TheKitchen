using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace TheKitchen.UnitOfMeasurements
{
    public static class ParseMeasure
    {
        public static List<IDescribableUnit> AllUnitDefinitions()
        {
            List<IDescribableUnit> unitDefs = new List<IDescribableUnit>();

            // Quantities
            unitDefs.Add(new Units());
            unitDefs.Add(new Dozen());
            unitDefs.Add(new BakersDozen());

            // Volumes
            unitDefs.Add(new Millilitres());
            unitDefs.Add(new Litres());
            unitDefs.Add(new Kilolitres());
            unitDefs.Add(new Cups());
            unitDefs.Add(new Teaspoons());
            unitDefs.Add(new Tablespoons());
            unitDefs.Add(new AustralianTablespoons());
            unitDefs.Add(new Desertspoons());

            // Masses
            unitDefs.Add(new Kilograms());
            unitDefs.Add(new Grams());
            unitDefs.Add(new Pounds());
            unitDefs.Add(new Ounces());


            return unitDefs;
        }

        public static IMeasurementValue Parse(string qty, string unit)
        {
            // Parse Qty
            double qtyValue = ParseQty(qty);
            IDescribableUnit selectedUnit = ParseUnit(unit);

            IQuantityUnit qtyUnit = selectedUnit as IQuantityUnit;
            if (qtyUnit != null)
                return new Quantity(qtyUnit, qtyValue);

            IVolumeUnit volUnit = selectedUnit as IVolumeUnit;
            if (volUnit != null)
                return new Volume(volUnit, qtyValue);

            ILengthUnit lenUnit = selectedUnit as ILengthUnit;
            if (lenUnit != null)
                return new Length(lenUnit, qtyValue);

            IWeightUnit weightUnit = selectedUnit as IWeightUnit;
            if (weightUnit != null)
                return new Weight(weightUnit, qtyValue);

            return null;
        }

        /// <summary>
        /// A regular expression to match fractional expression such as '1 2/3'.
        /// It's up to the user to validate that the expression makes sense. In this context, the fractional portion
        /// must be less than 1 (e.g., '2 3/2' does not make sense), and the denominator must be non-zero.
        /// </summary>
        static Regex FractionalNumberPattern = new Regex(@"
            ^                     # anchor the start of the match at the beginning of the string, then...
            (?<integer>-?\d+)     # match the integer portion of the expression, an optionally signed integer, then...
            \s+                   # match one or more whitespace characters, then...
            (?<numerator>\d+)     # match the numerator, an unsigned decimal integer
                                  #   consisting of one or more decimal digits), then...
            /                     # match the solidus (fraction separator, vinculum) that separates numerator from denominator
            (?<denominator>\d+)   # match the denominator, an unsigned decimal integer
                                  #   consisting of one or more decimal digits), then...
            $                     # anchor the end of the match at the end of the string
            ", RegexOptions.IgnorePatternWhitespace
        );

        /// <summary>
        /// A regular expression to match a fraction (rational number) in its usual format.
        /// The user is responsible for checking that the fraction makes sense in the context
        /// (e.g., 12/0 is perfectly legal, but has an undefined value)
        /// </summary>
        static Regex RationalNumberPattern = new Regex(@"
            ^                     # anchor the start of the match at the beginning of the string, then...
            (?<numerator>-?\d+)   # match the numerator, an optionally signed decimal integer
                                  #   consisting of an optional minus sign, followed by one or more decimal digits), then...
            /                     # match the solidus (fraction separator, vinculum) that separates numerator from denominator
            (?<denominator>-?\d+) # match the denominator, an optionally signed decimal integer
                                  #   consisting of an optional minus sign, followed by one or more decimal digits), then...
            $                     # anchor the end of the match at the end of the string
            ", RegexOptions.IgnorePatternWhitespace);

        private static double ParseQty(string qty)
        {
            double qtyValue;

            if (FractionalNumberPattern.IsMatch(qty))
            {
                var matches = FractionalNumberPattern.Matches(qty);
                var integerString = matches[0].Groups["integer"].Value;
                var numeratorString = matches[0].Groups["numerator"].Value;
                var denominatorString = matches[0].Groups["denominator"].Value;
                double integer = double.Parse(integerString);
                double numerator = double.Parse(numeratorString);
                double denominator = double.Parse(denominatorString);
                return integer + (numerator / denominator);
            }

            if (RationalNumberPattern.IsMatch(qty))
            {
                var matches = RationalNumberPattern.Matches(qty);
                var numeratorString = matches[0].Groups["numerator"].Value;
                var denominatorString = matches[0].Groups["denominator"].Value;
                double numerator = double.Parse(numeratorString);
                double denominator = double.Parse(denominatorString);

                return (numerator / denominator);
            }

            if (!double.TryParse(qty, out qtyValue))
                throw new ApplicationException("BLAH!");

            return qtyValue;
        }

        private static IDescribableUnit ParseUnit(string unit)
        {
            List<IDescribableUnit> unitDefs = AllUnitDefinitions();
            foreach (IDescribableUnit unitDefinition in unitDefs)
            {
                if (unitDefinition.ParseType(unit))
                {
                    return unitDefinition;
                }
            }

            return null;
        }
    }
}
