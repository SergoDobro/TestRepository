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
            var result = winnerChecker.Fight(RSP.Paper, RSP.Scissors);

            // Assert
            Assert.Equal(Result.Winner2, result);
        }

        [Fact]
        public void Test4()
        {
            // Arrange
            WinnerChecker winnerChecker = new WinnerChecker();

            // Act
            var result = winnerChecker.Fight(RSP.Rock, RSP.Paper);

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
            var result = winnerChecker.Fight(RSP.Rock, RSP.Scissors);

            // Assert
            Assert.Equal(Result.Winner1, result);
        }
        [Fact]
        public void Test7()
        {
            // Arrange
            WinnerChecker winnerChecker = new WinnerChecker();

            // Act
            var result = winnerChecker.Fight(RSP.Scissors, RSP.Paper);

            // Assert
            Assert.Equal(Result.Winner1, result);
        }
        [Fact]
        public void Test8()
        {
            // Arrange
            WinnerChecker winnerChecker = new WinnerChecker();

            // Act
            var result = winnerChecker.Fight(RSP.Scissors, RSP.Rock);

            // Assert
            Assert.Equal(Result.Winner2, result);
        }
        [Fact]
        public void Test9()
        {
            // Arrange
            WinnerChecker winnerChecker = new WinnerChecker();

            // Act
            var result = winnerChecker.Fight(RSP.Scissors, RSP.Scissors);

            // Assert
            Assert.Equal(Result.Draw, result);
        }
        [Fact]
        public void Test10()
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
            var result = winnerChecker.Fight(ModifiedRSP.Lizard, ModifiedRSP.Lizard);

            // Assert
            Assert.Equal(Result.Draw, result);
        }

        [Fact]
        public void Test2_2()
        {
            // Arrange
            ModifiedWinnerChecker winnerChecker = new ModifiedWinnerChecker();

            // Act
            var result = winnerChecker.Fight(ModifiedRSP.Lizard, ModifiedRSP.Paper);

            // Assert
            Assert.Equal(Result.Winner1, result);
        }

        [Fact]
        public void Test3_2()
        {
            // Arrange
            ModifiedWinnerChecker winnerChecker = new ModifiedWinnerChecker();

            // Act
            var result = winnerChecker.Fight(ModifiedRSP.Lizard, ModifiedRSP.Rock);

            // Assert
            Assert.Equal(Result.Winner2, result);
        }

        [Fact]
        public void Test4_2()
        {
            // Arrange
            ModifiedWinnerChecker winnerChecker = new ModifiedWinnerChecker();

            // Act
            var result = winnerChecker.Fight(ModifiedRSP.Lizard, ModifiedRSP.Scissors);

            // Assert
            Assert.Equal(Result.Winner2, result);
        }

        [Fact]
        public void Test5_2()
        {
            // Arrange
            ModifiedWinnerChecker winnerChecker = new ModifiedWinnerChecker();

            // Act
            var result = winnerChecker.Fight(ModifiedRSP.Lizard, ModifiedRSP.Spock);

            // Assert
            Assert.Equal(Result.Winner1, result);
        }
        [Fact]
        public void Test6_2()
        {
            // Arrange
            ModifiedWinnerChecker winnerChecker = new ModifiedWinnerChecker();

            // Act
            var result = winnerChecker.Fight(ModifiedRSP.Paper, ModifiedRSP.Lizard);

            // Assert
            Assert.Equal(Result.Winner2, result);
        }
        [Fact]
        public void Test7_2()
        {
            // Arrange
            ModifiedWinnerChecker winnerChecker = new ModifiedWinnerChecker();

            // Act
            var result = winnerChecker.Fight(ModifiedRSP.Paper, ModifiedRSP.Paper);

            // Assert
            Assert.Equal(Result.Draw, result);
        }
        [Fact]
        public void Test8_2()
        {
            // Arrange
            ModifiedWinnerChecker winnerChecker = new ModifiedWinnerChecker();

            // Act
            var result = winnerChecker.Fight(ModifiedRSP.Paper, ModifiedRSP.Rock);

            // Assert
            Assert.Equal(Result.Winner1, result);
        }
        [Fact]
        public void Test9_2()
        {
            // Arrange
            ModifiedWinnerChecker winnerChecker = new ModifiedWinnerChecker();

            // Act
            var result = winnerChecker.Fight(ModifiedRSP.Paper, ModifiedRSP.Scissors);

            // Assert
            Assert.Equal(Result.Winner2, result);
        }
        [Fact]
        public void Test10_2()
        {
            // Arrange
            ModifiedWinnerChecker winnerChecker = new ModifiedWinnerChecker();

            // Act
            var result = winnerChecker.Fight(ModifiedRSP.Paper, ModifiedRSP.Spock);

            // Assert
            Assert.Equal(Result.Winner1, result);
        }
        [Fact]
        public void Test11_2()
        {
            // Arrange
            ModifiedWinnerChecker winnerChecker = new ModifiedWinnerChecker();

            // Act
            var result = winnerChecker.Fight(ModifiedRSP.Rock, ModifiedRSP.Lizard);

            // Assert
            Assert.Equal(Result.Winner1, result);
        }
        [Fact]
        public void Test12_2()
        {
            // Arrange
            ModifiedWinnerChecker winnerChecker = new ModifiedWinnerChecker();

            // Act
            var result = winnerChecker.Fight(ModifiedRSP.Rock, ModifiedRSP.Paper);

            // Assert
            Assert.Equal(Result.Winner2, result);
        }
        [Fact]
        public void Test13_2()
        {
            // Arrange
            ModifiedWinnerChecker winnerChecker = new ModifiedWinnerChecker();

            // Act
            var result = winnerChecker.Fight(ModifiedRSP.Rock, ModifiedRSP.Rock);

            // Assert
            Assert.Equal(Result.Draw, result);
        }
        [Fact]
        public void Test14_2()
        {
            // Arrange
            ModifiedWinnerChecker winnerChecker = new ModifiedWinnerChecker();

            // Act
            var result = winnerChecker.Fight(ModifiedRSP.Rock, ModifiedRSP.Scissors);

            // Assert
            Assert.Equal(Result.Winner1, result);
        }
        [Fact]
        public void Test15_2()
        {
            // Arrange
            ModifiedWinnerChecker winnerChecker = new ModifiedWinnerChecker();

            // Act
            var result = winnerChecker.Fight(ModifiedRSP.Rock, ModifiedRSP.Spock);

            // Assert
            Assert.Equal(Result.Winner2, result);
        }
        [Fact]
        public void Test16_2()
        {
            // Arrange
            ModifiedWinnerChecker winnerChecker = new ModifiedWinnerChecker();

            // Act
            var result = winnerChecker.Fight(ModifiedRSP.Scissors, ModifiedRSP.Lizard);

            // Assert
            Assert.Equal(Result.Winner1, result);
        }
        [Fact]
        public void Test17_2()
        {
            // Arrange
            ModifiedWinnerChecker winnerChecker = new ModifiedWinnerChecker();

            // Act
            var result = winnerChecker.Fight(ModifiedRSP.Scissors, ModifiedRSP.Paper);

            // Assert
            Assert.Equal(Result.Winner1, result);
        }
        [Fact]
        public void Test18_2()
        {
            // Arrange
            ModifiedWinnerChecker winnerChecker = new ModifiedWinnerChecker();

            // Act
            var result = winnerChecker.Fight(ModifiedRSP.Scissors, ModifiedRSP.Rock);

            // Assert
            Assert.Equal(Result.Winner2, result);
        }
        [Fact]
        public void Test19_2()
        {
            // Arrange
            ModifiedWinnerChecker winnerChecker = new ModifiedWinnerChecker();

            // Act
            var result = winnerChecker.Fight(ModifiedRSP.Scissors, ModifiedRSP.Scissors);

            // Assert
            Assert.Equal(Result.Draw, result);
        }
        [Fact]
        public void Test20_2()
        {
            // Arrange
            ModifiedWinnerChecker winnerChecker = new ModifiedWinnerChecker();

            // Act
            var result = winnerChecker.Fight(ModifiedRSP.Scissors, ModifiedRSP.Spock);

            // Assert
            Assert.Equal(Result.Winner2, result);
        }
        [Fact]
        public void Test21_2()
        {
            // Arrange
            ModifiedWinnerChecker winnerChecker = new ModifiedWinnerChecker();

            // Act
            var result = winnerChecker.Fight(ModifiedRSP.Spock, ModifiedRSP.Lizard);

            // Assert
            Assert.Equal(Result.Winner2, result);
        }
        [Fact]
        public void Test22_2()
        {
            // Arrange
            ModifiedWinnerChecker winnerChecker = new ModifiedWinnerChecker();

            // Act
            var result = winnerChecker.Fight(ModifiedRSP.Spock, ModifiedRSP.Paper);

            // Assert
            Assert.Equal(Result.Winner2, result);
        }
        [Fact]
        public void Test23_2()
        {
            // Arrange
            ModifiedWinnerChecker winnerChecker = new ModifiedWinnerChecker();

            // Act
            var result = winnerChecker.Fight(ModifiedRSP.Spock, ModifiedRSP.Rock);

            // Assert
            Assert.Equal(Result.Winner1, result);
        }
        [Fact]
        public void Test24_2()
        {
            // Arrange
            ModifiedWinnerChecker winnerChecker = new ModifiedWinnerChecker();

            // Act
            var result = winnerChecker.Fight(ModifiedRSP.Spock, ModifiedRSP.Scissors);

            // Assert
            Assert.Equal(Result.Winner1, result);
        }
        [Fact]
        public void Test25_2()
        {
            // Arrange
            ModifiedWinnerChecker winnerChecker = new ModifiedWinnerChecker();

            // Act
            var result = winnerChecker.Fight(ModifiedRSP.Spock, ModifiedRSP.Spock);

            // Assert
            Assert.Equal(Result.Draw, result);
        }
        [Fact]
        public void Test26_2()
        {
            // Arrange
            ModifiedWinnerChecker winnerChecker = new ModifiedWinnerChecker();

            // Act
            var result = winnerChecker.Fight(ModifiedRSP.Rock, (ModifiedRSP)10);

            // Assert
            Assert.Equal(Result.Draw, result);
        }
        
    }
}
