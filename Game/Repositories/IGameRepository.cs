namespace Game.Repositories
{
    public interface IGameRepository
    {
        IGame GetGame(GameType gameCode);
        IGame CreateGame(GameType gameCode);
    }
}