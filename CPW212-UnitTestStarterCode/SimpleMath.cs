using System;

namespace CPW212_UnitTestStarterCode
{
    /*****************************************************************************
     * 
     * YOU MAY REFACTOR THE PARAMETER NAMES BUT DO NOT CHANGE THE METHOD SIGNATURES
     * 
     * ***************************************************************************/
    public static class SimpleMath
    {
        public static double Add(double augend, double addend)
        {
            double sum = augend + addend;
            return sum;
        }

        public static double Subtract(double minuend, double subtrahend)
        {
            double difference = minuend - subtrahend;
            return difference;
        }

        public static double Multiply(double multiplicand, double multiplier)
        {
            double product = multiplicand * multiplier;
            return product;
        }

        public static double Divide(double numerator, double denominator)
        {
            if (denominator == 0)
            {
                throw new DivideByZeroException("Denominator cannot be zero!");
            }
            double quotient = numerator / denominator;
            return quotient;
        }
    }
}
