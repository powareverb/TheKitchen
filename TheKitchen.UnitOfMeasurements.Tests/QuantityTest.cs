using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TheKitchen.UnitOfMeasurements.Tests
{
    [TestClass]
    public class QuantityTest
    {
        [TestMethod]
        public void BasicQuantities()
        {
            Quantity q = Measure.Quantity<Units>(1200);

            Assert.AreEqual(1200, q.In<Units>());
            Assert.AreEqual(100, q.In<Dozen>());

            Quantity q2 = Measure.Quantity<Units>(1300);

            Assert.AreEqual(1300, q2.In<Units>());
            Assert.AreEqual(100, q2.In<BakersDozen>());
        }

        [TestMethod]
        public void ParseUnits()
        {
            IMeasurementValue u = ParseMeasure.Parse("1000", "units");

            Quantity q = u as Quantity;
            Assert.IsNotNull(q);
        }
    }
}
