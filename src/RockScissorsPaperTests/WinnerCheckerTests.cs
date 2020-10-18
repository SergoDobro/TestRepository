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
            var result = winnerChecker.Fight((int)RSP.Paper, (int)RSP.Rock);

            // Assert
            Assert.Equal(Result.Winner1, result);
        }

        [Fact]
        public void Test2()
        {
            // Arrange
            WinnerChecker winnerChecker = new WinnerChecker();

            // Act
            var result = winnerChecker.Fight((int)RSP.Paper, (int)RSP.Paper);

            // Assert
            Assert.Equal(Result.Draw, result);
        }

        [Fact]
        public void Test3()
        {
            // Arrange
            WinnerChecker winnerChecker = new WinnerChecker();

            // Act
            var result = winnerChecker.Fight((int)RSP.Scissors, (int)RSP.Rock);

            // Assert
            Assert.Equal(Result.Winner2, result);
        }

        [Fact]
        public void Test4()
        {
            // Arrange
            WinnerChecker winnerChecker = new WinnerChecker();

            // Act
            var result = winnerChecker.Fight((int)RSP.Paper, (int)RSP.Scissors);

            // Assert
            Assert.Equal(Result.Winner2, result);
        }

        [Fact]
        public void Test5()
        {
            // Arrange
            WinnerChecker winnerChecker = new WinnerChecker();

            // Act
            var result = winnerChecker.Fight((int)RSP.Rock, (int)RSP.Rock);

            // Assert
            Assert.Equal(Result.Draw, result);
        }
        [Fact]
        public void Test6()
        {
            // Arrange
            WinnerChecker winnerChecker = new WinnerChecker();

            // Act
            var result = winnerChecker.Fight((int)RSP.Rock, 10);

            // Assert
            Assert.Equal(Result.Draw, result);
        }

        [Fact]
        public void Test1_2()
        {
            // Arrange
            ModifiedWinnerChecker winnerChecker = new ModifiedWinnerChecker();

            // Act
            var result = winnerChecker.Fight((int)ModifiedRSP.Paper, (int)ModifiedRSP.Rock);

            // Assert
            Assert.Equal(Result.Winner1, result);
        }

        [Fact]
        public void Test2_2()
        {
            // Arrange
            ModifiedWinnerChecker winnerChecker = new ModifiedWinnerChecker();

            // Act
            var result = winnerChecker.Fight((int)ModifiedRSP.Paper, (int)ModifiedRSP.Paper);

            // Assert
            Assert.Equal(Result.Draw, result);
        }

        [Fact]
        public void Test3_2()
        {
            // Arrange
            ModifiedWinnerChecker winnerChecker = new ModifiedWinnerChecker();

            // Act
            var result = winnerChecker.Fight((int)ModifiedRSP.Scissors, (int)ModifiedRSP.Rock);

            // Assert
            Assert.Equal(Result.Winner2, result);
        }

        [Fact]
        public void Test4_2()
        {
            // Arrange
            ModifiedWinnerChecker winnerChecker = new ModifiedWinnerChecker();

            // Act
            var result = winnerChecker.Fight((int)ModifiedRSP.Paper, (int)ModifiedRSP.Scissors);

            // Assert
            Assert.Equal(Result.Winner2, result);
        }

        [Fact]
        public void Test5_2()
        {
            // Arrange
            ModifiedWinnerChecker winnerChecker = new ModifiedWinnerChecker();

            // Act
            var result = winnerChecker.Fight((int)ModifiedRSP.Rock, (int)ModifiedRSP.Rock);

            // Assert
            Assert.Equal(Result.Draw, result);
        }
        [Fact]
        public void Test6_2()
        {
            // Arrange
            ModifiedWinnerChecker winnerChecker = new ModifiedWinnerChecker();

            // Act
            var result = winnerChecker.Fight((int)ModifiedRSP.Rock, 10);

            // Assert
            Assert.Equal(Result.Draw, result);
        }
        [Fact]
        public void Test7_2()
        {
            // Arrange
            ModifiedWinnerChecker winnerChecker = new ModifiedWinnerChecker();

            // Act
            var result = winnerChecker.Fight((int)ModifiedRSP.Lizard, (int)ModifiedRSP.Rock);

            // Assert
            Assert.Equal(Result.Winner2, result);
        }
        [Fact]
        public void Test8_2()
        {
            // Arrange
            ModifiedWinnerChecker winnerChecker = new ModifiedWinnerChecker();

            // Act
            var result = winnerChecker.Fight((int)ModifiedRSP.Spock, (int)ModifiedRSP.Scissors);

            // Assert
            Assert.Equal(Result.Winner1, result);
        }
        [Fact]
        public void Test1_3()
        {
            // Arrange
            ModifiedWinnerChecker winnerChecker = new ModifiedWinnerChecker();

            // Act
            var result = winnerChecker.Fight((int)ModifiedRSP.Spock, (int)ModifiedRSP.Scissors);

            // Assert
            Assert.Equal(Result.Winner1, result);
        }
    }
}
