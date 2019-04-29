using System;
using Xunit;
using CalculatorWithTests;

namespace CalculatorWithTests.Tests
{
    public class CalculatingTests
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(2, 3, 5)]
        [InlineData(3, 4, 7)]
        public void ShouldAddTest(decimal num1, decimal num2, decimal expectedNumber)
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            decimal actual = calculator.CalculateAddition(num1, num2);

            // Assert
            Assert.Equal(expectedNumber, actual);
        }

        [Theory]
        [InlineData(5, 3, 2)]
        [InlineData(4, 2, 2)]
        [InlineData(2, 1, 1)]
        public void ShouldSubtractTests(decimal num1, decimal num2, decimal expectedNumber)
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            decimal actual = calculator.CalculateSubtraction(num1, num2);

            // Assert
            Assert.Equal(expectedNumber, actual);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(2, 3, 6)]
        [InlineData(3, 4, 12)]
        public void ShouldMultiplyTests(decimal num1, decimal num2, decimal expectedNumber)
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            decimal actual = calculator.CalculateMultiplication(num1, num2);

            // Assert
            Assert.Equal(expectedNumber, actual);
        }

        [Theory]
        [InlineData(6, 3, 2)]
        [InlineData(4, 2, 2)]
        [InlineData(2, 2, 1)]
        public void ShouldDivideTests(decimal num1, decimal num2, decimal expectedNumber)
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            decimal actual = calculator.CalculateDivision(num1, num2);

            // Assert
            Assert.Equal(expectedNumber, actual);
        }

        [Theory]
        [InlineData(3, 6)]
        [InlineData(4, 24)]
        [InlineData(5, 120)]
        public void ShouldFactorialTests(decimal num1, decimal expectedNumber)
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            decimal actual = calculator.CalculateFactorial(num1);

            // Assert
            Assert.Equal(expectedNumber, actual);
        }
    }
}
