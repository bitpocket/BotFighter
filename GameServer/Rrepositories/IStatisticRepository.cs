using Game.Player;
using GameBase.Game;

namespace GameServer.Rrepositories
{
    public interface IStatisticRepository
    {
        void UpdateStatistic(IPlayer player, IGameResult result);
    }
}