using System;

namespace RockScissorsPaperLib
{
    public enum ModifiedRSP { Rock = 0, Scissors = 1, Paper = 2, Lizard = 3, Spock = 4 }
    public class ModifiedWinnerChecker : IWinCheck
    {
    
        public Result Fight(int p1, int p2)
        {
            ModifiedRSP player1 = (ModifiedRSP)p1;
            ModifiedRSP player2 = (ModifiedRSP)p2;
            if ((int)player1 >= 0 && (int)player1 < 5 && (int)player2 >= 0 && (int)player2 < 5)
            {
                if (player1 == player2)
                {
                    return Result.Draw;
                }

                if ((player1 == ModifiedRSP.Paper && player2 == ModifiedRSP.Rock) 
                || (player1 == ModifiedRSP.Rock && player2 == ModifiedRSP.Scissors) 
                || (player1 == ModifiedRSP.Scissors && player2 == ModifiedRSP.Paper) 
                || (player1 == ModifiedRSP.Scissors && player2 == ModifiedRSP.Lizard) 
                || (player1 == ModifiedRSP.Paper && player2 == ModifiedRSP.Spock)
                || (player1 == ModifiedRSP.Rock && player2 == ModifiedRSP.Lizard)
                || (player1 == ModifiedRSP.Lizard && player2 == ModifiedRSP.Paper)
                || (player1 == ModifiedRSP.Lizard && player2 == ModifiedRSP.Spock)
                || (player1 == ModifiedRSP.Spock && player2 == ModifiedRSP.Rock)
                || (player1 == ModifiedRSP.Spock && player2 == ModifiedRSP.Scissors))
                {
                    return Result.Winner1;
                }

                return Result.Winner2;
            }
            else
            {
                throw new Exception("Не понял, почему не правильный ввод");
            }
        }
    
    }
}