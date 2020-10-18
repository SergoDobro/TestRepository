using System;

namespace RockScissorsPaperLib
{
    public enum RSP { Rock, Scissors, Paper }
    public enum Result { Winner1, Winner2, Draw }
    public class WinnerChecker
    {
        public Result Fight(RSP player1, RSP player2)
        {
            if (player1 == player2)
            {
                return Result.Draw;
            }

            if ((player1 == RSP.Paper && player2 == RSP.Rock) || (player1 == RSP.Rock && player2 == RSP.Scissors) || (player1 == RSP.Scissors && player2 == RSP.Paper))
            {
                return Result.Winner1;
            }

            return Result.Winner2;
        }
    }

    


}
