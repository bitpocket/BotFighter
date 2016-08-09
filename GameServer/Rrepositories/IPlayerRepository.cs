using Game.Player;

namespace GameServer.Rrepositories
{
    public interface IPlayerRepository
    {
        void RegisterUser(string name, string password);
        IPlayer GetPlayer(string name, string password);
    }
}
