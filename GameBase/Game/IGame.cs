using Game.Player;

namespace GameBase.Game
{
    public interface IGame
    {
        int Id { get; set; }
        int MaxPlayer { get; set; }
        void ValidateMove(params object[] moveData);
        void MakeMove(params object[] moveData);
        IGameState GetGameState();
        bool CalculateEndCondition();
        IPlayer GetWinner();
    }
}