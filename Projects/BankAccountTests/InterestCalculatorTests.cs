using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BankAccountTests
{
    [TestClass]
    public class InterestCalculatorTests
    {
        [TestMethod]
        public void Test_FixedInterest_OneYear()
        {
            decimal result = InterestCalculator.CalculateInterest(1000m, 10m, 365);
            Assert.AreEqual(100m, result);
        }

        [TestMethod]
        public void Test_FixedInterest_HalfYear()
        {
            decimal result = InterestCalculator.CalculateInterest(2000m, 8m, 182);
            Assert.AreEqual(80m, result);
        }

        [TestMethod]
        public void Test_InterestRateChange()
        {
            decimal result = InterestCalculator.CalculateInterestWithChanges(1000m, new (decimal rate, int days)[]
            {
                (5m, 180),
                (10m, 185)
            });
            Assert.AreEqual(71.51m, Math.Round(result, 2));
        }

        [TestMethod]
        public void Test_SmallAmount()
        {
            decimal result = InterestCalculator.CalculateInterest(500m, 7m, 30);
            Assert.AreEqual(2.88m, Math.Round(result, 2));
        }

        [TestMethod]
        public void Test_NoInterest()
        {
            decimal result = InterestCalculator.CalculateInterest(3000m, 0m, 200);
            Assert.AreEqual(0m, result);
        }
    }
}
