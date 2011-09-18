using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheKitchen.UnitOfMeasurements;

namespace UnitOfMeasurements.Tests
{
    [TestClass]
    public class AreaTest
    {
        [TestMethod]
        public void AreaConvertionTest()
        {
            Area Area = Measure.Area<SquareMeters>(1000);

            double m = Area.In<SquareMeters>();
            double cm = Area.In<SquareCentimeters>();
            double km = Area.In<SquareKilometers>();

            Assert.AreEqual(1000, m);
            Assert.AreEqual(10000000, cm);
            Assert.AreEqual(0.001, km);
        }

        [TestMethod]
        public void AreaAdditionTest()
        {
            Area Area1 = Measure.Area<SquareMeters>(10);
            Area Area2 = Measure.Area<SquareCentimeters>(100);
            Area Area3 = Measure.Area<SquareKilometers>(1);

            Area newArea = Area1 + Area2 + Area3;

            Assert.AreEqual(10, Area1.In<SquareMeters>());
            Assert.AreEqual(100, Area2.In<SquareCentimeters>());
            Assert.AreEqual(1, Area3.In<SquareKilometers>());

            Assert.AreEqual(1000010.01, newArea.In<SquareMeters>());
        }

        [TestMethod]
        public void AreaSubstractionTest()
        {
            Area Area1 = Measure.Area<SquareMeters>(10);
            Area Area2 = Measure.Area<SquareCentimeters>(100);

            Area newArea = Area1 - Area2;

            Assert.AreEqual(10, Area1.In<SquareMeters>());
            Assert.AreEqual(100, Area2.In<SquareCentimeters>());

            Assert.AreEqual(9.99, newArea.In<SquareMeters>());
        }

        [TestMethod]
        public void AreaEqualityTest()
        {
            Area Area1 = Measure.Area<SquareMeters>(1000);
            Area Area2 = Measure.Area<SquareKilometers>(0.001);
            Area Area3 = Measure.Area<SquareMeters>(1000.005);
            Assert.AreEqual(Area1, Area2);
            Assert.IsTrue(Area1 == Area2);
            Assert.AreNotEqual(Area1, Area3);
        }
    }
}