using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheKitchen.UnitOfMeasurements
{
    public interface IDescribableUnit
    {
        string GetUnitDescription();
        string GetUnitSuffix();

        bool ParseType(string baseUnitString);
    }
}
