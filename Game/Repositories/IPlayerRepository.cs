namespace Game.Repositories
{
    public interface IPlayerRepository
    {
        void RegisterUser(string name, string password);
        IPlayer GetPlayer(string name, string password);
    }
}
