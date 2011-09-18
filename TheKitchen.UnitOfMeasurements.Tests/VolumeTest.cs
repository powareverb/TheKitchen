using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TheKitchen.UnitOfMeasurements.Tests
{
    [TestClass]
    public class VolumeTest
    {
        [TestMethod]
        public void VolumeConvertionTest()
        {
            Volume Volume = Measure.Volume<Litres>(1);

            Assert.AreEqual(1, Volume.In<Litres>());
            Assert.AreEqual(0.001, Volume.In<Kilolitres>());
            Assert.AreEqual(1000, Volume.In<Millilitres>());

            // Tablespoons
        }

        [TestMethod]
        public void VolumeCookingTest()
        {
            Volume teaspoon = Measure.Volume<Teaspoons>(1);
            Assert.AreEqual(5, teaspoon.In<Millilitres>());

            Console.WriteLine(teaspoon.ToDescription());

            Volume tablespoon = Measure.Volume<Tablespoons>(1);
            Assert.AreEqual(15, tablespoon.In<Millilitres>());

            Volume dessertspoon = Measure.Volume<Desertspoons>(1);
            Assert.AreEqual(10, dessertspoon.In<Millilitres>());

            Volume cups = Measure.Volume<Cups>(1);
            Assert.AreEqual(250, cups.In<Millilitres>());
        }
    }
}