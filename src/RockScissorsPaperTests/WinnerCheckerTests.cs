using System;
using Xunit;
using RockScissorsPaperLib;

namespace RockScissorsPaperTests
{
    public class WinnerCheckerTests
    {
        [Theory]
        [InlineData(RSP.Paper, RSP.Rock, Result.Winner1)]
        [InlineData(RSP.Paper, RSP.Paper, Result.Draw)]
        [InlineData(RSP.Paper, RSP.Scissors, Result.Winner2)]
        [InlineData(RSP.Rock, RSP.Paper, Result.Winner2)]
        [InlineData(RSP.Rock, RSP.Rock, Result.Draw)]
        [InlineData(RSP.Rock, RSP.Scissors, Result.Winner1)]
        [InlineData(RSP.Scissors, RSP.Paper, Result.Winner1)]
        [InlineData(RSP.Scissors, RSP.Rock, Result.Winner2)]
        [InlineData(RSP.Scissors, RSP.Scissors, Result.Draw)]
        [InlineData(RSP.Rock, (RSP)010, Result.Draw)]
        public void Test(RSP player1, RSP player2, Result winner)
        {
            // Arrange
            WinnerChecker winnerChecker = new WinnerChecker();

            // Act
            var result = winnerChecker.Fight((int)player1, (int)player2);

            // Assert
            Assert.Equal(winner, result);
        }

        [Theory]
        [InlineData(ModifiedRSP.Lizard, ModifiedRSP.Lizard, Result.Draw)]
        [InlineData(ModifiedRSP.Lizard, ModifiedRSP.Paper, Result.Winner1)]
        [InlineData(ModifiedRSP.Lizard, ModifiedRSP.Rock, Result.Winner2)]
        [InlineData(ModifiedRSP.Lizard, ModifiedRSP.Scissors, Result.Winner2)]
        [InlineData(ModifiedRSP.Lizard, ModifiedRSP.Spock, Result.Winner1)]
        [InlineData(ModifiedRSP.Paper, ModifiedRSP.Lizard, Result.Winner2)]
        [InlineData(ModifiedRSP.Paper, ModifiedRSP.Paper, Result.Draw)]
        [InlineData(ModifiedRSP.Paper, ModifiedRSP.Rock, Result.Winner1)]
        [InlineData(ModifiedRSP.Paper, ModifiedRSP.Scissors, Result.Winner2)]
        [InlineData(ModifiedRSP.Paper, ModifiedRSP.Spock, Result.Winner1)]
        [InlineData(ModifiedRSP.Rock, ModifiedRSP.Lizard, Result.Winner1)]
        [InlineData(ModifiedRSP.Rock, ModifiedRSP.Paper, Result.Winner2)]
        [InlineData(ModifiedRSP.Rock, ModifiedRSP.Rock, Result.Draw)]
        [InlineData(ModifiedRSP.Rock, ModifiedRSP.Scissors, Result.Winner1)]
        [InlineData(ModifiedRSP.Rock, ModifiedRSP.Spock, Result.Winner2)]
        [InlineData(ModifiedRSP.Scissors, ModifiedRSP.Lizard, Result.Winner1)]
        [InlineData(ModifiedRSP.Scissors, ModifiedRSP.Paper, Result.Winner1)]
        [InlineData(ModifiedRSP.Scissors, ModifiedRSP.Rock, Result.Winner2)]
        [InlineData(ModifiedRSP.Scissors, ModifiedRSP.Scissors, Result.Draw)]
        [InlineData(ModifiedRSP.Scissors, ModifiedRSP.Spock, Result.Winner2)]
        [InlineData(ModifiedRSP.Spock, ModifiedRSP.Lizard, Result.Winner2)]
        [InlineData(ModifiedRSP.Spock, ModifiedRSP.Paper, Result.Winner2)]
        [InlineData(ModifiedRSP.Spock, ModifiedRSP.Rock, Result.Winner1)]
        [InlineData(ModifiedRSP.Spock, ModifiedRSP.Scissors, Result.Winner1)]
        [InlineData(ModifiedRSP.Spock, ModifiedRSP.Spock, Result.Draw)]
        [InlineData(ModifiedRSP.Rock, (ModifiedRSP)10, Result.Draw)]
        public void Test2(ModifiedRSP player1,  ModifiedRSP player2, Result winner)
        {
            // Arrange
            ModifiedWinnerChecker winnerChecker = new ModifiedWinnerChecker();

            // Act
            var result = winnerChecker.Fight((int)player1, (int)player2);

            // Assert
            Assert.Equal(winner, result);
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
