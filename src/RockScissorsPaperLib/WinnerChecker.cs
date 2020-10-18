using System;

namespace RockScissorsPaperLib
{
    public enum RSP { Rock = 0, Scissors = 1, Paper = 2 }
    public enum Result { Winner1, Winner2, Draw }
    public class WinnerChecker : IWinCheck
    {
        public Result Fight(int p1, int p2)
        {
            RSP player1 = (RSP)p1;
            RSP player2 = (RSP)p2;
            if ((int)player1 >= 0 && (int)player1 < 3 && (int)player2 >= 0 && (int)player2 < 3)
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
            else
            {
                throw new Exception("Не понял, почему не правильный ввод");
            }
        }
    }

    


}
