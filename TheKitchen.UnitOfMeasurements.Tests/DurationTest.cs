using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheKitchen.UnitOfMeasurements;

namespace UnitOfMeasurements.Tests
{
    [TestClass]
    public class DurationTest
    {
        [TestMethod]
        public void DurationConvertionTest()
        {
            Duration sec = Measure.Duration<Seconds>(60);
            Assert.AreEqual(1, sec.In<Minutes>());

            Duration min = Measure.Duration<Minutes>(60);
            Assert.AreEqual(3600, min.In<Seconds>());
            Assert.AreEqual(1, min.In<Hours>());

            Duration day = Measure.Duration<Days>(1);
            Assert.AreEqual(24, day.In<Hours>());
            Assert.AreEqual(1440, day.In<Minutes>());

            Duration hr1 = Measure.Duration<Hours>(12);
            Assert.AreEqual(0.5, hr1.In<Days>());

            Duration hr2 = Measure.Duration<Hours>(24);
            Assert.AreEqual(1, hr2.In<Days>());

            Duration hr3 = Measure.Duration<Hours>(48);
            Assert.AreEqual(2, hr3.In<Days>());
        }

        [TestMethod]
        public void DurationAdditionTest()
        {
            Duration hr = Measure.Duration<Hours>(24);
            Duration min = Measure.Duration<Minutes>(720);

            Duration newDuration = hr + min;

            Assert.AreEqual(36, newDuration.In<Hours>());
            Assert.AreEqual(1.5, newDuration.In<Days>());
        }

        [TestMethod]
        public void DurationSubtractionTest()
        {
            Duration hr = Measure.Duration<Hours>(24);
            Duration min = Measure.Duration<Minutes>(720);

            Duration newDuration = hr - min;

            Assert.AreEqual(12, newDuration.In<Hours>());
            Assert.AreEqual(0.5, newDuration.In<Days>());
        }
    }
}