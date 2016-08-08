namespace Server
{
    public interface IGameState
    {
        string WinnerName { get; set; }
        IGameData State { get; set; }
    }
}