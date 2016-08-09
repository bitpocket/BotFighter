using GameBase.Game;

namespace GameServer.Rrepositories
{
    public interface IGameRepository
    {
        IGame GetGame(GameType gameCode);
        IGame CreateGame(GameType gameCode);
    }
}