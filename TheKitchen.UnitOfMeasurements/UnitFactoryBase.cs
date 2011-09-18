// http://splotter.wordpress.com/2009/09/03/csharp-unit-of-measurement/

using System.Collections.Generic;

namespace TheKitchen.UnitOfMeasurements
{
    public abstract class UnitFactoryBase<TValue, TUnit> : IUnitFactory<TValue, TUnit>
        where TUnit : IUnit<TValue>
    {
        protected IList<TUnit> createdUnits = new List<TUnit>();

        public T Create<T>() where T : TUnit, new()
        {
            foreach (TUnit unit in createdUnits)
            {
                if (unit is T)
                    return (T)unit;
            }

            T newUnit = new T();
            createdUnits.Add(newUnit);
            return newUnit;
        }
    }
}