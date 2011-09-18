using System;

namespace TheKitchen.UnitOfMeasurements
{
    public class Quantity : DoubleTypeMeasurementBase<IQuantityUnit>, IMeasurementValue
    {
        public Quantity(IQuantityUnit unit, double unitValue) :
            base(unit, unitValue) { }

        public Quantity(double baseValue) : base(baseValue) { }

        public static Quantity operator +(Quantity q1, Quantity q2)
        {
            return new Quantity(q1.BaseValue + q2.BaseValue);
        }

        public static Quantity operator -(Quantity q1, Quantity q2)
        {
            return new Quantity(q1.BaseValue - q2.BaseValue);
        }

        public override Type BaseUnit
        {
            get { return typeof(Quantity); }
        }

        protected override IUnitFactory<double, IQuantityUnit> BuildUnitFactory()
        {
            return new QuantityUnitFactory();
        }

        public static double ToBaseUnitRatio(Quantity qty)
        {
            return (1 / qty.In<Units>());
        }

        public string ToDescription()
        {
            throw new NotImplementedException();
        }
    }
}