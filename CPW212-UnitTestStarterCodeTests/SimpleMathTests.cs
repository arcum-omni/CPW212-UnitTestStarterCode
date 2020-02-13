using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CPW212_UnitTestStarterCode.Tests
{
    [TestClass()]
    public class SimpleMathTests
    {
        [TestMethod()]
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(-1, -10)]
        [DataRow(0, -0)]
        public void Add_TwoNumbers_ReturnsSum(double augend, double addend)
        {
            // Arrange => Act
            double sum = SimpleMath.Add(augend, addend);

            // Assert
            Assert.AreEqual(augend + addend, sum);
        }

        [TestMethod]
        public void Multiply_TwoNumbers_ReturnsProduct()
        {
            // Arrange => Act
            double multiplicand1 = 0.0;
            double multiplier1 = 10.0;
            double product1 = SimpleMath.Multiply(multiplicand1, multiplier1);

            double multiplicand2 = 2.0;
            double multiplier2 = 20.0;
            double product2 = SimpleMath.Multiply(multiplicand2, multiplier2);

            double multiplicand3 = 1000000.0;
            double multiplier3 = 2000000.0;
            double product3 = SimpleMath.Multiply(multiplicand3, multiplier3);

            // Assert
            Assert.AreEqual(multiplicand1 * multiplier1, product1);
            Assert.AreEqual(multiplicand2 * multiplier2, product2);
            Assert.AreEqual(multiplicand3 * multiplier3, product3);
        }

        [TestMethod]
        public void Divide_DenominatorZero_ThrowsArgumentException()
        {
            // Arrange => Act
            double numerator = 10.0;
            double denominator = 0.0;

            // Assert
            Assert.ThrowsException<DivideByZeroException>(() => SimpleMath.Divide(numerator, denominator));
        }

        #region TestMethod
        [TestMethod]
        [DataRow(0.0, 10.0)]
        [DataRow(1.0, 10.0)]
        [DataRow(10.0, 10.0)]
        [DataRow(100.0, 10.0)]
        [DataRow(1, 0.000000001)]
        #endregion
        public void Divide_TwoNumbers_ReturnQuotient(double numerator, double denominator)
        {
            // Arrange => Act
            double quotient = SimpleMath.Divide(numerator, denominator);

            // Assert
            Assert.AreEqual(numerator/denominator, quotient);
        }

        #region TestMethod
        [TestMethod]
        [DataRow(10.0, 5.0)]
        [DataRow(100.0, 0.0)]
        [DataRow(-1.0, -10.0)]
        [DataRow(0.0, -0.0)]
        #endregion
        public void Subtract_TwoNumbers_ReturnDifference(double minuend, double subtrahend)
        {
            // Arrange => Act
            double difference = SimpleMath.Subtract(minuend, subtrahend);

            // Assert
            Assert.AreEqual(minuend - subtrahend, difference);
        }
    }
}