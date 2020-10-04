using System;
using Xunit;

namespace MathCalculatorTests
{
    public class MathCalculatorTest
    {
        const int Five = 5;
        const int Three = 3;
        [Fact]
        public void WhenSumFiveAndThreeThaenGotEight()
        {
            // Arrange
            MathCalculatorr calculator = new MathCalculatorr();

            // Act
            var result = calculator.Sum(Five,Three);

            // Assert
            Assert.Equal(8, result);
        
        }
        
        [Fact]
        public void WhenSubFiveAndThreeThaenGotEight()
        {
            // Arrange
            MathCalculatorr calculator = new MathCalculatorr();

            // Act
            var result = calculator.Substract(Five,Three);

            // Assert
            Assert.Equal(2, result);
        
        }
        [Fact]
        public void WhenNegSumFiveAndThreeThaenGotEight()
        {
            // Arrange
            MathCalculatorr calculator = new MathCalculatorr();

            // Act
            var result = calculator.Sum(-Five,-Three);

            // Assert
            Assert.Equal(-8, result);
        
        }
        [Fact]
        public void WhenNegSubFiveAndThreeThaenGotEight()
        {
            // Arrange
            MathCalculatorr calculator = new MathCalculatorr();

            // Act
            var result = calculator.Substract(-Five,Three);

            // Assert
            Assert.Equal(-8, result);
        
        }

    }
}
