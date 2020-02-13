using Microsoft.VisualStudio.TestTools.UnitTesting;
using CPW212_UnitTestStarterCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public void Add_TwoNumbers_ReturnsSum(double num1, double num2)
        {
            // Arrange => Act
            double sum = SimpleMath.Add(num1, num2);

            // Assert
            Assert.AreEqual(num1 + num2, sum);
        }

        [TestMethod]
        public void Multiply_TwoNumbers_ReturnsProduct()
        {
            // Arrange => Act
            double num1 = 0.0;
            double num2 = 10.0;
            double sum1 = SimpleMath.Multiply(num1, num2);

            double num3 = 2.0;
            double num4 = 20.0;
            double sum2 = SimpleMath.Multiply(num3, num4);

            double num5 = 1000000.0;
            double num6 = 2000000.0;
            double sum3 = SimpleMath.Multiply(num5, num6);

            // Assert
            Assert.AreEqual(num1 * num2, sum1);
            Assert.AreEqual(num3 * num4, sum2);
            Assert.AreEqual(num5 * num6, sum3);
        }

        [TestMethod]
        public void Divide_DenominatorZero_ThrowsArgumentException()
        {
            // Arrange => Act
            int numerator = 10;
            int denominator = 0;

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