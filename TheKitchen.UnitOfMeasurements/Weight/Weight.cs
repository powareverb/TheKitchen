using System;
using Phoenix.Core.String;

namespace TheKitchen.UnitOfMeasurements
{
    public class Weight : DoubleTypeMeasurementBase<IWeightUnit>, IMeasurementValue
    {
        public Weight(IWeightUnit unit, double unitValue) :
            base(unit, unitValue) { }

        public Weight(double baseValue) : base(baseValue) { }

        public override Type BaseUnit
        {
            get { return typeof(Kilograms); }
        }

        protected override IUnitFactory<double, IWeightUnit> BuildUnitFactory()
        {
            return new WeightUnitFactory();
        }

        public static Weight operator +(Weight w1, Weight w2)
        {
            return new Weight(w1.BaseValue + w2.BaseValue);
        }

        public static Weight operator -(Weight w1, Weight w2)
        {
            return new Weight(w1.BaseValue - w2.BaseValue);
        }

        public string ToDescription()
        {
            return "{Value} {Unit}".Inject(new { Value = this.BaseValue, Unit = Litres.Description });
        }

        public override string ToString()
        {
            return ToDescription();
        }
    }
}