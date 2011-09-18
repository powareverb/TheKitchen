using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheKitchen.UnitOfMeasurements;

namespace UnitOfMeasurements.Tests
{
    [TestClass]
    public class LengthTest
    {
        [TestMethod]
        public void LengthConvertionTest()
        {
            Length length = Measure.Length<Meters>(1000);

            double m = length.In<Meters>();
            double cm = length.In<Centimeters>();
            double km = length.In<Kilometers>();

            Assert.AreEqual(1000, m);
            Assert.AreEqual(100000, cm);
            Assert.AreEqual(1, km);
        }

        [TestMethod]
        public void LengthAdditionTest()
        {
            Length length1 = Measure.Length<Meters>(10);
            Length length2 = Measure.Length<Centimeters>(100);
            Length length3 = Measure.Length<Kilometers>(1);

            Length newLength = length1 + length2 + length3;

            Assert.AreEqual(10, length1.In<Meters>());
            Assert.AreEqual(100, length2.In<Centimeters>());
            Assert.AreEqual(1, length3.In<Kilometers>());

            Assert.AreEqual(1011, newLength.In<Meters>());
        }

        [TestMethod]
        public void LengthSubstractionTest()
        {
            Length length1 = Measure.Length<Meters>(10);
            Length length2 = Measure.Length<Centimeters>(100);

            Length newLength = length1 - length2;

            Assert.AreEqual(10, length1.In<Meters>());
            Assert.AreEqual(100, length2.In<Centimeters>());

            Assert.AreEqual(9, newLength.In<Meters>());
        }

        [TestMethod]
        public void LengthEqualityTest()
        {
            Length length1 = Measure.Length<Meters>(1000);
            Length length2 = Measure.Length<Kilometers>(1);
            Length length3 = Measure.Length<Meters>(1000.005);
            Assert.AreEqual(length1, length2);
            Assert.AreNotEqual(length1, length3);
        }
    }
}