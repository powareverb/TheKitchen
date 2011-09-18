using System;

namespace TheKitchen.UnitOfMeasurements
{
    public class Area : DoubleTypeMeasurementBase<IAreaUnit>
    {
        public Area(double baseValue) : base(baseValue) { }

        public Area(IAreaUnit unit, double unitValue) :
            base(unit, unitValue) { }

        public static Area operator +(Area a1, Area a2)
        {
            return new Area(a1.BaseValue + a2.BaseValue);
        }

        public static Area operator -(Area a1, Area a2)
        {
            return new Area(a1.BaseValue - a2.BaseValue);
        }

        public override Type BaseUnit
        {
            get { return typeof(SquareMeters); }
        }

        protected override IUnitFactory<double, IAreaUnit> BuildUnitFactory()
        {
            return new AreaUnitFactory();
        }
    }
}