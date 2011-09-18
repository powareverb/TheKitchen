using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheKitchen.UnitOfMeasurements;

namespace UnitOfMeasurements.Tests
{
    [TestClass]
    public class WeightTest
    {
        [TestMethod]
        public void WeightConversionTest()
        {
            Weight w = Measure.Weight<Kilograms>(10);

            Assert.AreEqual(10, w.In<Kilograms>());
            Assert.AreEqual(10000, w.In<Grams>());
            Assert.AreEqual(22.0462262, Math.Round(w.In<Pounds>(), 7));
        }

        [TestMethod]
        public void WeightAdditionTest()
        {
            Weight kg = Measure.Weight<Kilograms>(10);
            Weight pound = Measure.Weight<Pounds>(2);

            Weight newWeight = kg + pound;

            Assert.AreEqual(10.90718474, Math.Round(newWeight.In<Kilograms>(), 8));

            Weight g = Measure.Weight<Grams>(3000);

            newWeight = kg + g;

            Assert.AreEqual(13, newWeight.In<Kilograms>());
        }

        [TestMethod]
        public void WeightSubtractionTest()
        {
            Weight kg = Measure.Weight<Kilograms>(10);
            Weight pound = Measure.Weight<Pounds>(2);

            Weight newWeight = kg - pound;

            Assert.AreEqual(9.09281526, Math.Round(newWeight.In<Kilograms>(), 8));

            Weight g = Measure.Weight<Grams>(3000);

            newWeight = g - kg;

            Assert.AreEqual(-7, newWeight.In<Kilograms>());
        }
    }
}