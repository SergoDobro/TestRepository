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
            var result = winnerChecker.Fight((int)RSP.Paper, (int)RSP.Scissors);
          
            // Assert
            Assert.Equal(Result.Winner2, result);
        }

        [Fact]
        public void Test4()
        {
            // Arrange
            WinnerChecker winnerChecker = new WinnerChecker();

            // Act
            var result = winnerChecker.Fight((int)RSP.Rock, (int)RSP.Paper);

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
            var result = winnerChecker.Fight((int)RSP.Rock, (int)RSP.Scissors);

            // Assert
            Assert.Equal(Result.Winner1, result);
        }
        [Fact]
        public void Test7()
        {
            // Arrange
            WinnerChecker winnerChecker = new WinnerChecker();

            // Act
            var result = winnerChecker.Fight((int)RSP.Scissors, (int)RSP.Paper);

            // Assert
            Assert.Equal(Result.Winner1, result);
        }
        [Fact]
        public void Test8()
        {
            // Arrange
            WinnerChecker winnerChecker = new WinnerChecker();

            // Act
            var result = winnerChecker.Fight((int)RSP.Scissors, (int)RSP.Rock);

            // Assert
            Assert.Equal(Result.Winner2, result);
        }
        [Fact]
        public void Test9()
        {
            // Arrange
            WinnerChecker winnerChecker = new WinnerChecker();

            // Act
            var result = winnerChecker.Fight((int)RSP.Scissors, (int)RSP.Scissors);

            // Assert
            Assert.Equal(Result.Draw, result);
        }
        [Fact]
        public void Test10()
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
            var result = winnerChecker.Fight((int)ModifiedRSP.Lizard, (int)ModifiedRSP.Lizard);

            // Assert
            Assert.Equal(Result.Draw, result);
        }

        [Fact]
        public void Test2_2()
        {
            // Arrange
            ModifiedWinnerChecker winnerChecker = new ModifiedWinnerChecker();

            // Act
            var result = winnerChecker.Fight((int)ModifiedRSP.Lizard, (int)ModifiedRSP.Paper);

            // Assert
            Assert.Equal(Result.Winner1, result);
        }

        [Fact]
        public void Test3_2()
        {
            // Arrange
            ModifiedWinnerChecker winnerChecker = new ModifiedWinnerChecker();

            // Act
            var result = winnerChecker.Fight((int)ModifiedRSP.Lizard, (int)ModifiedRSP.Rock);

            // Assert
            Assert.Equal(Result.Winner2, result);
        }

        [Fact]
        public void Test4_2()
        {
            // Arrange
            ModifiedWinnerChecker winnerChecker = new ModifiedWinnerChecker();

            // Act
            var result = winnerChecker.Fight((int)ModifiedRSP.Lizard, (int)ModifiedRSP.Scissors);

            // Assert
            Assert.Equal(Result.Winner2, result);
        }

        [Fact]
        public void Test5_2()
        {
            // Arrange
            ModifiedWinnerChecker winnerChecker = new ModifiedWinnerChecker();

            // Act
            var result = winnerChecker.Fight((int)ModifiedRSP.Lizard, (int)ModifiedRSP.Spock);

            // Assert
            Assert.Equal(Result.Winner1, result);
        }
        [Fact]
        public void Test6_2()
        {
            // Arrange
            ModifiedWinnerChecker winnerChecker = new ModifiedWinnerChecker();

            // Act
            var result = winnerChecker.Fight((int)ModifiedRSP.Paper, (int)ModifiedRSP.Lizard);

            // Assert
            Assert.Equal(Result.Winner2, result);
        }
        [Fact]
        public void Test7_2()
        {
            // Arrange
            ModifiedWinnerChecker winnerChecker = new ModifiedWinnerChecker();

            // Act
            var result = winnerChecker.Fight((int)ModifiedRSP.Paper, (int)ModifiedRSP.Paper);

            // Assert
            Assert.Equal(Result.Draw, result);
        }
        [Fact]
        public void Test8_2()
        {
            // Arrange
            ModifiedWinnerChecker winnerChecker = new ModifiedWinnerChecker();

            // Act
            var result = winnerChecker.Fight((int)ModifiedRSP.Paper, (int)ModifiedRSP.Rock);

            // Assert
            Assert.Equal(Result.Winner1, result);
        }
        [Fact]
        public void Test9_2()
        {
            // Arrange
            ModifiedWinnerChecker winnerChecker = new ModifiedWinnerChecker();

            // Act
            var result = winnerChecker.Fight((int)odifiedRSP.Paper, (int)ModifiedRSP.Scissors);

            // Assert
            Assert.Equal(Result.Winner2, result);
        }
        [Fact]
        public void Test10_2()
        {
            // Arrange
            ModifiedWinnerChecker winnerChecker = new ModifiedWinnerChecker();

            // Act
            var result = winnerChecker.Fight((int)ModifiedRSP.Paper, (int)ModifiedRSP.Spock);

            // Assert
            Assert.Equal(Result.Winner1, result);
        }
        [Fact]
        public void Test11_2()
        {
            // Arrange
            ModifiedWinnerChecker winnerChecker = new ModifiedWinnerChecker();

            // Act
            var result = winnerChecker.Fight((int)ModifiedRSP.Rock, (int)ModifiedRSP.Lizard);

            // Assert
            Assert.Equal(Result.Winner1, result);
        }
        [Fact]
        public void Test12_2()
        {
            // Arrange
            ModifiedWinnerChecker winnerChecker = new ModifiedWinnerChecker();

            // Act
            var result = winnerChecker.Fight((int)ModifiedRSP.Rock, (int)ModifiedRSP.Paper);

            // Assert
            Assert.Equal(Result.Winner2, result);
        }
        [Fact]
        public void Test13_2()
        {
            // Arrange
            ModifiedWinnerChecker winnerChecker = new ModifiedWinnerChecker();

            // Act
            var result = winnerChecker.Fight((int)ModifiedRSP.Rock, (int)ModifiedRSP.Rock);

            // Assert
            Assert.Equal(Result.Draw, result);
        }
        [Fact]
        public void Test14_2()
        {
            // Arrange
            ModifiedWinnerChecker winnerChecker = new ModifiedWinnerChecker();

            // Act
            var result = winnerChecker.Fight((int)ModifiedRSP.Rock, (int)ModifiedRSP.Scissors);

            // Assert
            Assert.Equal(Result.Winner1, result);
        }
        [Fact]
        public void Test15_2()
        {
            // Arrange
            ModifiedWinnerChecker winnerChecker = new ModifiedWinnerChecker();

            // Act
            var result = winnerChecker.Fight((int)ModifiedRSP.Rock, (int)ModifiedRSP.Spock);

            // Assert
            Assert.Equal(Result.Winner2, result);
        }
        [Fact]
        public void Test16_2()
        {
            // Arrange
            ModifiedWinnerChecker winnerChecker = new ModifiedWinnerChecker();

            // Act
            var result = winnerChecker.Fight((int)ModifiedRSP.Scissors, (int)ModifiedRSP.Lizard);

            // Assert
            Assert.Equal(Result.Winner1, result);
        }
        [Fact]
        public void Test17_2()
        {
            // Arrange
            ModifiedWinnerChecker winnerChecker = new ModifiedWinnerChecker();

            // Act
            var result = winnerChecker.Fight((int)ModifiedRSP.Scissors, (int)ModifiedRSP.Paper);

            // Assert
            Assert.Equal(Result.Winner1, result);
        }
        [Fact]
        public void Test18_2()
        {
            // Arrange
            ModifiedWinnerChecker winnerChecker = new ModifiedWinnerChecker();

            // Act
            var result = winnerChecker.Fight((int)ModifiedRSP.Scissors, (int)ModifiedRSP.Rock);

            // Assert
            Assert.Equal(Result.Winner2, result);
        }
        [Fact]
        public void Test19_2()
        {
            // Arrange
            ModifiedWinnerChecker winnerChecker = new ModifiedWinnerChecker();

            // Act
            var result = winnerChecker.Fight((int)ModifiedRSP.Scissors, (int)ModifiedRSP.Scissors);

            // Assert
            Assert.Equal(Result.Draw, result);
        }
        [Fact]
        public void Test20_2()
        {
            // Arrange
            ModifiedWinnerChecker winnerChecker = new ModifiedWinnerChecker();

            // Act
            var result = winnerChecker.Fight((int)ModifiedRSP.Scissors, (int)ModifiedRSP.Spock);

            // Assert
            Assert.Equal(Result.Winner2, result);
        }
        [Fact]
        public void Test21_2()
        {
            // Arrange
            ModifiedWinnerChecker winnerChecker = new ModifiedWinnerChecker();

            // Act
            var result = winnerChecker.Fight((int)ModifiedRSP.Spock, (int)ModifiedRSP.Lizard);

            // Assert
            Assert.Equal(Result.Winner2, result);
        }
        [Fact]
        public void Test22_2()
        {
            // Arrange
            ModifiedWinnerChecker winnerChecker = new ModifiedWinnerChecker();

            // Act
            var result = winnerChecker.Fight((int)ModifiedRSP.Spock, (int)ModifiedRSP.Paper);

            // Assert
            Assert.Equal(Result.Winner2, result);
        }
        [Fact]
        public void Test23_2()
        {
            // Arrange
            ModifiedWinnerChecker winnerChecker = new ModifiedWinnerChecker();

            // Act
            var result = winnerChecker.Fight((int)ModifiedRSP.Spock, (int)ModifiedRSP.Rock);

            // Assert
            Assert.Equal(Result.Winner1, result);
        }
        [Fact]
        public void Test24_2()
        {
            // Arrange
            ModifiedWinnerChecker winnerChecker = new ModifiedWinnerChecker();

            // Act
            var result = winnerChecker.Fight((int)ModifiedRSP.Spock, (int)ModifiedRSP.Scissors);

            // Assert
            Assert.Equal(Result.Winner1, result);
        }
        [Fact]
        public void Test25_2()
        {
            // Arrange
            ModifiedWinnerChecker winnerChecker = new ModifiedWinnerChecker();

            // Act
            var result = winnerChecker.Fight((int)ModifiedRSP.Spock, (int)ModifiedRSP.Spock);

            // Assert
            Assert.Equal(Result.Draw, result);
        }
        [Fact]
        public void Test26_2()
        {
            // Arrange
            ModifiedWinnerChecker winnerChecker = new ModifiedWinnerChecker();

            // Act
            var result = winnerChecker.Fight((int)ModifiedRSP.Rock, 10);

            // Assert
            Assert.Equal(Result.Draw, result);
        }

        public void Test1_3()
        {
            // Arrange
            WinCheckFabric winCheckFabric = new WinCheckFabric();

            // Act
            var result = winCheckFabric.Create(true);
            // Assert
            Assert.Equal(typeof(WinnerChecker), result.GetType());
        }

        [Fact]
        public void Test2_3()
        {
            // Arrange
            WinCheckFabric winCheckFabric = new WinCheckFabric();

            // Act
            var result = winCheckFabric.Create(false);
            // Assert
            Assert.Equal(typeof(ModifiedWinnerChecker), result.GetType());
        }
    }
}
