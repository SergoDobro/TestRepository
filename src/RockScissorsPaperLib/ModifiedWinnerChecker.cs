namespace RockScissorsPaperLib
{
    public enum ModifiedRSP { Rock, Scissors, Paper, Lizard, Spock }
    public class ModifiedWinnerChecker
    {
    
        public Result Fight(ModifiedRSP player1, ModifiedRSP player2)
        {
            if (player1 == player2)
            {
                return Result.Draw;
            }

            if ((player1 == ModifiedRSP.Paper && player2 == ModifiedRSP.Rock) || (player1 == ModifiedRSP.Rock && player2 == ModifiedRSP.Scissors) || (player1 == ModifiedRSP.Scissors && player2 == ModifiedRSP.Paper) || (player1 == ModifiedRSP.Scissors && player2 == ModifiedRSP.Lizard) || ())
            {
                return Result.Winner1;
            }

            return Result.Winner2;
        }
    
    }
}