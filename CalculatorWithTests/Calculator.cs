using System;
namespace CalculatorWithTests
{
    public class Calculator
    {
        public decimal CalculateAddition(decimal num1, decimal num2)
        {
            return num1 + num2;
        }
        public decimal CalculateSubtraction(decimal num1, decimal num2)
        {
            return num1 - num2;
        }
        public decimal CalculateMultiplication(decimal num1, decimal num2)
        {
            return num1 * num2;
        }
        public decimal CalculateDivision(decimal num1, decimal num2)
        {
            return num1 / num2;
        }
        public decimal CalculateFactorial(decimal num1)
        {
            int fact = 1;
          
            for (int i = 1; i <= num1; i++)
            {
                fact = fact * i;
            }
            return fact;
        }
    }
}
