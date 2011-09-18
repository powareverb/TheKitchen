// http://splotter.wordpress.com/2009/09/03/csharp-unit-of-measurement/

using System;

namespace TheKitchen.UnitOfMeasurements
{
    public abstract class DoubleUnitBase : NumericUnitBase<double>
    {
        public override double ConverToBase(double unitValue)
        {
            return unitValue / BaseUnitRatio;
        }

        public override double ConvertToUnit(double baseValue)
        {
            return baseValue * BaseUnitRatio;
        }
    }

    public abstract class Int64UnitBase : NumericUnitBase<long>
    {
        public override long ConverToBase(long unitValue)
        {
            return (long)Math.Round((unitValue / BaseUnitRatio));
        }

        public override long ConvertToUnit(long baseValue)
        {
            return (long)Math.Round((baseValue * BaseUnitRatio));
        }
    }

    public abstract class NumericUnitBase<T> : UnitBase<T>
        where T : struct
    {
        public abstract override double BaseUnitRatio { get; }
    }

    public abstract class UnitBase<T> : IUnit<T>
    {
        public T ToBaseValue(T unitValue)
        {
            return ConverToBase(unitValue);
        }

        public T ToUnitValue(T baseValue)
        {
            return ConvertToUnit(baseValue);
        }

        public abstract T ConverToBase(T unitValue);

        public abstract T ConvertToUnit(T baseValue);

        public abstract double BaseUnitRatio { get; }
    }

    public interface IUnit<T>
    {
        T ToBaseValue(T unitValue);

        T ToUnitValue(T baseValue);

        double BaseUnitRatio { get; }
    }
}