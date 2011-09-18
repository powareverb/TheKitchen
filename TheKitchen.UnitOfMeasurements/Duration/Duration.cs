using System;

namespace TheKitchen.UnitOfMeasurements
{
    public class Duration : DoubleTypeMeasurementBase<IDurationUnit>
    {
        public Duration(double baseValue) : base(baseValue) { }

        public Duration(IDurationUnit unit, double unitValue) :
            base(unit, unitValue) { }

        public static Duration operator +(Duration d1, Duration d2)
        {
            return new Duration(d1.BaseValue + d2.BaseValue);
        }

        public static Duration operator -(Duration d1, Duration d2)
        {
            return new Duration(d1.BaseValue - d2.BaseValue);
        }

        public override Type BaseUnit
        {
            get { return typeof(Hours); }
        }

        protected override IUnitFactory<double, IDurationUnit> BuildUnitFactory()
        {
            return new DurationUnitFactory();
        }
    }
}