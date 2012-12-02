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

        [TestMethod]
        public void VolumeParsingTest()
        {
            var parse = ParseMeasure.Parse("2", "cups");
            Assert.AreEqual(typeof(Volume), parse.GetType());
            Volume parsed = parse as Volume; 
            Assert.AreEqual(2, parsed.In<Cups>());

            var parse2 = ParseMeasure.Parse("1/2", "cup");
            Assert.AreEqual(typeof(Volume), parse.GetType());
            Volume parsed2 = parse2 as Volume;
            Assert.AreEqual(0.5, parsed2.In<Cups>());

            var parse3 = ParseMeasure.Parse("1 1/2", "teaspoons");
            Assert.AreEqual(typeof(Volume), parse.GetType());
            Volume parsed3 = parse3 as Volume;
            Assert.AreEqual(1.5, parsed3.In<Teaspoons>());

        }

    }
}