using System;

namespace TheKitchen.UnitOfMeasurements
{
    public abstract class DoubleTypeMeasurementBase<TUnit> : MeasurementBase<double, TUnit>
        where TUnit : IUnit<double>
    {
        public DoubleTypeMeasurementBase(TUnit unit, double unitValue) :
            base(unit, unitValue) { }

        public DoubleTypeMeasurementBase(double baseValue) : base(baseValue) { }

        protected DoubleTypeMeasurementBase() : base() { }

        public override bool Equals(object obj)
        {
            if (obj == null) { return false; }

            if (GetType() != obj.GetType()) return false;

            DoubleTypeMeasurementBase<TUnit> measurement
                    = (DoubleTypeMeasurementBase<TUnit>)obj;

            return (Math.Abs(this.BaseValue - measurement.BaseValue) <= Measure.Tolerance);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

    public abstract class Int64TypeMeasurementBase<TUnit> : MeasurementBase<long, TUnit>
        where TUnit : IUnit<long>
    {
        public Int64TypeMeasurementBase(TUnit unit, long unitValue) :
            base(unit, unitValue) { }

        public Int64TypeMeasurementBase(long baseValue) : base(baseValue) { }

        protected Int64TypeMeasurementBase() : base() { }
    }

    public abstract class MeasurementBase<TValue, TUnit> : IMeasurement<TValue>
        where TUnit : IUnit<TValue>
    {
        private TValue _baseValue;

        protected IUnitFactory<TValue, TUnit> _unitFactory;
        public Type SelectedUnit;

        public MeasurementBase(TUnit unit, TValue unitValue) :
            this(unit.ToBaseValue(unitValue))
        {
            SelectedUnit = unit.GetType();
        }

        public MeasurementBase(TValue baseValue)
        {
            _baseValue = baseValue;
        }

        protected MeasurementBase()
        {
            _baseValue = default(TValue);
        }

        public abstract Type BaseUnit { get; }

        public TValue BaseValue
        {
            get { return _baseValue; }
            protected set { _baseValue = value; }
        }

        public IUnitFactory<TValue, TUnit> UnitFactory
        {
            get
            {
                if (_unitFactory == null)
                    _unitFactory = BuildUnitFactory();

                return _unitFactory;
            }
        }

        protected abstract IUnitFactory<TValue, TUnit> BuildUnitFactory();

        protected T Unit<T>()
            where T : TUnit, new()
        {
            return UnitFactory.Create<T>();
        }

        public TValue In<T>()
           where T : TUnit, new()
        {
            return Unit<T>().ToUnitValue(_baseValue);
        }

        public override bool Equals(object obj)
        {
            if (obj == null) { return false; }

            if (GetType() != obj.GetType()) return false;

            MeasurementBase<TValue, TUnit> measurement
                    = (MeasurementBase<TValue, TUnit>)obj;

            return measurement.BaseValue.Equals(this.BaseValue);
        }

        public override int GetHashCode()
        {
            return this.BaseValue.GetHashCode() + typeof(TUnit).GetHashCode();
        }

        public static bool operator ==(MeasurementBase<TValue, TUnit> m1, MeasurementBase<TValue, TUnit> m2)
        {
            if (ReferenceEquals(m1, m2)) return true;
            return m1.Equals(m2);
        }

        public static bool operator !=(MeasurementBase<TValue, TUnit> m1, MeasurementBase<TValue, TUnit> m2)
        {
            return !(m1 == m2);
        }
    }

    public interface IMeasurement<T>
    {
        Type BaseUnit { get; }

        T BaseValue { get; }
    }
}