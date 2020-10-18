using System;


namespace RockScissorsPaperLib
{
    public enum RSP { Rock, Scissors, Paper}
    public enum Result { winner1, winner2, draw}
    public class WinnerChecker
    {
        public Result Fight(RSP player1,RSP player2){
            if (player1 == player2)
            {
                return Result.draw;
            }
            if (player1 == RSP.Paper )
            {
            
            }
        }
    }

    


}
