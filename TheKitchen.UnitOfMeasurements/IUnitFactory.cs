namespace TheKitchen.UnitOfMeasurements
{
    public interface IUnitFactory<TValue, TUnit>
        where TUnit : IUnit<TValue>
    {
        T Create<T>() where T : TUnit, new();
    }
}