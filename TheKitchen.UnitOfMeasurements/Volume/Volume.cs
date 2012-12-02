using System;
using Phoenix.Core.String;

namespace TheKitchen.UnitOfMeasurements
{
    public class Volume : DoubleTypeMeasurementBase<IVolumeUnit>, IMeasurementValue
    {
        public Volume(IVolumeUnit unit, double unitValue) :
            base(unit, unitValue) { }

        public Volume(double baseValue) : base(baseValue) { }

        public static Volume operator +(Volume v1, Volume v2)
        {
            return new Volume(v1.BaseValue + v2.BaseValue);
        }

        public static Volume operator -(Volume v1, Volume v2)
        {
            return new Volume(v1.BaseValue - v2.BaseValue);
        }

        public override Type BaseUnit
        {
            get { return typeof(Litres); }
        }

        protected override IUnitFactory<double, IVolumeUnit> BuildUnitFactory()
        {
            return new VolumeUnitFactory();
        }

        public static double ToBaseUnitRatio(Volume volume)
        {
            return (1 / volume.In<Litres>());
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