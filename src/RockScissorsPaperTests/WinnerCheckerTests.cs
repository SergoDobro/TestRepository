using System;
using Xunit;
using RockScissorsPaperLib;

namespace RockScissorsPaperTests
{
    public class WinnerCheckerTests
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            WinnerChecker winnerChecker = new WinnerChecker();

            // Act
            var result = winnerChecker.Fight(RSP.Paper, RSP.Rock);

            // Assert
            Assert.Equal(Result.Winner1, result);
        }

        [Fact]
        public void Test2()
        {
            // Arrange
            WinnerChecker winnerChecker = new WinnerChecker();

            // Act
            var result = winnerChecker.Fight(RSP.Paper, RSP.Paper);

            // Assert
            Assert.Equal(Result.Draw, result);
        }

        [Fact]
        public void Test3()
        {
            // Arrange
            WinnerChecker winnerChecker = new WinnerChecker();

            // Act
            var result = winnerChecker.Fight(RSP.Scissors, RSP.Rock);

            // Assert
            Assert.Equal(Result.Winner2, result);
        }

        [Fact]
        public void Test4()
        {
            // Arrange
            WinnerChecker winnerChecker = new WinnerChecker();

            // Act
            var result = winnerChecker.Fight(RSP.Paper, RSP.Scissors);

            // Assert
            Assert.Equal(Result.Winner2, result);
        }

        [Fact]
        public void Test5()
        {
            // Arrange
            WinnerChecker winnerChecker = new WinnerChecker();

            // Act
            var result = winnerChecker.Fight(RSP.Rock, RSP.Rock);

            // Assert
            Assert.Equal(Result.Draw, result);
        }
        [Fact]
        public void Test6()
        {
            // Arrange
            WinnerChecker winnerChecker = new WinnerChecker();

            // Act
            var result = winnerChecker.Fight(RSP.Rock, (RSP)10);

            // Assert
            Assert.Equal(Result.Draw, result);
        }

        [Fact]
        public void Test1_2()
        {
            // Arrange
            ModifiedWinnerChecker winnerChecker = new ModifiedWinnerChecker();

            // Act
            var result = winnerChecker.Fight(ModifiedRSP.Paper, ModifiedRSP.Rock);

            // Assert
            Assert.Equal(Result.Winner1, result);
        }

        [Fact]
        public void Test2_2()
        {
            // Arrange
            WinnerChecker winnerChecker = new WinnerChecker();

            // Act
            var result = winnerChecker.Fight(RSP.Paper, RSP.Paper);

            // Assert
            Assert.Equal(Result.Draw, result);
        }

        [Fact]
        public void Test3_2()
        {
            // Arrange
            WinnerChecker winnerChecker = new WinnerChecker();

            // Act
            var result = winnerChecker.Fight(RSP.Scissors, RSP.Rock);

            // Assert
            Assert.Equal(Result.Winner2, result);
        }

        [Fact]
        public void Test4_2()
        {
            // Arrange
            WinnerChecker winnerChecker = new WinnerChecker();

            // Act
            var result = winnerChecker.Fight(RSP.Paper, RSP.Scissors);

            // Assert
            Assert.Equal(Result.Winner2, result);
        }

        [Fact]
        public void Test5_2()
        {
            // Arrange
            WinnerChecker winnerChecker = new WinnerChecker();

            // Act
            var result = winnerChecker.Fight(RSP.Rock, RSP.Rock);

            // Assert
            Assert.Equal(Result.Draw, result);
        }
        [Fact]
        public void Test6_2()
        {
            // Arrange
            WinnerChecker winnerChecker = new WinnerChecker();

            // Act
            var result = winnerChecker.Fight(RSP.Rock, (RSP)10);

            // Assert
            Assert.Equal(Result.Draw, result);
        }
    }
}
