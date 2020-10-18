namespace RockScissorsPaperLib
{
    public class WinCheckFabric
    {
        public IWinCheck Create(bool isClassicGame)
        {
            if (isClassicGame)
            {
               return new WinnerChecker();
            }
            else
            {
               return new ModifiedWinnerChecker();
            }
        }
    }
}