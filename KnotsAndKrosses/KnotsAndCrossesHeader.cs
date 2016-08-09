using GameBase.Game;

namespace KnotsAndKrosses
{
    public class KnotsAndCrossesHeader : IGameHeader
    {
        public string Name { get; set; } = "Knots and Crosses";
        public string Description { get; set; }
        public int MaxPlayer { get; set; } = 2;
    }
}