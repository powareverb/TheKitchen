using System;
using Phoenix.Core.String;

namespace TheKitchen.UnitOfMeasurements
{
    public class Length : DoubleTypeMeasurementBase<ILengthUnit>, IMeasurementValue
    {
        public Length(ILengthUnit unit, double unitValue) :
            base(unit, unitValue) { }

        public Length(double baseValue) : base(baseValue) { }

        public static Length operator +(Length l1, Length l2)
        {
            return new Length(l1.BaseValue + l2.BaseValue);
        }

        public static Length operator -(Length l1, Length l2)
        {
            return new Length(l1.BaseValue - l2.BaseValue);
        }

        public override Type BaseUnit
        {
            get { return typeof(Meters); }
        }

        protected override IUnitFactory<double, ILengthUnit> BuildUnitFactory()
        {
            return new LengthUnitFactory();
        }

        public string ToDescription()
        {
            return "{Value} {Unit}".Inject(new { Value = this.BaseValue, Unit = Litres.Description });
        }
    }
}