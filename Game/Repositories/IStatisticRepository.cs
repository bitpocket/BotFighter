namespace Game.Repositories
{
    public interface IStatisticRepository
    {
        void UpdateStatistic(IPlayer player, IGameResult result);
    }
}