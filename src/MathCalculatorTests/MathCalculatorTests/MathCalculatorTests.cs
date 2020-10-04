using System;
using Xunit;

namespace MathCalculatorTests
{
    public class MathCalculatorTest
    {
        [Fact]
        public void WhenSumFiveAndThreeThaenGotEight()
        {
            // Arrange
            const int Five = 5;
            const int Three = 3;
            MathCalculatorr calculator = new MathCalculatorr();

            // Act
            var result = calculator.Sum(5,3);

            // Assert
            Assert.Equal(8, result);
        
        }
        
        [Fact]
        public void WhenSubFiveAndThreeThaenGotEight()
        {
            // Arrange
            const int Five = 5;
            const int Three = 3;
            MathCalculatorr calculator = new MathCalculatorr();

            // Act
            var result = calculator.Substract(5,3);

            // Assert
            Assert.Equal(2, result);
        
        }

    }
}
