
using MentalHealthTracket.Shared.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MentalHealthTracker.Test
{
    [TestClass]
    class HealthCalculatorTest
    {
        HealthCalculator calc;
        int[] mock;

       [TestInitialize]
        public void Initialize()
        {
            calc = new HealthCalculator();
            mock = new int[]{ 1, 5, 5, 10 };
        }

        [TestMethod]
        public void MoodAverage_AreEqual()
        {
            var expected = 5;
            var actual = calc.MoodAverage(mock);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MoodMode_AreEqual()
        {
            var expected = 5;
            var actual = calc.MoodMode(mock);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MoodMax_AreEqual()
        {
            var expected = 10;
            var actual = calc.MoodMax(mock);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MoodMin_AreEqual()
        {
            var expected = 1;
            var actual = calc.MoodMin(mock);

            Assert.AreEqual(expected, actual);
        }
    }
}
